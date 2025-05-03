using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class shows : Form
    {
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=CinemaDB;Integrated Security=True;";

        public shows()
        {
            InitializeComponent();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadShowsData();

            // Load show dates into comboboxes
            PopulateShowComboBoxes();

            // Load admin managers
            PopulateAdminManagerComboBox();

            // Load halls
            PopulateHallComboBox();
        }

        private void LoadShowsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT s.Show_start, s.Show_end, s.Show_date, s.Admin_id, s.Hall_id, 
                                        a.Admin_name, h.Hall_cap 
                                        FROM Show s
                                        JOIN Admin a ON s.Admin_id = a.Admin_id
                                        JOIN Hall h ON s.Hall_id = h.Hall_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Date");
                    table.Columns.Add("Start Time");
                    table.Columns.Add("End Time");
                    table.Columns.Add("Admin");
                    table.Columns.Add("Hall");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Date"] = reader["Show_date"];
                        row["Start Time"] = reader["Show_start"];
                        row["End Time"] = reader["Show_end"];
                        row["Admin"] = reader["Admin_name"];
                        row["Hall"] = reader["Hall_id"] + " (Capacity: " + reader["Hall_cap"] + ")";
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

        private void PopulateAdminManagerComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Admin_id, Admin_name FROM Admin";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    adminManagerComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["Admin_id"]} - {reader["Admin_name"]}";
                        adminManagerComboBox.Items.Add(display);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin managers: " + ex.Message);
            }
        }

        private void PopulateHallComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Hall_id, Hall_cap FROM Hall";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    hall_combobox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["Hall_id"]} - Capacity: {reader["Hall_cap"]}";
                        hall_combobox.Items.Add(display);
                        
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading halls: " + ex.Message);
            }
        }

        private void PopulateShowComboBoxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Show_date, Show_start FROM Show";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    showDeleteComboBox.Items.Clear();
                    showUpdateComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["Show_date"]} - {reader["Show_start"]}";
                        showDeleteComboBox.Items.Add(display);
                        showUpdateComboBox.Items.Add(display);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading show data: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (datePicker.Value == null || string.IsNullOrEmpty(startTimeTextBox.Text) ||endTimeTextBox.Text == null || adminManagerComboBox.SelectedItem.Equals(null)|| hall_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Date, Start Time,End time,Admin, and Hall fields are required.");
                    return;
                }

                // Get admin ID from selected item
                string adminManager = adminManagerComboBox.SelectedItem?.ToString();
                int adminId = 0;

                if (!string.IsNullOrEmpty(adminManager))
                {
                    adminId = int.Parse(adminManager.Split('-')[0].Trim());
                }

                // Get hall ID from selected item
                string selectedHall = hall_combobox.SelectedItem.ToString();
                string hallId = selectedHall.Split('-')[0].Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Show (Show_start, Show_end, Show_date, Admin_id, Hall_id) 
                                               VALUES (@startTime, @endTime, @date, @adminId, @hallId)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@startTime", startTimeTextBox.Text);
                    command.Parameters.AddWithValue("@endTime", endTimeTextBox.Text);
                    command.Parameters.AddWithValue("@date", datePicker.Value.Date);
                    command.Parameters.AddWithValue("@adminId", adminId);
                    command.Parameters.AddWithValue("@hallId", hallId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Show added successfully!");

                // Clear fields after insertion
                datePicker.Value = DateTime.Today;
                startTimeTextBox.Text = "";
                endTimeTextBox.Text = "";
                adminManagerComboBox.SelectedIndex = -1;
                hallIdComboBox.SelectedIndex = -1;

                // Refresh data
                LoadShowsData();
                PopulateShowComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting show: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (showDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a show to delete.");
                    return;
                }

                // Extract show date and time from the selected item
                string selectedShow = showDeleteComboBox.SelectedItem.ToString();
                string[] parts = selectedShow.Split('-');
                string showDate = parts[0].Trim();
                string showTime = parts[1].Trim();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this show?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Show WHERE Show_date = @date AND Show_start = @startTime";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@date", DateTime.Parse(showDate).Date);
                    command.Parameters.AddWithValue("@startTime", showTime);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Show deleted successfully!");

                // Refresh data
                LoadShowsData();
                PopulateShowComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting show: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (showUpdateComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a show and a field to update.");
                    return;
                }

                // Extract show date and time from the selected item
                string selectedShow = showUpdateComboBox.SelectedItem.ToString();
                string[] parts = selectedShow.Split('-');
                string showDate = parts[0].Trim();
                string showTime = parts[1].Trim();

                string selectedField = fieldComboBox.SelectedItem.ToString();

                

                string newValue = updateValueTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Show SET {selectedField} = @newValue WHERE Show_date = @date AND Show_start = @startTime";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@date", DateTime.Parse(showDate).Date);
                    command.Parameters.AddWithValue("@startTime", showTime);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Show updated successfully!");

                // Clear text box after update
                updateValueTextBox.Text = "";

                // Refresh data
                LoadShowsData();
                PopulateShowComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating show: " + ex.Message);
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
                        query = @"SELECT s.Show_start, s.Show_end, s.Show_date, s.Admin_id, s.Hall_id, 
                                     a.Admin_name, h.Hall_cap 
                                     FROM Show s
                                     JOIN Admin a ON s.Admin_id = a.Admin_id
                                     JOIN Hall h ON s.Hall_id = h.Hall_id";
                    }
                    else if (selectedOption == "Date")
                    {
                        string date = Microsoft.VisualBasic.Interaction.InputBox("Enter date to filter by (YYYY-MM-DD):", "Filter by Date", "");
                        if (string.IsNullOrEmpty(date))
                            return;

                        query = @"SELECT s.Show_start, s.Show_end, s.Show_date, s.Admin_id, s.Hall_id, 
                                    a.Admin_name, h.Hall_cap 
                                    FROM Show s
                                    JOIN Admin a ON s.Admin_id = a.Admin_id
                                    JOIN Hall h ON s.Hall_id = h.Hall_id
                                    WHERE CONVERT(date, s.Show_date) = '" + date + "'";
                    }
                    else if (selectedOption == "Admin")
                    {
                        string adminId = Microsoft.VisualBasic.Interaction.InputBox("Enter admin ID to filter by:", "Filter by Admin", "");
                        if (string.IsNullOrEmpty(adminId))
                            return;

                        query = @"SELECT s.Show_start, s.Show_end, s.Show_date, s.Admin_id, s.Hall_id, 
                                    a.Admin_name, h.Hall_cap 
                                    FROM Show s
                                    JOIN Admin a ON s.Admin_id = a.Admin_id
                                    JOIN Hall h ON s.Hall_id = h.Hall_id
                                    WHERE s.Admin_id = " + adminId;
                    }
                    else if (selectedOption == "Hall")
                    {
                        string hallId = Microsoft.VisualBasic.Interaction.InputBox("Enter hall ID:", "Filter by Hall", "");
                        if (string.IsNullOrEmpty(hallId))
                            return;

                        query = @"SELECT s.Show_start, s.Show_end, s.Show_date, s.Admin_id, s.Hall_id, 
                                    a.Admin_name, h.Hall_cap 
                                    FROM Show s
                                    JOIN Admin a ON s.Admin_id = a.Admin_id
                                    JOIN Hall h ON s.Hall_id = h.Hall_id
                                    WHERE s.Hall_id = '" + hallId + "'";
                    }
                    else
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Date");
                    table.Columns.Add("Start Time");
                    table.Columns.Add("End Time");
                    table.Columns.Add("Admin");
                    table.Columns.Add("Hall");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Date"] = reader["Show_date"];
                        row["Start Time"] = reader["Show_start"];
                        row["End Time"] = reader["Show_end"];
                        row["Admin"] = reader["Admin_name"];
                        row["Hall"] = reader["Hall_id"] + " (Capacity: " + reader["Hall_cap"] + ")";
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
            LoadShowsData();
            PopulateShowComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
    }
}
