using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admins : Form
    {
        // Connection string for database
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=CinemaDB;Integrated Security=True;";

        public admins()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadAdminsData();

            // Load admin names into comboboxes
            PopulateAdminComboBoxes();
        }

        private void LoadAdminsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Admin_id, Admin_name, Admin_email FROM Admin";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Admin_id");
                    table.Columns.Add("Name");
                    table.Columns.Add("Email");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Admin_id"] = reader["Admin_id"];
                        row["Name"] = reader["Admin_name"];
                        row["Email"] = reader["Admin_email"];
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

        private void PopulateAdminComboBoxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Admin_id, Admin_name FROM Admin";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    admin_delete_combobox.Items.Clear();
                    adminSelectComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["Admin_id"]} - {reader["Admin_name"]}";
                        admin_delete_combobox.Items.Add(display);
                        adminSelectComboBox.Items.Add(display);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin names: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Name and Password fields are required.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Admin (Admin_name, Admin_email, Admin_password) 
                       VALUES (@name, @email, @password)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@email", emailTextBox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextBox.Text);


                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Admin added successfully!");

                // Clear text boxes after insertion
                nameTextBox.Text = "";
                passwordTextBox.Text = "";
                emailTextBox.Text = "";

                // Refresh data
                LoadAdminsData();
                PopulateAdminComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting admin: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin_delete_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select an admin to delete.");
                    return;
                }

                // Extract admin ID from the selected item
                string selectedAdmin = admin_delete_combobox.SelectedItem.ToString();
                int adminId = int.Parse(selectedAdmin.Split('-')[0].Trim());

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?",
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Admin WHERE Admin_id = @adminId";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@adminId", adminId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Admin deleted successfully!");

                // Refresh data
                LoadAdminsData();
                PopulateAdminComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting admin: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminSelectComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select an admin and a field to update.");
                    return;
                }

                // Extract admin ID from the selected item
                string selectedAdmin = adminSelectComboBox.SelectedItem.ToString();
                int adminId = int.Parse(selectedAdmin.Split('-')[0].Trim());

                string selectedField = fieldComboBox.SelectedItem.ToString().ToLower();
                string newValue = updateTextBox.Text;

                if (string.IsNullOrEmpty(newValue))
                {
                    MessageBox.Show("New value cannot be empty.");
                    return;
                }
                string dbField = string.Empty;
                switch (selectedField)
                {
                    case "Name": dbField = "Admin_name"; break;
                    case "Email": dbField = "Admin_email"; break;
                    case "Password": dbField = "Admin_password"; break;
                    default: dbField = selectedField; break;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Admin SET {dbField} = @newValue WHERE Admin_id = @adminId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@adminId", adminId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Admin updated successfully!");

                // Clear text box after update
                updateTextBox.Text = "";

                // Refresh data
                LoadAdminsData();
                PopulateAdminComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating admin: " + ex.Message);
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
                        query = "SELECT Admin_id, Admin_name, Admin_email FROM Admin";
                    }
                    else if (selectedOption == "Email")
                    {
                        string email = Microsoft.VisualBasic.Interaction.InputBox("Enter email to filter by:", "Filter by Email", "");
                        if (string.IsNullOrEmpty(email))
                            return;

                        query = $"SELECT Admin_id, Admin_name, Admin_email FROM Admin WHERE Admin_email LIKE '%{email}%'";
                    }
                    else
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Admin_id");
                    table.Columns.Add("Name");
                    table.Columns.Add("Role");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Admin_id"] = reader["Admin_id"];
                        row["Name"] = reader["name"];
                        row["Role"] = reader["role"];
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
            LoadAdminsData();
            PopulateAdminComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Implement code to navigate back to dashboard
            // For example: this.Close(); or Form1 dashboardForm = new Form1(); dashboardForm.Show();
            dashboard dashboardForm = new dashboard();
            this.Close();
            dashboardForm.Show();
        }
    }
}
