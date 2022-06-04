using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class YoneticiPaneli: Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StokTakibi stokTakip = new StokTakibi();
            this.Hide();
            stokTakip.Show();
        }

        private void fiyetYönetimi_Click(object sender, EventArgs e)
        {
            FiyatYonetimi fiyatYonetimi = new FiyatYonetimi();
            this.Hide();
            fiyatYonetimi.Show();
        }

        private void gelirGiderKontrolu_Click(object sender, EventArgs e)
        {
            GelirGiderKontrolu gelirGiderKontrolu = new GelirGiderKontrolu();
            this.Hide();
            gelirGiderKontrolu.Show();
        }

        private void personelYonetimi_Click(object sender, EventArgs e)
        {
            PersonelYonetimi personelYonetimi = new PersonelYonetimi();
            this.Hide();
            personelYonetimi.Show();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            MarketOtomasyonu marketOtomasyonu = new MarketOtomasyonu();
            this.Hide();
            marketOtomasyonu.Show();
        }
    }
}
