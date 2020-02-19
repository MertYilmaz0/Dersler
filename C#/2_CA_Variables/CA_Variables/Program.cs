using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu bir yorum satırıdır.

            /*
             Çok satırlı yorum alanı.

             */


            //Değişken Nedir?

            /*
             Değişkenleri en sabit şekilde verilerin depolandığı yerler olarak tanımlayabiliriz. Değişkenlerin içine verilerimizi koyabiliriz veya değişkenlerimizin içerisindeki verileri C# programdaki işlemlerimiz için kullanabiliriz.

            değişken isimleri tanımlanır kucuk harflerle tanımlanmalıdır. eğer tanımlanacak değişken adı iki kelimeler oluşuyorsa ilk kelime tamamen küçük ikinci kelimenin ilk harfi büyük olarak tanımlanmalıdır.

                camelCase
               

            1-C# programlama büyük küçük harf duyarlı bir dildir.
              2-Değişken isimlerinde Türkçe karakter kullanmamaya özen gösterilmelidir.
              3-Değişken isimleri asla sayı ile başlamamalıdır.


                Veri Tipleri

            //Sayısal Veri Tipleri

            //sbyte=>
            //MinValue=> -128
            //MaxValue=> 127
             */

            sbyte degiskenBir = 10;

            //byte
            //MinValue=> 0
            //MaxValue=> 255

            byte degiskenIki = 255;

            //short=>
            //MinValue=> -32768
            //MaxValue=>  32767

            short degiskenUc = 10000;

            //Int
            //MinValue=> -2,147,483,648 
            //MaxValue=> 2,147,483,647

            //Uint
            //MinValue=> 0
            //MaxValue=>  4,294,967,295

            //long
            //MinValue=> -9,223,372,036,854,775,808
            //MaxValue=>  9,223,372,036,854,775,807

            //ulong
            //MinValue=> 0
            //MaxValue=> 18,446,744,073,709,551,615


            //Ondalıklı Sayısal Veri Tipleri

            //float=> .'dan sonra 7 hane desteği verir 

            float ondalikliBir = 1.25f;  //ondalıklı sayı tanımlamak için . (nokta) kullanmalıyız!

            //double=> .'dan sonra 14 hane desteği verir.
            double ondalikliIki = 1.25;

            //decimal=> . 'dan sonra 28 hane desteği verir
            decimal ondalikliUc = 1.25m;


            //Metinsel Veri Tipler
            //char=> üzerinde tek bir karakteri barındıran veri tipidir.

            char karakter = '%';
            char karakterIki = 'f';

            //string=> üzerinde birden fazla ve sınırsız olarak karakter barındıran veri tipidir.

            string metinselDeger = "buraya dilediğiniz kadar yazı yazabilirsiniz";

            //Mantıksal Tip

            //bool (boolean)=> true ya da false tipinde bir değer alır.

            bool bugunTatilMi = false;//0
            bool ehliyetVarMi = true;//1

           
            Console.Write(ulong.MaxValue);
            Console.Read();

        }
    }
}
