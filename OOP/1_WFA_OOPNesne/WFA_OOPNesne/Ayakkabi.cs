using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPNesne
{
    //eğer oluşturulan class'a herhangi bir erişim belirteci tanımlamazsanız varsayılan "internal" olarak tanımlanır.
    public class Ayakkabi
    {
        //Her bir ayakkabının .....'sı olur.


        #region Field
        //public string marka;
        //public string malzemesi;
        //public string bagcikTip;
        //public string tip;
        //public string renk;
        //public decimal fiyat; 
        #endregion

        #region İlk İşlem
        //private string marka = "Nike";
        //public string Marka
        //{
        //    //bu property sadece okunabilir. (Read Only)
        //    get
        //    {
        //        return marka;
        //    }
        //}
        //public string Malzeme { get; set; }
        //public string BagcikTip { get; set; }

        //public string Tip { get; set; }
        //public string Renk { get; set; }
        //public decimal Fiyat { get; set; } 

        //private short numara;
        //public short Numara//28
        //{
        //    get//getter=> getir
        //    {
        //        return numara;
        //    }
        //    set//setter=> ayarla (atama yap)
        //    {
        //        if (value <= 30 || value >= 45)
        //        {
        //            MessageBox.Show("numara 30'dan küçük ve 45'den büyük olamaz");
        //        }
        //        else
        //        {
        //            numara = value;
        //        }
        //    }
        //}
        //yukarıda yapılan işlem encapsulation işlemidir.
        //Encapsulation=> Nesnenin üyelerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktadır. Amaç; field'ları private yaparak bu alanlara dışarıdan erişimi önlemek ve get-set metotları ile kontrolü sağlamaktır.

        //"prop"+Tab+Tab snippet'ını kullanarak kısayoldan property tanımlayabilirisniz.
        #endregion

        private string marka;
        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                if (value == "Nike")
                {
                    marka = value;
                }
                else
                {
                    MessageBox.Show("Sadece Nike markası girebilirsiniz");
                    marka = "Nike";
                }
            }
        }

        private int numara;
        public int Numara
        {
            get
            {
                return numara;
            }
            set
            {
                if (value <= 30 || value >= 45)
                {
                    MessageBox.Show("Numara 30'dan küçük ve 45 den büyük olamaz.");
                }
                else
                {
                    numara = value;
                }
            }

        }

        public decimal Fiyat { get; set; }//100
        public decimal KdvDahilFiyat
        {
            //read only
            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }

        }
    }
}
