using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Randevu:Doktorekle
    {
        public string tckimlikno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime randevutarihi { get; set; }
        public Doktorekle Doktorekle { get; set; }

    }
}
