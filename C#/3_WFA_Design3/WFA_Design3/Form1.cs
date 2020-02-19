using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Design3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;

            MessageBox.Show("Adınız: " + ad + "\nSoyadınız: " + soyad + "\nTelefon No: " + telefon + "\nEmail Adresi: " + email);

            //Mesaj kutusundan sonra ilgili TextBox'ların içini boşaltın.
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            txtTelefon.Clear();
            txtEmail.Text = "";

            //txtAd.Text = txtEmail.Text = txtTelefon.Text = txtSoyad.Text = string.Empty;


            //Kaydet butonuna tıklandığında;
            /*
                    txtAd.Text 'in değerini lblAd.Text'e gönder
                    txtSoyad.Text'in değerini lblSoyad.Text'e gönder
                    txtTelefon.Text'in değerini lblTelefon.Text'e gönder
                    txtMail.Text'in değerini lblMail.Text'e gönder.
         */

            //btnKaydet isimli butonun Click olayında zaten ilgili textboxların değerlerini ayrı ayrı değişkenlerde tuttuğumuz için direkt olarak değişkenleri ilgili labellara gönderebiliriz.
            lblAd.Text = ad;
            lblSoyad.Text = soyad;
            lblEmail.Text = email;
            lblTelefon.Text = telefon;
        }

        private void btnGizle_MouseHover(object sender, EventArgs e)
        {
            lblAd.Visible = lblSoyad.Visible = lblTelefon.Visible = lblEmail.Visible = false;
        }
    }
}
