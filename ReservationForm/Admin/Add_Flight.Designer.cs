
namespace ReservationForm.Admin
{
    partial class Add_Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Flight));
            this.addflight = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addflight
            // 
            this.addflight.Location = new System.Drawing.Point(157, 128);
            this.addflight.Name = "addflight";
            this.addflight.Size = new System.Drawing.Size(105, 31);
            this.addflight.TabIndex = 0;
            this.addflight.Text = "Uçuş Ekle";
            this.addflight.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(214, 185);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(48, 27);
            this.back.TabIndex = 1;
            this.back.Text = "Geri";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Add_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(274, 226);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addflight);
            this.Name = "Add_Flight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Flight";
            this.Load += new System.EventHandler(this.Add_Flight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addflight;
        private System.Windows.Forms.Button back;
    }
}