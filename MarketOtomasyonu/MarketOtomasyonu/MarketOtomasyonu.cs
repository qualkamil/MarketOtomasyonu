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
    public partial class MarketOtomasyonu: Form
    {
        public MarketOtomasyonu()
        {
            InitializeComponent();
        }

        public void SqlConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BKPBS63\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
            
        }

        private void yoneticiGiris_Click(object sender, EventArgs e)
        {
            YoneticiGirisPaneli yoneticiGirisPaneli = new YoneticiGirisPaneli();
            this.Hide();
            yoneticiGirisPaneli.Show();
            
        }

        private void personelGiris_Click(object sender, EventArgs e)
        {
            PersonelGirisPaneli personelGirisPaneli = new PersonelGirisPaneli();
            this.Hide();
            personelGirisPaneli.Show();
        }
    }
}
