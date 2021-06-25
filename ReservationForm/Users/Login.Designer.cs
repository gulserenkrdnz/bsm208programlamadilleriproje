
namespace ReservationForm.Users
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_AdminLogin = new System.Windows.Forms.Button();
            this.Login_Register = new System.Windows.Forms.Button();
            this.Login_Login = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_AdminLogin
            // 
            this.Login_AdminLogin.Location = new System.Drawing.Point(223, 270);
            this.Login_AdminLogin.Name = "Login_AdminLogin";
            this.Login_AdminLogin.Size = new System.Drawing.Size(107, 32);
            this.Login_AdminLogin.TabIndex = 20;
            this.Login_AdminLogin.Text = "Yönetici Girişi";
            this.Login_AdminLogin.UseVisualStyleBackColor = true;
            this.Login_AdminLogin.Click += new System.EventHandler(this.Login_AdminLogin_Click);
            // 
            // Login_Register
            // 
            this.Login_Register.Location = new System.Drawing.Point(223, 210);
            this.Login_Register.Name = "Login_Register";
            this.Login_Register.Size = new System.Drawing.Size(107, 29);
            this.Login_Register.TabIndex = 19;
            this.Login_Register.Text = "Kayıt Ol";
            this.Login_Register.UseVisualStyleBackColor = true;
            this.Login_Register.Click += new System.EventHandler(this.Login_Register_Click);
            // 
            // Login_Login
            // 
            this.Login_Login.Location = new System.Drawing.Point(223, 149);
            this.Login_Login.Name = "Login_Login";
            this.Login_Login.Size = new System.Drawing.Size(107, 29);
            this.Login_Login.TabIndex = 18;
            this.Login_Login.Text = "Giriş Yap";
            this.Login_Login.UseVisualStyleBackColor = true;
            this.Login_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Şifre:";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(138, 76);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(48, 17);
            this.isim.TabIndex = 16;
            this.isim.Text = "E-Mail:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 25);
            this.textBox2.TabIndex = 15;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(188, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(196, 25);
            this.UserName.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationForm.Properties.Resources.ucak_bileti_troyatur;
            this.ClientSize = new System.Drawing.Size(544, 387);
            this.Controls.Add(this.Login_AdminLogin);
            this.Controls.Add(this.Login_Register);
            this.Controls.Add(this.Login_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserName);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_AdminLogin;
        private System.Windows.Forms.Button Login_Register;
        private System.Windows.Forms.Button Login_Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox UserName;
    }
}