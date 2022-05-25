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

namespace MarketOtomasyonu
{
    public partial class PersonelGirisPaneli: Form
    {
        public PersonelGirisPaneli()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");


        private void girisYap_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Select * From Personeller where PersonelKullaniciAdi='" + kullaniciAdi.Text +
                     "'and PersonelSifre='" + sifre.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    PersonelPaneli personelPaneli = new PersonelPaneli();
                    personelPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
