namespace Turizm
{
    partial class Sepet
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listele = new System.Windows.Forms.ListView();
            this.biletno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.koltukno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seferno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baslangicyeri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitisyeri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.geri = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.LightCoral;
            this.listele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.biletno,
            this.tcno,
            this.koltukno,
            this.seferno,
            this.baslangicyeri,
            this.bitisyeri,
            this.ucret});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listele.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listele.Location = new System.Drawing.Point(111, 60);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(1075, 270);
            this.listele.TabIndex = 3;
            this.listele.UseCompatibleStateImageBehavior = false;
            this.listele.View = System.Windows.Forms.View.Details;
            // 
            // biletno
            // 
            this.biletno.Text = "BiletNo";
            this.biletno.Width = 99;
            // 
            // tcno
            // 
            this.tcno.Text = "TcNo";
            this.tcno.Width = 122;
            // 
            // koltukno
            // 
            this.koltukno.Text = "KoltukNo";
            this.koltukno.Width = 111;
            // 
            // seferno
            // 
            this.seferno.Text = "SeferNo";
            this.seferno.Width = 122;
            // 
            // baslangicyeri
            // 
            this.baslangicyeri.Text = "BaşlangıçYeri";
            this.baslangicyeri.Width = 102;
            // 
            // bitisyeri
            // 
            this.bitisyeri.Text = "VarışYeri";
            this.bitisyeri.Width = 87;
            // 
            // ucret
            // 
            this.ucret.Text = "Ücret";
            this.ucret.Width = 87;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri.Image = global::Turizm.Properties.Resources.return_button;
            this.geri.Location = new System.Drawing.Point(-4, -5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 81);
            this.geri.TabIndex = 2;
            this.toolTip1.SetToolTip(this.geri, "Geri dönmek için tıklayınız.");
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Turizm.Properties.Resources.shopping_cart;
            this.button1.Location = new System.Drawing.Point(536, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 117);
            this.button1.TabIndex = 4;
            this.toolTip2.SetToolTip(this.button1, "Satın almak için tıklayınız.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::Turizm.Properties.Resources.cross_circular_button1;
            this.button2.Location = new System.Drawing.Point(1168, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1223, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.ListView listele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader biletno;
        private System.Windows.Forms.ColumnHeader tcno;
        private System.Windows.Forms.ColumnHeader koltukno;
        private System.Windows.Forms.ColumnHeader seferno;
        private System.Windows.Forms.ColumnHeader baslangicyeri;
        private System.Windows.Forms.ColumnHeader bitisyeri;
        private System.Windows.Forms.ColumnHeader ucret;
        private System.Windows.Forms.Button button2;
    }
}