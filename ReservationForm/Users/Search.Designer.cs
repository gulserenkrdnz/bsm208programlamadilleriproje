
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            // 
            // SearchTicket
            // 
            this.SearchTicket.Location = new System.Drawing.Point(258, 364);
            this.SearchTicket.Name = "SearchTicket";
            this.SearchTicket.Size = new System.Drawing.Size(84, 31);
            this.SearchTicket.TabIndex = 14;
            this.SearchTicket.Text = "Bilet Ara";
            this.SearchTicket.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Varış Noktası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kalkış Noktası :";
            // 
            // DestinationCity
            // 
            this.DestinationCity.FormattingEnabled = true;
            this.DestinationCity.Location = new System.Drawing.Point(229, 247);
            this.DestinationCity.Name = "DestinationCity";
            this.DestinationCity.Size = new System.Drawing.Size(198, 25);
            this.DestinationCity.TabIndex = 9;
            // 
            // DepartureCity
            // 
            this.DepartureCity.FormattingEnabled = true;
            this.DepartureCity.Location = new System.Drawing.Point(230, 201);
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.Size = new System.Drawing.Size(197, 25);
            this.DepartureCity.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 25);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Uçuş Ara";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Back_Login);
            this.Controls.Add(this.SearchTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationCity);
            this.Controls.Add(this.DepartureCity);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_Login;
        private System.Windows.Forms.Button SearchTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DestinationCity;
        private System.Windows.Forms.ComboBox DepartureCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}