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
    public partial class YardımSayfa : Form
    {
        public YardımSayfa()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-BK3DAJN;Initial Catalog=Turizm;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();

            string sorgu = "INSERT INTO Oneri (Baslik,İcerik) VALUES (@baslik,@icerik)";
            SqlCommand cmd = new SqlCommand(sorgu,bag);

            cmd.Parameters.Add("@baslik",textBox1.Text);
            cmd.Parameters.Add("@icerik",richTextBox1.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt oluşturuldu.");
            bag.Close();
        }
    }
}
