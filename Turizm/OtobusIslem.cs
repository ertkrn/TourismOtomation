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
    public partial class OtobusIslem : Form
    {
        public OtobusIslem()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        void FillDataGridView()
        {
            string sorgu = "SELECT * FROM Otobus";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bag);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
        public void resetle()
        {
            otoid.Text = oilplaka.Text = okoltuksayisi.Text = markaid.Text = modelid.Text = "";
            kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\save.png");
            label6.Text = "Save";
            sil.Enabled = false;
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                if (label6.Text == "Save" && oilplaka.Text!="" && okoltuksayisi.Text!="" && markaid.Text!="" && modelid.Text!="")
                {
                    string sorgu = "INSERT INTO Otobus (OilPlaka,OKoltukSayisi,MarkaId,ModelId) VALUES (@oilplaka,@okoltuksayisi,@markaid,@modelid)";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@oilplaka", oilplaka.Text);
                    cmd.Parameters.Add("@okoltuksayisi", okoltuksayisi.Text);
                    cmd.Parameters.Add("@markaid", markaid.Text);
                    cmd.Parameters.Add("@modelid", modelid.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                else if(label6.Text=="Update")
                {
                    string sorgu = "UPDATE Otobus SET OilPlaka=@oilplaka, OKoltukSayisi=@okoltuksayisi, MarkaId=@markaid, ModelId=@modelid WHERE OtobusId=@oid";
                    SqlCommand cmd = new SqlCommand(sorgu, bag);
                    cmd.Parameters.Add("@oid",otoid.Text);
                    cmd.Parameters.Add("@oilplaka", oilplaka.Text);
                    cmd.Parameters.Add("@okoltuksayisi", okoltuksayisi.Text);
                    cmd.Parameters.Add("@markaid", markaid.Text);
                    cmd.Parameters.Add("@modelid", modelid.Text);
                    cmd.ExecuteNonQuery();
                    FillDataGridView();
                    MessageBox.Show("Güncelleştirildi.");
                }
                else
                {
                    MessageBox.Show("Alanları boş bırakmayınız.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message");
            }
            finally
            {
                bag.Close();
            }
        }

        private void OtobusIslem_Load(object sender, EventArgs e)
        {
            resetle();
            label6.Text = "Save";
            sil.Enabled = false;
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message");
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            resetle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                otoid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                oilplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                okoltuksayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                markaid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                modelid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                sil.Enabled = true;
                label6.Text = "Update";
                kaydet.Image = Image.FromFile("D:\\Ders Notları\\Görsel Programlama\\Proje\\İcon\\settings.png");
                toolTip1.SetToolTip(kaydet,string.Format("Güncellemek için tıklayınız."));
                toolTip2.SetToolTip(sil, string.Format("Seçilen veriyi silmek için tıklayınız."));
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Yetkili yk = new Yetkili();
            yk.Show();
            this.Hide();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sorgu = "SELECT * FROM Otobus WHERE OtobusId=@osid";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@osid",otoid.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (otoid.Text!="" && okoltuksayisi.Text!="" && oilplaka.Text!="" && markaid.Text!="" && modelid.Text!="")
                {
                    if (dr.HasRows == true)
                    {
                        dr.Close();
                        string sorgu1 = "DELETE FROM Otobus WHERE OtobusId=@osid";
                        SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                        cmd1.Parameters.Add("@osid", otoid.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otoid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void oilplaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void okoltuksayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void markaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }

        private void modelid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kaydet.PerformClick();
            }
        }
    }
}
