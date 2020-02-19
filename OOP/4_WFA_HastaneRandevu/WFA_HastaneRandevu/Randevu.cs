using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Randevu:Ortak
    {
        public string TCKN { get; set; }
        public string Soyad { get; set; }
        public Brans Brans { get; set; }
        public Doktor Doktor { get; set; }
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }


    }
}
