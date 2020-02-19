using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Arrays (Diziler)
            /*
                Aynı tip (string, int, bool, short, double ....) verileri tek bir yapı altında tutumamızı sağlayan yapılardır.
             */

            //int sayi = 10,20,50,100;

            int[] sayilar = new int[3];
            sayilar[0] = 50;
            sayilar[1] = 10;
            sayilar[2] = 5;
            //sayilar[3] = 100;
            //Eğer diziye eleman sayısının üzerinde bir değer gönderirseniz "IndexOutOfRangeException" hatası verecektir.

            MessageBox.Show(sayilar[0].ToString());

            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };


        }

        private void btnSinifListesi_Click(object sender, EventArgs e)
        {
            //öğrencilerin isimlerini butona tıklandığında listbox'a yazdırın.

            //string[] ogrenciler = new string[11];

            string[] ogrenciler = { "Mert", "Ahmet", "Selim", "İhsan", "Bilal", "Esat", "Hava", "Gülsen", "Emirhan", "Ahmet", "Reyhan", "Şeyma" };

            //MessageBox.Show(ogrenciler.Length.ToString());//dizinin eleman sayısını length özelliği ile ulaşabiliriz.

            for(int i=0; i<ogrenciler.Length; i++)//for döngüsü butona tıklayınca devreye girer integral 0--- 0 küçükse öğrencilerin uzunluğundan list boxa eklenip integral 1 artar.
            {
                //listBox1.Items.Add(ogrenciler[i]);
                listBox1.Items.Add(string.Format("Öğrenci Ad: {0}", ogrenciler[i]));
            }

            //length saymaya 1 den başladığı için eğer koşulunuzd i<=ogrenciler.Length bu 11 indexli diziyyi 12 olarak sayacağı için 12. index de outofrangeexception hatası verecektir.
        }

        private void btnEnkucukSayi_Click(object sender, EventArgs e)
        {
            // -34,-5,-768,-467,-657,-457,-999,-324

            //yukarıdaki sayıları dizi içerisinde tanımlayın. Ardından dizideki en küçük sayıyı mesaj kutusunda gösterin.

            int[] sayilar = { -34, -5, -768, -467, -657, -457, -999, -324 };// sayılar dizgi içerisine alınır.

            int enKucukSayi = sayilar[0];// bulamız gereken sayı en küçük sayı, hepsini kontrol edebilmesi için 0'ıncı sıradakinden başlıyoruz yani en baştaki.
            for(int i=0; i<sayilar.Length; i++)//for döngüsü başlıyor. integral i sıfır olarak başlıyor. i küçükse sayıların lengtinden if karar yapısı devreye girer. karar yapısından dönen i 1 artar.
            {
                if (enKucukSayi > sayilar[i])//eğer en küçük sayı küçükse sayı 1-2-3-4-5-6... dan 
                {
                    enKucukSayi = sayilar[i];// o sayı en küçük sayıya eşittir.
                }
            }
            MessageBox.Show(enKucukSayi.ToString());// son olarak bulunan en küçük sayı messagebox da gösterilir.

        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            //Aşağıdaki sayılarda kaç tane çift kaç tane tek sayı vardır kullanıcıya gösterin. tek sayıları lstTek isimli listbox'a, çift sayıları lstCift isimli listbox'a gönderin.

            //12,45,23,76,119,85,46,223,4,6,25

            int[] sayilar = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };// sayılar dizgiye alınır.
            int tekSayilar = 0;// tek sayılar değerimiz
            int ciftSayilar = 0;// çift sayılar değerimiz


            for(int i=0; i<sayilar.Length; i++)// for döngüsü başlıyor integral i=0 i küçükse sayının lenghtinden if karar yapısı devreye girer oradan dönen integral 1 artar.
            {
                if (sayilar[i] % 2 == 0)// eğer i nolu sayı 2ye bölününce kalan 0 ise
                {
                    ciftSayilar++; // çift yası adedi 1 artar.
                    lstCift.Items.Add(sayilar[i]);  // sayı lstçift e gider.
                }
                else
                {
                    tekSayilar++;// 2 ye bölünmüyorsa tek sayılar 1 artar.
                    lstTek.Items.Add(sayilar[i]);// sayı lsttek e gider.
                }
            }
            MessageBox.Show(string.Format("Tek sayıların toplamı: {0}\nÇift sayıların toplamı: {1}", tekSayilar, ciftSayilar));
        }
    }
}
