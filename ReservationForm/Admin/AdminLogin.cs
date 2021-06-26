using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public static Agency LoggedAdmin;

        private void Admin_LoginButton_Click(object sender, EventArgs e)
        {

            AgencyManager agencyManager = new AgencyManager(new EfAgencyDal());
            Agency agency = new Agency();

            agency = agencyManager.LoginCheck(Admin_UserName.Text.Trim(), Admin_Password.Text.Trim());

            if (agency is null)
            {
                //Hatalı giriş uyarısı verilecek
            }
            else
            {
                LoggedAdmin = agency;

                AdminPage adminPage = new AdminPage();
                this.Visible = false;
                adminPage.ShowDialog();
                this.Close();
            }
            
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }
    }
}
