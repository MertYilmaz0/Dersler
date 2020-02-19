using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOPPersonelEkleme
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Adres { get; set; }
        public string SgkNo { get; set; }
        public string Departman { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal MaasNet { get; set; }
        public decimal MaasBrut { get; set; }
        public string TelefonNo { get; set; }

        //Todo Burç ve yaş eklenecek.
        public string Burc { get; set; }
        public int Yas { get; set; }

        public List<Personel> Personeller { get; set; }
        public void PersonelEkle(Personel p)
        {
            Personeller.Add(p);

            //veritabanı kayıt işlemi

            //mail gönderimi

            //mesaj gönderimi

        }

    }
}
