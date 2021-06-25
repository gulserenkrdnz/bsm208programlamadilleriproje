using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
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
                AdminPage adminPage = new AdminPage();
                this.Visible = false;
                adminPage.ShowDialog();
                this.Close();
            }
            
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
