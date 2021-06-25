using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Admin
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Visible = false;
            adminPage.ShowDialog();
            this.Close();
        }
    }
}
