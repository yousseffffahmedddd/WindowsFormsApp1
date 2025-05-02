using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class customers : Form
    {
        // Connection string for database
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=cinema_DB;Integrated Security=True;";

        public customers()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Set the form window state to maximized
            this.WindowState = FormWindowState.Maximized;

            // Load data into the DataGridView
            LoadCustomersData();

            // Load customer names into comboboxes
            PopulateCustomerComboBoxes();
        }

        private void LoadCustomersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Customer_id, Customer_firstName, Customer_lastName, Customer_email, Customer_phoneNum, Customer_age FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Customer ID");
                    table.Columns.Add("First Name");
                    table.Columns.Add("Last Name");
                    table.Columns.Add("Email");
                    table.Columns.Add("Phone Number");
                    table.Columns.Add("Age");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Customer ID"] = reader["Customer_id"];
                        row["First Name"] = reader["Customer_firstName"];
                        row["Last Name"] = reader["Customer_lastName"];
                        row["Email"] = reader["Customer_email"];
                        row["Phone Number"] = reader["Customer_phoneNum"];
                        row["Age"] = reader["Customer_age"];
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

        private void PopulateCustomerComboBoxes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Customer_id, Customer_firstName, Customer_lastName FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    customerDeleteComboBox.Items.Clear();
                    customerUpdateComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string display = $"{reader["Customer_id"]} - {reader["Customer_firstName"]} {reader["Customer_lastName"]}";
                        customerDeleteComboBox.Items.Add(display);
                        customerUpdateComboBox.Items.Add(display);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    MessageBox.Show("First Name and Last Name fields are required.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Customer (Customer_firstName, Customer_lastName, Customer_email, Customer_phoneNum, Customer_age) 
                                               VALUES (@firstName, @lastName, @email, @phoneNum, @age)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@email", emailTextBox.Text);
                    command.Parameters.AddWithValue("@phoneNum", phoneNumTextBox.Text);
                    command.Parameters.AddWithValue("@age", ageTextBox.Text);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Customer added successfully!");

                // Clear text boxes after insertion
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneNumTextBox.Text = "";
                ageTextBox.Text = "";

                // Refresh data
                LoadCustomersData();
                PopulateCustomerComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting customer: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerDeleteComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a customer to delete.");
                    return;
                }

                // Extract customer ID from the selected item
                string selectedCustomer = customerDeleteComboBox.SelectedItem.ToString();
                int customerId = int.Parse(selectedCustomer.Split('-')[0].Trim());

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Customer WHERE Customer_id = @customerId";

                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Customer deleted successfully!");

                // Refresh data
                LoadCustomersData();
                PopulateCustomerComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerUpdateComboBox.SelectedItem == null || fieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a customer and a field to update.");
                    return;
                }

                // Extract customer ID from the selected item
                string selectedCustomer = customerUpdateComboBox.SelectedItem.ToString();
                int customerId = int.Parse(selectedCustomer.Split('-')[0].Trim());

                string selectedField = fieldComboBox.SelectedItem.ToString();
                string dbField = "";

                // Map UI field names to database field names
                switch (selectedField)
                {
                    case "First Name": dbField = "Customer_firstName"; break;
                    case "Last Name": dbField = "Customer_lastName"; break;
                    case "Email": dbField = "Customer_email"; break;
                    case "Phone Number": dbField = "Customer_phoneNum"; break;
                    case "Age": dbField = "Customer_age"; break;
                    default: dbField = "Customer_" + selectedField.ToLower(); break;
                }

                string newValue = updateValueTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Customer SET {dbField} = @newValue WHERE Customer_id = @customerId";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Customer updated successfully!");

                // Clear text box after update
                updateValueTextBox.Text = "";

                // Refresh data
                LoadCustomersData();
                PopulateCustomerComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
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
                        query = "SELECT Customer_id, Customer_firstName, Customer_lastName, Customer_email, Customer_phoneNum, Customer_age FROM Customer";
                    }
                    else if (selectedOption == "Age")
                    {
                        string age = Microsoft.VisualBasic.Interaction.InputBox("Enter age to filter by:", "Filter by Age", "");
                        if (string.IsNullOrEmpty(age))
                            return;

                        query = $"SELECT Customer_id, Customer_firstName, Customer_lastName, Customer_email, Customer_phoneNum, Customer_age FROM Customer WHERE Customer_age = '{age}'";
                    }
                    else
                    {
                        return;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Columns.Add("Customer ID");
                    table.Columns.Add("First Name");
                    table.Columns.Add("Last Name");
                    table.Columns.Add("Email");
                    table.Columns.Add("Phone Number");
                    table.Columns.Add("Age");

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();
                        row["Customer ID"] = reader["Customer_id"];
                        row["First Name"] = reader["Customer_firstName"];
                        row["Last Name"] = reader["Customer_lastName"];
                        row["Email"] = reader["Customer_email"];
                        row["Phone Number"] = reader["Customer_phoneNum"];
                        row["Age"] = reader["Customer_age"];
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
            LoadCustomersData();
            PopulateCustomerComboBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
