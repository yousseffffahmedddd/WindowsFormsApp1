using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tickets : Form
    {
        // Connection string for database
        private string connectionString = "Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True";

        public tickets()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadTicketsData();

            // Load ticket IDs for update/delete, and customer IDs for insertion
            PopulateComboBoxes();
        }

        private void LoadTicketsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ticket_ID, price, date, payment_id, customer_id FROM Ticket";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Ticket ID");
                    table.Columns.Add("Price");
                    table.Columns.Add("Date");
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Customer ID");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Ticket ID"] = reader["ticket_ID"];
                        row["Price"] = reader["price"];
                        row["Date"] = reader["date"];
                        row["Payment ID"] = reader["payment_id"];
                        row["Customer ID"] = reader["customer_id"];
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
                // Customer IDs for ticket insertion
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

                // Payment IDs for ticket insertion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT payment_ID FROM Payment";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    paymentIdComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        paymentIdComboBox.Items.Add(reader["payment_ID"].ToString());
                    }

                    reader.Close();
                }

                // Ticket IDs for update/delete
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ticket_ID FROM Ticket";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    ticketDeleteComboBox.Items.Clear();
                    ticketUpdateComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        ticketDeleteComboBox.Items.Add(reader["ticket_ID"].ToString());
                        ticketUpdateComboBox.Items.Add(reader["ticket_ID"].ToString());
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
                if (string.IsNullOrEmpty(priceTextBox.Text) || customerComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Price and Customer ID fields are required.");
                    return;
                }

                // Extract customer ID
                string customerSelection = customerComboBox.SelectedItem.ToString();
                int customerId = int.Parse(customerSelection.Split('-')[0].Trim());

                // Get payment ID if selected
                object paymentSelection = paymentIdComboBox.SelectedItem;
                string paymentId = paymentSelection != null ? paymentSelection.ToString() : null;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Ticket (price, date, payment_id, customer_id) 
                                           VALUES (@price, @date, @paymentId, @customerId)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@price", priceTextBox.Text);
                    command.Parameters.AddWithValue("@date", datePicker.Value.Date);

                    if (paymentId != null)
                        command.Parameters.AddWithValue("@paymentId", paymentId);
                    else
                        command.Parameters.AddWithValue("@paymentId", DBNull.Value);

                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Ticket added successfully!");

                // Clear fields after insertion
                priceTextBox.Text = "";
                datePicker.Value = DateTime.Today;
                paymentIdComboBox.SelectedIndex = -1;
                customerComboBox.SelectedIndex = -1;

                // Refresh data
                LoadTicketsData();
                PopulateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting ticket: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ticketDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a ticket to delete.");
                    return;
                }

                string ticketId = ticketDeleteComboBox.SelectedItem.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Ticket WHERE ticket_ID = @ticketId";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@ticketId", ticketId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Ticket deleted successfully!");

                // Refresh data
                LoadTicketsData();
                PopulateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting ticket: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ticketUpdateComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a ticket and a field to update.");
                    return;
                }

                string ticketId = ticketUpdateComboBox.SelectedItem.ToString();
                string selectedField = fieldComboBox.SelectedItem.ToString();
                string dbField = "";

                // Map UI field names to database field names
                switch (selectedField)
                {
                    case "Price": dbField = "price"; break;
                    case "Date": dbField = "date"; break;
                    case "Payment ID": dbField = "payment_id"; break;
                    case "Customer ID": dbField = "customer_id"; break;
                    default: dbField = selectedField.ToLower(); break;
                }

                string newValue = updateValueTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Ticket SET {dbField} = @newValue WHERE ticket_ID = @ticketId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@ticketId", ticketId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Ticket updated successfully!");

                // Clear fields after update
                ticketUpdateComboBox.SelectedIndex = -1;
                fieldComboBox.SelectedIndex = -1;
                updateValueTextBox.Text = "";

                // Refresh data
                LoadTicketsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ticket: " + ex.Message);
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
                        query = "SELECT ticket_ID, price, date, payment_id, customer_id FROM Ticket";
                    }
                    else if (selectedOption == "Date")
                    {
                        string date = Microsoft.VisualBasic.Interaction.InputBox("Enter date to filter by (YYYY-MM-DD):", "Filter by Date", "");
                        if (string.IsNullOrEmpty(date))
                            return;

                        query = $"SELECT ticket_ID, price, date, payment_id, customer_id FROM Ticket WHERE CONVERT(date, date) = '{date}'";
                    }
                    else if (selectedOption == "Customer")
                    {
                        string customerId = Microsoft.VisualBasic.Interaction.InputBox("Enter customer ID to filter by:", "Filter by Customer", "");
                        if (string.IsNullOrEmpty(customerId))
                            return;

                        query = $"SELECT ticket_ID, price, date, payment_id, customer_id FROM Ticket WHERE customer_id = {customerId}";
                    }
                    else
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Ticket ID");
                    table.Columns.Add("Price");
                    table.Columns.Add("Date");
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Customer ID");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Ticket ID"] = reader["ticket_ID"];
                        row["Price"] = reader["price"];
                        row["Date"] = reader["date"];
                        row["Payment ID"] = reader["payment_id"];
                        row["Customer ID"] = reader["customer_id"];
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
            LoadTicketsData();
            PopulateComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
