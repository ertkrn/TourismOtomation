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
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        void FillDataGridView()
        {
            string sorgu = "SELECT * FROM Yetkili";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
        public void resetle()
        {
            yetkilino.Text = sifre.Text = "";
            kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\save.png");
            label6.Text = "Save";
            sil.Enabled = false;
        }
        private void YetkiliIslem_Load(object sender, EventArgs e)
        {
            resetle();
            label6.Text = "Save";
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
                if (label6.Text == "Save" && yetkilino.Text != "" && sifre.Text != "")
                {
                    string sorgu = "INSERT INTO Yetkili (YetkiliNo,Sifre) VALUES (@ytklno,@sifre)";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@ytklno", yetkilino.Text);
                    cmd.Parameters.Add("@sifre", sifre.Text);

                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                else if (label6.Text == "Update")
                {
                    string sorgu = "UPDATE Yetkili SET Sifre=@sifre WHERE YetkiliNo=@ytklno";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@ytklno", yetkilino.Text);
                    cmd.Parameters.Add("@sifre", sifre.Text);

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

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sorgu = "SELECT * FROM Yetkili WHERE YetkiliNo=@ytklno";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@ytklno", yetkilino.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (yetkilino.Text != "" && sifre.Text != "")
                {
                    if (dr.HasRows == true)
                    {
                        dr.Close();
                        string sorgu1 = "DELETE FROM Yetkili WHERE YetkiliNo=@ytklno";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                        cmd1.Parameters.Add("@ytklno", yetkilino.Text);
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

        private void reset_Click(object sender, EventArgs e)
        {
            resetle();
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                yetkilino.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sifre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                sil.Enabled = true;
                label6.Text = "Update";
                kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\settings.png");
                toolTip1.SetToolTip(kaydet, string.Format("Güncellemek için tıklayınız."));
                toolTip2.SetToolTip(sil, string.Format("Seçilen veriyi silmek için tıklayınız."));
            }
        }

        private void yetkilino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }
    }
}
