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
        public movies()
        {
            InitializeComponent();
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
