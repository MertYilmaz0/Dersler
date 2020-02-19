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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Karar Yapıları
            /*
             C# programalama dilinde kod akışı yukarıdan aşağıya doğru hiç bir satır atlanmaksızın okuyarak devam eder. Yazılımcılar bazı durumlarda kod akışına yön vermesi gerekebilir. Bu tip durumlarda kod akışına yön verebilmek için kullanacağımı yapılara karar yapıları denir.

            3 temel karar yapısı karşımıza çıkmaktadır;
                1-IF-Else
                2-Switch Case
                3-(Ternary If)

            //Karşılaştırma operatörleri
            1) == (Karşılıklı iki değerin birbirine eşit olması durumu)
            2) !=(Karşılıklı iki değerin birbirine eşit olmaması durumu)
            3) < (Soldaki değerin sağdaki değerden küçük olması durumu)
            4) >(Soldaki değerin sağdaki değerden büyük olması durumu)
            5) <= (Soldaki değerin sağdaki değerden küçük olması veya eşit olması durumu)
            6) >=(Soldaki değerin sağdaki değerden büyük olması veya eşit olması durumu)


            //if() parantez içerisine sadece bool tip gönderilir. ve true döndüğü takdirde if bloğu tetiklenir.
            if(3<5) //true
            {
                    //eğer koşul true dönerse kod akışı buradan devam eder.
            }
            else
            {
                   //eğer koşul false dönerse kod akışı buradan devam eder.
            }


                
             */

        }

        private void btnNeYapmali_Click(object sender, EventArgs e)
        {
            bool karar = chkHavaDurumu.Checked;

            //MessageBox.Show(karar.ToString());

            //if (karar)
            //{
            //    MessageBox.Show("Şemsiyeni yanına al");
            //}
            //if (chkHavaDurumu.Checked==true)
            //{
            //    MessageBox.Show("Şemsiyeni yanına al");
            //}
            if (chkHavaDurumu.Checked)
            {
                MessageBox.Show("Şemsiyeni yanına al");
            }
            else
            {
                MessageBox.Show("Güneş gözlüğünü yanına al");
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //ToLower()=> yazının tamamını küçük harf olarak alır.
            //ToUpper()=> yazının tamamnını büyük harf olarak alır.
            string gelenDeger = txtKullaniciAdi.Text.ToLower();
            string dogruDeger = "admin";

            if(gelenDeger==dogruDeger)//true
            {
                MessageBox.Show("Hoşgeldin Admin");
            }
            else
            {
                lblBilgi.Text = "Hatalı kullanıcı adı";
            }

        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            
            try
            {
                string gelenDeger = txtSayisalDeger.Text;
                int sayisalDeger = Convert.ToInt32(gelenDeger);

                if (sayisalDeger >= 0 && sayisalDeger <= 100)
                {
                    MessageBox.Show("Doğru tanımlama! Girilen Değer"+sayisalDeger);
                }
                else
                {
                    if (sayisalDeger < 0)
                    {
                        MessageBox.Show("0 dan küçük bir değer giremezsiniz");
                    }
                    else
                    {
                        MessageBox.Show("100'den büyük bir değer giremezsiniz");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata meydana geldi!");
            }
        }
    }
}
 