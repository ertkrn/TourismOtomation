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
    public partial class SeferAra : Form
    {
        public SeferAra()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        static public string sfrno;
        public void filldatagridview()
        {
            try
            {
                bag.Open();
                string sfrtrh = sefertarihi.SelectionStart.Year.ToString() + "-" + sefertarihi.SelectionStart.Month.ToString() + "-" + sefertarihi.SelectionStart.Day.ToString();
                string sorgu = "SELECT gh.SeferNo,COUNT(gh.SeferNo) '" + "SeferNo Sayısı" + "' FROM Sefer sfr,Guzergah gh, Otogar otr WHERE gh.SeferNo=sfr.SeferNo AND sfr.SeferTarihi='" + sfrtrh + "' AND gh.OtogarId=otr.OtogarId AND otr.OtogarAdi IN('" + nereye.Text + "','" + nereden.Text + "') group by gh.SeferNo having COUNT(gh.SeferNo)>1";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                bag.Close();
            }
            catch(Exception ex)
            {
                bag.Close();
                MessageBox.Show("Error Message",ex.Message);
            }
        }

        static public string sfrtrh1;
        static public string yılay;
        static public string secilen;
        static public string nrdn;
        static public string nrye;
        private void SeferAra_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'turizmDataSet1.Guzergah' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            this.guzergahTableAdapter.Fill(this.turizmDataSet1.Guzergah);
            bag.Open();
            SqlCommand cmd = new SqlCommand("SELECT OtogarAdi FROM Otogar", bag);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nereden.Items.Add(dr[0]);
                nereye.Items.Add(dr[0]);
            }
            dr.Close();
            bag.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            YolcuKart yk = new YolcuKart();
            yk.Show();
            this.Hide();
        }
        

        private void ara_Click(object sender, EventArgs e)
        {
            if (nereden.Text != "" && nereye.Text != "")
            {
                filldatagridview();
            }
            else
            {
                MessageBox.Show("Alanları boş bırakamazsınız.");
            }
        }
        static public int kltksys;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Close();
            Application.Exit();
        }

        private void listeleme_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //sfrno = dataGridView1.Rows[e.RowIndex].Cells.["SeferNo"].value.ToString();
            //label1.Text = sfrno;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bag.Open();
            sfrno = dataGridView1.Rows[e.RowIndex].Cells["SeferNo"].Value.ToString();
            sfrtrh1 = sefertarihi.SelectionStart.Year.ToString() + "-" + sefertarihi.SelectionStart.Month.ToString() + "-" + sefertarihi.SelectionStart.Day.ToString();
            nrdn = nereden.Text;
            nrye = nereye.Text;
            string sorgu = "SELECT os.OKoltukSayisi  FROM Sefer sfr, Otobus os WHERE sfr.OtobusId=os.OtobusId AND SeferNo=@sfrno";
            SqlCommand cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.Add("@sfrno", sfrno);

            kltksys = Convert.ToInt32(cmd.ExecuteScalar());
            if (kltksys == 54)
            {
                bag.Close();
                KoltukAra54 ka54 = new KoltukAra54();
                ka54.Show();
                this.Hide();
            }
            else if (kltksys == 46)
            {
                bag.Close();
                KoltukAra46 ka46 = new KoltukAra46();
                ka46.Show();
                this.Hide();
            }
            else if (kltksys == 78)
            {
                bag.Close();
                KoltukAra78 ka78 = new KoltukAra78();
                ka78.Show();
                this.Hide();
            }
        }

        private void sefertarihi_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

/*
 *Form ekranı yüklenirken combobox itemleri veritabanından çekiliyor.
 * verilerigoster metodunda belirtilen başlangıç ve varış otogarları Güzergah tablosunda aynı seferno ya gidiyorsa ve sefertarihi de uyuşuyorsa listview de kullanıcıya gösteriliyor.
 * Gösterilen verilerden birini kullanıcı seçiyor. Seçilen seferdeki otobüsün koltuk sayısına göre oluşturulmuş form ekranına aktarılıyor.
*/
//SqlCommand cmd = new SqlCommand("SELECT sfr.SeferNo, os.OtobusId, sfr.SeferTarihi, os.OKoltukSayisi FROM Otobus os, Otogar otr, Sefer sfr WHERE sfr.OtobusId=os.OtobusId group by sfr.SeferNo,os.OtobusId,sfr.SeferTarihi,os.OKoltukSayisi", bag);
//SELECT sfr.SeferNo FROM Otobus os, Otogar otr, Sefer sfr WHERE otr.OtogarAdi= @otogaradi AND sfr.OtobusId= os.OtobusId group by sfr.SeferNo