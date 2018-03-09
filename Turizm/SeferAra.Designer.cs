namespace Turizm
{
    partial class SeferAra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nereden = new System.Windows.Forms.ComboBox();
            this.nereye = new System.Windows.Forms.ComboBox();
            this.sefertarihi = new System.Windows.Forms.MonthCalendar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ara = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.geri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turizmDataSet1 = new Turizm.TurizmDataSet1();
            this.guzergahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guzergahTableAdapter = new Turizm.TurizmDataSet1TableAdapters.GuzergahTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turizmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guzergahBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "SEFER TARİHİ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "NEREDEN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "NEREYE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(288, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "SEFER ARA";
            // 
            // nereden
            // 
            this.nereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nereden.FormattingEnabled = true;
            this.nereden.Location = new System.Drawing.Point(294, 93);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(160, 24);
            this.nereden.TabIndex = 11;
            // 
            // nereye
            // 
            this.nereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nereye.FormattingEnabled = true;
            this.nereye.Location = new System.Drawing.Point(294, 167);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(160, 24);
            this.nereye.TabIndex = 12;
            // 
            // sefertarihi
            // 
            this.sefertarihi.Location = new System.Drawing.Point(294, 267);
            this.sefertarihi.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.sefertarihi.MaxSelectionCount = 1;
            this.sefertarihi.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.sefertarihi.Name = "sefertarihi";
            this.sefertarihi.TabIndex = 13;
            this.sefertarihi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.sefertarihi_DateChanged);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ara.Image = global::Turizm.Properties.Resources.magnifier;
            this.ara.Location = new System.Drawing.Point(349, 486);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(137, 115);
            this.ara.TabIndex = 14;
            this.toolTip1.SetToolTip(this.ara, "Sefer aramak için tıklayınız.");
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-2, -4);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 6;
            this.toolTip2.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(681, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Aranılan Seferler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(984, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(602, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 182);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // turizmDataSet1
            // 
            this.turizmDataSet1.DataSetName = "TurizmDataSet1";
            this.turizmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guzergahBindingSource
            // 
            this.guzergahBindingSource.DataMember = "Guzergah";
            this.guzergahBindingSource.DataSource = this.turizmDataSet1;
            // 
            // guzergahTableAdapter
            // 
            this.guzergahTableAdapter.ClearBeforeFill = true;
            // 
            // SeferAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1037, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.sefertarihi);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.nereden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SeferAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeferAra";
            this.Load += new System.EventHandler(this.SeferAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turizmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guzergahBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nereden;
        private System.Windows.Forms.ComboBox nereye;
        private System.Windows.Forms.MonthCalendar sefertarihi;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TurizmDataSet1 turizmDataSet1;
        private System.Windows.Forms.BindingSource guzergahBindingSource;
        private TurizmDataSet1TableAdapters.GuzergahTableAdapter guzergahTableAdapter;
    }
}