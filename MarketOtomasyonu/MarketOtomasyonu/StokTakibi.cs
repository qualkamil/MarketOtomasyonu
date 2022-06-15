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
    public partial class StokTakibi: Form
    {
        public StokTakibi()
        {
            InitializeComponent();
        }
        public void listeleme()
        {
            DataTable dt = new DataTable();
            dt.Clear();       
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Stok",conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"Stok");
            stokListe.DataSource = ds.Tables["Stok"];
            conn.Close();
        }
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;



        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");

        //Yonetici Paneline Dönme
        private void cikisYap_Click(object sender, EventArgs e)
        {

            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }
        

        //Stok Ekleme
        private void stokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string stokSorgu = "insert into Stok(BarkodNo,StokAd,StokMarka,StokAdet,SonAlinanBirimFiyat,SonEklenenAdet,SonEklenenTarih) " +
                    "values('" + barkodNo.Text + "','" + stokAdi.Text + "','" + stokMarka.Text + "','" + stokAdet.Text + "','" + birimFiyat.Text + "','"
                    + sonEklenenAdet.Text + "','" + sonEklenennTarih.Text.ToString() + "')";
                string fiyatSorgu = "insert into Fiyatlar(BarkodNo,StokAd)values('" + barkodNo.Text + "','" + stokAdi.Text + "')";
                SqlCommand stokCmd = new SqlCommand(stokSorgu, conn);
                SqlCommand fiyatCmd = new SqlCommand(fiyatSorgu, conn);
                stokCmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                fiyatCmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show(barkodNo.Text + " barkod numralı " + stokAdi.Text + " başarıyla kaydedildi.");
                listeleme();
            }
            catch(Exception)
            {
                MessageBox.Show(barkodNo.Text + " barkod numaralı kayıt zaten var.");
                throw;
            }
            
        }

       
        

        //Form Load sırasında datagridview veri çekme
        private void StokTakibi_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        //buton ile datagridview veri çekme
        private void listele_Click(object sender, EventArgs e)
        {
            listeleme();
        }


        //Barkod no ile arama
        private void barkodArama_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String sorgu = "Select * from Stok where BarkodNo Like '" + barkodNoArama.Text + "'";
            da = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            da.Fill(ds, "Stok");
            stokListe.DataSource = ds.Tables[0];
            conn.Close();
        }


        //stok silme
        private void stokSil_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                int BarkodNo = Convert.ToInt32(stokListe.SelectedCells[0].Value);
                string stokSorgu = "Delete From Stok where BarkodNo = '" + BarkodNo + "'";
                string fiyatSorgu = "Delete From Fiyatlar where BarkodNo = '" + BarkodNo + "'";
                cmd = new SqlCommand(stokSorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                cmd = new SqlCommand(fiyatSorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                listeleme();
            }catch(Exception)
            {
                MessageBox.Show("Silmek istediğiniz kaydın Barkod Numarasını Seçiniz.");
            }
        }


        //Stokno ile arama
        private void StokAdArama_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String sorgu = "select * from Stok where StokAd Like'" + stokAdiArama.Text + "'";
            da = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            da.Fill(ds, "Stok");
            stokListe.DataSource = ds.Tables[0];
            conn.Close();
        }


        //Stok Güncelleme
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            int barkodNu = Convert.ToInt32(barkodNo.Text);
            String sorgu = "Update Stok set BarkodNo=@BarkodNo, StokAd=@StokAd, StokMarka=@StokMarka,StokAdet=@StokAdet,SonAlinanBirimFiyat= " +
                "@SonAlinanBirimFiyat,SonEklenenAdet=@SonEklenenAdet,SonEklenenTarih= @SonEklenenTarih where BarkodNo = '"+barkodNu+"'";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@BarkodNo", barkodNo.Text);
            cmd.Parameters.AddWithValue("@StokAd", stokAdi.Text);
            cmd.Parameters.AddWithValue("@StokMarka", stokMarka.Text);
            cmd.Parameters.AddWithValue("@StokAdet", stokAdet.Text);
            cmd.Parameters.AddWithValue("@SonAlinanBirimFiyat", birimFiyat.Text);
            cmd.Parameters.AddWithValue("@SonEklenenAdet", sonEklenenAdet.Text);
            cmd.Parameters.AddWithValue("@SonEklenenTarih", sonEklenennTarih.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            listeleme();
        }


        //Datagridview'deki verileri textbox ekleme
        private void stokListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                barkodNo.Text = stokListe.Rows[e.RowIndex].Cells[1].Value.ToString();
                stokAdi.Text = stokListe.Rows[e.RowIndex].Cells[0].Value.ToString();
                stokMarka.Text = stokListe.Rows[e.RowIndex].Cells[2].Value.ToString();
                stokAdet.Text = stokListe.Rows[e.RowIndex].Cells[3].Value.ToString();
                birimFiyat.Text = stokListe.Rows[e.RowIndex].Cells[4].Value.ToString();
                sonEklenenAdet.Text = stokListe.Rows[e.RowIndex].Cells[5].Value.ToString();
                sonEklenennTarih.Text = stokListe.Rows[e.RowIndex].Cells[6].Value.ToString();
            }catch (Exception)
            {
                MessageBox.Show("Olmayan Satırı seçemezsiniz.");
            }

        }

        
    }
}
