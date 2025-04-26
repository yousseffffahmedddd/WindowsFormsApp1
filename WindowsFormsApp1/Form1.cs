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
    public partial class datagridview: Form
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
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();

            string updatestr = @"update Admin set Admin_email=@email where Admin_id=4";
            SqlCommand command = new SqlCommand(updatestr, connection);
            command.CommandType = CommandType.Text;
            SqlParameter email = new SqlParameter("email", textBox2.Text);
            command.Parameters.Add(email);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("succses update");



        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R2SLAOP\\SQLEXPRESS;Initial Catalog=Cinema_ticket_booking_system;Integrated Security=True");
            connection.Open();

            string deletestr = @"delete Admin where Admin_name=@name";
            SqlCommand command = new SqlCommand(deletestr, connection);
            command.CommandType = CommandType.Text;
            SqlParameter name = new SqlParameter("name", textBox3.Text);
            command.Parameters.Add(name);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("succses ");

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
    }
}
