using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Doktor:Ortak
    {
        //public string DoktorAdSoyad { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
