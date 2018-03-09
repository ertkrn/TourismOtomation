namespace Turizm
{
    partial class SatisListeleme
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.biletsts = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.listele = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // biletsts
            // 
            this.biletsts.BackColor = System.Drawing.Color.Green;
            this.biletsts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biletsts.Image = global::Turizm.Properties.Resources.bus_ticket1;
            this.biletsts.Location = new System.Drawing.Point(346, 109);
            this.biletsts.Name = "biletsts";
            this.biletsts.Size = new System.Drawing.Size(243, 184);
            this.biletsts.TabIndex = 10;
            this.toolTip1.SetToolTip(this.biletsts, "Bilet satın almaya devam etmek için tıklayınız.");
            this.biletsts.UseVisualStyleBackColor = false;
            this.biletsts.Click += new System.EventHandler(this.biletsts_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.DimGray;
            this.listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listele.Image = global::Turizm.Properties.Resources.check_mark;
            this.listele.Location = new System.Drawing.Point(346, 324);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(243, 184);
            this.listele.TabIndex = 11;
            this.toolTip2.SetToolTip(this.listele, "Biletleri listelemek için tıklayınız.");
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(845, -6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-3, -6);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 8;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // SatisListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.biletsts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatisListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisListeleme";
            this.Load += new System.EventHandler(this.SatisListeleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button biletsts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}