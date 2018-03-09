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
    public partial class YolcuKayıt : Form
    {
        public YolcuKayıt()
        {
            InitializeComponent();
            sifre1.PasswordChar = '*';
            sifre2.PasswordChar = '*';
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            BiletSatisGiris bsg = new BiletSatisGiris();
            bsg.Show();
            this.Hide();
        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcno.Text != "")
                {
                    long tcno1 = Convert.ToInt64(tcno.Text);
                    long ylctel = Convert.ToInt64(tel.Text);

                    if (tcno1 > 10000000000 && tcno1 < 99999999999)
                    {
                        bag.Open();
                        string sorgu1 = "SELECT Tc_No FROM Yolcu WHERE Tc_No=@tcno";
                        SqlCommand cmd8 = new SqlCommand(sorgu1, bag);
                        cmd8.Parameters.Add("@tcno", tcno1);
                        SqlDataReader dr1 = cmd8.ExecuteReader();
                        if (dr1.HasRows == true)
                        {
                            bag.Close();
                            tcno.Text = "";
                            MessageBox.Show("Girdiğiniz tc numarası sistemde kayıtlıdır. Farklı bir tc numarası giriniz.");
                        }
                        else
                        {
                            bag.Close();
                            long sfr = Convert.ToInt32(sifre1.Text);
                            long sfr1 = Convert.ToInt32(sifre2.Text);
                            if (sifre1.Text != "" && sfr >= 1000 && sfr <= 9999)
                            {
                                if (sifre1.Text == sifre2.Text)
                                {
                                    if (cinsiyet.Text != "")
                                    {
                                        if (yas.Text != "")
                                        {
                                            bag.Open();
                                            string sorgu = "SELECT YolcuTel FROM Yolcu WHERE YolcuTel=@tel";
                                            SqlCommand cmd9 = new SqlCommand(sorgu, bag);
                                            cmd9.Parameters.Add("@tel", tel.Text);
                                            SqlDataReader dr = cmd9.ExecuteReader();
                                            if (dr.HasRows == true)
                                            {
                                                bag.Close();
                                                MessageBox.Show("Girdiğiniz telefon numarası sisteme kayıtlı. Başka numara giriniz!");
                                            }
                                            else
                                            {
                                                bag.Close();
                                                if (ad.Text != "" && soyad.Text != "" && adres.Text != "" && tel.Text != "")
                                                {
                                                    if (ylctel > 5000000000 && ylctel < 5619999999)
                                                    {
                                                        bag.Open();
                                                        SqlCommand cmd = new SqlCommand("INSERT INTO Yolcu (Tc_No,YolcuAdi,YolcuSoyadi,YolcuAdres,YolcuCinsiyet,YolcuYas,YolcuTel,YolcuDogumTarihi) VALUES(@tcno, @ad, @soyad, @adres, @cinsiyet, @yas, @tel, @dogumtrh)", bag);
                                                        SqlCommand cmd2 = new SqlCommand("INSERT INTO WebGiris (Tc_No,YolcuSifre) VALUES (@tcno,@sifre)", bag);
                                                        string dgmtrh = dogumtarihi.SelectionStart.Year.ToString() + "-" + dogumtarihi.SelectionStart.Month.ToString() + "-" + dogumtarihi.SelectionStart.Day.ToString();
                                                        cmd.Parameters.Add("@tcno", tcno1);
                                                        cmd.Parameters.Add("@ad", ad.Text);
                                                        cmd.Parameters.Add("@soyad", soyad.Text);
                                                        cmd.Parameters.Add("@adres", adres.Text);
                                                        cmd.Parameters.Add("@cinsiyet", cinsiyet.SelectedItem.ToString());
                                                        cmd.Parameters.Add("@yas", yas.SelectedItem.ToString());
                                                        cmd.Parameters.Add("@tel", tel.Text);
                                                        cmd.Parameters.Add("@dogumtrh", dgmtrh);
                                                        cmd2.Parameters.Add("@tcno", tcno1);
                                                        cmd2.Parameters.Add("@sifre", sifre1.Text);
                                                        cmd.ExecuteNonQuery();
                                                        cmd2.ExecuteNonQuery();
                                                        MessageBox.Show("Kayıt oluşturuldu. Giriş Yapınız.");
                                                        YolcuKart yk = new YolcuKart();
                                                        yk.Show();
                                                        this.Hide();
                                                        bag.Close();
                                                    }
                                                    else
                                                    {
                                                        bag.Close();
                                                        MessageBox.Show("Yanlış telefon numarası girdiniz!");
                                                    }
                                                }
                                                else
                                                {
                                                    bag.Close();
                                                    MessageBox.Show("Ad, soyad ve tel alanlarını boş bırakmayınız.");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            bag.Close();
                                            MessageBox.Show("Yaş seçilmedi!!!");
                                        }
                                    }
                                    else
                                    {
                                        bag.Close();
                                        MessageBox.Show("Cinsiyet seçilmedi!!!");
                                    }
                                }
                                else
                                {
                                    bag.Close();
                                    sifre1.Text = "";
                                    sifre2.Text = "";
                                    MessageBox.Show("Şifreler uyuşmuyor!!!");
                                }
                            }
                            else
                            {
                                bag.Close();
                                MessageBox.Show("Şifre alanı 4 haneli sayı olacak!!!");
                            }
                        }
                    }
                    else
                    {
                        bag.Close();
                        MessageBox.Show("Tc No yanlış girildi!(11 Hane)");
                    }
                }
                else
                {
                    MessageBox.Show("Tc no boş bırakılamaz!!!");
                }
            }
            catch(Exception ex)
            {
                
                 MessageBox.Show("Tc no ve telefon kutucuğuna sayı giriniz! Şifre alanı 4 haneli sayı olacak!", ex.Message);
            }
        }

        private void YolcuKayıt_Load(object sender, EventArgs e)
        {

        }

        private void sifre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void sifre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void sifre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kayıt.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

/*
 * Yolcu tablosuna kayıtlar ekleniyor.
 * Kayıt eklenirken database de var olan tcno ve telefon lara izin verilmiyor.
 */