using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Polymorphism (Çok biçimlilik)

            /*
              Polymorphism (Çok biçimlilik) bir metodun farklı sınıflar içinde farklı etkiler oluşturmasını sağlayan bir yöntemdir.
             */

            //Hayvan
            //Kedi
            //Kopek
            //Kus

            Kedi kedi = new Kedi();
            kedi.AyakSayisi = 4;
            kedi.EvcilMi = false;
            kedi.Tur = "İran";
            Kopek kopek = new Kopek();
            Kus kus = new Kus();


            MessageBox.Show(kedi.SesCikar());
            MessageBox.Show(kopek.SesCikar());
            MessageBox.Show(kus.SesCikar());
        }
    }
}
