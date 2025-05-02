using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class seats : Form
    {
        // Connection string for database
        private string connectionString = "Data Sources=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True";

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
        }

        private void LoadSeatsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT hall_ID, place FROM Seats";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Place");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["hall_ID"];
                        row["Place"] = reader["place"];
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

        private void PopulateHallComboBoxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT hall_ID FROM Hall";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    hallIdComboBox.Items.Clear();
                    hallFilterComboBox.Items.Clear();
                    hallDeleteComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string hallId = reader["hall_ID"].ToString();
                        hallIdComboBox.Items.Add(hallId);
                        hallFilterComboBox.Items.Add(hallId);
                        hallDeleteComboBox.Items.Add(hallId);
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
                if (hallIdComboBox.SelectedItem == null || string.IsNullOrEmpty(placeTextBox.Text))
                {
                    MessageBox.Show("Hall ID and Place fields are required.");
                    return;
                }

                string hallId = hallIdComboBox.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Seats (hall_ID, place) 
                                           VALUES (@hallId, @place)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@hallId", hallId);
                    command.Parameters.AddWithValue("@place", placeTextBox.Text);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Seat added successfully!");

                // Clear fields after insertion
                hallIdComboBox.SelectedIndex = -1;
                placeTextBox.Text = "";

                // Refresh data
                LoadSeatsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting seat: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hallDeleteComboBox.SelectedItem == null || string.IsNullOrEmpty(placeDeleteTextBox.Text))
                {
                    MessageBox.Show("Please select a hall and enter the seat place to delete.");
                    return;
                }

                string hallId = hallDeleteComboBox.SelectedItem.ToString();
                string place = placeDeleteTextBox.Text;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this seat?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Seats WHERE hall_ID = @hallId AND place = @place";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@hallId", hallId);
                    command.Parameters.AddWithValue("@place", place);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Seat deleted successfully!");

                // Clear fields after deletion
                hallDeleteComboBox.SelectedIndex = -1;
                placeDeleteTextBox.Text = "";

                // Refresh data
                LoadSeatsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting seat: " + ex.Message);
            }
        }

        private void hallFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hallFilterComboBox.SelectedItem == null)
                return;

            string selectedHallId = hallFilterComboBox.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT hall_ID, place FROM Seats WHERE hall_ID = @hallId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@hallId", selectedHallId);

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Hall ID");
                    table.Columns.Add("Place");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Hall ID"] = reader["hall_ID"];
                        row["Place"] = reader["place"];
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
            this.Close();
        }
    }
}
