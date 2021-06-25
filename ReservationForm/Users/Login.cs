using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ReservationForm;

namespace ReservationForm.Users
{
    public partial class Login : Form
    {
        public Login()
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

        private void Login_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Visible = false;
            register.ShowDialog();
            this.Close();
        }

        private void Login_AdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Visible = false;
            adminLogin.ShowDialog();
            this.Close();
        }
    }
}
