
namespace ReservationForm.Users
{
    partial class UserPage
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
            this.ticket_search = new System.Windows.Forms.Button();
            this.Reservation_Show = new System.Windows.Forms.Button();
            this.informtion_updte = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticket_search
            // 
            this.ticket_search.Location = new System.Drawing.Point(115, 125);
            this.ticket_search.Name = "ticket_search";
            this.ticket_search.Size = new System.Drawing.Size(101, 39);
            this.ticket_search.TabIndex = 0;
            this.ticket_search.Text = "Bilet Ara";
            this.ticket_search.UseVisualStyleBackColor = true;
            this.ticket_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservation_Show
            // 
            this.Reservation_Show.Location = new System.Drawing.Point(102, 62);
            this.Reservation_Show.Name = "Reservation_Show";
            this.Reservation_Show.Size = new System.Drawing.Size(126, 57);
            this.Reservation_Show.TabIndex = 1;
            this.Reservation_Show.Text = "Rezervasyonları Görüntüle";
            this.Reservation_Show.UseVisualStyleBackColor = true;
            this.Reservation_Show.Click += new System.EventHandler(this.Reservation_Show_Click);
            // 
            // informtion_updte
            // 
            this.informtion_updte.Location = new System.Drawing.Point(104, 179);
            this.informtion_updte.Name = "informtion_updte";
            this.informtion_updte.Size = new System.Drawing.Size(123, 39);
            this.informtion_updte.TabIndex = 2;
            this.informtion_updte.Text = "Bilgileri Güncelle";
            this.informtion_updte.UseVisualStyleBackColor = true;
            this.informtion_updte.Click += new System.EventHandler(this.informtion_updte_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(268, 267);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(56, 26);
            this.back.TabIndex = 3;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 300);
            this.Controls.Add(this.back);
            this.Controls.Add(this.informtion_updte);
            this.Controls.Add(this.Reservation_Show);
            this.Controls.Add(this.ticket_search);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ticket_search;
        private System.Windows.Forms.Button Reservation_Show;
        private System.Windows.Forms.Button informtion_updte;
        private System.Windows.Forms.Button back;
    }
}