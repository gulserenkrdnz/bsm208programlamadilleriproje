
namespace ReservationForm.Admin
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.Admin_LoginButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.Admin_Password = new System.Windows.Forms.TextBox();
            this.Admin_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Admin_LoginButton
            // 
            this.Admin_LoginButton.Location = new System.Drawing.Point(115, 113);
            this.Admin_LoginButton.Name = "Admin_LoginButton";
            this.Admin_LoginButton.Size = new System.Drawing.Size(107, 28);
            this.Admin_LoginButton.TabIndex = 23;
            this.Admin_LoginButton.Text = "Giriş Yap";
            this.Admin_LoginButton.UseVisualStyleBackColor = true;
            this.Admin_LoginButton.Click += new System.EventHandler(this.Admin_LoginButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre:";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(31, 40);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(78, 17);
            this.isim.TabIndex = 21;
            this.isim.Text = "Username : ";
            // 
            // Admin_Password
            // 
            this.Admin_Password.Location = new System.Drawing.Point(115, 73);
            this.Admin_Password.Name = "Admin_Password";
            this.Admin_Password.Size = new System.Drawing.Size(154, 25);
            this.Admin_Password.TabIndex = 20;
            // 
            // Admin_UserName
            // 
            this.Admin_UserName.Location = new System.Drawing.Point(115, 37);
            this.Admin_UserName.Name = "Admin_UserName";
            this.Admin_UserName.Size = new System.Drawing.Size(154, 25);
            this.Admin_UserName.TabIndex = 19;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(316, 176);
            this.Controls.Add(this.Admin_LoginButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.Admin_Password);
            this.Controls.Add(this.Admin_UserName);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin_LoginButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox Admin_Password;
        private System.Windows.Forms.TextBox Admin_UserName;
    }
}