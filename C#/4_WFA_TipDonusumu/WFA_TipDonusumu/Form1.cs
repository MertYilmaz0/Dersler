using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TipDonusumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Convert İşlemleri (Tip Dönüşümleri)

        veri tipleri arasında dönüşüm yapmak için kullanılır. Örnek vermek gerekirse C# programlama dilinde string ifadeler "çift tırnak" arasına yazılır. "125" string bir ifade iken aynı zamanda sayıdır. 125 ifadesini çift tırnak içerisine almadığımızda rakamlar olarak tanımlamış oluruz. Ancak 125 aynı zamanda metinsel oalrak ta tanımlanabilir. Bu tip durumlarda Convert sınıfını kullanarak tipleri birbirleri arasında dönüşümünü gerçekleştirebiliriz.

                Kapalı Dönüşüm (Implicit Conversion): Dönüştürme işlemini C# kendisi yapar.

                Açık Dönüşüm (Explicit Conversion): Tipler arasındaki dünüştürme işlemini gerçekleştiririz. Fakat dönüştürme işlemini biz (Programcı) gerçekleştirir.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            //Kapalı Dönüşüm
            byte s1 = 55;
            int s2 = s1;

            char karakter = 'b';//98
            int karakterKodu = karakter;


            MessageBox.Show(karakterKodu.ToString());

            //MessageBox.Show(s2.GetType().ToString());

            //Convert Sınıfı
            string cevirilecekDeger = "125";
            //int ceviriInt = cevirilecekDeger; //hata alırız.

            //Int
            int ceviriInt = Convert.ToInt32(cevirilecekDeger);

            //byte
            byte ceviriByte = Convert.ToByte(cevirilecekDeger);

            //short
            short ceviriShort = Convert.ToInt16(cevirilecekDeger);

            /*
             ToInt16=> short
             ToInt32=> int
             ToInt64=> long
             */
            
            MessageBox.Show(ceviriInt.ToString());

            #region Listbox kullanımı
            //listBox1.Items.Add("C#");
            //listBox1.Items.Add("OOP");
            //listBox1.Items.Add(15);
            //listBox1.Items.Add(15.5);
            //listBox1.Items.Add(true); 
            #endregion

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //kullanıcıdan almış olduğunuz sayıyı 8 ile toplayın. Sonucu label'da yazdırın.
            string gelenDeger = txtSayi1.Text;
            int sayi = Convert.ToInt32(gelenDeger);
            int toplam = sayi + 8;
            //string sonuc = Convert.ToString(toplam);
            lblGetir.Text = toplam.ToString();

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan iki sayının toplamını lblToplam'da gösterin.

            
            //sayiBirin değerini al
            string sayiBir = txtSayiBir.Text;
            //sayiIkinin değerini al
            string sayiIki = txtSayiIki.Text;
            //sayiBir ile Sayiİkiyi topla
            int sayi1 = Convert.ToInt32(sayiBir);
            int sayi2 = Convert.ToInt32(sayiIki);
            int toplam = sayi1 + sayi2; 

            //string sonuc = Convert.ToString(toplam);
            //toplamı label'a yaz.
            lblToplam.Text = toplam.ToString();

        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            //string sayiBir = txtHesapMakinesiSayi1.Text;
            //string sayiIki = txtHesapMakinesiSayi2.Text;

            int sayiBir = Convert.ToInt32(txtHesapMakinesiSayi1.Text);
            int sayiIki = Convert.ToInt32(txtHesapMakinesiSayi2.Text);
            int toplam = sayiBir + sayiIki;
            lblHesapMakinesiSonuc.Text = toplam.ToString();
            listBox1.Items.Add("Toplam=" + toplam);
            //renk atama işlemi=>BackColor özelliği tip olarak Color tipi istediği için eşitliğin sağına color tipini tanımlamak zorundayız.
            btnToplama.BackColor = Color.Green;
        }

        private void btnCikartma_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(txtHesapMakinesiSayi1.Text);
            int sayiIki = Convert.ToInt32(txtHesapMakinesiSayi2.Text);
            //int fark = sayiBir - sayiIki;
            lblHesapMakinesiSonuc.Text = (sayiBir - sayiIki).ToString();
            listBox1.Items.Add("Fark sonuc=" + lblHesapMakinesiSonuc.Text);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtHesapMakinesiSayi1.Text) * Convert.ToInt32(txtHesapMakinesiSayi2.Text);
            lblHesapMakinesiSonuc.Text = sonuc.ToString();
            listBox1.Items.Add("Carpim Sonuc" + lblHesapMakinesiSonuc.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(txtHesapMakinesiSayi1.Text) / Convert.ToInt32(txtHesapMakinesiSayi2.Text);
            lblHesapMakinesiSonuc.Text = sonuc.ToString();
            listBox1.Items.Add("Bölme Sonuc" + lblHesapMakinesiSonuc.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtHesapMakinesiSayi1.Clear();
            txtHesapMakinesiSayi2.Clear();
            lblHesapMakinesiSonuc.Text = "";
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(txtHesapMakinesiSayi1.Text);
            int sayiIki = Convert.ToInt32(txtHesapMakinesiSayi2.Text);
            
            lblHesapMakinesiSonuc.Text = ((sayiBir + sayiIki)/2).ToString();
            listBox1.Items.Add("Ortalama Sonuc=" + lblHesapMakinesiSonuc.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(txtHesapMakinesiSayi1.Text);
            int sayiIki = Convert.ToInt32(txtHesapMakinesiSayi2.Text);

            lblHesapMakinesiSonuc.Text = ((sayiBir * sayiIki) / 100).ToString();
            listBox1.Items.Add("Yuzde Sonuc=" + lblHesapMakinesiSonuc.Text);
        }
    }
}
