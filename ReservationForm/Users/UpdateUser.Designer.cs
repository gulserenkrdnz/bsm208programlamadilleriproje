
namespace ReservationForm.Users
{
    partial class UpdateUser
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
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Register_PassCheck = new System.Windows.Forms.TextBox();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckNewPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Şifre :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "Bilgileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Şifre Tekrar :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Yeni Email :";
            // 
            // Register_PassCheck
            // 
            this.Register_PassCheck.Location = new System.Drawing.Point(142, 311);
            this.Register_PassCheck.Name = "Register_PassCheck";
            this.Register_PassCheck.Size = new System.Drawing.Size(183, 25);
            this.Register_PassCheck.TabIndex = 27;
            // 
            // Register_Password
            // 
            this.Register_Password.Location = new System.Drawing.Point(141, 268);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(183, 25);
            this.Register_Password.TabIndex = 26;
            // 
            // Register_Email
            // 
            this.Register_Email.Location = new System.Drawing.Point(146, 35);
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(183, 25);
            this.Register_Email.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Yeni Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Yeni Şifre Tekrar :";
            // 
            // CheckNewPass
            // 
            this.CheckNewPass.Location = new System.Drawing.Point(147, 77);
            this.CheckNewPass.Name = "CheckNewPass";
            this.CheckNewPass.Size = new System.Drawing.Size(183, 25);
            this.CheckNewPass.TabIndex = 34;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(146, 34);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(183, 25);
            this.NewPass.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Register_Email);
            this.groupBox1.Location = new System.Drawing.Point(42, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 80);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Güncelle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CheckNewPass);
            this.groupBox2.Controls.Add(this.NewPass);
            this.groupBox2.Location = new System.Drawing.Point(42, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 113);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Güncelle";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Register_PassCheck);
            this.Controls.Add(this.Register_Password);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Register_PassCheck;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckNewPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}