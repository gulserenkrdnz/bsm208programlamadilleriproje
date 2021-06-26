
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
            this.TheList = new System.Windows.Forms.ListView();
            this.list_firmName = new System.Windows.Forms.ColumnHeader();
            this.list_departureCity = new System.Windows.Forms.ColumnHeader();
            this.list_destinationCity = new System.Windows.Forms.ColumnHeader();
            this.list_date = new System.Windows.Forms.ColumnHeader();
            this.list_departureTime = new System.Windows.Forms.ColumnHeader();
            this.list_arrivalTime = new System.Windows.Forms.ColumnHeader();
            this.list_ecoPrice = new System.Windows.Forms.ColumnHeader();
            this.list_businessPrice = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.col1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheList
            // 
            this.TheList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_firmName,
            this.list_departureCity,
            this.list_destinationCity,
            this.list_date,
            this.list_departureTime,
            this.list_arrivalTime,
            this.list_ecoPrice,
            this.list_businessPrice});
            this.TheList.GridLines = true;
            this.TheList.HideSelection = false;
            this.TheList.Location = new System.Drawing.Point(29, 61);
            this.TheList.Name = "TheList";
            this.TheList.Size = new System.Drawing.Size(804, 176);
            this.TheList.TabIndex = 0;
            this.TheList.UseCompatibleStateImageBehavior = false;
            this.TheList.View = System.Windows.Forms.View.Details;
            // 
            // list_firmName
            // 
            this.list_firmName.Text = "Firma";
            this.list_firmName.Width = 100;
            // 
            // list_departureCity
            // 
            this.list_departureCity.Text = "Kalkış Noktası";
            this.list_departureCity.Width = 100;
            // 
            // list_destinationCity
            // 
            this.list_destinationCity.Text = "Varış Noktası";
            this.list_destinationCity.Width = 100;
            // 
            // list_date
            // 
            this.list_date.Text = "Tarih";
            this.list_date.Width = 100;
            // 
            // list_departureTime
            // 
            this.list_departureTime.Text = "Kalkış Saati";
            this.list_departureTime.Width = 100;
            // 
            // list_arrivalTime
            // 
            this.list_arrivalTime.Text = "Varış Saati";
            this.list_arrivalTime.Width = 100;
            // 
            // list_ecoPrice
            // 
            this.list_ecoPrice.Text = "Ekonomik Fiyat";
            this.list_ecoPrice.Width = 100;
            // 
            // list_businessPrice
            // 
            this.list_businessPrice.Text = "Business Fiyat";
            this.list_businessPrice.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uçuş Listesi";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(452, 567);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 37);
            this.back.TabIndex = 5;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(341, 567);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(90, 37);
            this.record.TabIndex = 12;
            this.record.Text = "Rezerve Et";
            this.record.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(69, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // col1
            // 
            this.col1.AutoSize = true;
            this.col1.Location = new System.Drawing.Point(839, 108);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(15, 14);
            this.col1.TabIndex = 13;
            this.col1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(839, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(839, 182);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(87, 21);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(839, 155);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 21);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // FlightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(942, 616);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TheList);
            this.Name = "FlightList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightList";
            this.Load += new System.EventHandler(this.FlightList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TheList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ColumnHeader kalkis;
        private System.Windows.Forms.ColumnHeader varis;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader kalkisSaat;
        private System.Windows.Forms.ColumnHeader varisSaat;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader list_departureCity;
        private System.Windows.Forms.ColumnHeader list_destinationCity;
        private System.Windows.Forms.ColumnHeader list_date;
        private System.Windows.Forms.ColumnHeader list_departureTime;
        private System.Windows.Forms.ColumnHeader list_arrivalTime;
        private System.Windows.Forms.ColumnHeader list_ecoPrice;
        private System.Windows.Forms.ColumnHeader list_businessPrice;
        private System.Windows.Forms.ColumnHeader list_firmName;
        private System.Windows.Forms.CheckBox col1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}