using System.Collections.Generic;

namespace WFA_Hamburgerci
{
    public class Siparis
    {
        //Bir siparişin ..... 'sı olur. (Aşağıda tanımladığımız propertyleri bir nevi siparişin özeti olarak düşünebiliriz. Bu özette nelerin olmasını istiyorsak aşağıda tanımladık.)
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> EkstraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar+= SeciliMenu.MenuFiyat;

            switch (Boyut)
            {
               //küçük boyutta herhangi bir fiyat farkı bulunmadığı için case ile yakalamadık.
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.50m;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.75m;
                    break;
            }
            foreach (Ekstra ekstra in EkstraMalzemesi)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar = Adet * ToplamTutar;

        }
        public override string ToString()
        {
            //eğer herhangi bir ekstra seçilmemişse aşağıdaki gibi string format uygulansın.
            if (EkstraMalzemesi.Count < 1)
            {
                return string.Format("{0} Menu, x{1}Adet, {2} Boy, Toplam:{3} TL", SeciliMenu.MenuAd, Adet, Boyut.ToString(), ToplamTutar.ToString());
            }
            //eğer en az 1 adet ekstra seçilmişse aşağıdaki gibi string format uygulansın.
            else
            {
                string ekstraMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzemesi)
                {
                    ekstraMalzemeler += ekstra.EkstraAd + " ";
                    ekstraMalzemeler += ekstra.Fiyat + " ";
                }

                return string.Format("{0} Menu, x{1}Adet, {2} Boy,({3}) Toplam:{4} TL", SeciliMenu.MenuAd, Adet, Boyut.ToString(), ekstraMalzemeler, ToplamTutar.ToString());
            }

        }

    }
}
