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
    public partial class Yetkili : Form
    {
        public Yetkili()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtobusIslem oi = new OtobusIslem();
            oi.Show();
            this.Hide();
        }

        private void sfrkltk_Click(object sender, EventArgs e)
        {
            SeferKoltukIslem ski = new SeferKoltukIslem();
            ski.Show();
            this.Hide();
        }

        private void Yetkili_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seferekle_Click(object sender, EventArgs e)
        {
            SeferIslem si = new SeferIslem();
            si.Show();
            this.Hide();
        }

        private void ilekle_Click(object sender, EventArgs e)
        {
            SehirIslem si = new SehirIslem();
            si.Show();
            this.Hide();
        }

        private void yetkiliekle_Click(object sender, EventArgs e)
        {
            YetkiliIslem yi = new YetkiliIslem();
            yi.Show();
            this.Hide();
        }

        private void guzergahekle_Click(object sender, EventArgs e)
        {

        }
    }
}
