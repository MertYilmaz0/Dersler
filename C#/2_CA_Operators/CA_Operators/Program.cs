using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörler

            //Atama Operatörü (=)

            //eşitliğin sağındaki değeri solundaki tipe atama işlemini gerçekleştirir. Burada dikkat etmeniz gereken en önemli nokta; eşitliğin solundaki tip ne ise sağındaki değer o tipe uygun olmak zorundadır.

            // int sayi = "metinsel değer atanmaz"; kesinlikle sağındaki değer solunda tnaımlı olan tipe eşit olmak zorunda.

            Console.WriteLine("Matematiksel İşlemler");
            Console.WriteLine("---------------------------");

            //sayısal işlemlerde varsayılan tip Int

            int sayiBir = 102;
            int sayiIki = 25;


            #region Toplama İşlemi
            int toplam = sayiBir + sayiIki;

            Console.WriteLine("Toplam işlemi sonucu: " + toplam);//127
            //CTRL+F5=> read metodu kullanmadan console ekranının sabit kalmasını sağlar.

            Console.WriteLine("Toplam işlemi sonucu: " + sayiBir + sayiIki);//10225

            Console.WriteLine("Toplam işlemi sonucu: " + (sayiBir + sayiIki));//127

            Console.WriteLine("----------------------------\n");
            #endregion

            #region Çıkartma
            int fark = sayiBir - sayiIki;
            Console.WriteLine("Çıkartma işlemi sonucu: " + fark);
            Console.WriteLine("Çıkartma işlemi sonucu: " + (sayiBir - sayiIki));
            Console.WriteLine("----------------------------\n");
            #endregion

            #region Bolme
            int bolme = sayiBir / sayiIki;
            Console.WriteLine("Bölme işlemi sonucu: " + bolme);
            Console.WriteLine("Bölme işlemi sonucu: " + (sayiBir / sayiIki));
            Console.WriteLine("----------------------------\n");
            #endregion


            #region Carpma
            int carpma = sayiBir * sayiIki;
            Console.WriteLine("Çarpma işlemi sonucu: " + carpma);
            Console.WriteLine("Çarpma işlemi sonucu: " + (sayiBir * sayiIki));
            Console.WriteLine("----------------------------\n");
            #endregion

            #region Mod
            int mod = sayiBir % sayiIki;
            Console.WriteLine("Mod işlemi sonucu: " + mod);
            Console.WriteLine("Mod işlemi sonucu: " + (sayiBir % sayiIki));
            Console.WriteLine("----------------------------\n");
            #endregion


            int sayi = 15;
            Console.WriteLine("Sayının ilk değeri: " + sayi);

            sayi = sayi + 1;
            Console.WriteLine("Sayının bir üst değeri: " + sayi);

            sayi += 1; //sağdaki değeri soldaki değişkene toplayarak aktarır.
            Console.WriteLine("Sayının bir üst değere atanmış hali:" + sayi);

            sayi++;//değişkeni sadece 1 kez artırır.
            //sayi--; değişkeni sadece 1 kez azaltır.
            Console.WriteLine("Sayının bir üst değeere atanmış hali: " + sayi);


            int vize = 45;
            int final = 80;
            double ortalama;
            //vize notunun %30'u, final notunun %70'ni alıp öğrencinin not ortalamasını veren konsol uygulamasını yazınız.

            ortalama = vize * 0.30 + final * 0.70;
            Console.WriteLine("Not ortalaması: "+ortalama);

            //İlişkisel Operatörler: İlişkisel operatörler geriye bool sonuç döndürürler. Iki operandın biribirleriyle olan ilişkilerini kontrol ederek mantıksal sonuç üretir.

            // >  büyüktür
            // < küçüktür
            // >= büyük eşittir.
            // <= küçük eşittir.
            // == eşit eşittir.
            // != eşit değildir.

            int a = 5;
            int b = 6;

           bool sonuc1= a < b;
            bool esitMi = a == b;
            Console.WriteLine(sonuc1);
            Console.WriteLine(esitMi);


            //kullanıcı tarafından konsola girilen değer "admin" ise "true" yazan uygulamayı yazınız.
            string gelenDeger;
            string sabitDeger = "admin";
            Console.WriteLine("Değer girin....");
            gelenDeger= Console.ReadLine();
            bool sonuc= gelenDeger == sabitDeger;
            Console.WriteLine("Sonuc: " + sonuc);
            Console.Read();

            //Yemek Tarifi

            string kap = "demir";
            string yagTuru = "Zeytin";
            string tahil = "Bulgur";

           string bulgurGram;
            string salcaGram;

            //Örnek Ödev
            //Console.WriteLine("Yemeğin Yapılışı");
            //Console.WriteLine("Lütfen bulgur gramı girin");
            //bulgurGram = Console.ReadLine();
            //Console.WriteLine("Lütfen salca gramı girin");
            //salcaGram = Console.ReadLine();

            //Console.WriteLine(bulgurGram + " " + salcaGram + " nar ekişini katınız");
            //Console.Read();

        }
    }
}
