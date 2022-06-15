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
    public partial class PersonelPaneli: Form
    {
        public PersonelPaneli()
        {
            InitializeComponent();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            MarketOtomasyonu marketOtomasyonu = new MarketOtomasyonu();
            this.Hide();
            marketOtomasyonu.Show();
        }

        private void satisIslemleri_Click(object sender, EventArgs e)
        {
            SatisIslemleri satisIslemleri = new SatisIslemleri();
            this.Hide();
            satisIslemleri.Show();
        }
    }
}
