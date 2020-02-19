using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Futboılcu
{
    public abstract class Futbolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNumarasi { get; set; }
        public string Takım { get; set; }

        //abstract properties
        public abstract int SutGucu { get; set; }
        public abstract int Agresiflik { get; set; }
        public abstract int TopKapma { get; set; }
        public abstract int BeceriGucu { get; set; }

    }
}
