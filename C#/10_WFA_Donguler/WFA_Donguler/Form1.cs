using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde 1 den 100'a kadar rakamkarı listbox da listeleyin.

            //listBox1.Items.Add(1);
            //listBox1.Items.Add(2);
            //listBox1.Items.Add(3);
            //listBox1.Items.Add(4);
            //listBox1.Items.Add(5);
            //listBox1.Items.Add(6);
            //listBox1.Items.Add(7);
            //listBox1.Items.Add(8);
            //listBox1.Items.Add(9);
            //listBox1.Items.Add(10);

            //Döngüler

            /*
                Hazırlamış olduğumuz programlarda bir işi birden fazla kez yapılması gereken durumlarda döngüler kullanılır. 

                4 çeşit döngü bulunmaktadır;
                    1- While
                    2- Do while
                    3- For
                    4- Foreach
             */

            //While

            int sayac = 1;// sayaç şu anda 1 değerinde.
            string metin = "merhaba dünya";//Merhaba dünya yazılı string bir değerimiz var.

            while (sayac <= 10)//koşul belirtiyoruz. sayacımız 10 yada 10 dan küçükse alttaki komut satırı devreye girecek.
            {
                //listBox1.Items.Add(sayac+" "+metin);
                listBox1.Items.Add(string.Format("İndex Sırası:{0} Değer:{1}", sayac, metin));//listbox1'e string formatta bir adet item atıyoruz parantez içindeki sıralamaya göre...
                sayac++;// her item attıktan sonra da sayaç 1 artıyor.
                // sayaç 10 a ulaştığında yaptırmış olduğumuz tüm işlemler forma yükleniyor. ( Listboxa 10 kere merhaba dünya yazdırmış olduk)
            }



        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki tek sayıların toplamını ve çift sayıların toplamanı iligli labellarda gösterin.

            int sayac = 1;//int değerde bir sayaç oluşturuyoruz değer 1 olarak atıyoruz.
            int tekToplam = 0;
            int ciftToplam = 0;

            while (sayac <= 100)// sayacımız şu anda 1 yani koşula uyuyor ve alttaki karar yapısı devreye giriyor.
            {

                if (sayac % 2 == 0)// eğer sayaçdaki sayı(şu anda 1) 2 ile bölümünden kalan 0 ise alttaki komut satırı devreye giriyor
                {
                    ciftToplam += sayac;// sayaçtaki değer çift toplamların değerine toplanarak aktarılıyor.
                }
                else// eğer sayaçtaki sayı if koşulunu yani 2ye bölümünden kalan 0 çıkmıyor ise alttaki komut satırı devreye giriyor.
                {
                    tekToplam += sayac;//sayaçtaki sayı tektoplamlara toplanarak ekleniyor.
                }

                sayac++;// yukarıdaki karar yapısı her gerçekleştiğinde sayaç 1 artıyor.101 e geldiğinde ise döngü son buluyor ve alttaki komut satırı devreye giriyor
            }

            lblTekToplam.Text = tekToplam.ToString();// toplanarak artan tektoplam değeri string olarak lbltektoplama yazılıyor.
            lblCiftToplam.Text = ciftToplam.ToString();//toplanarak artan çifttoplam değeri string olarak lblçifttoplama yazılıyor.

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan değerin faktoriyel hesaplamasını label'da gösterin.

            //5
            //1*2*3*4*5 => 120


            //5
            //4
            //3
            //2
            //1
            int sonuc = 1;// int bir sonuç belirliyoruz 1 değeri atıyoruz.
            int sayac = Convert.ToInt32(txtFaktoriyel.Text);// int değerinde bir sayaç ekliyoruz. sayacın değeri kullanıcının faktöriyelinin hesaplanmasını istediği değer.
            while (sayac > 0)//sayaca kullanıcının vermiş olduğu değer girilip hesapla butonuna basıldığında while döngümüz şartını belirtiyor 0 dan büyük bir rakam girildiğinde alttaki komut satırı devreye giriyor.
            {
                //5*4
                sonuc *= sayac;// sayaca girdiğimiz değer sonuçla çarpılıp sonuca aktarılıyor. ilk etapta bu 1 olduğundan sayacın kendisini alıyor. Döngüdeki koşul sağlanmayana kadar sonuca çarpılıp aktarılan değer sayaçla çarpılmaya devam ediliyor.
                sayac--;//sayaca girilen değer 1 eksiliyor döngüye geri dönülüyor

            }
            if (sonuc == 0)
            {
                lblSonuc.Text = "Hata";
            }
            else
            {
                lblSonuc.Text = sonuc.ToString();// döngümüz son bulduğunda lblsonucun textine string formatta sonucumuz yazılıyor.
            }
            

            //MessageBox.Show(int.MaxValue.ToString());


        }
    }
}
