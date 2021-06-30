
namespace ReservationForm.Admin
{
    partial class Reservations
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
            this.button1 = new System.Windows.Forms.Button();
            this.deleteReservation = new System.Windows.Forms.Button();
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
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteReservation
            // 
            this.deleteReservation.Location = new System.Drawing.Point(468, 379);
            this.deleteReservation.Name = "deleteReservation";
            this.deleteReservation.Size = new System.Drawing.Size(65, 24);
            this.deleteReservation.TabIndex = 24;
            this.deleteReservation.Text = "İptal Et";
            this.deleteReservation.UseVisualStyleBackColor = true;
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
            this.TheList.Location = new System.Drawing.Point(78, 77);
            this.TheList.Name = "TheList";
            this.TheList.Size = new System.Drawing.Size(580, 231);
            this.TheList.TabIndex = 23;
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
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(614, 379);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 24);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Çıkış";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rezervasyon Bilgileri:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.deleteReservation);
            this.Controls.Add(this.TheList);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteReservation;
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
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}