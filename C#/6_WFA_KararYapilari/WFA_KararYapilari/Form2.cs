using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBilgiKontrol_Click(object sender, EventArgs e)
        {
            //txtDeger1'e girilen değer "admin" ise ve txtDeger2'e girilen değer "1234" ise "tebrikler tüm bilgileri doğru girdiniz" uyarısını kullanıcıya verin, değilse "yanlış bilgi girildi" uyarısından sonra butonu kaybedin.  

            //eğer if koşulundan sonra true değer geldiği takdirde tek bir satır kod yazılacaksa {} kullanmayabilirsiniz.
            if (txtDeger1.Text == "admin" && txtDeger2.Text == "1234")MessageBox.Show("tebrikler tüm bilgileri doğru girdiniz");
            else
            {
                MessageBox.Show("yanlış bilgi girildi");
                btnBilgiKontrol.Visible = false;
            }

        }

        private void btnNotKontrol_Click(object sender, EventArgs e)
        {
            //txtDeger1'e girilen not,
            /*
                //0-30 aralığında ise "FF",
                //31-50 aralığında ise "DD",
                //51-70 aralığında ise "BB",
                //71-100 aralığında ise "AA"

            aldınız şeklinde kullanıcıya mesaj veriniz. Farklı bir not girilmesi durumunda "girilen not geçerli değildir" uyarısını verdirin.

                1. txtDeger1'in değerini int çevir.
                2- deger 0-30 aralığında ise "FF",
                3- deger 31-50 aralığında ise "DD",
                4- deger 51-70 aralığında ise "BB",
                5- deger 71-100 aralığında ise "AA"

            txtDeger1 girilen değerin %30'nu al
            txtDeger2'e girilen değerin %70 ni al
            sonuc olarak teslim edilen ortalamanın harf notunu kullanıcıya göster.
             */

            #region harf notu
            //try
            //{
            //    int not = Convert.ToInt32(txtDeger1.Text);
            //    if (not >= 0 && not <= 30)
            //    {
            //        MessageBox.Show("Herf Notu: FF");
            //    }
            //    else if (not >= 31 && not <= 50)
            //    {
            //        MessageBox.Show("Herf Notu: DD");
            //    }
            //    else if (not >= 51 && not <= 70)
            //    {
            //        MessageBox.Show("Herf Notu: BB");
            //    }
            //    else if (not >= 71 && not <= 100)
            //    {
            //        MessageBox.Show("Herf Notu: AA");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Girilen not geçerli değil.");
            //    }
            //}
            //catch(OverflowException)
            //{
            //    MessageBox.Show("sayı çok büyük");
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("girilen değer sayısal bir değer değil");
            //}
            //catch 
            //{
            //    MessageBox.Show("bir şeyler oldu!");
            //} 
            #endregion

            int vize = Convert.ToInt32(txtDeger1.Text);
            int final = Convert.ToInt32(txtDeger2.Text);

            double ortalama = vize * 0.30 + final * 0.70;

            if (ortalama >= 0 && ortalama <= 30)
            {
                MessageBox.Show("Herf Notu: FF");
            }
            else if (ortalama >= 31 && ortalama <= 50)
            {
                MessageBox.Show("Herf Notu: DD");
            }
            else if (ortalama >= 51 && ortalama <= 70)
            {
                MessageBox.Show("Herf Notu: BB");
            }
            else if (ortalama >= 71 && ortalama <= 100)
            {
                MessageBox.Show("Herf Notu: AA");
            }
            else
            {
                MessageBox.Show("Girilen not geçerli değil.");
            }
        }
    }
}
