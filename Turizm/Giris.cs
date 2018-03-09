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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        static public bool i;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yetkiligiris_Click(object sender, EventArgs e)
        {
            YetkiliGiris yg = new YetkiliGiris();
            yg.Show();
            this.Hide();
        }

        private void biletsatis_Click(object sender, EventArgs e)
        {
            i = false;
            BiletSatisGiris bsg = new BiletSatisGiris();
            bsg.Show();
            this.Hide();
        }

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            i = true;
            BiletSatisGiris bsg = new BiletSatisGiris();
            bsg.Show();
            this.Hide();
        }

        private void iletişim_Click(object sender, EventArgs e)
        {
            YardımSayfa ys = new YardımSayfa();
            ys.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
