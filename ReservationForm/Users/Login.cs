using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using ReservationForm;
using ReservationForm.Admin;

namespace ReservationForm.Users
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Login olan kullanıcıya buradan ulaşacağız
        public static User LoggedUser;


        private void button1_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User();
            
            user = userManager.LoginCheck(UserName.Text.Trim(), Pass.Text.Trim());
           
            if(user is null)
            {
                //Hatalı giriş uyarısı verilecek
            }
            else
            {
                LoggedUser = user;

                UserPage userPage = new UserPage();
                this.Visible = false;
                userPage.ShowDialog();
                this.Close();
            }
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

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
