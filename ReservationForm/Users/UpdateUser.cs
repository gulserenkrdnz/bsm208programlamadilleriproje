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
        public User LoggedUser { get; set; }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            string message = this.LoggedUser.FirstName;
            MessageBox.Show(message);

            if (Register_Password == Register_PassCheck)
            {
                if (Register_Email != null)
                {
                    this.LoggedUser.Email = Register_Email.Text.Trim();
                    userManager.Update(this.LoggedUser);
                }
                if (NewPass != null && NewPass == CheckNewPass)
                {
                    this.LoggedUser.Pass = NewPass.Text.Trim();
                    userManager.Update(this.LoggedUser);
                }
                
            }
        }
    }
}
