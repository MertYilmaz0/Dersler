using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Statics
{
    public class Personel
    {
        public Personel()
        {
            PersonelSayisi++;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }

        public static int PersonelSayisi { get; set; }
    }
}
