using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Users
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Back_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }

        private void SearchTicket_Click(object sender, EventArgs e)
        {
            FlightList flightList = new FlightList();
            this.Visible = false;
            flightList.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
