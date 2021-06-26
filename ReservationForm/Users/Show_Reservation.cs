using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Users
{
    public partial class Show_Reservation : Form
    {
        public Show_Reservation()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            this.Visible = false;
            userPage.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Exit Ex = new Exit();
            DialogResult sonuc = Ex.ShowDialog();
        }
    }
}
