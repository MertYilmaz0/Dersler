using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Malzemeler
            /*
            string tencere = "derin";
            string yagTuru1 = "zeytin";
            string yagTuru2 = "tere";
            string sebze1 = "patlican";
            string sebze2 = "patates";
            string sebze3 = "kabak";
            string sebze4 = "biber";
            string sebze5 = "soğan";
            string sebze6 = "fasulye";
            string konserve1 = "bezelye";
            string baharat1 = "tuz";
            string baharat2 = "karabiber";
            string baharat3 = "kekik";
            string baharat4 = "kimyon";
            string baharat5 = "pulbiber";
            */


            string sebzeler;
            string baharatlar;
            string yagMiktari;
            string konserve;
            string ocak;

            Console.WriteLine("Türlü Tarifi");
            Console.WriteLine("gerekli sebzeleri girin ");
            sebzeler = Console.ReadLine();
           

            Console.WriteLine(sebzeler + " " + " adlı sebzelere baharatları ekleyin");
            baharatlar = Console.ReadLine();
            Console.WriteLine(baharatlar + " " + "adlı baharatları başarılı şekilde eklediniz. Şimdi konserveyi eklemelisiniz... konservenin ismini girin...") ;
            konserve = Console.ReadLine();
            Console.WriteLine(konserve + " " + " konservesini de başarılı şekilde eklediğinize göre ocağı seçin BUYUK veya KUCUK");
            ocak = Console.ReadLine();
            Console.WriteLine(ocak + " " + " ocağı seçtiniz");
            Console.WriteLine("YEMEK PİŞİYOR LÜTFEN BEKLEYİN");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.WriteLine("Yemeği ocaktan alın");
            Console.Read();
        }
    }
}
