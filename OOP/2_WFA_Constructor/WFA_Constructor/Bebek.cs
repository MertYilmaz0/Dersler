using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Constructor
{
    public class Bebek
    {
        //constructor

            //constructorlar geriye değer dönmezler.
            //constructorlar bağlı bulunduğu class ile aynı isme sahip olmalıdırlar.

        /// <summary>
        /// eğer herhangi bir değer ataması yapmazsan doğum tarihini şuanki zaman olarak atayacak.
        /// </summary>
        public  Bebek()
        {
            DogumTarihi = DateTime.Now;
        }
        /// <summary>
        /// string tipte baba adı gönder, string tipte anne adı gönder. doğum tarihi otomatik oluşacak.
        /// </summary>
        /// <param name="anneAdi"></param>
        /// <param name="babaAdi"></param>
        public Bebek(string AnneAdi, string BabaAdi)
        {
            DogumTarihi = DateTime.Now;
            this.AnneAdi = AnneAdi;
            this.BabaAdi = BabaAdi;

        }
        /// <summary>
        /// parametreleri tanımlarsan propertylere değer atamak durumunda kalmazsın.
        /// </summary>
        /// <param name="anneAdi"></param>
        /// <param name="babaAdi"></param>
        /// <param name="kilo"></param>
        /// <param name="cinsiyet"></param>
        /// <param name="boy"></param>
        public Bebek(string anneAdi, string babaAdi, double kilo, string cinsiyet, double boy)
        {
            DogumTarihi = DateTime.Now;
            AnneAdi = anneAdi;
            BabaAdi = babaAdi;
            Kilo = kilo;
            Cinsiyet = cinsiyet;
            Boy = boy;
        }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public double Kilo { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }


    }
}
