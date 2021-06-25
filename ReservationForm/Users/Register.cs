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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Register_RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterResult registerResult = new RegisterResult();
            this.Visible = false;
            registerResult.ShowDialog();
            this.Close();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_RegisterButton_Click_1(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User {
                FirstName = Register_Name.Text.Trim(),
                LastName = Register_LastName.Text.Trim(),
                BirthDate = dateTimePicker1.Value,
                PhoneNumber = textBox1.Text.Trim(),
                TC = Register_TC.Text.Trim(),
                Email = Register_Email.Text.Trim(),
                Pass = Register_Password.Text.Trim()
            };

            if (Register_Password.Text.Trim() == Register_PassCheck.Text.Trim()
                && userManager.GetByemail(Register_Email.Text.Trim()) == null)
            {
                userManager.Add(user);
                //Kayıt tamamlandı bildirimi verilecek
            }
            else
            {
                //Kayıt tamamlanamadı bildirimi verilecek
            }
        }
    }
}
