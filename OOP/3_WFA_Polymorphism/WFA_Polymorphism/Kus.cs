using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
   
    public class Kus:Hayvan
    {
        public bool MemeliMi { get; set; }
        public double KanatCap { get; set; }

        public override string SesCikar()
        {
            return "cik cik";
        }
    }
}
