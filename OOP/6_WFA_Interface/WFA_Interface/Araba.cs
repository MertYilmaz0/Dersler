using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public abstract class Araba//Base
    {
        public string Model { get; set; }
        public string Renk { get; set; }
        public DateTime UretimYili { get; set; }
        public decimal Fiyat { get; set; }

        public abstract string MaxHiz();

    }
}
