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
    public partial class YolcuKart : Form
    {
        public YolcuKart()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        static public string txtTcNo;
        static public string txtSifre;

        public void grssayisiekle()
        {
            try
            {
                bag.Open();
                string sorgu = "SELECT GirisSayisi FROM WebGiris WHERE Tc_No=@tcno";
                string sorgu1 = "UPDATE WebGiris SET GirisSayisi=@grssys WHERE Tc_No=@tcno";
                SqlCommand cmd = new SqlCommand(sorgu,bag);
                SqlCommand cmd1 = new SqlCommand(sorgu1,bag);
                cmd.Parameters.Add("@tcno",textBox1.Text);
                int grssays;

                if (cmd.ExecuteScalar()==DBNull.Value)
                {
                    grssays = 1;
                    cmd1.Parameters.Add("@grssys", grssays);
                    cmd1.Parameters.Add("@tcno", textBox1.Text);
                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    grssays = Convert.ToInt32(cmd.ExecuteScalar());
                    grssays += 1;
                    cmd1.Parameters.Add("@grssys", grssays);
                    cmd1.Parameters.Add("@tcno", textBox1.Text);
                    cmd1.ExecuteNonQuery();
                }
                bag.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Var!!",ex.Message);
            }
        }

        public void songiristrh()
        {
            try
            {
                bag.Open();
                txtTcNo = textBox1.Text;
                MonthCalendar mc = new MonthCalendar();
                string sngrstrh = mc.TodayDate.Year.ToString() + "-" + mc.TodayDate.Month.ToString() + "-" + mc.TodayDate.Day.ToString();
                string sorgu = "UPDATE WebGiris SET SonGirisTarihi=@sgt WHERE Tc_No=@tcno";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@sgt", sngrstrh);
                cmd.Parameters.Add("@tcno", txtTcNo);
                cmd.ExecuteNonQuery();

                bag.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Message",ex.Message);
            }
        }

        public void girisyap()
        {
                bag.Open();
                txtTcNo = textBox1.Text;
                txtSifre = textBox2.Text;
                string sorgu = "SELECT * FROM WebGiris WHERE Tc_No=@tcno AND YolcuSifre=@sifre";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add(new SqlParameter("@tcno", txtTcNo));
                cmd.Parameters.Add(new SqlParameter("@sifre", txtSifre));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    bag.Close();
                    MessageBox.Show("Giriş Başarılı.");
                    if (BiletSatisGiris.gncl==true)
                    {
                        RezervasyonIslem ri = new RezervasyonIslem();
                        ri.Show();
                        this.Hide();
                        songiristrh();
                    }
                    else
                    {
                        grssayisiekle();
                        SatisListeleme sl = new SatisListeleme();
                        sl.Show();
                        this.Hide();
                    }
                }
                else
                {
                    textBox2.Text = "";
                    MessageBox.Show("Hatalı Giriş Yaptınız!!!");
                }
                dr.Close();
                bag.Close();
        }
            

        private void YolcuKart_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisyap();
            Giris.i = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            BiletSatisGiris bsg = new BiletSatisGiris();
            bsg.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

/*
 * Yolcu tablosundaki tcno su ve WebGiris tablosundaki sifreye göre giriş yapıyor.
 * Giriş yapan yolcunun WebGiris tablosundaki SonGirisTarihi 'ne giriş tarihini güncelliyor
 * Giriş yapan yolcunun WebGiris tablosundaki GirisSayisi 'nı her girişinde güncelliyor.
 */
