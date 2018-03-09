using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Turizm
{
    public partial class KoltukAra54 : Form
    {
        public KoltukAra54()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        
        static public string kltkno;
        private void KoltukAra_Load(object sender, EventArgs e)
        {
            bag.Open();
            string sorgu = "SELECT YolcuAdi FROM Yolcu WHERE Tc_No=@tcno";
            string sorgu2 = "SELECT YolcuCinsiyet FROM Yolcu WHERE Tc_No=@tcno";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            SqlCommand cmd2 = new SqlCommand(sorgu2, bag);
            cmd.Parameters.Add("@tcno", YolcuKart.txtTcNo);
            cmd2.Parameters.Add("@tcno", YolcuKart.txtTcNo);
            string cns = Convert.ToString(cmd2.ExecuteScalar());
            if (cns == "BAY")
            {
                string hg = Convert.ToString(cmd.ExecuteScalar()); ;
                label1.Text = "Hoşgeldiniz, " + hg + " Bey";
            }

            else
            {
                string hg = Convert.ToString(cmd.ExecuteScalar()); ;
                label1.Text = "Hoşgeldiniz, " + hg + " Hanım";
            }



            bag.Close();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ara_Click(object sender, EventArgs e)
        {
            kltkno = koltukno.Text;
            bag.Open();

            string sorgu = "SELECT spt.BiletNo FROM SeferKoltuk sk, Sepet spt WHERE sk.SKNo=spt.SKNo AND sk.SeferNo=@sfrno AND sk.KoltukNo=@kltkno";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.Add("@sfrno", SeferAra.sfrno);
            cmd.Parameters.Add("@kltkno", koltukno.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Koltuk Dolu");
                dr.Close();
            }
            else
            {
                dr.Close();
                string sorgu2 = "SELECT rn.RezervasyonId FROM Rezervasyon rn,SeferKoltuk sk WHERE sk.SKNo=rn.SKNo AND sk.SeferNo=@sfrno AND sk.KoltukNo=@kltkno";
                SqlCommand cmd2 = new SqlCommand(sorgu2, bag);
                cmd2.Parameters.Add("@sfrno", SeferAra.sfrno);
                cmd2.Parameters.Add("@kltkno", koltukno.Text);
                SqlDataReader dr1 = cmd2.ExecuteReader();
                if (dr1.HasRows == true)
                {
                    MessageBox.Show("Koltuk rezerve edilmiş. Son güne kadar satın alım gerçekleştirilmezse koltuk satın alınabilir.");
                }
                else
                {
                    MessageBox.Show("Devam edilecek");
                    Sepet spt = new Sepet();
                    spt.Show();
                    this.Close();
                }
                bag.Close();
            }
            bag.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            SeferAra sa = new SeferAra();
            sa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
