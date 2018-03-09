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
    public partial class SeferIslem : Form
    {
        public SeferIslem()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        void FillDataGridView()
        {
            string sorgu = "SELECT * FROM Otobus";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            DataTable dtbl = new DataTable();
            da.Fill(ds);
            listele.DataSource = ds.Tables[0];
        }
        public void resetle()
        {
            sfrno.Text = otoid.Text = bslngc.Text = bts.Text = "";
            kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\save.png");
            label6.Text = "Save";
            sil.Enabled = false;
        }
        private void SeferIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'turizmDataSet.Sefer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seferTableAdapter.Fill(this.turizmDataSet.Sefer);
            resetle();
            label6.Text = "Save";
            sil.Enabled = false;
            try
            {
                bag.Open();
                FillDataGridView();
                bag.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void SeferIslem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //string trh = trhgstr.SelectionStart.Year.ToString() + "-" + trhgstr.SelectionStart.Month.ToString() + "-" + trhgstr.SelectionStart.Day.ToString();
                bag.Open();
                if (label6.Text == "Save" && otoid.Text != "" && sfrtrh.Text != "" && bslngc.Text != "" && bts.Text != "")
                {
                    string sorgu = "INSERT INTO Sefer (OtobusId,SeferTarihi,Baslangic,Bitis) VALUES (@oid,@sefrtrh,@baslngc,@bits)";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@oid", otoid.Text);
                    cmd.Parameters.Add("@sefrtrh", sfrtrh.Text);
                    cmd.Parameters.Add("@baslngc", bslngc.Text);
                    cmd.Parameters.Add("@bits", bts.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                else if (label6.Text == "Update")
                {
                    string sorgu = "UPDATE Sefer SET OtobusId=@oid, SeferTarihi=@seftrh, Baslangic=@baslngc, Bitis=@bits WHERE SeferNo=@sefrno";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@oid", otoid.Text);
                    cmd.Parameters.Add("@sefrtrh", sfrtrh.Text);
                    cmd.Parameters.Add("@baslngc", bslngc.Text);
                    cmd.Parameters.Add("@bits", bts.Text);
                    cmd.Parameters.Add("@sefrno", sfrno.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Güncelleştirildi.");
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakmayınız.");
                }
            }
            catch
            {
                MessageBox.Show("Alanları kontrol ediniz...");
            }
            finally
            {
                bag.Close();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetle();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                //string trh = trhgstr.SelectionStart.Year.ToString() + "-" + trhgstr.SelectionStart.Month.ToString() + "-" + trhgstr.SelectionStart.Day.ToString();
                bag.Open();
                string sorgu = "SELECT * FROM Sefer WHERE SeferNo=@sefrno";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@sefrno", sfrno.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (sfrno.Text != "" && otoid.Text != "" && sfrtrh.Text != "" && bslngc.Text != "" && bts.Text != "")
                {
                    if (dr.HasRows == true)
                    {
                        dr.Close();
                        string sorgu1 = "DELETE FROM Sefer WHERE SeferNo=@sefrno";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                        cmd1.Parameters.Add("@sefno", sfrno.Text);
                        cmd1.ExecuteNonQuery();
                        FillDataGridView();
                        MessageBox.Show("Kayıt silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kayıt bulunmamaktadır.");
                    }
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakmayınız.");
                }
                dr.Close();
                bag.Close();
            }
            catch
            {
                MessageBox.Show("Alanları gözden geçir!!!");
            }
            finally
            {
                bag.Close();
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Yetkili ytk = new Yetkili();
            ytk.Show();
            this.Hide();
        }

        private void listele_DoubleClick(object sender, EventArgs e)
        {
            if (listele.CurrentRow.Index != -1)
            {
                sfrno.Text = listele.CurrentRow.Cells[0].Value.ToString();
                otoid.Text = listele.CurrentRow.Cells[1].Value.ToString();
                sfrtrh.Text = listele.CurrentRow.Cells[2].Value.ToString();
                bslngc.Text = listele.CurrentRow.Cells[3].Value.ToString();
                bts.Text = listele.CurrentRow.Cells[4].Value.ToString();
                sil.Enabled = true;
                label6.Text = "Update";
                kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\settings.png");
                toolTip1.SetToolTip(kaydet, string.Format("Güncellemek için tıklayınız."));
                toolTip2.SetToolTip(sil, string.Format("Seçilen veriyi silmek için tıklayınız."));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sfrno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void otoid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void sfrtrh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void bslngc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void bts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }
    }
}
