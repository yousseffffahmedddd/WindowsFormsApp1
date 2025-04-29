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
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Tracing;

namespace WindowsFormsApp1
{
    public partial class datagridview : Form
    {
        public datagridview()
        {

            InitializeComponent();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();


            //SqlCommand query = new SqlCommand("insert into Admin (Admin_id,Admin_email,Admin_name,Admin_password) values('4','faaaaaagmail.com','abdo','442');", connection);
            //query.CommandType = CommandType.Text;

            //SqlDataReader reader = query.ExecuteReader();
            //DataTable table = new DataTable();
            //table.Columns.Add("AdminID");
            //table.Columns.Add("AdminEMAIL");

            //DataRow row;
            //while(reader.Read())
            //{
            //    row = table.NewRow();
            //    row["AdminID"] = reader["Admin_id"];
            //    row["AdminEMAIL"] = reader["Admin_email"];
            //    table.Rows.Add(row);
            //}
            //reader.Close();
            //connection.Close();
            //MessageBox.Show("succes");
            // dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();

            string insertstr = @"insert into Admin (Admin_id) values(@id);";
            SqlCommand command = new SqlCommand(insertstr, connection);
            command.CommandType = CommandType.Text;
            SqlParameter id = new SqlParameter("id", textBox1.Text);
            command.Parameters.Add(id);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("succses insert");





        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();


            SqlCommand query = new SqlCommand("select * from Admin", connection);
            query.CommandType = CommandType.Text;

            SqlDataReader reader = query.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("AdminID");
            table.Columns.Add("AdminEMAIL");
            table.Columns.Add("AdminNAME");
            table.Columns.Add("AdminPAss");

            DataRow row;
            while (reader.Read())
            {
                row = table.NewRow();
                row["AdminID"] = reader["Admin_id"];
                row["AdminEMAIL"] = reader["Admin_email"];
                row["AdminNAME"] = reader["Admin_name"];
                row["AdminPAss"] = reader["Admin_password"];
                table.Rows.Add(row);
            }
            reader.Close();
            connection.Close();
            MessageBox.Show("succes");
            dataGridView2.DataSource = table;

        }

        private void update_Click(object sender, EventArgs e)
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



        }

        private void delete_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            //connection.Open();

            //string deletestr = @"delete Admin where Admin_name=@name";
            //SqlCommand command = new SqlCommand(deletestr, connection);
            //command.CommandType = CommandType.Text;
            //SqlParameter name = new SqlParameter("name", textBox3.Text);
            //command.Parameters.Add(name);
            //command.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("succses ");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //insertcertain
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();

