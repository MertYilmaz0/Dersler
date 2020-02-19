using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For Döngüsü: Bir işi belirli sayıda yapmamızı sağlayan döngüdür. Döngü içerisinde döngünün başlangıç değeri, bitiş değeri ve artış miktarını doğrudan tanımlanmalıdır.

            //int i = 1;
            //while (i <= 100)
            //{
            //    listBox1.Items.Add(i);
            //    i++;
            //}

            //for döngüsü syntax:

            /*
                for(<dongununBaslangicDeger>; <sart>; iterasyon)
                {
                    //döngünün her döndüğünde çalışacak olan kodları.
                }
             */

            //for(int i = 1; i <= 100; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan sayının faktoriyel sonucunu mesaj kutusunda for döngüsü kullanarak gösterin. 

            //int sonuc = 1;
            //int sayac = 1;
            //while (sayac <= Convert.ToInt32(txtFaktoriyel.Text))
            //{
            //    sonuc *= sayac;
            //    sayac++;
            //}
            //MessageBox.Show(sonuc.ToString());

            int sayi = Convert.ToInt32(txtFaktoriyel.Text);// kullanıcıdan alınan değer
            int sonuc = 1;//sonuç

            for (int i = 1; i <= sayi; i++)//başlangıç değeri int i=1 olarak belirliyoruz ve i girilen sayıdan küçük yada eşitse alttaki komut satırı devreye giriyor.
            {
                sonuc *= i;// burada i sonuçla çarpılarak sonuca aktarılıyor ve bir üst satırdaki for koşuluna dönüp 1 artıyor. i girilen sayi ile eşitlenince döngü duruyor. Yani verilen döngü limitine ulaşmış oluyor.
            }
            MessageBox.Show(sonuc.ToString());
        }

        private void btnBindenBire_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// bir önceki for döngüsü ile yaptığımız faktöriyel işleminin sonucunu siliyor.
            for(int i = 1000; i >= 1; i--)//integral sayımız 1000... 1000 büyük yada eşit olmadığı için alttaki komut satırı devreye giriyor 
            {
                listBox1.Items.Add(i);//integral sayımız listboxa ekleniyor ve for döngüsüne geri dönerek bir eksiliyor. Böylece 1000 den 1 e kadar sayıları sıralamış oluyoruz.
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayıların toplamını mesaj kutusunda gösterin.
            //int toplam = 0;
            //for(int i=1; i>=toplam; i++)
            //{
            //    toplam += i;
            //    toplam++;
            //}
            //MessageBox.Show(toplam.ToString());
            int toplam = 0;// toplam değe butona tıkladığımız anda 0 olarak atanıyor.
            for(int i = 0; i <= 100; i++)// integral 0 olarak başlıyor ve 100den küçük yada eşite alttaki komutla beraber toplama eklenerek integral değeri 1 artıyor.
            {
                toplam += i;
            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnAdanZye_Click(object sender, EventArgs e)
        {
            //listbox içerisine a'dan z'ye alfabeyi sıralayınız.
            for (char c = 'a'; c <= 'z'; c++)// harflerde arka planda sayılardan oluştuğu için char değeri olarak en başa a harfini atıyoruz(char c=a). Ve değerimiz z harfinden küçük olduğu sürece alttaki komut satırı devreye giriyor.Komuttan dönen harf 1 artıyor yani sonraki harfe geçiyor.
            {
                //listBox1.Items.Add(c);
                //listBox1.Items.Add(c + " " + Convert.ToInt32(c));
                listBox1.Items.Add(
                    string.Format(
                        "Harf:{0} Kod:{1}", c, Convert.ToInt32(c)
                        )// gelen harf girdiğimiz sıra doğrultusunda listboxa string formatta ekleniyor.
                    );
            }

            
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki tek sayıların toplamı ile çift sayıların toplamının farklarının karesi kaçtır?

            int ciftToplam = 0;
            int tekToplam = 0;


            for(int i=1; i<=100; i++)//integralimizi 1 alıyoruz i 100'e küçük yada eşitse aşağıdaki if karar yapısı devreye giriyor. karar yapısı tamamlandıktan sonra i 1 artıyor.
            {
                if (i % 2 == 0)// eğer i'nin 2ye bölümünden kalan 0 ise alttaki komut satırı devreye girer.
                {
                    ciftToplam += i;//i çifttoplam değerine toplanarak eklenir.
                }
                else
                {
                    tekToplam += i;// eğer 2 ye bölümden kalan 0 değil ise tektoplam değerine toplanarak eklenir.
                }
            }

            int sonuc = (ciftToplam - tekToplam)*(ciftToplam - tekToplam);//i'nin for döngüsü bitince sonuçlar buraya aktarılır ve diğer iki işlemden geçerek sonuç mesaj olarak gösterilir.
            MessageBox.Show(sonuc.ToString());

        }
    }
}
