namespace Turizm
{
    partial class RezervasyonIslem
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
            this.rzrvid = new System.Windows.Forms.TextBox();
            this.skno = new System.Windows.Forms.TextBox();
            this.tcno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sontrh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guncelle = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sil = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rzrvid
            // 
            this.rzrvid.Location = new System.Drawing.Point(257, 70);
            this.rzrvid.Multiline = true;
            this.rzrvid.Name = "rzrvid";
            this.rzrvid.Size = new System.Drawing.Size(129, 28);
            this.rzrvid.TabIndex = 23;
            // 
            // skno
            // 
            this.skno.Location = new System.Drawing.Point(257, 113);
            this.skno.Multiline = true;
            this.skno.Name = "skno";
            this.skno.Size = new System.Drawing.Size(129, 28);
            this.skno.TabIndex = 24;
            // 
            // tcno
            // 
            this.tcno.Location = new System.Drawing.Point(257, 161);
            this.tcno.Multiline = true;
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(129, 28);
            this.tcno.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tc No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "SKNo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "RezervasyonId :";
            // 
            // sontrh
            // 
            this.sontrh.Location = new System.Drawing.Point(258, 208);
            this.sontrh.Multiline = true;
            this.sontrh.Name = "sontrh";
            this.sontrh.Size = new System.Drawing.Size(129, 28);
            this.sontrh.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(139, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Son Tarih :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 230);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Aqua;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.Image = global::Turizm.Properties.Resources.settings;
            this.guncelle.Location = new System.Drawing.Point(481, 34);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(72, 64);
            this.guncelle.TabIndex = 33;
            this.toolTip1.SetToolTip(this.guncelle, "Güncellemek için tıklayınız.");
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::Turizm.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(481, 195);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 64);
            this.reset.TabIndex = 35;
            this.toolTip3.SetToolTip(this.reset, "Alanları temizlemek için tıklayınız.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.Image = global::Turizm.Properties.Resources.rezervasyon1;
            this.pictureBox1.Location = new System.Drawing.Point(589, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Image = global::Turizm.Properties.Resources.rubbish_bin;
            this.sil.Location = new System.Drawing.Point(481, 113);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(72, 64);
            this.sil.TabIndex = 34;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-2, -5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(883, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 37;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RezervasyonIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(962, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sontrh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skno);
            this.Controls.Add(this.rzrvid);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervasyonIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonIslem";
            this.Load += new System.EventHandler(this.RezervasyonIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.TextBox rzrvid;
        private System.Windows.Forms.TextBox skno;
        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sontrh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button2;
    }
}