namespace Turizm
{
    partial class Listeleme
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
            this.button2 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BiletNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SKNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GNoBaslangic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GNoBitis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FaturaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SigortaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(843, -5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-5, -5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 10;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BiletNo,
            this.Tc_No,
            this.SKNo,
            this.GNoBaslangic,
            this.GNoBitis,
            this.FaturaId,
            this.SigortaId,
            this.Ucret});
            this.listView1.Location = new System.Drawing.Point(196, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 308);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BiletNo
            // 
            this.BiletNo.Text = "BiletNo";
            // 
            // Tc_No
            // 
            this.Tc_No.Text = "Tc_No";
            // 
            // SKNo
            // 
            this.SKNo.Text = "SKNo";
            // 
            // GNoBaslangic
            // 
            this.GNoBaslangic.Text = "GNoBaslangic";
            // 
            // GNoBitis
            // 
            this.GNoBitis.Text = "GNoBitis";
            // 
            // FaturaId
            // 
            this.FaturaId.Text = "FaturaId";
            // 
            // SigortaId
            // 
            this.SigortaId.Text = "SigortaId";
            // 
            // Ucret
            // 
            this.Ucret.Text = "Ucret";
            // 
            // Listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeleme";
            this.Load += new System.EventHandler(this.Listeleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button geri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BiletNo;
        private System.Windows.Forms.ColumnHeader Tc_No;
        private System.Windows.Forms.ColumnHeader SKNo;
        private System.Windows.Forms.ColumnHeader GNoBaslangic;
        private System.Windows.Forms.ColumnHeader GNoBitis;
        private System.Windows.Forms.ColumnHeader FaturaId;
        private System.Windows.Forms.ColumnHeader SigortaId;
        private System.Windows.Forms.ColumnHeader Ucret;
    }
}