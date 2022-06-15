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
    public partial class SatisIslemleri : Form
    {
        public SatisIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        private void sil_Click(object sender, EventArgs e)
        {
            
        }
        
        private void urunEkle_Click(object sender, EventArgs e)
        {
                     
            conn.Close();
            string sorgu = "Select st.BarkodNo,st.StokAd,fiy.SatisFiyati from Stok st, Fiyatlar fiy where st.BarkodNo=fiy.BarkodNo and  st.BarkodNo = '" + barkodNo.Text + "'";

            dt = new DataTable();
            conn.Open();
            cmd = new SqlCommand(sorgu, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            satisListe.DataSource=dt;
                
            
            conn.Close();        
        }

        private void odeme_Click(object sender, EventArgs e)
        {
            string odeme;
            string val1 = satisListe.Rows[0].Cells[0].Value.ToString();
            string val2 = satisListe.Rows[0].Cells[1].Value.ToString();
            string val3 = satisListe.Rows[0].Cells[2].Value.ToString();
            if (kk.Checked == true)
            {
                odeme = kk.Text;
            }
            else
            {
                odeme = nakit.Text;
            }
            
            
            
            if (kk.Checked == true || nakit.Checked == true)
            {
                conn.Close();
                conn.Open();
                string sorgu = "insert into Satislar(BarkodNo,UrunAdi,SatisFiyati,OdemeSekli) values('" + val1 + "','" + val2 + "','" + val3 + "','" + odeme + "')";
                cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Ödeme Yöntemi Seçiniz.");
            }
            
            
            
            
        }

        private void cıkısYap_Click(object sender, EventArgs e)
        {
            PersonelPaneli personelPaneli = new PersonelPaneli();
            this.Hide();
            personelPaneli.Show();
        }
    }
}
