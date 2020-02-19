using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Futboılcu
{
    public interface IFutbolcu
    {
        //her futbolcunun eylemleri.

        string Kos();
        string SutCek();
        string TopKurtar();
        string PasVer();
        string PresYap();
    }
}
