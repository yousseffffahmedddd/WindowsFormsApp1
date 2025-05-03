using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tickets : Form
    {
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=CinemaDB;Integrated Security=True;";

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
        }

        private void LoadTicketsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT t.Ticket_id, t.Ticket_date, t.Ticket_price, 
                                       t.Show_start, t.Show_date, t.Payment_id, 
                                       c.Customer_firstName + ' ' + c.Customer_lastName AS Customer_Name,
                                       m.Mov_name AS Movie_Name, h.Hall_id,
                                       ts.Seat_place
                                       FROM Ticket t
                                       LEFT JOIN Customer c ON t.Customer_id = c.Customer_id
                                       LEFT JOIN Show s ON t.Show_start = s.Show_start AND t.Show_date = s.Show_date
                                       LEFT JOIN MoviesShow ms ON s.Show_start = ms.Show_start AND s.Show_date = ms.Show_date
                                       LEFT JOIN Movies m ON ms.Movie_id = m.Movie_id
                                       LEFT JOIN TicketSeat ts ON t.Ticket_id = ts.Ticket_id";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Ticket ID");
                    table.Columns.Add("Purchase Date");
                    table.Columns.Add("Price");
                    table.Columns.Add("Show Time");
                    table.Columns.Add("Show Date");
                    table.Columns.Add("Payment ID");
                    table.Columns.Add("Customer");
                    table.Columns.Add("Movie");
                    table.Columns.Add("Hall");
                    table.Columns.Add("Seat");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Ticket ID"] = reader["Ticket_id"];
                        row["Purchase Date"] = Convert.ToDateTime(reader["Ticket_date"]).ToString("yyyy-MM-dd");
                        row["Price"] = string.Format("{0:C}", reader["Ticket_price"]);
                        row["Show Time"] = reader["Show_start"].ToString();
                        row["Show Date"] = Convert.ToDateTime(reader["Show_date"]).ToString("yyyy-MM-dd");
                        row["Payment ID"] = reader["Payment_id"];
                        row["Customer"] = reader["Customer_Name"];
                        row["Movie"] = reader["Movie_Name"] ?? "Not specified";
                        row["Hall"] = reader["Hall_id"];
                        row["Seat"] = reader["Seat_place"];
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
                    string query = @"SELECT t.Ticket_id, t.Ticket_date, t.Ticket_price, 
                                       t.Show_start, t.Show_date, t.Payment_id, 
                                       c.Customer_firstName + ' ' + c.Customer_lastName AS Customer_Name,
                                       m.Mov_name AS Movie_Name, h.Hall_id,
                                       ts.Seat_place
                                       FROM Ticket t
                                       LEFT JOIN Customer c ON t.Customer_id = c.Customer_id
                                       LEFT JOIN Show s ON t.Show_start = s.Show_start AND t.Show_date = s.Show_date
                                       LEFT JOIN MoviesShow ms ON s.Show_start = ms.Show_start AND s.Show_date = ms.Show_date
                                       LEFT JOIN Movies m ON ms.Movie_id = m.Movie_id
                                       LEFT JOIN TicketSeat ts ON t.Ticket_id = ts.Ticket_id
                                       LEFT JOIN Hall h ON s.Hall_id = h.Hall_id";

                    if (selectedOption == "All")
                    {
                        // No additional WHERE clause needed
                    }
                    else if (selectedOption == "Today's Shows")
                    {
                        query += " WHERE t.Show_date = CAST(GETDATE() AS DATE)";
                    }
                    else if (selectedOption == "Future Shows")
                    {
                        query += " WHERE t.Show_date > CAST(GETDATE() AS DATE)";
                    }
                    else if (selectedOption == "Past Shows")
                    {
                        query += " WHERE t.Show_date < CAST(GETDATE() AS DATE)";
                    }
                    else if (selectedOption == "By Date")
                    {
                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Date";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select date to filter by:" };
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

                            string selectedDate = datePicker.Value.ToString("yyyy-MM-dd");
                            query += " WHERE CONVERT(date, t.Show_date) = @date";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@date", selectedDate);
                            FilterAndShowData(command);
                            return;
                        }
                    }
                    else if (selectedOption == "By Movie")
                    {
                        // Get a list of movies
                        SqlDataAdapter moviesAdapter = new SqlDataAdapter("SELECT Movie_id, Mov_name FROM Movies", connection);
                        DataTable moviesTable = new DataTable();
                        moviesAdapter.Fill(moviesTable);

                        using (Form inputForm = new Form())
                        {
                            inputForm.Width = 300;
                            inputForm.Height = 150;
                            inputForm.Text = "Filter by Movie";

                            Label label = new Label() { Left = 20, Top = 20, Text = "Select movie:" };
                            ComboBox movieCombo = new ComboBox() { Left = 20, Top = 50, Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };

                            foreach (DataRow row in moviesTable.Rows)
                            {
                                movieCombo.Items.Add(new KeyValuePair<int, string>(
                                    Convert.ToInt32(row["Movie_id"]),
                                    row["Mov_name"].ToString()
                                ));
                            }

                            movieCombo.DisplayMember = "Value";
                            movieCombo.ValueMember = "Key";

                            Button confirmButton = new Button() { Text = "OK", Left = 180, Width = 80, Top = 80 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 90, Width = 80, Top = 80 };

                            confirmButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.OK; };
                            cancelButton.Click += (s, ev) => { inputForm.DialogResult = DialogResult.Cancel; };

                            inputForm.Controls.Add(label);
                            inputForm.Controls.Add(movieCombo);
                            inputForm.Controls.Add(confirmButton);
                            inputForm.Controls.Add(cancelButton);
                            inputForm.AcceptButton = confirmButton;
                            inputForm.CancelButton = cancelButton;

                            if (inputForm.ShowDialog() != DialogResult.OK || movieCombo.SelectedItem == null)
                                return;

                            KeyValuePair<int, string> selectedMovie = (KeyValuePair<int, string>)movieCombo.SelectedItem;
                            int movieId = selectedMovie.Key;

                            query += " WHERE m.Movie_id = @movieId";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@movieId", movieId);
                            FilterAndShowData(command);
                            return;
                        }
                    }
                    else if (selectedOption == "By Customer")
                    {
                        // Get a list of customers
                        SqlDataAdapter customersAdapter = new SqlDataAdapter(
                            "SELECT Customer_id, Customer_firstName + ' ' + Customer_lastName AS FullName FROM Customer",
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

                            query += " WHERE t.Customer_id = @customerId";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@customerId", customerId);
                            FilterAndShowData(command);
                            return;
                        }
                    }

                    SqlCommand basicCommand = new SqlCommand(query, connection);
                    FilterAndShowData(basicCommand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        private void FilterAndShowData(SqlCommand command)
        {
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("Ticket ID");
                table.Columns.Add("Purchase Date");
                table.Columns.Add("Price");
                table.Columns.Add("Show Time");
                table.Columns.Add("Show Date");
                table.Columns.Add("Payment ID");
                table.Columns.Add("Customer");
                table.Columns.Add("Movie");
                table.Columns.Add("Hall");
                table.Columns.Add("Seat");

                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    row["Ticket ID"] = reader["Ticket_id"];
                    row["Purchase Date"] = Convert.ToDateTime(reader["Ticket_date"]).ToString("yyyy-MM-dd");
                    row["Price"] = string.Format("{0:C}", reader["Ticket_price"]);
                    row["Show Time"] = reader["Show_start"].ToString();
                    row["Show Date"] = Convert.ToDateTime(reader["Show_date"]).ToString("yyyy-MM-dd");
                    row["Payment ID"] = reader["Payment_id"];
                    row["Customer"] = reader["Customer_Name"];
                    row["Movie"] = reader["Movie_Name"] ?? "Not specified";
                    row["Hall"] = reader["Hall_id"];
                    row["Seat"] = reader["Seat_place"];
                    table.Rows.Add(row);
                }

                reader.Close();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering tickets: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTicketsData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard mainForm = new dashboard();
            mainForm.Show();
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrEmpty(priceTextBox.Text) ||
                    show_combobox.SelectedItem == null ||
                    seat_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields: price, show, and seat.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse price
                if (!decimal.TryParse(priceTextBox.Text, out decimal ticketPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction since we need to insert into multiple tables
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Set default values for customer and payment
                        int customerId = 1; // Default customer ID
                        int paymentId = 1001; // Default payment ID

                        // Extract show information (assumes format like "10:00:00 - 2025-05-05")
                        string showInfo = show_combobox.SelectedItem.ToString();
                        string[] showParts = showInfo.Split('-');
                        TimeSpan showStart = TimeSpan.Parse(showParts[0].Trim());
                        DateTime showDate = DateTime.Parse(showParts[1].Trim());

                        // Extract seat information (assumes format like "15 - 1")
                        string seatInfo = seat_combobox.SelectedItem.ToString();
                        string[] seatParts = seatInfo.Split('-');
                        int seatPlace = int.Parse(seatParts[0].Trim());
                        int hallId = int.Parse(seatParts[1].Trim());

                        // Get next ticket ID
                        int newTicketId = GetNextTicketId(connection, transaction);

                        // 1. Insert into Ticket table
                        string ticketQuery = @"INSERT INTO Ticket (Ticket_id, Ticket_date, Ticket_price, Show_start, Show_date, Payment_id, Customer_id)
                                      VALUES (@TicketId, @TicketDate, @TicketPrice, @ShowStart, @ShowDate, @PaymentId, @CustomerId)";

                        SqlCommand ticketCommand = new SqlCommand(ticketQuery, connection, transaction);
                        ticketCommand.Parameters.AddWithValue("@TicketId", newTicketId);
                        ticketCommand.Parameters.AddWithValue("@TicketDate", DateTime.Now);
                        ticketCommand.Parameters.AddWithValue("@TicketPrice", ticketPrice);
                        ticketCommand.Parameters.AddWithValue("@ShowStart", showStart);
                        ticketCommand.Parameters.AddWithValue("@ShowDate", showDate);
                        ticketCommand.Parameters.AddWithValue("@PaymentId", paymentId);
                        ticketCommand.Parameters.AddWithValue("@CustomerId", customerId);

                        ticketCommand.ExecuteNonQuery();

                        // 2. Insert into TicketSeat table
                        string ticketSeatQuery = @"INSERT INTO TicketSeat (Ticket_id, Seat_place, Hall_id)
                                         VALUES (@TicketId, @SeatPlace, @HallId)";

                        SqlCommand ticketSeatCommand = new SqlCommand(ticketSeatQuery, connection, transaction);
                        ticketSeatCommand.Parameters.AddWithValue("@TicketId", newTicketId);
                        ticketSeatCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
                        ticketSeatCommand.Parameters.AddWithValue("@HallId", hallId);

                        ticketSeatCommand.ExecuteNonQuery();

                        // 3. Update TicketPayments table
                        string ticketPaymentQuery = @"INSERT INTO TicketPayments (Payment_id, Ticket_id, num_of_tickets)
                                            VALUES (@PaymentId, @TicketId, 1)";

                        SqlCommand ticketPaymentCommand = new SqlCommand(ticketPaymentQuery, connection, transaction);
                        ticketPaymentCommand.Parameters.AddWithValue("@PaymentId", paymentId);
                        ticketPaymentCommand.Parameters.AddWithValue("@TicketId", newTicketId);

                        ticketPaymentCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Ticket inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the form and reload data
                        priceTextBox.Text = string.Empty;
                        show_combobox.SelectedIndex = -1;
                        seat_combobox.SelectedIndex = -1;
                        LoadTicketsData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error inserting ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextTicketId(SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT ISNULL(MAX(Ticket_id), 0) + 1 FROM Ticket";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ticketUpdateComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null ||
                    string.IsNullOrEmpty(updateValueTextBox.Text))
                {
                    MessageBox.Show("Please select a ticket, field to update, and provide a new value.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Extract ticket ID from the selected item
                string selectedTicket = ticketUpdateComboBox.SelectedItem.ToString();
                int ticketId = int.Parse(selectedTicket.Split('-')[0].Trim());

                string fieldToUpdate = fieldComboBox.SelectedItem.ToString();
                string newValue = updateValueTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        switch (fieldToUpdate)
                        {
                            case "Price":
                                if (!decimal.TryParse(newValue, out decimal price))
                                {
                                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string priceQuery = "UPDATE Ticket SET Ticket_price = @Price WHERE Ticket_id = @TicketId";
                                SqlCommand priceCommand = new SqlCommand(priceQuery, connection, transaction);
                                priceCommand.Parameters.AddWithValue("@Price", price);
                                priceCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                priceCommand.ExecuteNonQuery();
                                break;

                            case "Customer":
                                // Assuming newValue contains customer ID
                                if (!int.TryParse(newValue, out int customerId))
                                {
                                    MessageBox.Show("Please enter a valid customer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string customerQuery = "UPDATE Ticket SET Customer_id = @CustomerId WHERE Ticket_id = @TicketId";
                                SqlCommand customerCommand = new SqlCommand(customerQuery, connection, transaction);
                                customerCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                customerCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                customerCommand.ExecuteNonQuery();
                                break;

                            case "Payment ID":
                                if (!int.TryParse(newValue, out int paymentId))
                                {
                                    MessageBox.Show("Please enter a valid payment ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string paymentQuery = @"UPDATE Ticket SET Payment_id = @PaymentId WHERE Ticket_id = @TicketId;
                                                       IF EXISTS (SELECT 1 FROM TicketPayments WHERE Ticket_id = @TicketId)
                                                           UPDATE TicketPayments SET Payment_id = @PaymentId WHERE Ticket_id = @TicketId
                                                       ELSE
                                                           INSERT INTO TicketPayments (Payment_id, Ticket_id, num_of_tickets) VALUES (@PaymentId, @TicketId, 1)";

                                SqlCommand paymentCommand = new SqlCommand(paymentQuery, connection, transaction);
                                paymentCommand.Parameters.AddWithValue("@PaymentId", paymentId);
                                paymentCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                paymentCommand.ExecuteNonQuery();
                                break;

                            case "Show Date":
                                if (!DateTime.TryParse(newValue, out DateTime showDate))
                                {
                                    MessageBox.Show("Please enter a valid date format (YYYY-MM-DD).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string dateQuery = "UPDATE Ticket SET Show_date = @ShowDate WHERE Ticket_id = @TicketId";
                                SqlCommand dateCommand = new SqlCommand(dateQuery, connection, transaction);
                                dateCommand.Parameters.AddWithValue("@ShowDate", showDate);
                                dateCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                dateCommand.ExecuteNonQuery();
                                break;

                            case "Show Time":
                                if (!TimeSpan.TryParse(newValue, out TimeSpan showTime))
                                {
                                    MessageBox.Show("Please enter a valid time format (HH:MM:SS).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                string timeQuery = "UPDATE Ticket SET Show_start = @ShowStart WHERE Ticket_id = @TicketId";
                                SqlCommand timeCommand = new SqlCommand(timeQuery, connection, transaction);
                                timeCommand.Parameters.AddWithValue("@ShowStart", showTime);
                                timeCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                timeCommand.ExecuteNonQuery();
                                break;

                            case "Seat":
                                // Assuming newValue contains "SeatPlace - HallId"
                                string[] seatParts = newValue.Split('-');
                                if (seatParts.Length != 2 || !int.TryParse(seatParts[0].Trim(), out int seatPlace) ||
                                    !int.TryParse(seatParts[1].Trim(), out int hallId))
                                {
                                    MessageBox.Show("Please enter seat information in format 'SeatPlace - HallId'", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Check if the seat is available
                                string checkQuery = @"
                                    SELECT COUNT(*) FROM TicketSeat ts
                                    INNER JOIN Ticket t1 ON ts.Ticket_id = t1.Ticket_id
                                    INNER JOIN Ticket t2 ON t1.Show_start = t2.Show_start AND t1.Show_date = t2.Show_date
                                    WHERE ts.Seat_place = @SeatPlace AND ts.Hall_id = @HallId
                                    AND t2.Ticket_id = @TicketId AND ts.Ticket_id <> @TicketId";

                                SqlCommand checkCommand = new SqlCommand(checkQuery, connection, transaction);
                                checkCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
                                checkCommand.Parameters.AddWithValue("@HallId", hallId);
                                checkCommand.Parameters.AddWithValue("@TicketId", ticketId);

                                int conflictCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                                if (conflictCount > 0)
                                {
                                    MessageBox.Show("This seat is already booked for the same show.", "Seat Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Update seat
                                string seatQuery = @"
                                    IF EXISTS (SELECT 1 FROM TicketSeat WHERE Ticket_id = @TicketId)
                                        UPDATE TicketSeat SET Seat_place = @SeatPlace, Hall_id = @HallId WHERE Ticket_id = @TicketId
                                    ELSE
                                        INSERT INTO TicketSeat (Ticket_id, Seat_place, Hall_id) VALUES (@TicketId, @SeatPlace, @HallId)";

                                SqlCommand seatCommand = new SqlCommand(seatQuery, connection, transaction);
                                seatCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
                                seatCommand.Parameters.AddWithValue("@HallId", hallId);
                                seatCommand.Parameters.AddWithValue("@TicketId", ticketId);
                                seatCommand.ExecuteNonQuery();
                                break;

                            default:
                                MessageBox.Show("Invalid field selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        transaction.Commit();
                        MessageBox.Show("Ticket updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields and reload data
                        ticketUpdateComboBox.SelectedIndex = -1;
                        fieldComboBox.SelectedIndex = -1;
                        updateValueTextBox.Text = "";
                        LoadTicketsData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error updating ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTicketPrice(int ticketId, decimal price, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE Ticket SET Ticket_price = @Price WHERE Ticket_id = @TicketId";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@TicketId", ticketId);
            command.ExecuteNonQuery();
        }

        private void UpdateTicketShowDate(int ticketId, DateTime showDate, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE Ticket SET Show_date = @ShowDate WHERE Ticket_id = @TicketId";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@ShowDate", showDate);
            command.Parameters.AddWithValue("@TicketId", ticketId);
            command.ExecuteNonQuery();
        }

        private void UpdateTicketPayment(int ticketId, int paymentId, SqlConnection connection, SqlTransaction transaction)
        {
            // Update ticket table
            string ticketQuery = "UPDATE Ticket SET Payment_id = @PaymentId WHERE Ticket_id = @TicketId";
            SqlCommand ticketCommand = new SqlCommand(ticketQuery, connection, transaction);
            ticketCommand.Parameters.AddWithValue("@PaymentId", paymentId);
            ticketCommand.Parameters.AddWithValue("@TicketId", ticketId);
            ticketCommand.ExecuteNonQuery();

            // Update ticket payments table
            string paymentQuery = @"
                IF EXISTS (SELECT 1 FROM TicketPayments WHERE Ticket_id = @TicketId)
                    UPDATE TicketPayments SET Payment_id = @PaymentId WHERE Ticket_id = @TicketId
                ELSE
                    INSERT INTO TicketPayments (Payment_id, Ticket_id, num_of_tickets) VALUES (@PaymentId, @TicketId, 1)";

            SqlCommand paymentCommand = new SqlCommand(paymentQuery, connection, transaction);
            paymentCommand.Parameters.AddWithValue("@PaymentId", paymentId);
            paymentCommand.Parameters.AddWithValue("@TicketId", ticketId);
            paymentCommand.ExecuteNonQuery();
        }

        private void UpdateTicketCustomer(int ticketId, int customerId, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE Ticket SET Customer_id = @CustomerId WHERE Ticket_id = @TicketId";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@CustomerId", customerId);
            command.Parameters.AddWithValue("@TicketId", ticketId);
            command.ExecuteNonQuery();
        }

        private void UpdateTicketSeat(int ticketId, int seatPlace, int hallId, SqlConnection connection, SqlTransaction transaction)
        {
            // Check if the seat is available (not assigned to another ticket for same show)
            string checkQuery = @"
                SELECT COUNT(*) FROM TicketSeat ts
                INNER JOIN Ticket t1 ON ts.Ticket_id = t1.Ticket_id
                INNER JOIN Ticket t2 ON t1.Show_start = t2.Show_start AND t1.Show_date = t2.Show_date
                WHERE ts.Seat_place = @SeatPlace AND ts.Hall_id = @HallId
                AND t2.Ticket_id = @TicketId AND ts.Ticket_id <> @TicketId";

            SqlCommand checkCommand = new SqlCommand(checkQuery, connection, transaction);
            checkCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
            checkCommand.Parameters.AddWithValue("@HallId", hallId);
            checkCommand.Parameters.AddWithValue("@TicketId", ticketId);

            int conflictCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (conflictCount > 0)
            {
                throw new Exception("This seat is already booked for the same show time.");
            }

            // Update the seat assignment
            string updateQuery = @"
                UPDATE TicketSeat 
                SET Seat_place = @SeatPlace, Hall_id = @HallId 
                WHERE Ticket_id = @TicketId";

            SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
            updateCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
            updateCommand.Parameters.AddWithValue("@HallId", hallId);
            updateCommand.Parameters.AddWithValue("@TicketId", ticketId);

            int rowsAffected = updateCommand.ExecuteNonQuery();

            // If no existing record was found, insert a new one
            if (rowsAffected == 0)
            {
                string insertQuery = @"
                    INSERT INTO TicketSeat (Ticket_id, Seat_place, Hall_id)
                    VALUES (@TicketId, @SeatPlace, @HallId)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction);
                insertCommand.Parameters.AddWithValue("@TicketId", ticketId);
                insertCommand.Parameters.AddWithValue("@SeatPlace", seatPlace);
                insertCommand.Parameters.AddWithValue("@HallId", hallId);

                insertCommand.ExecuteNonQuery();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ticketDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a ticket to delete.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Extract ticket ID from the selected item
                string selectedTicket = ticketDeleteComboBox.SelectedItem.ToString();
                int ticketId = int.Parse(selectedTicket.Split('-')[0].Trim());

                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete ticket #{ticketId}?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Delete from TicketSeat table first (foreign key constraint)
                        string deleteSeatQuery = "DELETE FROM TicketSeat WHERE Ticket_id = @TicketId";
                        SqlCommand deleteSeatCommand = new SqlCommand(deleteSeatQuery, connection, transaction);
                        deleteSeatCommand.Parameters.AddWithValue("@TicketId", ticketId);
                        deleteSeatCommand.ExecuteNonQuery();

                        // Delete from TicketPayments table (foreign key constraint)
                        string deletePaymentQuery = "DELETE FROM TicketPayments WHERE Ticket_id = @TicketId";
                        SqlCommand deletePaymentCommand = new SqlCommand(deletePaymentQuery, connection, transaction);
                        deletePaymentCommand.Parameters.AddWithValue("@TicketId", ticketId);
                        deletePaymentCommand.ExecuteNonQuery();

                        // Finally delete the ticket
                        string deleteTicketQuery = "DELETE FROM Ticket WHERE Ticket_id = @TicketId";
                        SqlCommand deleteTicketCommand = new SqlCommand(deleteTicketQuery, connection, transaction);
                        deleteTicketCommand.Parameters.AddWithValue("@TicketId", ticketId);
                        deleteTicketCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Ticket deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear selection and reload data
                        ticketDeleteComboBox.SelectedIndex = -1;
                        LoadTicketsData();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seat_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method is called when a seat is selected from the seat combobox
            if (seat_combobox.SelectedItem == null || show_combobox.SelectedItem == null)
                return;

            try
            {
                // Extract show information to verify seat availability
                string showInfo = show_combobox.SelectedItem.ToString();
                string[] showParts = showInfo.Split('-');

                if (showParts.Length < 2)
                    return;

                TimeSpan showStart = TimeSpan.Parse(showParts[0].Trim());
                DateTime showDate = DateTime.Parse(showParts[1].Trim());

                // Extract seat information
                string seatInfo = seat_combobox.SelectedItem.ToString();
                string[] seatParts = seatInfo.Split('-');

                if (seatParts.Length < 2)
                    return;

                int seatPlace = int.Parse(seatParts[0].Trim());
                int hallId = int.Parse(seatParts[1].Trim());

                // Check if selected seat is available for this show
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT COUNT(*) FROM TicketSeat ts
                        INNER JOIN Ticket t ON ts.Ticket_id = t.Ticket_id
                        WHERE ts.Seat_place = @SeatPlace 
                        AND ts.Hall_id = @HallId
                        AND t.Show_start = @ShowStart
                        AND t.Show_date = @ShowDate";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SeatPlace", seatPlace);
                    command.Parameters.AddWithValue("@HallId", hallId);
                    command.Parameters.AddWithValue("@ShowStart", showStart);
                    command.Parameters.AddWithValue("@ShowDate", showDate);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("This seat is already booked for the selected show time.",
                            "Seat Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        seat_combobox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking seat availability: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       
    }
}
