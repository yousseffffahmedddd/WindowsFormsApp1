using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class payments : Form
    {
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=CinemaDB;Integrated Security=True;";

        public payments()
        {
            InitializeComponent();
        }

        private void payments_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Populate filter combobox if it exists
            if (viewByComboBox != null)
            {
                viewByComboBox.Items.Clear();
                viewByComboBox.Items.Add("All");
                viewByComboBox.Items.Add("Date");
                viewByComboBox.Items.Add("Status");
                viewByComboBox.Items.Add("Method");
                viewByComboBox.Items.Add("Customer");
            }

            LoadPaymentsData();
        }

        private void LoadPaymentsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Modified query to handle payment data correctly
                    // Using LEFT JOIN because a payment might not have tickets yet
                    // Or might have multiple tickets
                    string query = @"
                            SELECT 
                                p.Payment_id, 
                                p.Payment_date, 
                                p.Payment_method, 
                                p.Payment_status, 
                                p.Payment_amount,
                                COALESCE(tp.TotalTickets, 0) AS Tickets_Count,
                                CASE 
                                    WHEN c.Customer_id IS NULL THEN 'N/A'
                                    ELSE CONCAT(c.Customer_firstName, ' ', c.Customer_lastName) 
                                END AS Customer_Name,
                                COALESCE(c.Customer_id, 0) AS Customer_id
                            FROM 
                                Payment p
                            LEFT JOIN (
                                SELECT 
                                    tp.Payment_id, 
                                    SUM(tp.num_of_tickets) AS TotalTickets,
                                    MIN(t.Customer_id) AS Customer_id
                                FROM 
                                    TicketPayments tp
                                JOIN 
                                    Ticket t ON tp.Ticket_id = t.Ticket_id
                                GROUP BY 
                                    tp.Payment_id
                            ) AS tp ON p.Payment_id = tp.Payment_id
                            LEFT JOIN 
                                Customer c ON tp.Customer_id = c.Customer_id
                            ORDER BY 
                                p.Payment_date DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Date");
                    table.Columns.Add("Method");
                    table.Columns.Add("Status");
                    table.Columns.Add("Amount");
                    table.Columns.Add("Tickets Count");
                    table.Columns.Add("Customer");
                    table.Columns.Add("Customer ID");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Payment ID"] = reader["Payment_id"];
                        row["Date"] = Convert.ToDateTime(reader["Payment_date"]).ToString("yyyy-MM-dd HH:mm:ss");
                        row["Method"] = reader["Payment_method"];
                        row["Status"] = Convert.ToBoolean(reader["Payment_status"]) ? "Completed" : "Pending";
                        row["Amount"] = string.Format("{0:C}", reader["Payment_amount"]);
                        row["Tickets Count"] = reader["Tickets_Count"];
                        row["Customer"] = reader["Customer_Name"];
                        row["Customer ID"] = reader["Customer_id"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;

                    // Format the DataGridView for better readability
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            // Apply formatting to DataGridView if it exists
            if (dataGridView1 != null && dataGridView1.Columns.Count > 0)
            {
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                dataGridView1.ReadOnly = true;
            }
        }

        private void viewByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = viewByComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedOption))
                return;

            try
            {
                if (selectedOption == "All")
                {
                    LoadPaymentsData();
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string filterQuery;

                    // Build base query with appropriate filter
                    if (selectedOption == "Date")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Date";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select date:" };
                            DateTimePicker datePicker = new DateTimePicker() { Left = 20, Top = 50, Width = 240, Format = DateTimePickerFormat.Short };
                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(datePicker);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK)
                                return;

                            string dateFilter = datePicker.Value.ToString("yyyy-MM-dd");

                            filterQuery = @"
                                    SELECT 
                                        p.Payment_id, 
                                        p.Payment_date, 
                                        p.Payment_method, 
                                        p.Payment_status, 
                                        p.Payment_amount,
                                        COALESCE(tp.TotalTickets, 0) AS Tickets_Count,
                                        CASE 
                                            WHEN c.Customer_id IS NULL THEN 'N/A'
                                            ELSE CONCAT(c.Customer_firstName, ' ', c.Customer_lastName) 
                                        END AS Customer_Name,
                                        COALESCE(c.Customer_id, 0) AS Customer_id
                                    FROM 
                                        Payment p
                                    LEFT JOIN (
                                        SELECT 
                                            tp.Payment_id, 
                                            SUM(tp.num_of_tickets) AS TotalTickets,
                                            MIN(t.Customer_id) AS Customer_id
                                        FROM 
                                            TicketPayments tp
                                        JOIN 
                                            Ticket t ON tp.Ticket_id = t.Ticket_id
                                        GROUP BY 
                                            tp.Payment_id
                                    ) AS tp ON p.Payment_id = tp.Payment_id
                                    LEFT JOIN 
                                        Customer c ON tp.Customer_id = c.Customer_id
                                    WHERE 
                                        CONVERT(date, p.Payment_date) = @dateFilter
                                    ORDER BY 
                                        p.Payment_date DESC";

                            SqlCommand command = new SqlCommand(filterQuery, connection);
                            command.Parameters.AddWithValue("@dateFilter", dateFilter);
                            FilterAndPopulateData(command);
                        }
                    }
                    else if (selectedOption == "Status")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Status";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select payment status:" };
                            ComboBox statusCombo = new ComboBox() { Left = 20, Top = 50, Width = 240 };
                            statusCombo.Items.Add("Completed");
                            statusCombo.Items.Add("Pending");
                            statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                            statusCombo.SelectedIndex = 0; // Default to "Completed"

                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(statusCombo);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || statusCombo.SelectedItem == null)
                                return;

                            bool statusValue = statusCombo.SelectedItem.ToString() == "Completed" ? true : false;

                            filterQuery = @"
                                    SELECT 
                                        p.Payment_id, 
                                        p.Payment_date, 
                                        p.Payment_method, 
                                        p.Payment_status, 
                                        p.Payment_amount,
                                        COALESCE(tp.TotalTickets, 0) AS Tickets_Count,
                                        CASE 
                                            WHEN c.Customer_id IS NULL THEN 'N/A'
                                            ELSE CONCAT(c.Customer_firstName, ' ', c.Customer_lastName) 
                                        END AS Customer_Name,
                                        COALESCE(c.Customer_id, 0) AS Customer_id
                                    FROM 
                                        Payment p
                                    LEFT JOIN (
                                        SELECT 
                                            tp.Payment_id, 
                                            SUM(tp.num_of_tickets) AS TotalTickets,
                                            MIN(t.Customer_id) AS Customer_id
                                        FROM 
                                            TicketPayments tp
                                        JOIN 
                                            Ticket t ON tp.Ticket_id = t.Ticket_id
                                        GROUP BY 
                                            tp.Payment_id
                                    ) AS tp ON p.Payment_id = tp.Payment_id
                                    LEFT JOIN 
                                        Customer c ON tp.Customer_id = c.Customer_id
                                    WHERE 
                                        p.Payment_status = @status
                                    ORDER BY 
                                        p.Payment_date DESC";

                            SqlCommand command = new SqlCommand(filterQuery, connection);
                            command.Parameters.AddWithValue("@status", statusValue);
                            FilterAndPopulateData(command);
                        }
                    }
                    else if (selectedOption == "Method")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Method";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select payment method:" };
                            ComboBox methodCombo = new ComboBox() { Left = 20, Top = 50, Width = 240 };
                            methodCombo.Items.Add("Credit Card");
                            methodCombo.Items.Add("Debit Card");
                            methodCombo.Items.Add("Cash");
                            methodCombo.Items.Add("Mobile Payment");
                            methodCombo.Items.Add("Online Transfer");
                            methodCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                            methodCombo.SelectedIndex = 0; // Default to "Credit Card"

                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(methodCombo);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || methodCombo.SelectedItem == null)
                                return;

                            string method = methodCombo.SelectedItem.ToString();

                            filterQuery = @"
                                    SELECT 
                                        p.Payment_id, 
                                        p.Payment_date, 
                                        p.Payment_method, 
                                        p.Payment_status, 
                                        p.Payment_amount,
                                        COALESCE(tp.TotalTickets, 0) AS Tickets_Count,
                                        CASE 
                                            WHEN c.Customer_id IS NULL THEN 'N/A'
                                            ELSE CONCAT(c.Customer_firstName, ' ', c.Customer_lastName) 
                                        END AS Customer_Name,
                                        COALESCE(c.Customer_id, 0) AS Customer_id
                                    FROM 
                                        Payment p
                                    LEFT JOIN (
                                        SELECT 
                                            tp.Payment_id, 
                                            SUM(tp.num_of_tickets) AS TotalTickets,
                                            MIN(t.Customer_id) AS Customer_id
                                        FROM 
                                            TicketPayments tp
                                        JOIN 
                                            Ticket t ON tp.Ticket_id = t.Ticket_id
                                        GROUP BY 
                                            tp.Payment_id
                                    ) AS tp ON p.Payment_id = tp.Payment_id
                                    LEFT JOIN 
                                        Customer c ON tp.Customer_id = c.Customer_id
                                    WHERE 
                                        p.Payment_method = @method
                                    ORDER BY 
                                        p.Payment_date DESC";

                            SqlCommand command = new SqlCommand(filterQuery, connection);
                            command.Parameters.AddWithValue("@method", method);
                            FilterAndPopulateData(command);
                        }
                    }
                    else if (selectedOption == "Customer")
                    {
                        // Get list of customers
                        SqlDataAdapter customersAdapter = new SqlDataAdapter(
                            "SELECT Customer_id, Customer_firstName + ' ' + Customer_lastName AS FullName FROM Customer ORDER BY FullName",
                            connection);
                        DataTable customersTable = new DataTable();
                        customersAdapter.Fill(customersTable);

                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Customer";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select customer:" };
                            ComboBox customerCombo = new ComboBox() { Left = 20, Top = 50, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };

                            foreach (DataRow row in customersTable.Rows)
                            {
                                customerCombo.Items.Add(new KeyValuePair<int, string>(
                                    Convert.ToInt32(row["Customer_id"]),
                                    row["FullName"].ToString()
                                ));
                            }

                            customerCombo.DisplayMember = "Value";
                            customerCombo.ValueMember = "Key";

                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(customerCombo);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || customerCombo.SelectedItem == null)
                                return;

                            KeyValuePair<int, string> selectedCustomer = (KeyValuePair<int, string>)customerCombo.SelectedItem;
                            int customerId = selectedCustomer.Key;

                            filterQuery = @"
                                    SELECT 
                                        p.Payment_id, 
                                        p.Payment_date, 
                                        p.Payment_method, 
                                        p.Payment_status, 
                                        p.Payment_amount,
                                        COALESCE(tp.TotalTickets, 0) AS Tickets_Count,
                                        CASE 
                                            WHEN c.Customer_id IS NULL THEN 'N/A'
                                            ELSE CONCAT(c.Customer_firstName, ' ', c.Customer_lastName) 
                                        END AS Customer_Name,
                                        COALESCE(c.Customer_id, 0) AS Customer_id
                                    FROM 
                                        Payment p
                                    JOIN 
                                        TicketPayments tp1 ON p.Payment_id = tp1.Payment_id
                                    JOIN 
                                        Ticket t ON tp1.Ticket_id = t.Ticket_id
                                    LEFT JOIN (
                                        SELECT 
                                            tp2.Payment_id, 
                                            SUM(tp2.num_of_tickets) AS TotalTickets,
                                            MIN(t2.Customer_id) AS Customer_id
                                        FROM 
                                            TicketPayments tp2
                                        JOIN 
                                            Ticket t2 ON tp2.Ticket_id = t2.Ticket_id
                                        GROUP BY 
                                            tp2.Payment_id
                                    ) AS tp ON p.Payment_id = tp.Payment_id
                                    LEFT JOIN 
                                        Customer c ON tp.Customer_id = c.Customer_id
                                    WHERE 
                                        t.Customer_id = @customerId
                                    ORDER BY 
                                        p.Payment_date DESC";

                            SqlCommand command = new SqlCommand(filterQuery, connection);
                            command.Parameters.AddWithValue("@customerId", customerId);
                            FilterAndPopulateData(command);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterAndPopulateData(SqlCommand command)
        {
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("Payment ID");
                table.Columns.Add("Date");
                table.Columns.Add("Method");
                table.Columns.Add("Status");
                table.Columns.Add("Amount");
                table.Columns.Add("Tickets Count");
                table.Columns.Add("Customer");
                table.Columns.Add("Customer ID");

                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    row["Payment ID"] = reader["Payment_id"];
                    row["Date"] = Convert.ToDateTime(reader["Payment_date"]).ToString("yyyy-MM-dd HH:mm:ss");
                    row["Method"] = reader["Payment_method"];
                    row["Status"] = Convert.ToBoolean(reader["Payment_status"]) ? "Completed" : "Pending";
                    row["Amount"] = string.Format("{0:C}", reader["Payment_amount"]);
                    row["Tickets Count"] = reader["Tickets_Count"];
                    row["Customer"] = reader["Customer_Name"];
                    row["Customer ID"] = reader["Customer_id"];
                    table.Rows.Add(row);
                }

                reader.Close();
                dataGridView1.DataSource = table;

                // Format the DataGridView
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPaymentsData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
    }
}
