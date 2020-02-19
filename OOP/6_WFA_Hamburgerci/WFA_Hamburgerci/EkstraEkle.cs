using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Hamburgerci
{
    public partial class EkstraEkle : Form
    {
        public EkstraEkle()
        {
            InitializeComponent();
        }

        private void BtnMenuKaydet_Click(object sender, EventArgs e)
        {
            SiparisEkle.ekstralar.Add(new Ekstra { EkstraAd = txtEkstraAdi.Text, Fiyat = nudFiyat.Value });
            MessageBox.Show(string.Format("{0} ekstra kaydedildi", txtEkstraAdi.Text));
            Fonksiyon.Temizle(this.Controls);
            
        }
    }
}
