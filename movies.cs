using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
using System.Data.SqlClient;
>>>>>>> 1f6da3a15b613da3c1611ba337c4325963a65fa5

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

<<<<<<< HEAD
        private void OK_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            //connection.Open();

            //string updatestr = @"update Admin set Admin_email=@email where Admin_id=4";
            //SqlCommand command = new SqlCommand(updatestr, connection);
            //command.CommandType = CommandType.Text;
            //SqlParameter email = new SqlParameter("email", textBox2.Text);
            //command.Parameters.Add(email);
            //command.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("succses update");


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();


            string insertstr = @"insert into Movies (Mov_name, Mov_rating, Mov_duration, Mov_category, Mov_year, Mov_language, Mov_minAge, Mov_cast) values(@Mov_name, @Mov_rating, @Mov_duration, @Mov_category, @Mov_year, @Mov_language, @Mov_minAge, @Mov_cast);";
            SqlCommand command = new SqlCommand(insertstr, connection);
            command.CommandType = CommandType.Text;

            SqlParameter Mov_name = new SqlParameter("Mov_name", textBox1.Text);
            SqlParameter Mov_rating = new SqlParameter("Mov_rating", maskedTextBox2.Text);
            SqlParameter Mov_duration = new SqlParameter("Mov_duration", maskedTextBox3.Text);
            SqlParameter Mov_category = new SqlParameter("Mov_category", textBox3.Text);
            SqlParameter Mov_year = new SqlParameter("Mov_year", maskedTextBox4.Text);
            SqlParameter Mov_language = new SqlParameter("Mov_language", textBox4.Text);
            SqlParameter Mov_minAge = new SqlParameter("Mov_minAge", maskedTextBox5.Text);
            SqlParameter Mov_cast = new SqlParameter("Mov_cast", richTextBox1.Text);
            command.Parameters.Add(Mov_name);
            command.Parameters.Add(Mov_rating);
            command.Parameters.Add(Mov_duration);
            command.Parameters.Add(Mov_category);
            command.Parameters.Add(Mov_year);
            command.Parameters.Add(Mov_language);
            command.Parameters.Add(Mov_minAge); 
            command.Parameters.Add(Mov_cast);
            command.ExecuteNonQuery();
            connection.Close();


      

            MessageBox.Show("succses insert ");


        }

        private void ShowMovies_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True;");
            connection.Open();
            string showmoviesStr = @"select * from Movies";
            SqlCommand command = new SqlCommand(showmoviesStr, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Movie_id");
            table.Columns.Add("Mov_name");
            table.Columns.Add("Mov_rating");
            table.Columns.Add("Mov_duration");
            table.Columns.Add("Mov_category");
            table.Columns.Add("Mov_language");
            table.Columns.Add("Mov_minAge");
            table.Columns.Add("Mov_year");
            table.Columns.Add("Mov_cast");
            DataRow row;
            while (reader.Read())
            {
                row = table.NewRow();
                row["Movie_id"] = reader["Movie_id"];
                row["Mov_name"] = reader["Mov_name"];
                row["Mov_rating"] = reader["Mov_rating"];
                row["Mov_duration"] = reader["Mov_duration"];
                row["Mov_category"] = reader["Mov_category"];
                row["Mov_language"] = reader["Mov_language"];
                row["Mov_minAge"] = reader["Mov_minAge"];
                row["Mov_year"] = reader["Mov_year"];
                row["Mov_cast"] = reader["Mov_cast"];

                table.Rows.Add(row);

            }
            reader.Close();
            connection.Close();
            dataGridView1.DataSource = table;

        }

        private void movies_delete_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True;");
            connection.Open();
            string deletestr1 = @"delete  movies where Mov_name=@name";
            string deletestr2=@"delete movies where Mov_year = @year";
            SqlCommand command1= new SqlCommand(deletestr1, connection);
            SqlCommand command2 = new SqlCommand(deletestr2, connection);
            SqlParameter mov_name = new SqlParameter("@name", textBox2.Text);
            SqlParameter mov_year = new SqlParameter("@year", textBox2.Text);
            if (movies_delete_combobox.Items.Contains("Mov_name"))
            {
                command1.Parameters.Add(mov_name);
                command1.ExecuteNonQuery();
            
            }
            else if (movies_delete_combobox.Items.Contains("Mov_year"))
            {
                command2.Parameters.Add(mov_year);
                command2.ExecuteNonQuery();
            }
            MessageBox.Show("success delete");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();


            SqlParameter Mov_id = new SqlParameter("@Movie_id", mov_id.Text);
            SqlParameter Mov_name = new SqlParameter("@Mov_name", textBox1.Text);
            SqlParameter Mov_rating = new SqlParameter("@Mov_rating", maskedTextBox2.Text);
            SqlParameter Mov_duration = new SqlParameter("Mov_duration", maskedTextBox3.Text);
            SqlParameter Mov_category = new SqlParameter("Mov_category", textBox3.Text);
            SqlParameter Mov_year = new SqlParameter("Mov_year", maskedTextBox4.Text);
            SqlParameter Mov_language = new SqlParameter("Mov_language", textBox4.Text);
            SqlParameter Mov_minAge = new SqlParameter("Mov_minAge", maskedTextBox5.Text);
            SqlParameter Mov_cast = new SqlParameter("Mov_cast", richTextBox1.Text);

            if (comboBox3.Items.Contains("name"))
            {
                string updatestr = @"update Movies
                                    set 
                                    Mov_name=@Mov_name
                                    where Movie_id=@Movie_id ;";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);
                command.Parameters.Add(Mov_name);
                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("rating"))
            {
                string updatestr2 = @"update Movies
                                    set 
                                    Mov_rating=@Mov_rating
                                    where Movie_id=@Movie_id ;";
                SqlCommand command = new SqlCommand(updatestr2, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);

                command.Parameters.Add(Mov_rating);

                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("duration"))
            {
                string updatestr = @"update Movies
                                    set 
                                    Mov_duration=@Mov_duration
                                    where Movie_id=@Movie_id;";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);

                command.Parameters.Add(Mov_duration);

                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("category"))
            {
                string updatestr = @"update Movies
                                    set 
                                    Mov_category=@Mov_category
                                    where Movie_id=@Movie_id;";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);

                command.Parameters.Add(Mov_category);

                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("year"))
            {

                string updatestr = @"update Movies
                                    set 
                                    Mov_year=@Mov_year
                                    where Movie_id=@Movie_id;";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);

                command.Parameters.Add(Mov_year);

                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("language"))
            {

                string updatestr = @"update Movies
                                    set 
                                    Mov_language=@Mov_language
                                    where Movie_id=@Movie_id;";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);

                command.Parameters.Add(Mov_language);

                command.ExecuteNonQuery();
            }
            else if (comboBox3.Items.Contains("min_age"))
            {

                string updatestr = @"update Movies
                                    set
                                    Mov_min_age=@Mov_min_age
                                    where Movie_id=@Movie_id;";

                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add(Mov_id);
                command.Parameters.Add(Mov_minAge);


                command.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("succses update ");

        }

        private void mov_id_TextChanged(object sender, EventArgs e)
