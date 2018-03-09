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
    public partial class Listeleme : Form
    {
        public Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        private void Listeleme_Load(object sender, EventArgs e)
        {
            if (BiletSatisGiris.x == true)
            {
                bag.Open();
                listView1.Items.Clear();
                string sorgu = "SELECT * FROM Rezervasyon WHERE Tc_No='" + YolcuKart.txtTcNo + "'";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["RezervasyonId"].ToString();
                    lvi.SubItems.Add(dr["SKNo"].ToString());
                    lvi.SubItems.Add(dr["Tc_No"].ToString());
                    lvi.SubItems.Add(dr["R_son_tarihi"].ToString());

                    listView1.Columns.Clear();
                    listView1.Columns.Add("RezervasyonId");
                    listView1.Columns.Add("SKNo");
                    listView1.Columns.Add("Tc_No");
                    listView1.Columns.Add("R_son_tarihi");
                    listView1.Items.Add(lvi);
                }

                bag.Close();
            }
            else
            {
                bag.Open();
                string sorgu = "SELECT * FROM Sepet WHERE Tc_No='" + YolcuKart.txtTcNo + "'";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["BiletNo"].ToString();
                    lvi.SubItems.Add(dr["Tc_No"].ToString());
                    lvi.SubItems.Add(dr["SKNo"].ToString());
                    lvi.SubItems.Add(dr["GNoBaslangic"].ToString());
                    lvi.SubItems.Add(dr["GNoBitis"].ToString());
                    lvi.SubItems.Add(dr["FaturaId"].ToString());
                    lvi.SubItems.Add(dr["SigortaId"].ToString());
                    lvi.SubItems.Add(dr["Ucret"].ToString());
                    listView1.Items.Add(lvi);
                }

                bag.Close();
            }
            
        }

        private void geri_Click(object sender, EventArgs e)
        {
            SatisListeleme sl = new SatisListeleme();
            sl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
