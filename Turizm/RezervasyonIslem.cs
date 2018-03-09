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
    public partial class RezervasyonIslem : Form
    {
        public RezervasyonIslem()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");

        void FillDataGridView()
        {
            bag.Open();
            string sorgu = "SELECT * FROM Rezervasyon WHERE Tc_No='"+YolcuKart.txtTcNo+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu,bag);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            bag.Close();
        }

        public void resetle()
        {
            skno.Text = rzrvid.Text = tcno.Text = sontrh.Text = "";
            sil.Enabled = false;
        }

        private void RezervasyonIslem_Load(object sender, EventArgs e)
        {
            resetle();
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

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                if(rzrvid.Text!="" && skno.Text!="" && tcno.Text!="" && sontrh.Text != "")
                {
                    string tcnosu = YolcuKart.txtTcNo;
                    if (tcnosu == tcno.Text)
                    {
                        string sorgu = "UPDATE Rezervasyon SET SKNo=@skno, Tc_No=@tcno, R_son_tarihi=@sontrh WHERE RezervasyonId=@rid";
                        SqlCommand cmd = new SqlCommand(sorgu, bag);
                        cmd.Parameters.Add("@skno", skno.Text);
                        cmd.Parameters.Add("@tcno", YolcuKart.txtTcNo);
                        cmd.Parameters.Add("@sontrh", sontrh.Text);
                        cmd.Parameters.Add("@rid", rzrvid.Text);
                        cmd.ExecuteNonQuery();
                        bag.Close();
                        FillDataGridView();
                        MessageBox.Show("Güncelleştirildi.");
                    }
                    else
                    {
                        MessageBox.Show("Hata!!!");
                    }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                rzrvid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                skno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tcno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sontrh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sil.Enabled = true;
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
                string sorgu = "SELECT * FROM Rezervasyon WHERE RezervasyonId=@rid";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.Add("@rid", rzrvid.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (rzrvid.Text != "" && skno.Text != "" && tcno.Text != "" && sontrh.Text!="")
                {
                    string tcnosu = YolcuKart.txtTcNo;
                    if (tcnosu == tcno.Text)
                    {
                        if (dr.HasRows == true)
                        {
                            dr.Close();
                            string sorgu1 = "DELETE FROM Rezervasyon WHERE RezervasyonId=@rid";
                            SqlCommand cmd1 = new SqlCommand(sorgu1, bag);
                            cmd1.Parameters.Add("@rid", rzrvid.Text);
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
                        MessageBox.Show("Hata!!!");
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
            BiletSatisGiris.gncl = false;
            YolcuKart yk = new YolcuKart();
            yk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
