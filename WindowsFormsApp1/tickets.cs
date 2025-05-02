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
                    string query = @"SELECT t.ticket_ID, t.price, t.date, t.payment_id, t.customer_id,
                                   ts.Seat_place, ts.Hall_id
                                   FROM Ticket t
                                   LEFT JOIN TicketSeat ts ON t.ticket_ID = ts.Ticket_id";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Ticket ID");
                    table.Columns.Add("Price");
                    table.Columns.Add("Date");
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Customer ID");
                    table.Columns.Add("Seat");
                    table.Columns.Add("Hall");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Ticket ID"] = reader["ticket_ID"];
                        row["Price"] = reader["price"];
                        row["Date"] = reader["date"];
                        row["Payment ID"] = reader["payment_id"] == DBNull.Value ? "N/A" : reader["payment_id"];
                        row["Customer ID"] = reader["customer_id"] == DBNull.Value ? "N/A" : reader["customer_id"];
                        row["Seat"] = reader["Seat_place"] == DBNull.Value ? "N/A" : reader["Seat_place"];
                        row["Hall"] = reader["Hall_id"] == DBNull.Value ? "N/A" : reader["Hall_id"];
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
                if (string.IsNullOrEmpty(priceTextBox.Text) || seat_combobox.SelectedItem == null || show_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Price, Show and seat fields are required.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, create the ticket
                    string insertTicketQuery = @"INSERT INTO Ticket (price, date, show_start, show_date) 
                                               VALUES (@price, @date, @showStart, @showDate);
                                               SELECT SCOPE_IDENTITY();"; // Get the new ticket ID

                    SqlCommand ticketCommand = new SqlCommand(insertTicketQuery, connection);
                    ticketCommand.CommandType = CommandType.Text;

                    // Set the current date as the ticket date
                    DateTime currentDate = DateTime.Now;

                    ticketCommand.Parameters.AddWithValue("@price", priceTextBox.Text);
                    ticketCommand.Parameters.AddWithValue("@date", currentDate);
                    ticketCommand.Parameters.AddWithValue("@showStart", show_combobox.SelectedValue); // Assuming this contains show_start
                    ticketCommand.Parameters.AddWithValue("@showDate", show_combobox.SelectedItem); // Assuming this contains show_date

                    // Get the new ticket ID
                    int ticketId = Convert.ToInt32(ticketCommand.ExecuteScalar());

                    // Now create the relationship in the TicketSeat table
                    string insertTicketSeatQuery = @"INSERT INTO TicketSeat (Ticket_id, Seat_place, Hall_id) 
                                                   VALUES (@ticketId, @seatPlace, @hallId)";

                    SqlCommand ticketSeatCommand = new SqlCommand(insertTicketSeatQuery, connection);

                    // Parse the seat information (assuming format "SeatPlace - HallId" or similar)
                    string selectedSeat = seat_combobox.SelectedItem.ToString();
                    string[] seatParts = selectedSeat.Split('-');
                    string seatPlace = seatParts[0].Trim();
                    string hallId = seatParts[1].Trim();

                    ticketSeatCommand.Parameters.AddWithValue("@ticketId", ticketId);
                    ticketSeatCommand.Parameters.AddWithValue("@seatPlace", seatPlace);
                    ticketSeatCommand.Parameters.AddWithValue("@hallId", hallId);

                    ticketSeatCommand.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Ticket added successfully!");

                // Clear fields after insertion
                priceTextBox.Text = "";
                seat_combobox.SelectedIndex = -1;
                show_combobox.SelectedIndex = -1;

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
            this.Hide();
            dashboard mainForm = new dashboard();
            mainForm.Show();

        }

        private void seat_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Updated query to join with Hall table to get available seats
                string query = @"SELECT s.Seat_place, s.Hall_id 
                               FROM Seat s 
                               INNER JOIN Hall h ON s.Hall_id = h.Hall_id
                               WHERE NOT EXISTS (
                                   SELECT 1 FROM TicketSeat ts 
                                   INNER JOIN Ticket t ON ts.Ticket_id = t.Ticket_id 
                                   WHERE ts.Seat_place = s.Seat_place 
                                   AND ts.Hall_id = s.Hall_id
                                   AND t.Show_start = @showStart
                                   AND t.Show_date = @showDate
                               )";

                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters for the specific show if a show is selected
                if (show_combobox.SelectedItem != null)
                {
                    // Assuming show_combobox has values that can be split into start time and date
                    string selectedShow = show_combobox.SelectedItem.ToString();
                    string[] showParts = selectedShow.Split('-');
                    string showStart = showParts[0].Trim();
                    string showDate = showParts[1].Trim();

                    command.Parameters.AddWithValue("@showStart", showStart);
                    command.Parameters.AddWithValue("@showDate", showDate);
                }

                SqlDataReader reader = command.ExecuteReader();
                seat_combobox.Items.Clear();

                while (reader.Read())
                {
                    string seatInfo = $"{reader["Seat_place"]} - {reader["Hall_id"]}";
                    seat_combobox.Items.Add(seatInfo);
                }

                reader.Close();
                connection.Close();

                if (seat_combobox.SelectedItem != null)
                {
                    string selectedSeat = seat_combobox.SelectedItem.ToString();
                    string message = $"You have selected seat: {selectedSeat}";
                    MessageBox.Show(message, "Seat Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading seats: " + ex.Message);
            }
        }
    }
}
