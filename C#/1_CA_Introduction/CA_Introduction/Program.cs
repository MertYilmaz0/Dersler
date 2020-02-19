using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CA_Introduction
{//scope başlangıcı
    class Program
    {//scope
        static void Main(string[] args)
        {
            #region Örnek Kodlar
            //Console.Write("Merhaba Dünya");
            //Console.Read();

            ////Metinsel veri tipi

            //string metinselDeger = "Örnek değer";

            //char karakter = 'a';
            //Console.WriteLine(karakter);
            //karakter = 'b';
            //Console.WriteLine(karakter);


            //int karakterKodu = karakter;
            ////karakterKodu = metinselDeger;


            //Console.Write("herhangi bir metinsel değer");//bağlı bulunan satırda gösterir.
            //Console.WriteLine("herhangi bir metinsel değer");//yazıyı yazdıktan sonra imleci bir satır aşağıa kaydırır.
            //Console.Read();//konsol ekranının kapanmamasını sağlar.

            //string degisken = Console.ReadLine();//satırdaki veriyi okur.

            //Console.ReadKey();//klavyeden herhangi bir tuşa basıldığı okumayı durdurur. 
            #endregion


            Console.WriteLine("Burada herhangi bir değer gösteriliyor");
            Console.Read();

            Console.Beep();


            //Operatörler

            // =

            //İlişkisel operatörler
            /*
             <
             >
             <=
             >=
             !=
             ==
             
             */

            string deger = "admin";
            string gelenDeger = Console.ReadLine();
            bool sonuc = deger == gelenDeger; //admin != a
            Console.WriteLine(sonuc);
            Console.Read();






        }
    }//scope bitişi
}//scope bitişi
