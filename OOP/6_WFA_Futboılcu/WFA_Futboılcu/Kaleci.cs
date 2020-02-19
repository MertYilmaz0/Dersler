using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Futboılcu
{
    public class Kaleci : Futbolcu,IFutbolcu
    {
        private int sutGucu;
        public override int SutGucu
        {
            get 
            {
                return sutGucu;
            }
            set
            {
                if (value > 70)
                {
                    MessageBox.Show("Şut gücü 70'den büyük olduğu için isabet oranı düşer");
                    sutGucu = value;
                }
                else
                {
                    sutGucu = value;
                }
            }
        }
        public override int Agresiflik { get; set; }
        public override int TopKapma { get; set; }
        public override int BeceriGucu { get; set; }

        public string Kos()
        {
            return this.Ad + " Koşuyor";
        }

        public string PasVer()
        {
            return this.Ad + " Pas Verdi";
        }

        public string PresYap()
        {
            return this.Ad + " Press Yaptı";
        }

        public string SutCek()
        {
            return this.Ad + " Şut Çekti";
        }

        public string TopKurtar()
        {
            return this.Ad + " Top Kurtardı";
        }
    }
}
