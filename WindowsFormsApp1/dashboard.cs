using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            movies m = new movies();
            m.Show();
            this.Hide();
        }

        private void adminbtn(object sender, EventArgs e)
        {
            admins a = new admins();
            a.Show();
            this.Hide();
        }

        private void customerbtn(object sender, EventArgs e)
        {
            customers c = new customers();
            c.Show();
            this.Hide();
        }

        private void hallsbtn(object sender, EventArgs e)
        {
            halls h = new halls();
            h.Show();
            this.Hide();

        }

        private void seatsbtn(object sender, EventArgs e)
        {
            seats s = new seats();
            s.Show();
            this.Hide();

        }

        private void ticketsbtn(object sender, EventArgs e)
        {
            tickets ticket = new tickets();
            ticket.Show();
            this.Hide();
        }

        private void showsbtn(object sender, EventArgs e)
        {
            shows s = new shows();
            s.Show();
            this.Hide();
        }

        private void paymentbtn(object sender, EventArgs e)
        {
            payments p = new payments();
            p.Show();
            this.Hide();

        }
    }

}
