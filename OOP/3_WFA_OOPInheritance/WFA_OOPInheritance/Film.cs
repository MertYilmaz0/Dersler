using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOPInheritance
{
    public class Film:Urun
    {
        public string YonetmenAd { get; set; }
        public string YonetmenSoyad { get; set; }

        public List<Oyuncu> Oyuncular { get; set; }

        public override string ToString()
        {
            string oyuncular = string.Empty;
            //foreach (Oyuncu oyuncu in Oyuncular)
            //{
            //    oyuncular += oyuncu.Ad + " " + oyuncu.Soyad + " ";
            //}
            for (int i = 0; i < Oyuncular.Count; i++)
            {
                oyuncular += Oyuncular[i].Ad + " " + Oyuncular[i].Soyad + " ";
            }
            return string.Format("Yönetmen Adı: {0} Yönetmen Soyad:{1} Oyuncular: ({2})", YonetmenAd, YonetmenSoyad,oyuncular);
        }

    }
}
