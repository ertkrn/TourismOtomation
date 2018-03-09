namespace Turizm
{
    partial class BiletSatisGiris
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
            this.yolcugirisi = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.devam = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.geri = new System.Windows.Forms.Button();
            this.rzrvsyngncll = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yolcugirisi
            // 
            this.yolcugirisi.BackColor = System.Drawing.Color.DarkOrange;
            this.yolcugirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yolcugirisi.Image = global::Turizm.Properties.Resources.restaurant_membership_card_tool;
            this.yolcugirisi.Location = new System.Drawing.Point(332, 54);
            this.yolcugirisi.Name = "yolcugirisi";
            this.yolcugirisi.Size = new System.Drawing.Size(209, 162);
            this.yolcugirisi.TabIndex = 0;
            this.toolTip1.SetToolTip(this.yolcugirisi, "Kayıtlı üye girişi yapmak için tıklayınız.");
            this.yolcugirisi.UseVisualStyleBackColor = false;
            this.yolcugirisi.Click += new System.EventHandler(this.yolcugirisi_Click);
            // 
            // devam
            // 
            this.devam.BackColor = System.Drawing.SystemColors.Info;
            this.devam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devam.Image = global::Turizm.Properties.Resources.membership;
            this.devam.Location = new System.Drawing.Point(332, 269);
            this.devam.Name = "devam";
            this.devam.Size = new System.Drawing.Size(209, 162);
            this.devam.TabIndex = 1;
            this.toolTip2.SetToolTip(this.devam, "Yeni yolcu kaydı eklemek için tıklayınız.");
            this.devam.UseVisualStyleBackColor = false;
            this.devam.Click += new System.EventHandler(this.devam_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-2, -2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.toolTip3.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // rzrvsyngncll
            // 
            this.rzrvsyngncll.BackColor = System.Drawing.Color.GreenYellow;
            this.rzrvsyngncll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rzrvsyngncll.Enabled = false;
            this.rzrvsyngncll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rzrvsyngncll.Image = global::Turizm.Properties.Resources.rzrvsyngncll;
            this.rzrvsyngncll.Location = new System.Drawing.Point(628, 269);
            this.rzrvsyngncll.Name = "rzrvsyngncll";
            this.rzrvsyngncll.Size = new System.Drawing.Size(209, 162);
            this.rzrvsyngncll.TabIndex = 3;
            this.rzrvsyngncll.UseVisualStyleBackColor = false;
            this.rzrvsyngncll.Visible = false;
            this.rzrvsyngncll.Click += new System.EventHandler(this.rzrvsyngncll_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(837, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BiletSatisGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(890, 506);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rzrvsyngncll);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.devam);
            this.Controls.Add(this.yolcugirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "BiletSatisGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletSatisGiris";
            this.Load += new System.EventHandler(this.BiletSatisGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yolcugirisi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button devam;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button rzrvsyngncll;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button button2;
    }
}