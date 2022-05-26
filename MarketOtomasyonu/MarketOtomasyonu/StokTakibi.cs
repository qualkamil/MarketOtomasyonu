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

        private void cikisYap_Click(object sender, EventArgs e)
        {

            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }

        private void stokEkle_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string sorgu = "insert into Stok(BarkodNo,StokAd,StokMarka,StokAdet,SonAlinanBirimFiyat,SonEklenenAdet,SonEklenenTarih) " + //
                "values('" + barkodNo.Text + "','" + stokAdi.Text + "','" + stokMarka.Text + "','" + stokAdet.Text+"','"+ birimFiyat.Text + "','" + sonEklenenAdet.Text +"','"+sonEklenennTarih.Text.ToString()+"')";
            cmd = new SqlCommand(sorgu, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(barkodNo.Text + " barkod numralı " + stokAdi.Text + "başarıyla kaydedildi.");

        }
        
        private void StokTakibi_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            listeleme();
        }

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

        private void stokSil_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            int BarkodNo = Convert.ToInt32(stokListe.SelectedCells[0].Value);
            MessageBox.Show(Convert.ToString(BarkodNo));
            string sorgu = "Delete From Stok where BarkodNo = '"+BarkodNo+"'";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@BarkodNo", BarkodNo);
            cmd.ExecuteNonQuery();
            conn.Close();
            listeleme();
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String sorgu = "Update Stok set BarkodNo=@BarkodNo, StokAd=@StokAd, StokMarka=@StokMarka,StokAdet=@StokAdet,SonAlinanBirimFiyat= " +
                "@SonAlinanBirimFiyat,SonEklenenAdet=@SonEklenenAdet,SonEklenenTarih= @SonEklenenTarih";
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

        private void stokListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            barkodNo.Text = stokListe.Rows[e.RowIndex].Cells[0].Value.ToString();
            stokAdi.Text = stokListe.Rows[e.RowIndex].Cells[1].Value.ToString();
            stokMarka.Text = stokListe.Rows[e.RowIndex].Cells[2].Value.ToString();
            stokAdet.Text = stokListe.Rows[e.RowIndex].Cells[3].Value.ToString();
            birimFiyat.Text = stokListe.Rows[e.RowIndex].Cells[4].Value.ToString();
            sonEklenenAdet.Text = stokListe.Rows[e.RowIndex].Cells[5].Value.ToString();
            sonEklenennTarih.Text = stokListe.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
