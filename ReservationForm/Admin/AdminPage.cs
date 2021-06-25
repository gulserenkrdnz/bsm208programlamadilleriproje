using ReservationForm.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Admin
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Add_Flight_Click(object sender, EventArgs e)
        {
            Add_Flight addFlight = new Add_Flight();
            this.Visible = false;
            addFlight.ShowDialog();
            this.Close();
        }

        private void Show_Rz_Click(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            this.Visible = false;
            reservation.ShowDialog();
            this.Close();
        }

        private void Add_notification_Click(object sender, EventArgs e)
        {
            update_information update = new update_information();
            this.Visible = false;
            update.ShowDialog();
            this.Close();

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Visible = false;
            adminLogin.ShowDialog();
            this.Close();
        }
    }
}