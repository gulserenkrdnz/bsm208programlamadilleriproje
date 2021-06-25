using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Admin
{
    public partial class Add_Flight : Form
    {
        public Add_Flight()
        {
            InitializeComponent();
        }

        private void Add_Flight_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Visible = false;
            adminPage.ShowDialog();
            this.Close();
        }
    }
}
