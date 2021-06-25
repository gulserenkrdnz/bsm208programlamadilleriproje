
namespace ReservationForm.Users
{
    partial class FlightList
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.destination = new System.Windows.Forms.Label();
            this.departurePoint = new System.Windows.Forms.Label();
            this.DestinationCity = new System.Windows.Forms.ComboBox();
            this.DepartureCity = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.Label();
            this.Ageny = new System.Windows.Forms.ComboBox();
            this.Agency = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Acenta";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kalkış Noktası";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varış Noktası";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Koltuk Numarası";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uçuş Listesi";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(788, 808);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(61, 28);
            this.back.TabIndex = 5;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(263, 799);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(117, 37);
            this.record.TabIndex = 12;
            this.record.Text = "Kaydet";
            this.record.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 25);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(674, 93);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(91, 17);
            this.destination.TabIndex = 19;
            this.destination.Text = "Varış Noktası :";
            // 
            // departurePoint
            // 
            this.departurePoint.AutoSize = true;
            this.departurePoint.Location = new System.Drawing.Point(673, 46);
            this.departurePoint.Name = "departurePoint";
            this.departurePoint.Size = new System.Drawing.Size(96, 17);
            this.departurePoint.TabIndex = 18;
            this.departurePoint.Text = "Kalkış Noktası :";
            // 
            // DestinationCity
            // 
            this.DestinationCity.FormattingEnabled = true;
            this.DestinationCity.Location = new System.Drawing.Point(764, 93);
            this.DestinationCity.Name = "DestinationCity";
            this.DestinationCity.Size = new System.Drawing.Size(198, 25);
            this.DestinationCity.TabIndex = 17;
            // 
            // DepartureCity
            // 
            this.DepartureCity.FormattingEnabled = true;
            this.DepartureCity.Location = new System.Drawing.Point(765, 43);
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.Size = new System.Drawing.Size(197, 25);
            this.DepartureCity.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 25);
            this.comboBox1.TabIndex = 20;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(417, 87);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 17);
            this.price.TabIndex = 22;
            this.price.Text = "Fiyat:";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // Ageny
            // 
            this.Ageny.FormattingEnabled = true;
            this.Ageny.Location = new System.Drawing.Point(463, 146);
            this.Ageny.Name = "Ageny";
            this.Ageny.Size = new System.Drawing.Size(153, 25);
            this.Ageny.TabIndex = 23;
            this.Ageny.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Agency
            // 
            this.Agency.AutoSize = true;
            this.Agency.Location = new System.Drawing.Point(414, 146);
            this.Agency.Name = "Agency";
            this.Agency.Size = new System.Drawing.Size(50, 17);
            this.Agency.TabIndex = 24;
            this.Agency.Text = "Acenta:";
            this.Agency.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // FlightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 850);
            this.Controls.Add(this.Agency);
            this.Controls.Add(this.Ageny);
            this.Controls.Add(this.price);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.departurePoint);
            this.Controls.Add(this.DestinationCity);
            this.Controls.Add(this.DepartureCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FlightList";
            this.Text = "FlightList";
            this.Load += new System.EventHandler(this.FlightList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label departurePoint;
        private System.Windows.Forms.ComboBox DestinationCity;
        private System.Windows.Forms.ComboBox DepartureCity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.ComboBox Ageny;
        private System.Windows.Forms.Label Agency;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}