namespace Turizm
{
    partial class KoltukAra78
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
            this.label2 = new System.Windows.Forms.Label();
            this.koltukno = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ara = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "KoltukNo :";
            // 
            // koltukno
            // 
            this.koltukno.FormattingEnabled = true;
            this.koltukno.ItemHeight = 16;
            this.koltukno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54"});
            this.koltukno.Location = new System.Drawing.Point(317, 210);
            this.koltukno.Name = "koltukno";
            this.koltukno.Size = new System.Drawing.Size(120, 36);
            this.koltukno.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(170, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(1131, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Image = global::Turizm.Properties.Resources._80plan2;
            this.pictureBox1.Location = new System.Drawing.Point(593, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 667);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.LightCyan;
            this.ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ara.Image = global::Turizm.Properties.Resources.magnifier;
            this.ara.Location = new System.Drawing.Point(299, 274);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(161, 106);
            this.ara.TabIndex = 9;
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-1, -5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 6;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // KoltukAra78
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1189, 751);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.koltukno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "KoltukAra78";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoltukAra78";
            this.Load += new System.EventHandler(this.KoltukAra78_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox koltukno;
        private System.Windows.Forms.Button ara;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}