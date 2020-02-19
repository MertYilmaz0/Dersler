using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5

{/// <summary>
 /// Ad
    //--Soyad
    //--TcKimlik
    //--Departman
    //--Telefon No
    //--Adres
    //--SGK No
    //--Cinsiyet
    //--Doğum Tarihi
    //--Maaş Net:
    //--Maaş Brüt:
    //--Burcu
    //--Banka Bilgisi:
    //--Hesap No:
    //--Yaş:
    /// </summary>
    public class Personel
    {
        public string Ad ;
        public string Soyad;
        private int tcKimlikno;
        public string TcKimlikno
        {
            get
            {
                return tcKimlikno.ToString();
            }
            set
            {
                if (value.Length == 11)
                {
                    MessageBox.Show("Karakter Sayısı 11 haneli olmalıdır");
                }
                else
                {
                    tcKimlikno = value.Length;
                }
            }
        }
        public string Departman;
        private int telefonNo;

        public string TelefonNo
        {
            get
            {
                return telefonNo.ToString();
            }
            set
            {
                if(value.Length == 11 )
                {
                    MessageBox.Show("Telefon Numaranız 11 haneli olmalıdır");
                }
                else
                {
                    telefonNo = value.Length;
                }
            }
        }
        public string Adress;
        public int SgkNo;
        public string Cinsiyet;
        public decimal MaasNet { get; set; }
        public decimal MaasBurut
        {
            get
            {
                return MaasNet;
            }
            set
            {
              value=  MaasNet + 2200;
            }
        }
        public string Burc;
        public string BankaBilgisi;
        public int HesapNo;
        public int Yas;


         


    }
}
