using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //While
            //int i = 1;
            //while (i <= 100)
            //{
            //    listBox1.Items.Add(string.Format("Sayı: {0}", i));
            //    i++;
            //}

            //Do While
            //int i = 1;
            //do
            //{
            //    listBox2.Items.Add(i);
            //    i++;
            //}
            //while (i <= 100);
            //For
            //for(int i=1; i<=100; i++)
            //{
            //    listBox3.Items.Add(i);
            //}

            //Foreach


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında listbox içerisine 1'den 10'a kadar çarpım tablosunu ekleyin.

            /*
             1x1=1
             1x2=2
             1x3=3
             .
             .
             .
             1x10=10
             -----------------------
             2x1=2
             2x2=4
             2x3=6
             .
             .
             .
             2x10=20
             --------------------
             .
             .
             .
             10x1=10
             10x2=20
             .
             .
             
             */

            for(int i=1; i<=10; i++)// integrali 1 alıyoruz tablo 1 den başladığı için. i küçük yada eşitse 10dan alt satırdaki ikinci for döngüsüne aktarılır.
            {
                for(int z=1; z<=10; z++)// ikinci for döngüsünde ikinci sayı olarak z 1 alınır.  z küçük yada eşitse 10dan alttaki işlem devreye girer.
                {
                    listBox4.Items.Add(string.Format("{0}x{1}={2}", i, z, i * z));// burada yarattığımız iki sayı belirlediğimiz sıra ve şekilde çarpılır.
                }// döngü başa döner i ve z 1 artar. sayılar 10 a gelince döngüler de son bulur.
            }

            //ÖDEV:
            //10 adet listbox tanımlayın her bir sayıyı bu listbox içerisinde çarpım tablosuna dahil edin.



        }
    }
}
