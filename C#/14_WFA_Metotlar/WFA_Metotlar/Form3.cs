using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            //textbox1'e girilen ad ve textbox2'e girilen soyadı mesaj kutusunda birleştirerek gösterin.

            IsimsoyisimGoster(txtDeger1.Text, txtDeger2.Text);

        }

        void IsimsoyisimGoster(string ad, string soyad)
        {
            string isimSoyisim = ad + " " + soyad;
            MessageBox.Show(isimSoyisim);
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            TekmiCiftmi(Convert.ToInt32(textBox1.Text));
        }

        void TekmiCiftmi(int girilenDeger)
        {
            if (girilenDeger % 2 == 0)
            {
                MessageBox.Show("Sayı Çift");
            }
            else
            {
                MessageBox.Show("Sayı Tek");
            }
        }
    }
}
