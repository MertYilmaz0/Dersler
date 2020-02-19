using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOPInheritance
{
    public class Kitap:Urun
    {
        public string YazarAd { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public Dil Dil { get; set; }


    }
}
