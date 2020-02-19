using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Hamburgerci
{
    //todo: Abstract oluşturun.
    public class Ekstra
    {
        public string EkstraAd { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return EkstraAd;

        }

    }
}
