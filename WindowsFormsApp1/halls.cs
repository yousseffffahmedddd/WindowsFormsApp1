using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class halls : Form
    {
        // Connection string for database
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=cinema_DB;Integrated Security=True;";

        public halls()
        {
            InitializeComponent();
        }

        private void halls_Load(object sender, EventArgs e) // Changed from HallForm_Load to match InitializeComponent
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadHallsData();

            // Load hall IDs into comboboxes
            PopulateHallComboBoxes();
        }

        private void LoadHallsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Hall_id, Hall_cap FROM Hall";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Capacity");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["Hall_id"];
                        row["Capacity"] = reader["Hall_cap"];
                        table.Rows.Add(row);
                    }

                    reader.Close();
                    dataGridView1.DataSource = table;

                    // Also load seats
                    LoadSeatsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadSeatsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Hall_id, Seat_place, Seat_number FROM Seat";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable seatTable = new DataTable();
                    seatTable.Columns.Add("Hall ID");
                    seatTable.Columns.Add("Seat Place");
                    seatTable.Columns.Add("Seat Number");

                    while (reader.Read())
                    {
                        DataRow row = seatTable.NewRow();
                        row["Hall ID"] = reader["Hall_id"];
                        row["Seat Place"] = reader["Seat_place"];
                        row["Seat Number"] = reader["Seat_number"];
                        seatTable.Rows.Add(row);
                    }

                    reader.Close();

                    // Add to a second datagrid view if you have one for seats
                    // seatDataGridView.DataSource = seatTable;
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
                    string query = "SELECT Hall_id FROM Hall";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    hallDeleteComboBox.Items.Clear();
                    hallUpdateComboBox.Items.Clear();
                    seatHallComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string hallId = reader["Hall_id"].ToString();
                        hallDeleteComboBox.Items.Add(hallId);
                        hallUpdateComboBox.Items.Add(hallId);
                        seatHallComboBox.Items.Add(hallId);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hall data: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(hallIdTextBox.Text) || string.IsNullOrEmpty(capacityTextBox.Text))
                {
                    MessageBox.Show("Hall ID and Capacity fields are required.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Hall (Hall_id, Hall_cap) 
                                               VALUES (@hallId, @capacity)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@hallId", hallIdTextBox.Text);
                    command.Parameters.AddWithValue("@capacity", capacityTextBox.Text);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Hall added successfully!");

                // Clear text boxes after insertion
                hallIdTextBox.Text = "";
                capacityTextBox.Text = "";

                // Refresh data
                LoadHallsData();
                PopulateHallComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting hall: " + ex.Message);
            }
        }

        private void addSeatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(seatPlaceTextBox.Text) || seatHallComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Seat Place and Hall ID are required.");
                    return;
                }

                string hallId = seatHallComboBox.SelectedItem.ToString();

                // Calculate next seat number
                int nextSeatNumber = 1;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) FROM Seat WHERE Hall_id = @hallId";
                    SqlCommand countCmd = new SqlCommand(countQuery, connection);
                    countCmd.Parameters.AddWithValue("@hallId", hallId);

                    nextSeatNumber = (int)countCmd.ExecuteScalar() + 1;

                    // Insert the new seat
                    string insertQuery = @"INSERT INTO Seat (Seat_place, Seat_number, Hall_id) 
                                              VALUES (@place, @number, @hallId)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@place", seatPlaceTextBox.Text);
                    command.Parameters.AddWithValue("@number", nextSeatNumber);
                    command.Parameters.AddWithValue("@hallId", hallId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Seat added successfully!");

                // Clear seat place text box
                seatPlaceTextBox.Text = "";

                // Refresh data
                LoadHallsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding seat: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hallDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a hall to delete.");
                    return;
                }

                // Get hall ID
                string hallId = hallDeleteComboBox.SelectedItem.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this hall?\n\nThis will also delete all seats in this hall.",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First delete related seats
                    string deleteSeatsQuery = "DELETE FROM Seat WHERE Hall_id = @hallId";
                    SqlCommand seatsCommand = new SqlCommand(deleteSeatsQuery, connection);
                    seatsCommand.Parameters.AddWithValue("@hallId", hallId);
                    seatsCommand.ExecuteNonQuery();

                    // Then delete the hall
                    string deleteQuery = "DELETE FROM Hall WHERE Hall_id = @hallId";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@hallId", hallId);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Hall deleted successfully!");

                // Refresh data
                LoadHallsData();
                PopulateHallComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting hall: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hallUpdateComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a hall to update.");
                    return;
                }

                // Get hall ID
                string hallId = hallUpdateComboBox.SelectedItem.ToString();

                if (string.IsNullOrEmpty(updateValueTextBox.Text))
                {
                    MessageBox.Show("Please enter a new capacity value.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Hall SET Hall_cap = @newCapacity WHERE Hall_id = @hallId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newCapacity", updateValueTextBox.Text);
                    command.Parameters.AddWithValue("@hallId", hallId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Hall capacity updated successfully!");

                // Clear text box after update
                updateValueTextBox.Text = "";

                // Refresh data
                LoadHallsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating hall: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadHallsData();
            PopulateHallComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
