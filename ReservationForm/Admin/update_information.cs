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
    public partial class update_information : Form
    {
        public update_information()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Visible = false;
            adminPage.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgencyManager agencyManager = new AgencyManager(new EfAgencyDal());

            if (AdminLogin.LoggedAdmin.Pass == Register_Password.Text)
            {
                Agency agency = new Agency();
                agency = AdminLogin.LoggedAdmin;

                if (Register_Username.Text.Length > 0)
                {
                    agency.UserName = Register_Username.Text.Trim();
                    MessageBox.Show("Email");
                }
                if (NewPass.Text.Length > 0 && NewPass.Text.Trim() == CheckNewPass.Text.Trim())
                {
                    agency.Pass = NewPass.Text.Trim();
                    MessageBox.Show("Pass");
                }

                agencyManager.Update(agency);
            }
        }
    }
}
