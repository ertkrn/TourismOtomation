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
    public partial class Hosgeldiniz : Form
    {
       
        public Hosgeldiniz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Hosgeldiniz_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac = sayac+1;
            if (sayac == 3) {
                Giris grs = new Giris();
                grs.Show();
                this.Hide();
                timer1.Stop();
            }
                
        }
    }
}
