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

        }
    }
}
