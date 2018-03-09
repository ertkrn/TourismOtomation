using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turizm
{
    public partial class BiletSatisGiris : Form
    {
        public BiletSatisGiris()
        {
            InitializeComponent();
        }

        private void yolcugirisi_Click(object sender, EventArgs e)
        {
            if (Giris.i == false)
            {
                gncl = false;
            }
            YolcuKart yk = new YolcuKart();
            yk.Show();
            this.Hide();
        }

        private void devam_Click(object sender, EventArgs e)
        {
            YolcuKayıt yk = new YolcuKayıt();
            yk.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
        static public bool gncl=false;
        static public bool x = false;
        private void BiletSatisGiris_Load(object sender, EventArgs e)
        {
            if (Giris.i == true)
            {
                x = true;
                rzrvsyngncll.Visible = true;
                rzrvsyngncll.Enabled = true;
                toolTip4.SetToolTip(rzrvsyngncll,string.Format("Rezervasyon güncellemek için tıklayınız."));
            }
        }
        private void rzrvsyngncll_Click(object sender, EventArgs e)
        {
            gncl = true;
            YolcuKart yk = new YolcuKart();
            yk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
