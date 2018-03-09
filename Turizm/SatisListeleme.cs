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
    public partial class SatisListeleme : Form
    {
        public SatisListeleme()
        {
            InitializeComponent();
        }

        private void biletsts_Click(object sender, EventArgs e)
        {
            SeferAra sa = new SeferAra();
            sa.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            YolcuKart yk = new YolcuKart();
            yk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listeleme lst = new Listeleme();
            lst.Show();
            this.Hide();
        }

        private void SatisListeleme_Load(object sender, EventArgs e)
        {

        }
    }
}
