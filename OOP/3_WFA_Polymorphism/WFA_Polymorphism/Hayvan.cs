using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    public class Hayvan
    {
        public string Cinsiyet { get; set; }
        public int AyakSayisi { get; set; }
        public bool EvcilMi { get; set; }
        public bool UcabilirMi { get; set; }
        public string Tur { get; set; }
        public string YasadigiBolge { get; set; }

        //virtual: ezilebilir anlamına gelmektedir. Miras verdiğimiz class içerisinde aşağıdaki metodu ezmek istersek "override" keywordunu kullanarak ezmek istediğimiz metodu seçebiliriz. 


        public virtual string SesCikar()
        {
            return "Tanımlı Ses";
        }

    }
}
