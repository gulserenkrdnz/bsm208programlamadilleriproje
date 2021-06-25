
namespace ReservationForm.Admin
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.Add_Flight = new System.Windows.Forms.Button();
            this.Show_Rz = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Flight
            // 
            this.Add_Flight.Location = new System.Drawing.Point(36, 77);
            this.Add_Flight.Name = "Add_Flight";
            this.Add_Flight.Size = new System.Drawing.Size(75, 26);
            this.Add_Flight.TabIndex = 0;
            this.Add_Flight.Text = "Uçuş Ekle";
            this.Add_Flight.UseVisualStyleBackColor = true;
            this.Add_Flight.Click += new System.EventHandler(this.Add_Flight_Click);
            // 
            // Show_Rz
            // 
            this.Show_Rz.Location = new System.Drawing.Point(36, 110);
            this.Show_Rz.Name = "Show_Rz";
            this.Show_Rz.Size = new System.Drawing.Size(167, 33);
            this.Show_Rz.TabIndex = 1;
            this.Show_Rz.Text = "Rezervasyonları Göster";
            this.Show_Rz.UseVisualStyleBackColor = true;
            this.Show_Rz.Click += new System.EventHandler(this.Show_Rz_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(36, 150);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(121, 37);
            this.update.TabIndex = 2;
            this.update.Text = "Bilgileri Güncelle";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Add_notification_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(328, 284);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 28);
            this.back.TabIndex = 3;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(390, 316);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Show_Rz);
            this.Controls.Add(this.Add_Flight);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Flight;
        private System.Windows.Forms.Button Show_Rz;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
    }
}