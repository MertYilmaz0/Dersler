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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void BtnMenuKaydet_Click(object sender, EventArgs e)
        {
            SiparisEkle.menuler.Add(new Menu { MenuAd = txtMenuAdi.Text, MenuFiyat = nudFiyat.Value });
            Fonksiyon.Temizle(this.Controls);
            MessageBox.Show("Menü başarıyla eklendi");
        }
    }
}
