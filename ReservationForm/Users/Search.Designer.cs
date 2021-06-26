
namespace ReservationForm.Users
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.Back_Login = new System.Windows.Forms.Button();
            this.SearchTicket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationCity = new System.Windows.Forms.ComboBox();
            this.DepartureCity = new System.Windows.Forms.ComboBox();
            this.Dates = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goReservations = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Login
            // 
            this.Back_Login.Location = new System.Drawing.Point(511, 486);
            this.Back_Login.Name = "Back_Login";
            this.Back_Login.Size = new System.Drawing.Size(66, 29);
            this.Back_Login.TabIndex = 12;
            this.Back_Login.Text = "Geri";
            this.Back_Login.UseVisualStyleBackColor = true;
            this.Back_Login.Click += new System.EventHandler(this.Back_Login_Click_1);
            // 
            // SearchTicket
            // 
            this.SearchTicket.Location = new System.Drawing.Point(172, 263);
            this.SearchTicket.Name = "SearchTicket";
            this.SearchTicket.Size = new System.Drawing.Size(84, 31);
            this.SearchTicket.TabIndex = 14;
            this.SearchTicket.Text = "Bilet Ara";
            this.SearchTicket.UseVisualStyleBackColor = true;
            this.SearchTicket.Click += new System.EventHandler(this.SearchTicket_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Varış Noktası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kalkış Noktası :";
            // 
            // DestinationCity
            // 
            this.DestinationCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCity.FormattingEnabled = true;
            this.DestinationCity.Location = new System.Drawing.Point(141, 156);
            this.DestinationCity.Name = "DestinationCity";
            this.DestinationCity.Size = new System.Drawing.Size(198, 25);
            this.DestinationCity.TabIndex = 9;
            this.DestinationCity.SelectedIndexChanged += new System.EventHandler(this.DestinationCity_SelectedIndexChanged);
            // 
            // DepartureCity
            // 
            this.DepartureCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartureCity.FormattingEnabled = true;
            this.DepartureCity.Location = new System.Drawing.Point(141, 110);
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.Size = new System.Drawing.Size(198, 25);
            this.DepartureCity.TabIndex = 8;
            this.DepartureCity.SelectedIndexChanged += new System.EventHandler(this.DepartureCity_SelectedIndexChanged);
            // 
            // Dates
            // 
            this.Dates.Location = new System.Drawing.Point(141, 204);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(198, 25);
            this.Dates.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SearchTicket);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DestinationCity);
            this.groupBox1.Controls.Add(this.DepartureCity);
            this.groupBox1.Controls.Add(this.Dates);
            this.groupBox1.Location = new System.Drawing.Point(102, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 376);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçuş Bilgileri";
            // 
            // goReservations
            // 
            this.goReservations.Location = new System.Drawing.Point(372, 486);
            this.goReservations.Name = "goReservations";
            this.goReservations.Size = new System.Drawing.Size(119, 28);
            this.goReservations.TabIndex = 16;
            this.goReservations.Text = "Rezervasyonlarım";
            this.goReservations.UseVisualStyleBackColor = true;
            this.goReservations.Click += new System.EventHandler(this.goReservations_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 542);
            this.Controls.Add(this.goReservations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Back_Login);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back_Login;
        private System.Windows.Forms.Button SearchTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goReservations;
        public System.Windows.Forms.ComboBox DestinationCity;
        public System.Windows.Forms.ComboBox DepartureCity;
        public System.Windows.Forms.DateTimePicker Dates;
    }
}