using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
            populateCombobox();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void insertionAndUpdateTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_click(object sender, EventArgs e)
        {
            string selectedMovie = movies_delete_combobox.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JDD3HCC\MSSQLSERVER01;Initial Catalog=MovieTheaterDB;Integrated Security=True;");
            con.Open();
            SqlCommand deleteShowsCmd = new SqlCommand("DELETE FROM Show WHERE Movie_id = (SELECT Movie_id FROM Movies WHERE Mov_name = @Mov_name)", con);
            deleteShowsCmd.Parameters.AddWithValue("@Mov_name", selectedMovie);
            deleteShowsCmd.ExecuteNonQuery();


            SqlCommand cmd = new SqlCommand("DELETE FROM Movies WHERE Mov_name = @Mov_name", con);
            cmd.Parameters.AddWithValue("@Mov_name", selectedMovie);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Movie deleted successfully.");
            populateCombobox();

        }

        private void populateCombobox()
        {
            // Define the connection string
            string connectionString = @"Data Source=DESKTOP-JDD3HCC\MSSQLSERVER01;Initial Catalog=MovieTheaterDB;Integrated Security=True;";

            // Create a new connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Query to fetch movie names
                    SqlCommand cmd = new SqlCommand("SELECT Mov_name FROM Movies", conn);

                    // Execute the query and read the results
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<string> movieNames = new List<string>();
                    while (reader.Read())
                    {
                        movieNames.Add(reader["Mov_name"].ToString());
                    }
                    reader.Close();

                    // Update the combo boxes
                    comboBox3.DataSource = null; // Reset the data source
                    movies_delete_combobox.DataSource = null; // Reset the data source
                    comboBox3.DataSource = movieNames;
                    movies_delete_combobox.DataSource = movieNames;

                    // Reset the selected index
                    comboBox3.SelectedIndex = -1;
                    movies_delete_combobox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("An error occurred while populating the combo boxes: " + ex.Message);
                }
            }
        }
        private void insertbtn_Click(object sender, EventArgs e)
        {
            // Get values from input fields  
            string movieName = name.Text.Trim();
            if (!int.TryParse(this.rating.Text.Trim(), out int rating))
            {
                MessageBox.Show("Please enter a valid integer for the rating.");
                return;
            }

            string duration = this.duration.Text.Trim();
            string category = this.category.SelectedItem?.ToString();
            int year = int.Parse(this.year.Text.Trim());
            string language = this.language.SelectedItem?.ToString();
            string minAge = min_age.Text.Trim();
            string cast = this.cast.Text.Trim();

            // Validate inputs  
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(duration) ||
                string.IsNullOrEmpty(category) || year< 1910 || year > 2025 ||
                string.IsNullOrEmpty(language) || string.IsNullOrEmpty(minAge) ||
                string.IsNullOrEmpty(cast))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Define the connection string  
            string connectionString = @"Data Source=DESKTOP-JDD3HCC\MSSQLSERVER01;Initial Catalog=MovieTheaterDB;Integrated Security=True;";

            // Insert into the database  
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to insert a new movie  
                    string query = @"INSERT INTO Movies (Movie_id, Mov_name, Mov_rating, Mov_duration, Mov_category, Mov_language, Mov_minAge, Mov_cast, Admin_id)  
                                    VALUES (35, @Mov_name, @Rating, @Duration, @Category, @Language, @Min_Age, @Cast, 1)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Mov_name", movieName);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Duration", duration);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Language", language);
                    cmd.Parameters.AddWithValue("@Min_Age", minAge);
                    cmd.Parameters.AddWithValue("@Cast", cast);

                    // Execute the query  
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Movie inserted successfully.");
                        populateCombobox(); // Refresh the combo boxes  
                        clearInputFields(); // Clear the input fields  
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert the movie.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting the movie: " + ex.Message);
                }
            }
        }

        // Helper method to clear input fields
        private void clearInputFields()
        {
            name.Clear();
            rating.Clear();
            duration.Clear();
            category.SelectedIndex = -1;
            year.Clear();
            language.SelectedIndex = -1;
            min_age.Clear();
            cast.Clear();
        }
       
        private void backbtn_Click(object sender, EventArgs e)
        {
            // Navigate back to the dashboard form
            this.Hide(); // Hide the current form
            dashboard dashboardForm = new dashboard();
            dashboardForm.Show();
        }

        private void sh(object sender, EventArgs e)
        {

        }
    }
}
