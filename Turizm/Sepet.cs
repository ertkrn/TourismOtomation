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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");

        private void geri_Click(object sender, EventArgs e)
        {
            BiletSatisGiris.x = false;
            if (SeferAra.kltksys == 54)
            {
                KoltukAra54 ka54 = new KoltukAra54();
                ka54.Show();
                this.Hide();
            }
            if (SeferAra.kltksys == 46)
            {
                KoltukAra46 ka46 = new KoltukAra46();
                ka46.Show();
                this.Hide();
            }
            if (SeferAra.kltksys == 78)
            {
                KoltukAra78 ka78 = new KoltukAra78();
                ka78.Show();
                this.Hide();
            }
        }
        public string sontrh;
        public string skno;
        private void Sepet_Load(object sender, EventArgs e)
        {
            if (BiletSatisGiris.x == true)
            {
                listele.Columns.Clear();
                listele.Columns.Add("RezervasyonId");
                listele.Columns.Add("SKNo");
                listele.Columns.Add("Tc_No");
                listele.Columns.Add("R_son_tarihi");
                button1.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\reserved.png");
                toolTip2.SetToolTip(button1, string.Format("Rezervasyon yapmak için tıklayınız."));
                string koltkno;
                bag.Open();
                string sorgu = "SELECT MAX(RezervasyonId)+1 'RezervasyonId' FROM Rezervasyon";
                string sorgu2 = "SELECT os.OKoltukSayisi  FROM Sefer sfr, Otobus os WHERE sfr.OtobusId=os.OtobusId AND SeferNo=@sfrno";
                string sorgu3 = "SELECT sk.SKNo FROM Sefer sfr,SeferKoltuk sk WHERE sfr.SeferNo=sk.SeferNo AND sfr.SeferNo=@sfrno and sk.KoltukNo=@kltkno";
                string sorgu4 = "SELECT day(sfr.SeferTarihi)-1 'Tarih' FROM Sefer sfr WHERE sfr.SeferNo=@sfrno and sfr.SeferTarihi=@sfrtrh";

                string trh = SeferAra.sfrtrh1;
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                SqlCommand cmd2 = new SqlCommand(sorgu2, bag);
                SqlCommand cmd3 = new SqlCommand(sorgu3, bag);
                SqlCommand cmd4 = new SqlCommand(sorgu4, bag);

                cmd4.Parameters.Add("@sfrtrh", trh);
                cmd4.Parameters.Add("@sfrno", SeferAra.sfrno);
                string gun = Convert.ToString(cmd4.ExecuteScalar());
                sontrh = SeferAra.yılay + "-" + gun;
                cmd3.Parameters.Add("@sfrno", SeferAra.sfrno);
                cmd2.Parameters.Add("@sfrno", SeferAra.sfrno);
                int kltksys = Convert.ToInt32(cmd2.ExecuteScalar());
                if (kltksys == 54)
                {
                    koltkno = KoltukAra54.kltkno;
                    cmd3.Parameters.Add("@kltkno", koltkno);
                }
                else if (kltksys == 46)
                {
                    koltkno = KoltukAra46.kltkno;
                    cmd3.Parameters.Add("@kltkno", koltkno);
                }
                else if (kltksys == 78)
                {
                    koltkno = KoltukAra78.kltkno;
                    cmd3.Parameters.Add("@kltkno", koltkno);
                }
                skno = Convert.ToString(cmd3.ExecuteScalar());
                SqlDataReader dr2 = cmd.ExecuteReader();
                while (dr2.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ListViewItem ekle1 = new ListViewItem();
                    ListViewItem ekle2 = new ListViewItem();
                    ListViewItem ekle3 = new ListViewItem();
                    ekle.Text = dr2["RezervasyonId"].ToString();
                    ekle1.Text = skno;
                    ekle2.Text = YolcuKart.txtTcNo;
                    ekle3.Text = sontrh;
                    ekle.SubItems.Add(ekle1.Text);
                    ekle.SubItems.Add(ekle2.Text);
                    ekle.SubItems.Add(ekle3.Text);

                    listele.Items.Add(ekle);

                }

                bag.Close();
            }
            else
            {
                button1.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\shopping-cart.png");
                bag.Open();
                string sorgu = "SELECT MAX(spt.BiletNo)+1 'BiletNo' FROM Sepet spt";
                string sorgu2 = "SELECT os.OKoltukSayisi  FROM Sefer sfr, Otobus os WHERE sfr.OtobusId=os.OtobusId AND SeferNo=@sfrno";
                string sorgu3 = "SELECT gh.GNo FROM Guzergah gh, Otogar otr,Sefer sfr WHERE otr.OtogarId=gh.OtogarId AND otr.OtogarAdi=@otradi AND gh.SeferNo=sfr.SeferNo AND gh.SeferNo=@sfrno";
                string sorgu4 = "SELECT gh.GNo FROM Guzergah gh, Otogar otr,Sefer sfr WHERE otr.OtogarId=gh.OtogarId AND otr.OtogarAdi=@otradi AND gh.SeferNo=sfr.SeferNo AND gh.SeferNo=@sfrno";
                string sorgu5 = "SELECT ucr.Ucret FROM Ucret ucr WHERE ucr.OBslngcId IN (SELECT otr.OtogarId FROM Otogar otr WHERE otr.OtogarAdi=@oadi1) AND ucr.OBtsId IN (SELECT otr.OtogarId FROM Otogar otr WHERE otr.OtogarAdi=@oadi2)";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                SqlCommand cmd2 = new SqlCommand(sorgu2, bag);
                SqlCommand cmd3 = new SqlCommand(sorgu3, bag);
                SqlCommand cmd4 = new SqlCommand(sorgu4, bag);
                SqlCommand cmd5 = new SqlCommand(sorgu5, bag);


                cmd3.Parameters.Add("@otradi", SeferAra.nrdn);
                cmd3.Parameters.Add("@sfrno", SeferAra.sfrno);
                string gnobslngc = Convert.ToString(cmd3.ExecuteScalar());
                cmd4.Parameters.Add("@otradi", SeferAra.nrye);
                cmd4.Parameters.Add("@sfrno", SeferAra.sfrno);
                string gnobitis = Convert.ToString(cmd4.ExecuteScalar());
                cmd5.Parameters.Add("@oadi1", SeferAra.nrdn);
                cmd5.Parameters.Add("@oadi2", SeferAra.nrye);
                string ucret = Convert.ToString(cmd5.ExecuteScalar());

                cmd2.Parameters.Add("@sfrno", SeferAra.sfrno);
                int kltksys = Convert.ToInt32(cmd2.ExecuteScalar());
                SqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ListViewItem ekle1 = new ListViewItem();
                    ListViewItem ekle2 = new ListViewItem();
                    ListViewItem ekle3 = new ListViewItem();
                    ListViewItem ekle4 = new ListViewItem();
                    ListViewItem ekle5 = new ListViewItem();
                    ListViewItem ekle6 = new ListViewItem();
                    ekle.Text = dr1["BiletNo"].ToString();
                    ekle1.Text = YolcuKart.txtTcNo;
                    if (kltksys == 54)
                    {
                        ekle2.Text = KoltukAra54.kltkno;
                    }
                    else if (kltksys == 46)
                    {
                        ekle2.Text = KoltukAra46.kltkno;
                    }
                    else if (kltksys == 78)
                    {
                        ekle2.Text = KoltukAra78.kltkno;
                    }
                    ekle3.Text = SeferAra.sfrno;
                    ekle4.Text = SeferAra.nrdn;
                    ekle5.Text = SeferAra.nrye;
                    ekle6.Text = ucret;
                    ekle.SubItems.Add(ekle1.Text);
                    ekle.SubItems.Add(ekle2.Text);
                    ekle.SubItems.Add(ekle3.Text);
                    ekle.SubItems.Add(ekle4.Text);
                    ekle.SubItems.Add(ekle5.Text);
                    ekle.SubItems.Add(ekle6.Text);

                    listele.Items.Add(ekle);

                }

                bag.Close();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (BiletSatisGiris.x==true)
            {
                if (skno != "")
                {
                    if (YolcuKart.txtTcNo != "")
                    {
                        if (sontrh != "")
                        {
                            bag.Open();
                            string sorgu = "INSERT INTO Rezervasyon (SKNo,Tc_No,R_son_tarihi) VALUES (@skno,@tcno,@rsontrh)";
                            SqlCommand cmd = new SqlCommand(sorgu, bag);
                            cmd.Parameters.Add("@skno", skno);
                            cmd.Parameters.Add("@tcno", YolcuKart.txtTcNo);
                            cmd.Parameters.Add("@rsontrh", sontrh);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Rezervasyon yapılmıştır.");
                            bag.Close();
                        }
                        else
                        {
                            MessageBox.Show("sontrh boş!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("tcno boş!!!");
                    }
                }
                else
                {
                    MessageBox.Show("skno boş!!!");
                }
            }
            else
            {

                bag.Open();

                string sorgu = "INSERT INTO Sepet (Tc_No,SKNo,GNoBaslangic,GNoBitis,Ucret) VALUES (@tcno,@skno,@gnoblngc,@gnobts,@ucret)";
                string sorgu2 = "SELECT SKNo FROM SeferKoltuk WHERE KoltukNo=@kltkno AND SeferNo=@sfrno";
                string sorgu3 = "SELECT gh.GNo FROM Guzergah gh, Otogar otr,Sefer sfr WHERE otr.OtogarId=gh.OtogarId AND otr.OtogarAdi=@otradi AND gh.SeferNo=sfr.SeferNo AND gh.SeferNo=@sfrno";
                string sorgu4 = "SELECT gh.GNo FROM Guzergah gh, Otogar otr,Sefer sfr WHERE otr.OtogarId=gh.OtogarId AND otr.OtogarAdi=@otradi AND gh.SeferNo=sfr.SeferNo AND gh.SeferNo=@sfrno";
                string sorgu5 = "SELECT os.OKoltukSayisi  FROM Sefer sfr, Otobus os WHERE sfr.OtobusId=os.OtobusId AND SeferNo=@sfrno";
                string sorgu6 = "SELECT ucr.Ucret FROM Ucret ucr WHERE ucr.OBslngcId IN (SELECT otr.OtogarId FROM Otogar otr WHERE otr.OtogarAdi=@oadi1) AND ucr.OBtsId IN (SELECT otr.OtogarId FROM Otogar otr WHERE otr.OtogarAdi=@oadi2)";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                SqlCommand cmd2 = new SqlCommand(sorgu2, bag);
                SqlCommand cmd3 = new SqlCommand(sorgu3, bag);
                SqlCommand cmd4 = new SqlCommand(sorgu4, bag);
                SqlCommand cmd5 = new SqlCommand(sorgu5, bag);
                SqlCommand cmd6 = new SqlCommand(sorgu6, bag);


                cmd5.Parameters.Add("@sfrno", SeferAra.sfrno);
                int kltksys = Convert.ToInt32(cmd5.ExecuteScalar());

                if (kltksys == 54)
                {
                    cmd2.Parameters.Add("@kltkno", KoltukAra54.kltkno);
                }
                else if (kltksys == 46)
                {
                    cmd2.Parameters.Add("@kltkno", KoltukAra46.kltkno);
                }
                else if (kltksys == 78)
                {
                    cmd2.Parameters.Add("@kltkno", KoltukAra78.kltkno);
                }
                cmd2.Parameters.Add("@sfrno", SeferAra.sfrno);
                string skno = Convert.ToString(cmd2.ExecuteScalar());
                if (skno != "")
                {
                    cmd3.Parameters.Add("@otradi", SeferAra.nrdn);
                    cmd3.Parameters.Add("@sfrno", SeferAra.sfrno);
                    string gnobslngc = Convert.ToString(cmd3.ExecuteScalar());
                    cmd4.Parameters.Add("@otradi", SeferAra.nrye);
                    cmd4.Parameters.Add("@sfrno", SeferAra.sfrno);
                    string gnobitis = Convert.ToString(cmd4.ExecuteScalar());
                    cmd6.Parameters.Add("@oadi1", SeferAra.nrdn);
                    cmd6.Parameters.Add("@oadi2", SeferAra.nrye);
                    string ucret = Convert.ToString(cmd6.ExecuteScalar());
                    cmd.Parameters.Add("@tcno", YolcuKart.txtTcNo);
                    cmd.Parameters.Add("@skno", skno);
                    cmd.Parameters.Add("@gnoblngc", gnobslngc);
                    cmd.Parameters.Add("@gnobts", gnobitis);
                    cmd.Parameters.Add("@ucret", ucret);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Satın alma işlemi başarıyla sonuçlanmıştır. İyi günler dileriz...");
                    Giris grs = new Giris();
                    grs.Show();
                    this.Hide();

                    bag.Close();
                }
                else
                {
                    MessageBox.Show("Sefere Koltuk eklenmemiştir!!!");
                }
                bag.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
