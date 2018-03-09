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
    public partial class SehirIslem : Form
    {
        public SehirIslem()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        void FillDataGridView()
        {
            string sorgu = "SELECT * FROM il";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
        public void resetle()
        {
            ilplaka.Text = iladi.Text =  "";
            kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\save.png");
            label6.Text = "Save";
            sil.Enabled = false;
        }
        private void SehirIslem_Load(object sender, EventArgs e)
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
                if (label6.Text == "Save" && ilplaka.Text != "" && iladi.Text != "")
                {
                    string sorgu = "INSERT INTO il (ilPlaka,ilAdi) VALUES (@ilplk,@iladi)";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@ilplk", ilplaka.Text);
                    cmd.Parameters.Add("@iladi", iladi.Text);

                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                else if (label6.Text == "Update")
                {
                    string sorgu = "UPDATE il SET ilAdi=@iladi WHERE ilPlaka=@ilplk";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@iladi", iladi.Text);
                    cmd.Parameters.Add("@ilplk", ilplaka.Text);
                    
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

        private void reset_Click(object sender, EventArgs e)
        {
            resetle();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sorgu = "SELECT * FROM il WHERE ilPlaka=@ilplk";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@ilplk", ilplaka.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (ilplaka.Text != "" && iladi.Text != "" )
                {
                    if (dr.HasRows == true)
                    {
                        dr.Close();
                        string sorgu1 = "DELETE FROM il WHERE ilPlaka=@ilplk";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                        cmd1.Parameters.Add("@ilplk", ilplaka.Text);
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
                MessageBox.Show(ex.Message, "Bu kaydı silemezsiniz.");
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ilplaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                iladi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
                sil.Enabled = true;
                label6.Text = "Update";
                kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\settings.png");
                toolTip1.SetToolTip(kaydet, string.Format("Güncellemek için tıklayınız."));
                toolTip2.SetToolTip(sil, string.Format("Seçilen veriyi silmek için tıklayınız."));
            }
        }

        private void ilplaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void iladi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }
    }
}
