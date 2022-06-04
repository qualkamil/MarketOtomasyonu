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
    public partial class PersonelYonetimi: Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;


        public void listeleme()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personeller", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Personeller");
            personelListe.DataSource = ds.Tables["Personeller"];
            conn.Close();
        }


        //YÖnetici Paneline Dönme
        private void cikisYap_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }


        //Personel Ekleme
        private void personelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                string sorgu = "Insert Into Personeller(PersonelAdi,PersonelSoyadi,PersonelKullaniciAdi,PersonelSifre) " +
                    "Values('" + ad.Text + "','" + soyad.Text + "','" + kullaniciAdi.Text + "','" + sifre.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("'"+kullaniciAdi.Text + "' kullanıcı adına sahip personel başarılı şekilde kaydedilmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata ile Karşılaşıldı. Bilgileri doğru girdiğinizden emin olun.");
            }
        }



        //datagridview listeleme
        private void PersonelYonetimi_Load(object sender, EventArgs e)
        {
            listeleme();
        }


        //Kaydı Silme
        private void personelSil_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string kullaniciAdi = Convert.ToString(personelListe.SelectedCells[2].Value);
                string sorgu = "Delete From Personeller where PersonelKullaniciAdi = '" + kullaniciAdi + "'";
                cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                listeleme();
            }catch(Exception)
            {
                MessageBox.Show("Silme işlemi için satırın tamamını seçiniz.");
            }
        }


        //kaydı güncelleme
        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                String sorgu = "Update Personeller set PersonelAdi='" + ad.Text + "', PersonelSoyadi = '" + soyad.Text + "', " +
                    "PersonelKullaniciAdi = '" + kullaniciAdi.Text + "',PersonelSifre= '" + sifre.Text + "' where PersonelKullaniciAdi = '" + kullaniciAdi.Text + "'";
                cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("'" + kullaniciAdi.Text + "' kullanıcı adlı personelin bilgileri başarıyla güncellendi.");
                listeleme();
            }catch(Exception)
            {
                MessageBox.Show("Kullanıcı Adının doğru olduğundan emin olunuz.");
            }
        }


        //Listeyi textboxa aktarma
        private void personelListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kullaniciAdi.Text = personelListe.Rows[e.RowIndex].Cells[2].Value.ToString();
                sifre.Text = personelListe.Rows[e.RowIndex].Cells[3].Value.ToString();
                ad.Text = personelListe.Rows[e.RowIndex].Cells[0].Value.ToString();
                soyad.Text = personelListe.Rows[e.RowIndex].Cells[1].Value.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Olmayan Satırı seçemezsiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
