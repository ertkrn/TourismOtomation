namespace Turizm
{
    partial class SeferIslem
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
            this.listele = new System.Windows.Forms.DataGridView();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turizmDataSet = new Turizm.TurizmDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kaydet = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.seferTableAdapter = new Turizm.TurizmDataSetTableAdapters.SeferTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sfrno = new System.Windows.Forms.TextBox();
            this.otoid = new System.Windows.Forms.TextBox();
            this.bslngc = new System.Windows.Forms.TextBox();
            this.bts = new System.Windows.Forms.TextBox();
            this.sfrtrh1 = new System.Windows.Forms.Label();
            this.sfrtrh = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sil = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turizmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // listele
            // 
            this.listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listele.Location = new System.Drawing.Point(37, 382);
            this.listele.Name = "listele";
            this.listele.RowTemplate.Height = 24;
            this.listele.Size = new System.Drawing.Size(811, 301);
            this.listele.TabIndex = 27;
            this.listele.DoubleClick += new System.EventHandler(this.listele_DoubleClick);
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "Sefer";
            this.seferBindingSource.DataSource = this.turizmDataSet;
            // 
            // turizmDataSet
            // 
            this.turizmDataSet.DataSetName = "TurizmDataSet";
            this.turizmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Lime;
            this.kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydet.Image = global::Turizm.Properties.Resources.save;
            this.kaydet.Location = new System.Drawing.Point(709, 98);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(72, 64);
            this.kaydet.TabIndex = 22;
            this.toolTip1.SetToolTip(this.kaydet, "Kaydetmek için tıklayınız.");
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Image = global::Turizm.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(709, 273);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 64);
            this.reset.TabIndex = 23;
            this.toolTip2.SetToolTip(this.reset, "Alanları temizlemek için tıklayınız.");
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(192, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "SeferNo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(181, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "OtobusId :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Baslangic :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(226, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bitis :";
            // 
            // sfrno
            // 
            this.sfrno.Location = new System.Drawing.Point(295, 62);
            this.sfrno.Multiline = true;
            this.sfrno.Name = "sfrno";
            this.sfrno.Size = new System.Drawing.Size(129, 28);
            this.sfrno.TabIndex = 17;
            this.sfrno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sfrno_KeyPress);
            // 
            // otoid
            // 
            this.otoid.Location = new System.Drawing.Point(295, 113);
            this.otoid.Multiline = true;
            this.otoid.Name = "otoid";
            this.otoid.Size = new System.Drawing.Size(129, 28);
            this.otoid.TabIndex = 18;
            this.otoid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otoid_KeyPress);
            // 
            // bslngc
            // 
            this.bslngc.Location = new System.Drawing.Point(294, 207);
            this.bslngc.Multiline = true;
            this.bslngc.Name = "bslngc";
            this.bslngc.Size = new System.Drawing.Size(129, 28);
            this.bslngc.TabIndex = 20;
            this.bslngc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bslngc_KeyPress);
            // 
            // bts
            // 
            this.bts.Location = new System.Drawing.Point(294, 247);
            this.bts.Multiline = true;
            this.bts.Name = "bts";
            this.bts.Size = new System.Drawing.Size(129, 28);
            this.bts.TabIndex = 21;
            this.bts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bts_KeyPress);
            // 
            // sfrtrh1
            // 
            this.sfrtrh1.AutoSize = true;
            this.sfrtrh1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfrtrh1.Location = new System.Drawing.Point(170, 161);
            this.sfrtrh1.Name = "sfrtrh1";
            this.sfrtrh1.Size = new System.Drawing.Size(118, 28);
            this.sfrtrh1.TabIndex = 29;
            this.sfrtrh1.Text = "SeferTarihi :";
            // 
            // sfrtrh
            // 
            this.sfrtrh.Location = new System.Drawing.Point(294, 161);
            this.sfrtrh.Multiline = true;
            this.sfrtrh.Name = "sfrtrh";
            this.sfrtrh.Size = new System.Drawing.Size(129, 28);
            this.sfrtrh.TabIndex = 30;
            this.sfrtrh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sfrtrh_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(1226, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Turizm.Properties.Resources.sefer;
            this.pictureBox1.Location = new System.Drawing.Point(787, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Red;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.Image = global::Turizm.Properties.Resources.rubbish_bin;
            this.sil.Location = new System.Drawing.Point(709, 186);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(72, 64);
            this.sil.TabIndex = 24;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-4, -3);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // SeferIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1282, 979);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sfrtrh);
            this.Controls.Add(this.sfrtrh1);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.bts);
            this.Controls.Add(this.bslngc);
            this.Controls.Add(this.otoid);
            this.Controls.Add(this.sfrno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeferIslem";
            this.Load += new System.EventHandler(this.SeferIslem_Load);
            this.DoubleClick += new System.EventHandler(this.SeferIslem_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.listele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turizmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.DataGridView listele;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private TurizmDataSet turizmDataSet;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private TurizmDataSetTableAdapters.SeferTableAdapter seferTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sfrno;
        private System.Windows.Forms.TextBox otoid;
        private System.Windows.Forms.TextBox bslngc;
        private System.Windows.Forms.TextBox bts;
        private System.Windows.Forms.Label sfrtrh1;
        private System.Windows.Forms.TextBox sfrtrh;
        private System.Windows.Forms.Button button2;
    }
}