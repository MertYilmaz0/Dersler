using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Constructor (Yapıcı Metot)

            /*
             Yapıcı metotlardan kısaca bahsetmek gerekirse, static olmayan (ileride göreceğiz) bir sınıf içerisindeki özelliklere sınıfın instance alımı esnasında değerleri atama işlemidir.
             */

           

            //Bebek bebek = new Bebek();

            //MessageBox.Show(bebek.DogumTarihi.ToString());

            Bebek bebek = new Bebek();

            Bebek bebek2 = new Bebek("Fatma","Cumali");

            MessageBox.Show(
                bebek2.BabaAdi
                +" "+
                bebek2.AnneAdi
                +" "+
                bebek2.DogumTarihi.ToShortDateString()
                );

            Bebek bebek3 = new Bebek("Hatice", "Hüseyin", 3.3, "erkek", 45);


            Bebek b1 = new Bebek();
            b1.AnneAdi = "Fatma";

            b1.BabaAdi = "Kamil";

            b1.Cinsiyet = "Kız";
            b1.DogumTarihi = DateTime.Now;
            b1.Kilo = 3.3;
            b1.Boy = 50;

            //Object Initilizaer

            Bebek bebek4 = new Bebek()
            {
                AnneAdi = "Zeynep",
                BabaAdi = "Ahmet",
                Boy = 48,
                Kilo = 4

            };


            //Araba isminde bir class tanımlayın
                //marka
                //model
                //motorgucu

            //3 farklı yoldan nesnenin ram üzerinde örneğini oluşturun.
                //ilk olarak nesne örneği oluşturulsun. Değer tanımlamaları daha sonra yapılsın.
                // ikinci olarak nesne örneği oluşturulurken nesne içerisindeki özelliklere değer tanımlaması yapılsın.
                //üçüncü olarak nesne oluşturma esnasında yapıcı metot kullanılmadan özelliklere değer tanımlaması yapılsın.



        }
    }
}
