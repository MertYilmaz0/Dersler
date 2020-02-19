using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Hata Yönetimi

            yazılım dünyasında karşılaşılan 3 çeşit hata vardır;
                1-Syntax(söz dizimi) hatası
                2-Runtime (Çalışma zamanı) hataları
                3-Logical(Mantıksal) hataları

             */
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = sayi1 + sayi2;

            MessageBox.Show(toplam.ToString());
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            //Try Catch
            try
            {
                int sayi1 = Convert.ToInt32(txtSayiBir.Text);
                int sayi2 = Convert.ToInt32(txtSayiIki.Text);

                int toplam = sayi1 + sayi2;
                MessageBox.Show(toplam.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz");
            }

            //BreakPoint=> Duraklama noktası
        }
    }
}
 