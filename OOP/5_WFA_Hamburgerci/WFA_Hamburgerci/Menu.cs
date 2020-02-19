using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Hamburgerci
{
    //todo: Abstract oluşturun.
    public class Menu
    {
        //Her bir menunun ..... olur.

        public string MenuAd { get; set; }
        public decimal MenuFiyat { get; set; }


        public override string ToString()
        {
            return MenuAd;
        }

    }
}
