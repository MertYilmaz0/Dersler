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
    public partial class SiparisBilgileri_ : Form
    {
        public SiparisBilgileri_()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri__Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdet = 0;
            foreach (Siparis item in SiparisEkle.siparisler)
            {
                ciro += item.ToplamTutar;
                foreach (Ekstra ekstra in item.EkstraMalzemesi)
                {
                    ekstraMalzemeGeliri += ekstra.Fiyat;
                }
                satisAdet += item.Adet;


                listBox1.Items.Add(item);
            }

            lblSiparisSayisi.Text = listBox1.Items.Count.ToString();
            lblCiro.Text = ciro.ToString();
            lblEkstraGelir.Text = ekstraMalzemeGeliri.ToString();
            lblUrunAdet.Text = satisAdet.ToString();
        }
    }
}
