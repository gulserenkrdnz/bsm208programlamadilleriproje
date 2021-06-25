
namespace ReservationForm.Admin
{
    partial class update_information
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
            this.label10 = new System.Windows.Forms.Label();
            this.Register_PassCheck = new System.Windows.Forms.TextBox();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Username :";
            // 
            // Register_PassCheck
            // 
            this.Register_PassCheck.Location = new System.Drawing.Point(167, 160);
            this.Register_PassCheck.Name = "Register_PassCheck";
            this.Register_PassCheck.Size = new System.Drawing.Size(183, 25);
            this.Register_PassCheck.TabIndex = 18;
            // 
            // Register_Password
            // 
            this.Register_Password.Location = new System.Drawing.Point(166, 117);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(183, 25);
            this.Register_Password.TabIndex = 17;
            // 
            // Register_Email
            // 
            this.Register_Email.Location = new System.Drawing.Point(166, 74);
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(183, 25);
            this.Register_Email.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Şifre Tekrar :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Bilgileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Şifre :";
            // 
            // update_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 373);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Register_PassCheck);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.Register_Email);
            this.Name = "update_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_information";
            this.Load += new System.EventHandler(this.update_information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Register_PassCheck;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
    }
}