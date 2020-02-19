
namespace WFA_OOPIntroduction
{
    //Class: Bir veri tipini modellemek için kullandığımız yapılara denir. Bir sınıf, kapsüllenmiş verileri bu veriler üzerinde işlem yapacak metotları ve bu verilere ait özellikleri içerebilir.
    class Araba
    {
        //Bir arabanın ........'sı olur.

        //Field: C#'ta alanlar, bir sınıf ya da bir sınıf örneği ile ilişkilendirilmiş değişkenlerdir. Varsayılan olarak private olarak tanımlanır.

        #region Access Modifiers
        //Access Modifiers => Erişim Belirteçleri
        /*
         private=> bir dğerin private oalrak tanımlanması demek, o değişkene sadece kendi class'ı içinden ulaşılabileceği anlamına gelmektedir. Program içinde kesinlikle değiştirilmemesi gereken, kritik kodlarda kullanılır.
         public=> bir değerin erişim belirtecini public olarak tanımladığınızda o değeri heryerden ulaşabilir olarak tanımlamış olursunuz.
         internal=> internal olarak tanımlanan bir değer sadece bağlı bulunduğu proje içerisinden ulaşılabilir anlamına gelmektedir.

         */
        #endregion

        internal double motorGucu;
        public int tekerlekCap;
        public string renk;
        internal string marka;
        public string model;
        public string kasaTip;
        public string vitesTip;
        public string yakitTip;
        public string cikisYil;
        public int tork;




    }
}