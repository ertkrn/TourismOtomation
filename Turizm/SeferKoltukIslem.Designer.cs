namespace Turizm
{
    partial class SeferKoltukIslem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.koltukno = new System.Windows.Forms.TextBox();
            this.skno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfrno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kaydet = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.sil = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.geri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 230);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "SKNo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "KoltukNo :";
            // 
            // koltukno
            // 
            this.koltukno.Location = new System.Drawing.Point(275, 145);
            this.koltukno.Multiline = true;
            this.koltukno.Name = "koltukno";
            this.koltukno.Size = new System.Drawing.Size(129, 28);
            this.koltukno.TabIndex = 23;
            this.koltukno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.koltukno_KeyPress);
            // 
            // skno
            // 
            this.skno.Location = new System.Drawing.Point(275, 99);
            this.skno.Multiline = true;
            this.skno.Name = "skno";
            this.skno.Size = new System.Drawing.Size(129, 28);
            this.skno.TabIndex = 22;
            this.skno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "SeferNo :";
            // 
            // sfrno
            // 
            this.sfrno.Location = new System.Drawing.Point(275, 190);
            this.sfrno.Multiline = true;
            this.sfrno.Name = "sfrno";
            this.sfrno.Size = new System.Drawing.Size(129, 28);
            this.sfrno.TabIndex = 25;
            this.sfrno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sfrno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Lime;
            this.kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydet.Image = global::Turizm.Properties.Resources.save;
            this.kaydet.Location = new System.Drawing.Point(461, 56);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(72, 64);
            this.kaydet.TabIndex = 14;
            this.toolTip1.SetToolTip(this.kaydet, "Kaydetmek için tıklayınız.");
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Image = global::Turizm.Properties.Resources.rubbish_bin;
            this.sil.Location = new System.Drawing.Point(461, 142);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(72, 64);
            this.sil.TabIndex = 16;
            this.toolTip2.SetToolTip(this.sil, "Tablodan seçim yapmadan silme işlemini gerçekleştiremezsiniz.");
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::Turizm.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(461, 231);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 64);
            this.reset.TabIndex = 17;
            this.toolTip3.SetToolTip(this.reset, "Alanları temizlemek için tıklayınız.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-3, -3);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.toolTip4.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(894, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turizm.Properties.Resources.depositphotos_55335789_stock_photo_seats_of_tourism_bus;
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SeferKoltukIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sfrno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.koltukno);
            this.Controls.Add(this.skno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SeferKoltukIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeferKoltukIslem";
            this.Load += new System.EventHandler(this.SeferKoltukIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox koltukno;
        private System.Windows.Forms.TextBox skno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sfrno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button button2;
    }
}