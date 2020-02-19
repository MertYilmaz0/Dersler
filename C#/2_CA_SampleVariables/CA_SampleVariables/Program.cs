using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SampleVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //eğer kodlarınızı simge haline dönüştürmek istiyorsanız; 
            //kodları seçtikten sonra CTRL+K+S tuş kombinasyonu ile region ekleyebilirsiniz 


            #region Tanımlanacak Değerler
            /*
                 ad
                 soyad
                 tckimlik no
                 telefon no
                 boy
                 yaş
                 kilo
                 evli misin
                 ehliyetin var mı
                 adres
                 kapı no
                 ingilizce biliyor musun
                 bugün günlerden ne
                 ev kira mı
                 okul adı
                 çalışıyor musun
                 şu an hangi dili öğreniyorsun
                 bildiğiniz programlama dilleri
                 doğum yılı
                 doğum yeri
                 baba adı
                 anne adı
                 anne kızlık soyadı
                 aile sıra numarası


                 */
            #endregion

            #region Değişkenler
            //string ad = "Fatih";
            //string soyad = "Günalp";
            //string tcKimlikNo = "54654654456";
            //byte boy = 175;
            //byte yas = 35;
            //byte kilo = 72;
            //bool evliMisin = false;
            //bool ehliyetVarMi = true;
            //string adres = "ev adresi...";
            //string kapiNo = "35";
            //bool ingilizceBiliyorMusun = true;
            //string gunAdi = "Çarşamba";
            //ushort dogumYili = 1990;
            #endregion

            #region Değişken Çağırma
            //Console.Write()=> bağlı bulunduğu satıra yazar
            //Console.WriteLine()=>değeri ekrana yazar imleci bir satır aşağıya kaydırır.

            //Ctrl+k+c tuş kombinasyonu ile yorum satırını aktif edebilirsiniz.
            //Ctrl+k+u tuş kombinasyonu ile yorum satını devredışı bırakabilirsiniz.

            //Console.WriteLine(ad);
            //Console.WriteLine(soyad);
            //Console.WriteLine(tcKimlikNo);
            //Console.WriteLine(boy);

            //Console.WriteLine(ad + " " + soyad + " " + tcKimlikNo + " " + adres + " " + gunAdi); 
            #endregion

            #region Satır atlama
            // \n=> bir alt satıra geçmek için kullanılır.

            //string ikiSatirlikMetin = "Burası birinci satır\nBurası ikinci satır\nburası da üçüncü satır";
            //Console.WriteLine(ikiSatirlikMetin);

            //Console.Read(); 
            #endregion


            string ad, soyad, adres;
            int frekans = 500;
            int sure = 1000;
            //int sayi1, sayi2, sayi3;
            //byte byteBir, byteIki;

            //Console.WriteLine(ad); yandaki tanımlaamada hata alacaksınız. Sebebi ise; ad isimli değişken içerisinde herhangi bir değer barındırmadığı için konsol ekranında hiç bir şey gösteremeyecek.

         

            Console.WriteLine("Lütfen adınızı yazınız...");
            ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı yazınız...");
            soyad = Console.ReadLine();
            Console.WriteLine("adresinizi yazınız....");
            adres = Console.ReadLine();
            Console.WriteLine("Lütfen bekleyin... Bilgilerinizi kontrol ediyorum...");
            Console.Beep(frekans, sure);
            Console.Beep(frekans, sure);
            Console.Beep(frekans, sure);
            Console.WriteLine("adınız: " + ad + " soyadınız: " + soyad + " adresiniz: " + adres);
            Console.WriteLine("Başka arzunuz?....");
            Console.Read();
            // Console.ReadKey(); klavyeden herhangi bir tuşa basmanızı ister.





        }
    }
}
