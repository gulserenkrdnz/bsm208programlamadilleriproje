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

namespace ReservationForm.Users
{
    public partial class UpdateUser : Form
    {
       
        public UpdateUser()
        {
            InitializeComponent();
        }

        //public User LoggedUser { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            if (Login.LoggedUser.Pass == Register_Password.Text)
            {
                User user = new User();
                user = Login.LoggedUser;

                if (Register_Email.Text.Length > 0)
                {
                    user.Email = Register_Email.Text.Trim();
                }
                if (NewPass.Text.Length > 0 && NewPass.Text.Trim() == CheckNewPass.Text.Trim())
                {
                    user.Pass = NewPass.Text.Trim();
                }

                userManager.Update(user);
                MessageBox.Show("Günellendi");
            }
            else
            {
                MessageBox.Show("Günellenme işlemi tamamlanamadı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            this.Visible = false;
            userPage.ShowDialog();
            this.Close();
        }
    }
}
