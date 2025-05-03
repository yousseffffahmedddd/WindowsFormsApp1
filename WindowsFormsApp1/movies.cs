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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class movies : Form
    {
        private string connectionString = "Data Source=DESKTOP-JDD3HCC\\MSSQLSERVER01;Initial Catalog=cinema_DB;Integrated Security=True;";

        public movies()
        {
            InitializeComponent();
            populate_combobox();
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
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void insertionAndUpdateTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {



            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string insertstr = @"insert into Movies (Mov_name, Mov_rating, Mov_duration, Mov_category, Mov_year, Mov_language, Mov_minAge, Mov_cast_members,Mov_cast_roles,Admin_id) values(@Mov_name, @Mov_rating, @Mov_duration, @Mov_category, @Mov_year, @Mov_language, @Mov_minAge, @Mov_cast_members,@Mov_cast_roles,@Admin_id);";
            SqlCommand command = new SqlCommand(insertstr, connection);
            command.CommandType = CommandType.Text;
            SqlParameter Mov_name = new SqlParameter("Mov_name", textBox1.Text);
            SqlParameter Mov_rating = new SqlParameter("Mov_rating", maskedTextBox2.Text);
            SqlParameter Mov_duration = new SqlParameter("Mov_duration", maskedTextBox3.Text);
            SqlParameter Mov_category = new SqlParameter("Mov_category", textBox3.Text);
            SqlParameter Mov_year = new SqlParameter("Mov_year", maskedTextBox4.Text);
            SqlParameter Mov_language = new SqlParameter("Mov_language", textBox4.Text);
            SqlParameter Mov_minAge = new SqlParameter("Mov_minAge", maskedTextBox5.Text);
            SqlParameter Mov_cast_members = new SqlParameter("Mov_cast_members", richTextBox1.Text);
            SqlParameter Mov_cast_roles = new SqlParameter("Mov_cast_roles", richTextBox1.Text);
            SqlParameter Admin_id = new SqlParameter("Admin_id", textBox2.Text);
            command.Parameters.Add(Mov_name);
            command.Parameters.Add(Mov_rating);
            command.Parameters.Add(Mov_duration);
            command.Parameters.Add(Mov_category);
            command.Parameters.Add(Mov_year);
            command.Parameters.Add(Mov_language);
            command.Parameters.Add(Mov_minAge);
            command.Parameters.Add(Mov_cast_members);
            command.Parameters.Add(Mov_cast_roles);
            command.Parameters.Add(Admin_id);
            command.ExecuteNonQuery();
            connection.Close();




            MessageBox.Show("succses insert ");


        }

        private void ShowMovies_Click(object sender, EventArgs e)
        {


        }

        private void movies_delete_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Extract movie ID from the selected item
            string selectedMovie = movies_delete_combobox.SelectedItem.ToString();
            int movieId = int.Parse(selectedMovie.Split('-')[0].Trim());
            // Use the movie ID in your SQL command
            string deletestr = @"delete  Movies where Movie_id=@Movie_id";

            SqlCommand command = new SqlCommand(deletestr, connection);
            SqlParameter mov_id = new SqlParameter("@Movie_id", movieId);

            command.Parameters.Add(mov_id);
            command.ExecuteNonQuery();

            

            MessageBox.Show("success delete");
            populate_combobox();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (update_movie_combobox.SelectedItem == null || string.IsNullOrEmpty(update_attr_combobox.Text))
            {
                MessageBox.Show("Please select a movie and attribute to update.");
                return;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                // Extract movie ID from the selected item
                string selectedMovie = update_movie_combobox.SelectedItem.ToString();
                int movieId = int.Parse(selectedMovie.Split('-')[0].Trim());

                string attributeName = update_attr_combobox.Text.Trim();
                string newValue = update_textbox.Text.Trim();

                // Build the dynamic SQL with proper escaping for column names
                string updatestr = $"UPDATE Movies SET [{attributeName}] = @Value WHERE Movie_id = @MovieId";

                SqlCommand command = new SqlCommand(updatestr, connection);
                command.Parameters.AddWithValue("@Value", newValue);
                command.Parameters.AddWithValue("@MovieId", movieId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully updated movie information!");
                }
                else
                {
                    MessageBox.Show("No records were updated. Please check your selections.");
                }

                populate_combobox();
                update_textbox.Clear();
                update_movie_combobox.SelectedIndex = -1;
                update_attr_combobox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating movie: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void mov_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void movies_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SqlConnection connection = new SqlConnection(connectionString);
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
            table.Columns.Add("Mov_cast_members");
            table.Columns.Add("Mov_cast_roles");
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
                row["Mov_cast_members"] = reader["Mov_cast_members"];
                row["Mov_cast_roles"] = reader["Mov_cast_roles"];
                table.Rows.Add(row);

            }
            reader.Close();
            connection.Close();
            dataGridView1.DataSource = table;
        }

        void populate_combobox()
        {
            movies_delete_combobox.Items.Clear();
            update_movie_combobox.Items.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string showmoviesStr = @"select * from Movies";
            SqlCommand command = new SqlCommand(showmoviesStr, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string display = $"{reader["Movie_id"]} - {reader["Mov_name"]}";
                movies_delete_combobox.Items.Add(display);
                update_movie_combobox.Items.Add(display);
            }
            reader.Close();
            connection.Close();

        }
    }
}
