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
    public partial class FiyatYonetimi : Form
    {
        public FiyatYonetimi()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        private void arama_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String sorgu = "Select * from Fiyatlar where BarkodNo Like '" + barkodNo.Text + "'";
            da = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            da.Fill(ds, "Stok");
            fiyatListe.DataSource = ds.Tables[0];
            conn.Close();
        }


        //Yönetici Paneline Dönme
        private void cikisYap_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }

        private void fiyatGuncelle_Click(object sender, EventArgs e)
        {
            
            
            
            try
            {
                conn.Close();
                conn.Open();
                String sorgu = "Update Fiyatlar set SatisFiyati = '" + satisFiyati.Text + "'";
                cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(fiyatListe.SelectedCells[0].Value.ToString()+" barkod numaralı kaydın fiyatı "+satisFiyati.Text+" olarak güncellendi.");
            }
            catch(Exception)
            {
                MessageBox.Show("Bir Hata Meydana Geldi.");
                throw;
            }
            
            
        }

        private void FiyatYonetimi_Load(object sender, EventArgs e)
        {

        }
    }
}
