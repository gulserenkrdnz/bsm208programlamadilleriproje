
namespace UcakBiletiRezervasyon
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
            this.Admin_LoginButton.Location = new System.Drawing.Point(97, 139);
            this.Admin_LoginButton.Name = "Admin_LoginButton";
            this.Admin_LoginButton.Size = new System.Drawing.Size(107, 26);
            this.Admin_LoginButton.TabIndex = 23;
            this.Admin_LoginButton.Text = "Giriş Yap";
            this.Admin_LoginButton.UseVisualStyleBackColor = true;
            this.Admin_LoginButton.Click += new System.EventHandler(this.Admin_LoginButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre:";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(2, 71);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(69, 15);
            this.isim.TabIndex = 21;
            this.isim.Text = "Username : ";
            // 
            // Admin_Password
            // 
            this.Admin_Password.Location = new System.Drawing.Point(77, 100);
            this.Admin_Password.Name = "Admin_Password";
            this.Admin_Password.Size = new System.Drawing.Size(154, 23);
            this.Admin_Password.TabIndex = 20;
            // 
            // Admin_UserName
            // 
            this.Admin_UserName.Location = new System.Drawing.Point(77, 68);
            this.Admin_UserName.Name = "Admin_UserName";
            this.Admin_UserName.Size = new System.Drawing.Size(154, 23);
            this.Admin_UserName.TabIndex = 19;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(300, 172);
            this.Controls.Add(this.Admin_LoginButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.Admin_Password);
            this.Controls.Add(this.Admin_UserName);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
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