using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inheritance (Kalıtım/miras)

            /*
             Inheritance (Kalıtım/miras) bir nesnenin özelliklerini farklı nesneler tarafından da kullanılabilmesine olanak sağlayan OOP prensibidir.
             */


            EkranKarti ekranKarti = new EkranKarti();
            ekranKarti.Marka = "GeForce";
            ekranKarti.Bellek = 4;

            Laptop laptop = new Laptop();
            laptop.Marka = "Dell";
            laptop.RamKapasite = 16;
            laptop.IslemciMarka = "Intel I7";
            //laptop.EkranKartiMarkasi = "GeForce Gtx bıdı bıdı";
            laptop.EkranKarti = ekranKarti;
            laptop.Fiyat = 9000;

            UltraBook ultraBook = new UltraBook();
            ultraBook.EkranBoyutu = 15.6;
            //ultraBook.EkranKartiMarkasi = "GeForce";
            ultraBook.Marka = "Asus";
            ultraBook.Fiyat = 5000;



        }
    }
}
