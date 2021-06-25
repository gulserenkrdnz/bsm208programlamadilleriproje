using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Users
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Visible = false;
            search.ShowDialog();
            this.Close();
        }

        private void Reservation_Show_Click(object sender, EventArgs e)
        {
            Show_Reservation reservation = new Show_Reservation();
            this.Visible = false;
            reservation.ShowDialog();
            this.Close();
        }

        private void informtion_updte_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            this.Visible = false;
            updateUser.ShowDialog();
            this.Close();
        }
    }
}
