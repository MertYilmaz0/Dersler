using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HazırMetotlar
{
    public partial class TarihMetotlari : Form
    {
        public TarihMetotlari()
        {
            InitializeComponent();
        }

        private void TarihMetotlari_Load(object sender, EventArgs e)
        {
            //günün tarihini ve şuanki saatini verir...
            lblTarih.Text = DateTime.Now.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //Günün tarihini alma
            lblTarih.Text = DateTime.Now.ToLongDateString();
            this.Text = DateTime.Now.ToShortDateString();

            //Tarih formatlama...
            lblTarih.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            //Haftanın Gününü Alma...
            lblTarih.Text = DateTime.Now.DayOfWeek.ToString();

            //Yılın gününü alma...
            string yilinKacinciGunu= DateTime.Now.DayOfYear.ToString();
            lblTarih.Text = "Bugün Yılın " + yilinKacinciGunu + ". günüdür";

         

        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //TimeSpan
            //İki zaman arasındaki farkı alıp size teslim eden nesnedir.

            //DateTime yeniZaman = new DateTime(1992, 09, 27, 01, 01, 59);

            //DateTime bugun = DateTime.Now;

            //TimeSpan zamanFarki = bugun - yeniZaman;
            //int toplamGun = Convert.ToInt32(zamanFarki.TotalDays);
            //MessageBox.Show("Mert toplam" + toplamGun + " gündür yaşıyorsun.. Uzun ömürler...");

            MessageBox.Show(YasadiginGunSayisi(20, 5, 1990));
        }

        string YasadiginGunSayisi(int gun, int ay, int yil)
        {
            DateTime zaman = new DateTime(yil, ay, gun);
            TimeSpan zamanFarki = DateTime.Now - zaman;
            int toplamGun = Convert.ToInt32(zamanFarki.TotalDays);
            string yasadiginGunSayisi = toplamGun.ToString();

            return yasadiginGunSayisi;
        }

    }
}
