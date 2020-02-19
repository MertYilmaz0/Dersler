using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public class Tesla : Araba,IYetenek
    {
        public override string MaxHiz()
        {
            return "Max hız 250 km/h";
        }

        public string OtoPilot()
        {
            return "Bu araba kendi kendini sürer";
        }
    }
}