            string insertstr = @"insert into Admin (Admin_id,Admin_email,Admin_name,Admin_password) values(@idd,@emaill,@namee,@passw);";
            SqlCommand command = new SqlCommand(insertstr, connection);
            command.CommandType = CommandType.Text;
            SqlParameter idd = new SqlParameter("idd", textBox1.Text);
            SqlParameter emaill = new SqlParameter("emaill", textBox4.Text);
            SqlParameter namee = new SqlParameter("namee", textBox5.Text);
            SqlParameter passw = new SqlParameter("passw", textBox6.Text);
            command.Parameters.Add(idd);
            command.Parameters.Add(emaill);
            command.Parameters.Add(namee);
            command.Parameters.Add(passw);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("succses insert all");


        }
        //check boxes wrong
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combBoxUD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //update
        private void button1_Click_2(object sender, EventArgs e)
        {
            SqlParameter ID = new SqlParameter("ID", textBoxUpdateID.Text);
            SqlParameter passwor = new SqlParameter("passwor", textBoxNewValUpdate.Text);
            SqlParameter email = new SqlParameter("email", textBoxNewValUpdate.Text);
            SqlParameter name = new SqlParameter("name", textBoxNewValUpdate.Text);


            if (comboBox1.Text.Contains("email"))
            {

                //update
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();


                string updatestr = @"update Admin set Admin_email=@email where Admin_id=@ID";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                //SqlParameter email = new SqlParameter("email", textBoxNewValUpdate.Text);
                command.Parameters.Add(ID);
                command.Parameters.Add(email);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses update");






            }
            else if (comboBox1.Text.Contains("name"))
            {

                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();

                string updatestr = @"update Admin set Admin_name=@name where Admin_id=@ID";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                // SqlParameter name = new SqlParameter("name", textBoxNewValUpdate.Text);
                command.Parameters.Add(ID);
                command.Parameters.Add(name);
                //command.Parameters.Add(name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses update");

            }
            else if (comboBox1.Text.Contains("password"))
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();

                string updatestr = @"update Admin set Admin_password=@passwor where Admin_id=@ID";
                SqlCommand command = new SqlCommand(updatestr, connection);
                command.CommandType = CommandType.Text;
                //SqlParameter passw = new SqlParameter("password", textBoxNewValUpdate.Text);
                //command.Parameters.Add(passw);
                command.Parameters.Add(ID);
                command.Parameters.Add(passwor);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses update");
            }

        }

        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (combBoxUD.Text.Contains("email"))
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();

                string deletestr = @"delete Admin where Admin_email=@email";
                SqlCommand command = new SqlCommand(deletestr, connection);
                command.CommandType = CommandType.Text;
                SqlParameter name = new SqlParameter("email", textBoxud.Text);
                command.Parameters.Add(name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses ");
            }
            else if (combBoxUD.Text.Contains("name"))
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();

                string deletestr = @"delete Admin where Admin_name=@name";
                SqlCommand command = new SqlCommand(deletestr, connection);
                command.CommandType = CommandType.Text;
                SqlParameter name = new SqlParameter("name", textBoxud.Text);
                command.Parameters.Add(name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses ");
            }
            else if (combBoxUD.Text.Contains("password"))
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
                connection.Open();

                string deletestr = @"delete Admin where Admin_password=@password";
                SqlCommand command = new SqlCommand(deletestr, connection);
                command.CommandType = CommandType.Text;
                SqlParameter name = new SqlParameter("password", textBoxud.Text);
                command.Parameters.Add(name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("succses ");
            }
        }
        //show movies
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True;");
            connection.Open();
            string showmoviesStr = @"select * from Movies";
            SqlCommand command = new SqlCommand(showmoviesStr, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
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
                row["NAME"] = reader["Mov_name"];
                row["RATING"] = reader["Mov_rating"];
                row["DURARION"] = reader["Mov_duration"];
                row["CATEOGRY"] = reader["Mov_category"];
                row["LANUAGE"] = reader["Mov_language"];
                row["MIN_AGE"] = reader["Mov_minAge"];
                row["YEAR OF PRODCTION"] = reader["Mov_year"];
                row["CAST"] = reader["Mov_cast"];

                table.Rows.Add(row);

            }
            reader.Close();
            connection.Close();
            dataGridView2.DataSource = table;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True;");
            connection.Open();
            string showCustomersstr = @"select * from Customer";
            SqlCommand command = new SqlCommand(showCustomersstr, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Customer_id");
            table.Columns.Add("Customer_email");
            table.Columns.Add("Customer_phoneNum");
            table.Columns.Add("Customer_age");
            table.Columns.Add("Customer_fullName");
            DataRow row;
            while (reader.Read())
            {
                row = table.NewRow();
                row["ID"] = reader["Customer_id"];
                row["EMAIL"] = reader["Customer_email"];
                row["PHONENUM"] = reader["Customer_phoneNum"];
                row["AGE"] = reader["Customer_age"];
                row["FULLNAME"] = reader["Customer_fullName"];

                table.Rows.Add(row);

            }
            reader.Close();
            connection.Close();
            dataGridView2.DataSource = table;

        }
    }
    //combobox and button


    
}
