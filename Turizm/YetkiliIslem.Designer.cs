namespace Turizm
{
    partial class YetkiliIslem
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifre = new System.Windows.Forms.TextBox();
            this.yetkilino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sil = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 230);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(272, 133);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(129, 28);
            this.sifre.TabIndex = 28;
            this.sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifre_KeyPress);
            // 
            // yetkilino
            // 
            this.yetkilino.Location = new System.Drawing.Point(272, 87);
            this.yetkilino.Multiline = true;
            this.yetkilino.Name = "yetkilino";
            this.yetkilino.Size = new System.Drawing.Size(129, 28);
            this.yetkilino.TabIndex = 27;
            this.yetkilino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yetkilino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(202, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(162, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "YetkiliNo :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(832, -6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turizm.Properties.Resources.icon_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(607, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Image = global::Turizm.Properties.Resources.rubbish_bin;
            this.sil.Location = new System.Drawing.Point(519, 133);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(72, 64);
            this.sil.TabIndex = 35;
            this.toolTip2.SetToolTip(this.sil, "Tablodan seçim yapmadan silme işlemini gerçekleştiremezsiniz.");
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::Turizm.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(519, 220);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 64);
            this.reset.TabIndex = 34;
            this.toolTip3.SetToolTip(this.reset, "Alanları temizlemek için tıklayınız.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Lime;
            this.kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydet.Image = global::Turizm.Properties.Resources.save;
            this.kaydet.Location = new System.Drawing.Point(519, 45);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(72, 64);
            this.kaydet.TabIndex = 33;
            this.toolTip1.SetToolTip(this.kaydet, "Kaydetmek için tıklayınız.");
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-2, -6);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 21;
            this.toolTip4.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // YetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(886, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.yetkilino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YetkiliIslem";
            this.Load += new System.EventHandler(this.YetkiliIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox yetkilino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}