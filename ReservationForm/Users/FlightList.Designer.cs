
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
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.col1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.list_firmName = new System.Windows.Forms.ColumnHeader();
            this.list_departureCity = new System.Windows.Forms.ColumnHeader();
            this.list_destinationCity = new System.Windows.Forms.ColumnHeader();
            this.list_date = new System.Windows.Forms.ColumnHeader();
            this.list_departureTime = new System.Windows.Forms.ColumnHeader();
            this.list_arrivalTime = new System.Windows.Forms.ColumnHeader();
            this.list_ecoPrice = new System.Windows.Forms.ColumnHeader();
            this.list_businessPrice = new System.Windows.Forms.ColumnHeader();
            this.TheList = new System.Windows.Forms.ListView();
            this.list_id = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button58 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
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
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // col1
            // 
            this.col1.AutoSize = true;
            this.col1.Location = new System.Drawing.Point(859, 91);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(15, 14);
            this.col1.TabIndex = 13;
            this.col1.UseVisualStyleBackColor = true;
            this.col1.CheckedChanged += new System.EventHandler(this.col1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(859, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(859, 154);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(859, 133);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(859, 194);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(859, 173);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
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
            // TheList
            // 
            this.TheList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_id,
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
            this.TheList.Location = new System.Drawing.Point(12, 62);
            this.TheList.Name = "TheList";
            this.TheList.Size = new System.Drawing.Size(841, 176);
            this.TheList.TabIndex = 0;
            this.TheList.UseCompatibleStateImageBehavior = false;
            this.TheList.View = System.Windows.Forms.View.Details;
            // 
            // list_id
            // 
            this.list_id.Text = "ID";
            this.list_id.Width = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "1 Gün Öncesi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "1 Gün Sonrası";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(312, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 273);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B Acentası";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(29, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 273);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Acentası";
            // 
            // button58
            // 
            this.button58.Location = new System.Drawing.Point(104, 219);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(36, 25);
            this.button58.TabIndex = 29;
            this.button58.Text = "button58";
            this.button58.UseVisualStyleBackColor = true;
            // 
            // button59
            // 
            this.button59.Location = new System.Drawing.Point(104, 171);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(36, 25);
            this.button59.TabIndex = 28;
            this.button59.Text = "button59";
            this.button59.UseVisualStyleBackColor = true;
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(104, 124);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(36, 25);
            this.button60.TabIndex = 27;
            this.button60.Text = "button60";
            this.button60.UseVisualStyleBackColor = true;
            // 
            // button61
            // 
            this.button61.Location = new System.Drawing.Point(104, 77);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(36, 25);
            this.button61.TabIndex = 26;
            this.button61.Text = "button61";
            this.button61.UseVisualStyleBackColor = true;
            // 
            // button62
            // 
            this.button62.Location = new System.Drawing.Point(104, 28);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(36, 25);
            this.button62.TabIndex = 25;
            this.button62.Text = "button62";
            this.button62.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(609, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 273);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "C Acentası";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(859, 214);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 42;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // FlightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(891, 616);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TheList);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlightList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightList";
            this.Load += new System.EventHandler(this.FlightList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.CheckBox col1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ColumnHeader list_firmName;
        private System.Windows.Forms.ColumnHeader list_departureCity;
        private System.Windows.Forms.ColumnHeader list_destinationCity;
        private System.Windows.Forms.ColumnHeader list_date;
        private System.Windows.Forms.ColumnHeader list_departureTime;
        private System.Windows.Forms.ColumnHeader list_arrivalTime;
        private System.Windows.Forms.ColumnHeader list_ecoPrice;
        private System.Windows.Forms.ColumnHeader list_businessPrice;
        private System.Windows.Forms.ListView TheList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button58;
        private System.Windows.Forms.Button button59;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button61;
        private System.Windows.Forms.Button button62;
        private System.Windows.Forms.ColumnHeader list_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}