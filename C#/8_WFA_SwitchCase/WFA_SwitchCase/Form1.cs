using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int a = 1;

            //if (a == 1)
            //{
            //    MessageBox.Show("sayı 1 e eşit");
            //}
            //else if (a == 2)
            //{
            //    MessageBox.Show("sayı 2 e eşit");

            //}
            //else if (a == 3)
            //{
            //    MessageBox.Show("sayı 3 e eşit");
            //}
            //else if (a == 4)
            //{
            //    MessageBox.Show("sayı 4 e eşit");
            //}

            //Switch-Case

            /*
             If-Else mantığıyla çalışan bir kontrol mekanizmasıdır. Aradaki fark; if-else yapısı büyüklük-küçüklük durumlarını kontrol ederken, switch-case yalnızca eşitlik durumunu kontrol eder. Kendisine ait bit index mekanizması ile koşulları algılar.
             */


            //Dışarıdan bir mevsim girilsin, aylar dönsün...
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string mevsim = txtDeger.Text.ToLower();//txtdeğere bir değer girmemiz isteniyor.(örn: kış)

            #region If else
            //if (mevsim == "yaz")
            //{
            //    MessageBox.Show("Haziran\nTemmuz\nAğustos");
            //}
            //else if (mevsim == "sonbahar")
            //{
            //    MessageBox.Show("Eylül\nEkim\nKasım");
            //}
            //else if (mevsim == "kış")
            //{
            //    MessageBox.Show("Aralık\nOcak\nŞubat");
            //}
            //else if (mevsim == "ilkbahar")
            //{
            //    MessageBox.Show("Mart\nNisan\nMayıs");
            //}
            //else
            //{
            //    MessageBox.Show("Böyle bir mevsim duymadım");
            //} 
            #endregion
            string mesaj = "";

            switch (mevsim)//kış
            {
                case "kış":
                case "ayaz":
                    mesaj = "Aralık-Ocak-Şubat";// koşulu gerçekleştirdiğimiz için mesaj değeri içine aralık ocak şubat geliyor.
                    break;
                case "ilkbahar":
                    mesaj = "Mart-Nisan-Mayıs";
                    break;
                case "yaz":
                    mesaj = "Haziran-Temmuz-Ağustos";
                    break;
                case "sonbahar":
                    mesaj = "Eylül-Ekim-Kasım";
                    break;
                    //Default=> öngörülen bir durum harici değerle karşılaşırsak, varsayılan olarak karar yapısı ne gibi bir işlem uygulasın? default tamamen opsiyoneldir. 
                default://case koşulları dışında herhangi birşey girilmesi durumunda da alttaki kod satırı devreye giriyor
                    mesaj = "Böyle bir mevsim duymadım";
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //Eğer textbox a  "Admin","Moderatör","Yönetici","Ceo","Başkan" girilirse "Yönetim paneline yönlendiriliyorsunuz..."
            //"üye" girilirse "anasayfaya yönlendiriliyorsunuz"
            //harici bir durumda "bu sayfayı görüntülemeye yetkiniz yok!"
            //mesajını kullanıcıya gösterin.

            string deger = txtDeger.Text;//bir değer girmemiz isteniyor textbox içine.
            string mesaj = "";//mesaj değerimiz şu an boş... doldurmak için switch case koşulumuza giridyor.
            switch (deger)//eğer değer case koşullarından biri ile eşleşiyorsa o koşulların altındaki mesaj değerini alıyor.
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "ceo":
                case "başkan":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz...";
                    break;
                case "üye":
                    mesaj = "anasayfaya yönlendiriliyorsunuz";
                    break;
                default:
                    mesaj = "Bu sayfayı görüntülemeye yetkiniz bulunmamaktadır";
                    break;
            }
            MessageBox.Show(mesaj);

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //Kullanıcı Adı: "bilgeadam"
            //Şifre:"1234"

            //Eğer kullanıcı txtDeger isimli textbox a girmiş olduğu değer "bilgeadam" ve txtDeger2'ye girilen değer "1234" ise "Tebrikler hem kullanıcı adı hem de şifreniz doğru" uyarısını versin
            //kullanıcı adı doğru şifre yanlışsa "kullanıcı adınız doğru ancak şifreniz yanlış",
            //kullanıcı adı yanlışsa "kullanıcı adınız yanlış, şifreye bakmadım bile!" uyarısını kullanıcıya mesaj kutusunda gösterin.    

            string kullaniciAdi = txtDeger.Text;
            string sifre = txtDeger2.Text;
            string mesaj = "";

            switch (kullaniciAdi)//bilgeadam
            {
                case "bilgeadam":
                    switch (sifre)//1234
                    {
                        case "1234":
                            mesaj = "Tebrikler hem kullanıcı adı hem de şifreniz doğru";
                            break;
                        default:
                            mesaj = "kullanıcı adınız doğru ancak şifreniz yanlış";
                            break;
                    }
                    break;
                default:
                    mesaj = "kullanıcı adınız yanlış, şifreye bakmadım bile!";
                    break;
            }

            MessageBox.Show(mesaj);

        }
    }
}
