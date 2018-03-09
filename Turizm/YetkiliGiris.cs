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
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        private void YetkiliGiris_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString= "Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True";
            bag.Open();
            string txtYetkili = textBox1.Text;
            string txtSifre = textBox2.Text;
            string sorgu = "SELECT * FROM Yetkili WHERE YetkiliNo=@yetkili AND Sifre=@sifre";
            SqlCommand cmd = new SqlCommand(sorgu,bag);
            cmd.Parameters.Add(new SqlParameter("@yetkili", txtYetkili));
            cmd.Parameters.Add(new SqlParameter("@sifre", txtSifre));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Giriş Başarılı.");
                Yetkili yg = new Yetkili();
                yg.Show();
                this.Hide();
            }
            else
            {
                textBox2.Text = "";
                MessageBox.Show("Hatalı Giriş Yaptınız!!!");
            }
            bag.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
