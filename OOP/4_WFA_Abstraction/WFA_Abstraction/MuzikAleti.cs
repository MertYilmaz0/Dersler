using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public abstract class MuzikAleti
    {
        #region Abstract
        //Abstract class'lar, sadece base class olarak davranmasını ve kendisinden instance çıkartılmamasını istediğimiz durumlarda kullanılır.

        //Abstract olarak işaretlenmiş tüm yapılar mutlaka override edilmek zorundadır. (Bknz. Cal())

        //Abstract classların en büyük özelliği, içerisinde abtract olan ya da olmayan metotları barındırabilmesidir. Abstract metotlar kalıtım aldığı classta implement edilerek kullanılacak metotlardır yani tanımlandığı yerlerde herhangi bir kod bloğu bulundurmazlar. 
        #endregion
        
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        //public virtual string Cal()
        //{
        //    return "tanımlı ses";
        //}
        public abstract string Cal();

        //Abstract metotlarımızı tanımlarken aşağıdaki kurallara dikkat etmeliyiz;
        #region Abstract Kuralları
        /*
           1-Abstract metotlar private olarak tanımlanamazlar. Çünkü, private metotlar miras alınan classlar tarafından ulaşılamadıkları için implement edilemezler.Bu da abstract yapısına ters düşer.
           2- Abstract metotlar sadece abstract classlar içerisinde tanımlanırlar.
           3- abstract metotlar virtual olarak tanımlanmazlar. Her abstract class virtual'dır. Abstract classın da amacı miras alındığı classta impelemente edilmek olduğu için virtual yazıldığı takdirde hata alınacaktır.
           4-Abstract metotlar static olarak tanımlanmazlar. Statik kavramı class özelliği veya metotu olduğu için instance çıkarmaya gerek yoktur. Halbu ki statik olmayan metotlar instance metotlardır.
           5-abstract metotların gövdesi olamaz. Çünkü onlar sadece miras alındığı classlarda implement edilebilir.
    */ 
        #endregion
    }
}
