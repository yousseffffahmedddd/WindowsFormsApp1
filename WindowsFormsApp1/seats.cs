using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class seats : Form
    {
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=CinemaDB;Integrated Security=True;";

        public seats()
        {
            InitializeComponent();

        }

        private void SeatForm_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadSeatsData();

            // Load hall IDs into comboboxes
            PopulateHallComboBoxes();
            populateHallCombo();

        }

        private void LoadSeatsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT s.Hall_id, s.Seat_place, 
                                      CASE 
                                        WHEN ts.Ticket_id IS NULL THEN 'Available' 
                                        ELSE 'Occupied' 
                                      END AS Status,
                                      h.Hall_cap as Hall_Capacity
                                      FROM Seat s
                                      INNER JOIN Hall h ON s.Hall_id = h.Hall_id
                                      LEFT JOIN (
                                        SELECT ts.* FROM TicketSeat ts
                                        JOIN Ticket t ON ts.Ticket_id = t.Ticket_id
                                        WHERE t.Show_date >= CAST(GETDATE() AS DATE)
                                      ) ts ON s.Seat_place = ts.Seat_place AND s.Hall_id = ts.Hall_id
                                      ORDER BY s.Hall_id, s.Seat_place";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Seat Number");
                    table.Columns.Add("Status");
                    table.Columns.Add("Hall Capacity");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["Hall_id"];
                        row["Seat Number"] = reader["Seat_place"];
                        row["Status"] = reader["Status"];
                        row["Hall Capacity"] = reader["Hall_Capacity"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading seat data: " + ex.Message);
            }
        }

        private void PopulateHallComboBoxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Hall_id, Hall_cap FROM Hall ORDER BY Hall_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    hallFilterComboBox.Items.Clear();
                    hallFilterComboBox.Items.Add("All Halls");

                    while (reader.Read())
                    {
                        string hallInfo = $"Hall {reader["Hall_id"]} (Capacity: {reader["Hall_cap"]})";
                        hallFilterComboBox.Items.Add(hallInfo);
                    }

                    reader.Close();

                    // Select "All Halls" by default
                    if (hallFilterComboBox.Items.Count > 0)
                        hallFilterComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hall data: " + ex.Message);
            }
        }

        private void hallFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hallFilterComboBox.SelectedItem == null)
                return;

            try
            {
                // If "All Halls" is selected, show all seats
                if (hallFilterComboBox.SelectedIndex == 0)
                {
                    LoadSeatsData();
                    return;
                }

                // Extract hall ID from selected item (format: "Hall X (Capacity: Y)")
                string selectedItem = hallFilterComboBox.SelectedItem.ToString();
                int startIndex = selectedItem.IndexOf("Hall ") + 5;
                int endIndex = selectedItem.IndexOf(" (");
                string hallIdStr = selectedItem.Substring(startIndex, endIndex - startIndex);
                int hallId = int.Parse(hallIdStr);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT s.Hall_id, s.Seat_place, 
                                      CASE 
                                        WHEN ts.Ticket_id IS NULL THEN 'Available' 
                                        ELSE 'Occupied' 
                                      END AS Status,
                                      h.Hall_cap as Hall_Capacity
                                      FROM Seat s
                                      INNER JOIN Hall h ON s.Hall_id = h.Hall_id
                                      LEFT JOIN (
                                        SELECT ts.* FROM TicketSeat ts
                                        JOIN Ticket t ON ts.Ticket_id = t.Ticket_id
                                        WHERE t.Show_date >= CAST(GETDATE() AS DATE)
                                      ) ts ON s.Seat_place = ts.Seat_place AND s.Hall_id = ts.Hall_id
                                      WHERE s.Hall_id = @hallId
                                      ORDER BY s.Seat_place";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@hallId", hallId);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Seat Number");
                    table.Columns.Add("Status");
                    table.Columns.Add("Hall Capacity");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["Hall_id"];
                        row["Seat Number"] = reader["Seat_place"];
                        row["Status"] = reader["Status"];
                        row["Hall Capacity"] = reader["Hall_Capacity"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering seats: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadSeatsData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void showOccupiedSeats_CheckedChanged(object sender, EventArgs e)
        {
            // Filter for occupied or available seats based on checkbox
            CheckBox checkbox = (CheckBox)sender;

            try
            {
                // Determine if we need to filter by hall as well
                int? hallId = null;
                if (hallFilterComboBox.SelectedIndex > 0) // Not "All Halls"
                {
                    string selectedItem = hallFilterComboBox.SelectedItem.ToString();
                    int startIndex = selectedItem.IndexOf("Hall ") + 5;
                    int endIndex = selectedItem.IndexOf(" (");
                    string hallIdStr = selectedItem.Substring(startIndex, endIndex - startIndex);
                    hallId = int.Parse(hallIdStr);
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT s.Hall_id, s.Seat_place, 
                                      CASE 
                                        WHEN ts.Ticket_id IS NULL THEN 'Available' 
                                        ELSE 'Occupied' 
                                      END AS Status,
                                      h.Hall_cap as Hall_Capacity
                                      FROM Seat s
                                      INNER JOIN Hall h ON s.Hall_id = h.Hall_id
                                      LEFT JOIN (
                                        SELECT ts.* FROM TicketSeat ts
                                        JOIN Ticket t ON ts.Ticket_id = t.Ticket_id
                                        WHERE t.Show_date >= CAST(GETDATE() AS DATE)
                                      ) ts ON s.Seat_place = ts.Seat_place AND s.Hall_id = ts.Hall_id
                                      WHERE 1=1 ";

                    if (checkbox.Checked)
                        query += " AND ts.Ticket_id IS NOT NULL ";

                    if (hallId.HasValue)
                        query += " AND s.Hall_id = @hallId ";

                    query += " ORDER BY s.Hall_id, s.Seat_place";

                    SqlCommand command = new SqlCommand(query, connection);

                    if (hallId.HasValue)
                        command.Parameters.AddWithValue("@hallId", hallId.Value);

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Seat Number");
                    table.Columns.Add("Status");
                    table.Columns.Add("Hall Capacity");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["Hall_id"];
                        row["Seat Number"] = reader["Seat_place"];
                        row["Status"] = reader["Status"];
                        row["Hall Capacity"] = reader["Hall_Capacity"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering seats: " + ex.Message);
            }
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
          
           
                if (string.IsNullOrWhiteSpace(hallIdComboBox.Text) || string.IsNullOrWhiteSpace(placeTextBox.Text))
                {
                    MessageBox.Show("Please enter both Hall ID and Seat Number");
                    return;
                }

                if (!int.TryParse(placeTextBox.Text, out int seatPlace))
                {
                    MessageBox.Show("Seat Number must be a valid integer");
                    return;
                }

                if (!int.TryParse(hallIdComboBox.Text, out int hallId))
                {
                    MessageBox.Show("Hall ID must be a valid integer");
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // First check if the seat already exists
                        string checkQuery = "SELECT COUNT(*) FROM Seat WHERE Hall_id = @hallId AND Seat_place = @seatPlace";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@hallId", hallId);
                        checkCommand.Parameters.AddWithValue("@seatPlace", seatPlace);

                        int existingCount = (int)checkCommand.ExecuteScalar();
                        if (existingCount > 0)
                        {
                            MessageBox.Show("This seat already exists in the specified hall.");
                            return;
                        }

                        // Now check if the hall exists and get its capacity
                        string hallCheckQuery = "SELECT Hall_cap FROM Hall WHERE Hall_id = @hallId";
                        SqlCommand hallCheckCommand = new SqlCommand(hallCheckQuery, connection);
                        hallCheckCommand.Parameters.AddWithValue("@hallId", hallId);

                        object hallCapObj = hallCheckCommand.ExecuteScalar();
                        if (hallCapObj == null)
                        {
                            MessageBox.Show("The specified hall does not exist.");
                            return;
                        }

                        int hallCapacity = Convert.ToInt32(hallCapObj);
                        if (seatPlace > hallCapacity)
                        {
                            MessageBox.Show($"Seat number exceeds hall capacity ({hallCapacity})");
                            return;
                        }

                        // Insert the new seat
                        string insertQuery = "INSERT INTO Seat (Hall_id, Seat_place) VALUES (@hallId, @seatPlace)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@hallId", hallId);
                        insertCommand.Parameters.AddWithValue("@seatPlace", seatPlace);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("New seat added successfully!");

                        // Refresh the grid
                        LoadSeatsData();

                        placeTextBox.Clear();   
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding seat: " + ex.Message);
                }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(hallDeleteComboBox.Text) || string.IsNullOrWhiteSpace(placeDeleteTextBox.Text))
            {
                MessageBox.Show("Please enter both Hall ID and Seat Number to delete");
                return;
            }

            if (!int.TryParse(hallDeleteComboBox.Text, out int hallId))
            {
                MessageBox.Show("Hall ID must be a valid integer");
                return;
            }

            if (!int.TryParse(placeDeleteTextBox.Text, out int seatPlace))
            {
                MessageBox.Show("Seat Number must be a valid integer");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the seat exists
                    string checkQuery = "SELECT COUNT(*) FROM Seat WHERE Hall_id = @hallId AND Seat_place = @seatPlace";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@hallId", hallId);
                    checkCommand.Parameters.AddWithValue("@seatPlace", seatPlace);

                    int seatCount = (int)checkCommand.ExecuteScalar();
                    if (seatCount == 0)
                    {
                        MessageBox.Show($"Seat {seatPlace} in Hall {hallId} does not exist.");
                        return;
                    }

                    // Check if the seat is occupied
                    string statusQuery = @"SELECT COUNT(*) 
                                         FROM TicketSeat ts 
                                         JOIN Ticket t ON ts.Ticket_id = t.Ticket_id
                                         WHERE ts.Hall_id = @hallId 
                                         AND ts.Seat_place = @seatPlace 
                                         AND t.Show_date >= CAST(GETDATE() AS DATE)";
                    SqlCommand statusCommand = new SqlCommand(statusQuery, connection);
                    statusCommand.Parameters.AddWithValue("@hallId", hallId);
                    statusCommand.Parameters.AddWithValue("@seatPlace", seatPlace);

                    int occupiedCount = (int)statusCommand.ExecuteScalar();
                    if (occupiedCount > 0)
                    {
                        MessageBox.Show("Cannot delete occupied seats. This seat is currently assigned to a ticket.");
                        return;
                    }

                    // Confirm deletion
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete Seat {seatPlace} in Hall {hallId}?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Delete the seat
                        string deleteQuery = "DELETE FROM Seat WHERE Hall_id = @hallId AND Seat_place = @seatPlace";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@hallId", hallId);
                        deleteCommand.Parameters.AddWithValue("@seatPlace", seatPlace);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Seat deleted successfully!");

                            // Refresh the grid
                            LoadSeatsData();
                            placeDeleteTextBox.Clear();
                            hallDeleteComboBox.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete seat. It may no longer exist in the database.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting seat: " + ex.Message);
            }
        }
        private void populateHallCombo()
        {
            // Load halls into combo box
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Hall_id FROM Hall ORDER BY Hall_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        hallIdComboBox.Items.Add(reader["Hall_id"].ToString());
                        hallDeleteComboBox.Items.Add(reader["Hall_id"].ToString());
                    }

                    if (hallIdComboBox.Items.Count > 0)
                        hallIdComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading halls: " + ex.Message);
                return;
            }
        }

    }
}
