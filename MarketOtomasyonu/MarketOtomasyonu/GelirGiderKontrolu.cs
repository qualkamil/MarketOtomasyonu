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
    
    public partial class GelirGiderKontrolu: Form
    {
        public GelirGiderKontrolu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;



        //Veritabanındaki tarihleri comboBox'lara getirme
        private void GelirGiderKontrolu_Load(object sender, EventArgs e)
        {
            conn.Close();
            String sorgu = "select * from GelirGider";
            conn.Open();
            cmd = new SqlCommand(sorgu, conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                eklemeTarih.Items.Add(dr["Tarih"]);
                goruntulemeTarih.Items.Add(dr["Tarih"]);
            }
            conn.Close();
        }

        //girilen gider veya gelir değerlerini veritabanına ekleme
        private void giderekle_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string updateSorgu = "update GelirGider set "+gider.Text+" = '"+giderTutari.Text+"' where Tarih='"+eklemeTarih.Text+"'";
            try
            {
                cmd = new SqlCommand(updateSorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(eklemeTarih.Text + " tarihi için " + gider.Text + " ücreti " + giderTutari.Text + " olarak kaydedildi.");
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        //istenilen ayı görüntüleme
        private void goruntule_Click(object sender, EventArgs e)
        {
            conn.Close();
            string sorgu = "select * from GelirGider where Tarih = '" + goruntulemeTarih.Text + "'";
            conn.Open();
            da = new SqlDataAdapter(sorgu, conn);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "GelirGider");
            gelirGiderListe.DataSource = ds.Tables["GelirGider"];
            

        }

        //tüm ayları görüntüleme
        private void yillikGoruntule_Click(object sender, EventArgs e)
        {
            conn.Close();
            string sorgu = "select * from GelirGider";
            conn.Open();
            da = new SqlDataAdapter(sorgu, conn);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds, "GelirGider");
            gelirGiderListe.DataSource = ds.Tables["GelirGider"];
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }
    }
}
