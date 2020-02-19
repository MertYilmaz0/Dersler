using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Interface (Arayüz) / Yetenek Kazandırma

            /*
                Interfaceler, class gibi türler için oluşturulmuş modellerdir. Bir sınıfın temelde hangi üyelerden oluşacağını belirleyen şablon yapılardır. Bu sayede oluşturulacak sınıflara öncülük ederler ve içermeleri gereken üyelerin ne olacağının standartını belirler. Kullanılması zorunlu olan metotlar belirlenir fakat metot içerikleri doldurulmaz.

            //sınıflara yetenek kazandırır
            //interface oalrak tanımlanan class'dan instance alınamaz.
            //bir sınıf birden fazla interface'den miras alabilir.

            Abstract => is
            Interface => can

            //Bir araba düşünelim arabanın temel özelliklerini tanımlamak için Araba isimli classı Abstract olarak oluşturup propertylerini tanımladık. Bu class içerisinde bir arabada olmazsa olmaz özellikleri yazdık.

            Oluşturmuş olduğumuz abstract class'da araba classından miras alan classlarda doldurulması zorunlu lanları belirlemiş olduk. Kısaca Abstract "is" yani audi isminde bir class oluşturulduğunda audi arabasının mecbut olarak tanımlanacak özelliklerini asbtract class'tan miras olarak getirildi. Interface ise "-can" yani yapabilir anlamında Tesla isimimli class'a yetenek olarak verildi. 

            Detyalar için classların yapısını inceleyin.

             */

            Audi audi = new Audi();
            audi.Fiyat = 300000;
            audi.Model = "A5";
            audi.Renk = "Siyah";

            Tesla tesla = new Tesla();
            tesla.Fiyat = 500000;
            tesla.Model = "Model s";
            tesla.Renk = "Kırmızı";
            tesla.UretimYili = DateTime.Now;
            

        }
    }
}
