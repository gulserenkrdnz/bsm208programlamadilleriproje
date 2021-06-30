
namespace ReservationForm.Users
{
    partial class Show_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Reservation));
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.TheList = new System.Windows.Forms.ListView();
            this.list_ID = new System.Windows.Forms.ColumnHeader();
            this.list_Firm = new System.Windows.Forms.ColumnHeader();
            this.list_SeatNo = new System.Windows.Forms.ColumnHeader();
            this.list_Dep = new System.Windows.Forms.ColumnHeader();
            this.list_Des = new System.Windows.Forms.ColumnHeader();
            this.list_Date = new System.Windows.Forms.ColumnHeader();
            this.list_DepT = new System.Windows.Forms.ColumnHeader();
            this.list_Name = new System.Windows.Forms.ColumnHeader();
            this.list_Lastname = new System.Windows.Forms.ColumnHeader();
            this.list_Price = new System.Windows.Forms.ColumnHeader();
            this.deleteReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(520, 341);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 24);
            this.back.TabIndex = 0;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervasyon Bilgileri:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(593, 341);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 24);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Çıkış";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TheList
            // 
            this.TheList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_ID,
            this.list_Firm,
            this.list_SeatNo,
            this.list_Dep,
            this.list_Des,
            this.list_Date,
            this.list_DepT,
            this.list_Name,
            this.list_Lastname,
            this.list_Price});
            this.TheList.HideSelection = false;
            this.TheList.Location = new System.Drawing.Point(46, 53);
            this.TheList.Name = "TheList";
            this.TheList.Size = new System.Drawing.Size(580, 231);
            this.TheList.TabIndex = 18;
            this.TheList.UseCompatibleStateImageBehavior = false;
            this.TheList.View = System.Windows.Forms.View.Details;
            // 
            // list_ID
            // 
            this.list_ID.Text = "ID";
            this.list_ID.Width = 25;
            // 
            // list_Firm
            // 
            this.list_Firm.Text = "Firma";
            this.list_Firm.Width = 65;
            // 
            // list_SeatNo
            // 
            this.list_SeatNo.Text = "Koltuk No";
            // 
            // list_Dep
            // 
            this.list_Dep.Text = "Nereden";
            this.list_Dep.Width = 65;
            // 
            // list_Des
            // 
            this.list_Des.Text = "Nereye";
            // 
            // list_Date
            // 
            this.list_Date.Text = "Tarih";
            // 
            // list_DepT
            // 
            this.list_DepT.Text = "Kalkış Saati";
            // 
            // list_Name
            // 
            this.list_Name.Text = "İsim";
            // 
            // list_Lastname
            // 
            this.list_Lastname.Text = "Soyisim";
            // 
            // list_Price
            // 
            this.list_Price.Text = "Fiyat";
            // 
            // deleteReservation
            // 
            this.deleteReservation.Location = new System.Drawing.Point(447, 341);
            this.deleteReservation.Name = "deleteReservation";
            this.deleteReservation.Size = new System.Drawing.Size(65, 24);
            this.deleteReservation.TabIndex = 19;
            this.deleteReservation.Text = "İptal Et";
            this.deleteReservation.UseVisualStyleBackColor = true;
            // 
            // Show_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.deleteReservation);
            this.Controls.Add(this.TheList);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Show_Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Reservation";
            this.Load += new System.EventHandler(this.Show_Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListView TheList;
        private System.Windows.Forms.ColumnHeader list_ID;
        private System.Windows.Forms.ColumnHeader list_Firm;
        private System.Windows.Forms.ColumnHeader list_SeatNo;
        private System.Windows.Forms.ColumnHeader list_Dep;
        private System.Windows.Forms.ColumnHeader list_Des;
        private System.Windows.Forms.ColumnHeader list_Date;
        private System.Windows.Forms.ColumnHeader list_DepT;
        private System.Windows.Forms.ColumnHeader list_Name;
        private System.Windows.Forms.ColumnHeader list_Lastname;
        private System.Windows.Forms.ColumnHeader list_Price;
        private System.Windows.Forms.Button deleteReservation;
    }
}