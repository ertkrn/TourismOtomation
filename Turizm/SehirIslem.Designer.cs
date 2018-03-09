namespace Turizm
{
    partial class SehirIslem
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
            this.iladi = new System.Windows.Forms.TextBox();
            this.ilplaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.sil = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.geri = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iladi
            // 
            this.iladi.Location = new System.Drawing.Point(256, 160);
            this.iladi.Multiline = true;
            this.iladi.Name = "iladi";
            this.iladi.Size = new System.Drawing.Size(190, 28);
            this.iladi.TabIndex = 27;
            this.iladi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iladi_KeyPress);
            // 
            // ilplaka
            // 
            this.ilplaka.Location = new System.Drawing.Point(256, 114);
            this.ilplaka.Multiline = true;
            this.ilplaka.Name = "ilplaka";
            this.ilplaka.Size = new System.Drawing.Size(190, 28);
            this.ilplaka.TabIndex = 26;
            this.ilplaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ilplaka_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "İlAdi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(168, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "İlPlaka :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 230);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Image = global::Turizm.Properties.Resources.rubbish_bin;
            this.sil.Location = new System.Drawing.Point(585, 178);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(72, 64);
            this.sil.TabIndex = 30;
            this.toolTip2.SetToolTip(this.sil, "Tablodan seçim yapmadan silme işlemini gerçekleştiremezsiniz.");
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::Turizm.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(585, 265);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 64);
            this.reset.TabIndex = 29;
            this.toolTip3.SetToolTip(this.reset, "Alanları temizlemek için tıklayınız.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Lime;
            this.kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydet.Image = global::Turizm.Properties.Resources.save;
            this.kaydet.Location = new System.Drawing.Point(585, 90);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(72, 64);
            this.kaydet.TabIndex = 28;
            this.toolTip1.SetToolTip(this.kaydet, "Kaydetmek için tıklayınız.");
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(1055, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turizm.Properties.Resources.turkiye_iller_2;
            this.pictureBox1.Location = new System.Drawing.Point(675, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-5, -2);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.toolTip4.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // SehirIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1113, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.iladi);
            this.Controls.Add(this.ilplaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SehirIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SehirIslem";
            this.Load += new System.EventHandler(this.SehirIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iladi;
        private System.Windows.Forms.TextBox ilplaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}