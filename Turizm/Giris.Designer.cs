namespace Turizm
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.yetkiligiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.biletsatis = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.rezervasyon = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.iletişim = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yetkiligiris
            // 
            this.yetkiligiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yetkiligiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.yetkiligiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yetkiligiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.yetkiligiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.yetkiligiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.yetkiligiris.Image = global::Turizm.Properties.Resources.user;
            this.yetkiligiris.Location = new System.Drawing.Point(486, 128);
            this.yetkiligiris.Name = "yetkiligiris";
            this.yetkiligiris.Size = new System.Drawing.Size(232, 110);
            this.yetkiligiris.TabIndex = 0;
            this.toolTip1.SetToolTip(this.yetkiligiris, "Yetkili girişi için tıklayınız.");
            this.yetkiligiris.UseVisualStyleBackColor = false;
            this.yetkiligiris.Click += new System.EventHandler(this.yetkiligiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(216, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sağlam Turizm Otomasyonu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // biletsatis
            // 
            this.biletsatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.biletsatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.biletsatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biletsatis.Image = global::Turizm.Properties.Resources.bus_ticket;
            this.biletsatis.Location = new System.Drawing.Point(486, 289);
            this.biletsatis.Name = "biletsatis";
            this.biletsatis.Size = new System.Drawing.Size(232, 110);
            this.biletsatis.TabIndex = 2;
            this.toolTip2.SetToolTip(this.biletsatis, "Bilet satış için tıklayınız.");
            this.biletsatis.UseVisualStyleBackColor = false;
            this.biletsatis.Click += new System.EventHandler(this.biletsatis_Click);
            // 
            // rezervasyon
            // 
            this.rezervasyon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rezervasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rezervasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rezervasyon.Image = global::Turizm.Properties.Resources.booking;
            this.rezervasyon.Location = new System.Drawing.Point(486, 461);
            this.rezervasyon.Name = "rezervasyon";
            this.rezervasyon.Size = new System.Drawing.Size(232, 110);
            this.rezervasyon.TabIndex = 3;
            this.toolTip3.SetToolTip(this.rezervasyon, "Rezervasyon yapmak için tıklayınız.");
            this.rezervasyon.UseVisualStyleBackColor = false;
            this.rezervasyon.Click += new System.EventHandler(this.rezervasyon_Click);
            // 
            // iletişim
            // 
            this.iletişim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iletişim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iletişim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iletişim.Image = global::Turizm.Properties.Resources.icon;
            this.iletişim.Location = new System.Drawing.Point(908, 274);
            this.iletişim.Name = "iletişim";
            this.iletişim.Size = new System.Drawing.Size(77, 68);
            this.iletişim.TabIndex = 4;
            this.toolTip4.SetToolTip(this.iletişim, "Yardım almak için tıklayın.");
            this.iletişim.UseVisualStyleBackColor = false;
            this.iletişim.Click += new System.EventHandler(this.iletişim_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(1208, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1261, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iletişim);
            this.Controls.Add(this.rezervasyon);
            this.Controls.Add(this.biletsatis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetkiligiris);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turizm Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yetkiligiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button iletişim;
        private System.Windows.Forms.ToolTip toolTip4;
        public System.Windows.Forms.Button biletsatis;
        public System.Windows.Forms.Button rezervasyon;
        private System.Windows.Forms.Button button2;
    }
}

