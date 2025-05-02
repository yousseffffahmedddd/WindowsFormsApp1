using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class payments : Form
    {
        // Connection string for database
        private string connectionString = "Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True";

        public payments()
        {
            InitializeComponent();
        }

        private void payments_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadPaymentsData();

            // Load payment IDs for update/delete, and customer IDs for insertion
            PopulateComboBoxes();

            // Add payment methods to the combo box
            methodComboBox.Items.Add("Credit Card");
            methodComboBox.Items.Add("Cash");
            methodComboBox.Items.Add("Online");

            // Add payment statuses to the combo box
            statusComboBox.Items.Add("Completed");
            statusComboBox.Items.Add("Pending");
            statusComboBox.Items.Add("Failed");
        }

        private void LoadPaymentsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Date");
                    table.Columns.Add("Payment Reference");
                    table.Columns.Add("Tickets Number");
                    table.Columns.Add("Customer ID");
                    table.Columns.Add("Method");
                    table.Columns.Add("Status");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Payment ID"] = reader["payment_ID"];
                        row["Date"] = reader["date"];
                        row["Payment Reference"] = reader["paymentID"];
                        row["Tickets Number"] = reader["tickets_num"];
                        row["Customer ID"] = reader["customerID"];
                        row["Method"] = reader["method"];
                        row["Status"] = reader["status"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void PopulateComboBoxes()
        {
            try
            {
                // Customer IDs for payment insertion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT customer_ID, firstName, lastName FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    customerComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["customer_ID"]} - {reader["firstName"]} {reader["lastName"]}";
                        customerComboBox.Items.Add(display);
                    }

                    reader.Close();
                }

                // Payment IDs for update/delete
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT payment_ID FROM Payment";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    paymentDeleteComboBox.Items.Clear();
                    paymentUpdateComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        paymentDeleteComboBox.Items.Add(reader["payment_ID"].ToString());
                        paymentUpdateComboBox.Items.Add(reader["payment_ID"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating comboboxes: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerComboBox.SelectedItem == null || methodComboBox.SelectedItem == null || statusComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Customer ID, Method, and Status fields are required.");
                    return;
                }

                // Extract customer ID
                string customerSelection = customerComboBox.SelectedItem.ToString();
                int customerId = int.Parse(customerSelection.Split('-')[0].Trim());

                string method = methodComboBox.SelectedItem.ToString();
                string status = statusComboBox.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Payment (date, paymentID, tickets_num, customerID, method, status) 
                                           VALUES (@date, @paymentId, @ticketsNum, @customerId, @method, @status)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@date", datePicker.Value.Date);
                    command.Parameters.AddWithValue("@paymentId", paymentRefTextBox.Text);
                    command.Parameters.AddWithValue("@ticketsNum", ticketsNumTextBox.Text);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@method", method);
                    command.Parameters.AddWithValue("@status", status);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Payment added successfully!");

                // Clear fields after insertion
                datePicker.Value = DateTime.Today;
                paymentRefTextBox.Text = "";
                ticketsNumTextBox.Text = "";
                customerComboBox.SelectedIndex = -1;
                methodComboBox.SelectedIndex = -1;
                statusComboBox.SelectedIndex = -1;

                // Refresh data
                LoadPaymentsData();
                PopulateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymentDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment to delete.");
                    return;
                }

                string paymentId = paymentDeleteComboBox.SelectedItem.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this payment?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Payment WHERE payment_ID = @paymentId";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@paymentId", paymentId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Payment deleted successfully!");

                // Refresh data
                LoadPaymentsData();
                PopulateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payment: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymentUpdateComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment and a field to update.");
                    return;
                }

                string paymentId = paymentUpdateComboBox.SelectedItem.ToString();
                string selectedField = fieldComboBox.SelectedItem.ToString();
                string dbField = "";

                // Map UI field names to database field names
                switch (selectedField)
                {
                    case "Date": dbField = "date"; break;
                    case "Payment Reference": dbField = "paymentID"; break;
                    case "Tickets Number": dbField = "tickets_num"; break;
                    case "Customer ID": dbField = "customerID"; break;
                    case "Method": dbField = "method"; break;
                    case "Status": dbField = "status"; break;
                    default: dbField = selectedField.ToLower(); break;
                }

                string newValue = updateValueTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Payment SET {dbField} = @newValue WHERE payment_ID = @paymentId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@paymentId", paymentId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Payment updated successfully!");

                // Clear fields after update
                paymentUpdateComboBox.SelectedIndex = -1;
                fieldComboBox.SelectedIndex = -1;
                updateValueTextBox.Text = "";

                // Refresh data
                LoadPaymentsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

        private void viewByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = viewByComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedOption))
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (selectedOption == "All")
                    {
                        query = "SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment";
                    }
                    else if (selectedOption == "Date")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Date";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Enter date to filter by (YYYY-MM-DD):" };
                            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(textBox);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(textBox.Text))
                                return;

                            string date = textBox.Text;
                            query = $"SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment WHERE CONVERT(date, date) = '{date}'";
                        }
                    }
                    else if (selectedOption == "Status")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Status";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Enter status to filter by (Completed/Pending/Failed):" };
                            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(textBox);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(textBox.Text))
                                return;

                            string status = textBox.Text;
                            query = $"SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment WHERE status = '{status}'";
                        }
                    }
                    else if (selectedOption == "Method")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Method";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Enter payment method:" };
                            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(textBox);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(textBox.Text))
                                return;

                            string method = textBox.Text;
                            query = $"SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment WHERE method = '{method}'";
                        }
                    }
                    else if (selectedOption == "Customer")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Customer";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Enter customer ID:" };
                            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(textBox);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(textBox.Text))
                                return;

                            string customerId = textBox.Text;
                            query = $"SELECT payment_ID, date, paymentID, tickets_num, customerID, method, status FROM Payment WHERE customerID = {customerId}";
                        }
                    }
                    else
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Date");
                    table.Columns.Add("Payment Reference");
                    table.Columns.Add("Tickets Number");
                    table.Columns.Add("Customer ID");
                    table.Columns.Add("Method");
                    table.Columns.Add("Status");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Payment ID"] = reader["payment_ID"];
                        row["Date"] = reader["date"];
                        row["Payment Reference"] = reader["paymentID"];
                        row["Tickets Number"] = reader["tickets_num"];
                        row["Customer ID"] = reader["customerID"];
                        row["Method"] = reader["method"];
                        row["Status"] = reader["status"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPaymentsData();
            PopulateComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