=======
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
>>>>>>> 1f6da3a15b613da3c1611ba337c4325963a65fa5
        {

        }
    }
}
//show movies
//private void button5_Click(object sender, EventArgs e)
//{
   
////}

//private void button6_Click(object sender, EventArgs e)
//{
//    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True;");
//    connection.Open();
//    string showCustomersstr = @"select * from Customer";
//    SqlCommand command = new SqlCommand(showCustomersstr, connection);
//    command.CommandType = CommandType.Text;
//    SqlDataReader reader = command.ExecuteReader();
//    DataTable table = new DataTable();
//    table.Columns.Add("Customer_id");
//    table.Columns.Add("Customer_email");
//    table.Columns.Add("Customer_phoneNum");
//    table.Columns.Add("Customer_age");
//    table.Columns.Add("Customer_fullName");
//    DataRow row;
//    while (reader.Read())
//    {
//        row = table.NewRow();
//        row["ID"] = reader["Customer_id"];
//        row["EMAIL"] = reader["Customer_email"];
//        row["PHONENUM"] = reader["Customer_phoneNum"];
//        row["AGE"] = reader["Customer_age"];
//        row["FULLNAME"] = reader["Customer_fullName"];

//        table.Rows.Add(row);

//    }
//    reader.Close();
//    connection.Close();
//    dataGridView2.DataSource = table;
