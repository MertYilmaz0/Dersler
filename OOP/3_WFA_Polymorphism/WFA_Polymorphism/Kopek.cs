using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    public class Kopek:Hayvan
    {
        public bool EgitimliMi { get; set; }
        public string EgitimTuru { get; set; }

        public override string SesCikar()
        {
            return "Hav Hav";
        }
    }
}
