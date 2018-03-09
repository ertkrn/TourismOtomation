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
    public partial class SeferKoltukIslem : Form
    {
        public SeferKoltukIslem()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");

        void FillDataGridView()
        {
            bag.Open();
            string sorgu = "SELECT * FROM SeferKoltuk";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            bag.Close();
        }

        public void resetle()
        {
            skno.Text = koltukno.Text = sfrno.Text = "";
            kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\save.png");
            label4.Text = "Save";
            sil.Enabled = false;
        }

        private void SeferKoltukIslem_Load(object sender, EventArgs e)
        {
            resetle();
            label4.Text = "Save";
            sil.Enabled = false;
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                if (label4.Text == "Save" && koltukno.Text != "" && sfrno.Text != "")
                {
                    string sorgu = "INSERT INTO SeferKoltuk (KoltukNo,SeferNo) VALUES (@kltkno,@sfrno)";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@kltkno", koltukno.Text);
                    cmd.Parameters.Add("@sfrno", sfrno.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                else if (label4.Text == "Update")
                {
                    string sorgu = "UPDATE SeferKoltuk SET KoltukNo=@kltkno, SeferNo=@sfrno WHERE SKNo=@skno";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@skno", skno.Text);
                    cmd.Parameters.Add("@kltkno", koltukno.Text);
                    cmd.Parameters.Add("@sfrno", sfrno.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Güncelleştirildi.");
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakmayınız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                bag.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                skno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                koltukno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sfrno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sil.Enabled = true;
                label4.Text = "Update";
                kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\settings.png");
                toolTip1.SetToolTip(kaydet, string.Format("Güncellemek için tıklayınız."));
                toolTip2.SetToolTip(sil, string.Format("Seçilen veriyi silmek için tıklayınız."));
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
                bag.Open();
                string sorgu = "SELECT * FROM SeferKoltuk WHERE SKNo=@skno";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@skno", skno.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (skno.Text != "" && koltukno.Text != "" && sfrno.Text != "")
                {
                    if (dr.HasRows == true)
                    {
                        dr.Close();
                        string sorgu1 = "DELETE FROM SeferKoltuk WHERE SKNo=@skno";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                        cmd1.Parameters.Add("@skno", skno.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                bag.Close();
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Yetkili yk = new Yetkili();
            yk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void koltukno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void sfrno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }
    }
}
