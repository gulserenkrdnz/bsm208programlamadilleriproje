
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckNewPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Register_Username = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CheckNewPass);
            this.groupBox2.Controls.Add(this.NewPass);
            this.groupBox2.Location = new System.Drawing.Point(55, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 113);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Güncelle";
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
            this.groupBox1.Controls.Add(this.Register_Username);
            this.groupBox1.Location = new System.Drawing.Point(55, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 80);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Adı Güncelle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Yeni Kullanıcı Adı :";
            // 
            // Register_Username
            // 
            this.Register_Username.Location = new System.Drawing.Point(146, 35);
            this.Register_Username.Name = "Register_Username";
            this.Register_Username.Size = new System.Drawing.Size(183, 25);
            this.Register_Username.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Şifre :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 41);
            this.button3.TabIndex = 40;
            this.button3.Text = "Bilgileri Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Register_Password
            // 
            this.Register_Password.Location = new System.Drawing.Point(152, 271);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(183, 25);
            this.Register_Password.TabIndex = 39;
            // 
            // update_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.button2);
            this.Name = "update_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_information";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckNewPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Register_Username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Register_Password;
    }
}