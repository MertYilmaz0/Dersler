using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPNesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OOP
            /*
             Encapsulation => kapsülleme
             Inheritance=> miras verme
             Polymorphism=> çok biçimlilik
             Abstraction=> Soyutlama
             */
            Ayakkabi ayakkabi = new Ayakkabi();
            //ayakkabi.marka = "Adidas";
            //ayakkabi.malzemesi = "deri";
            //ayakkabi.numara = 42;
            //ayakkabi.Numara = 42;
            //if (ayakkabi.numara <= 30 || ayakkabi.numara >= 45)
            //{
            //    ayakkabi.numara = 0;
            //}
            //ayakkabi.renk = "Beyaz";
            //ayakkabi.tip = "Spor";
            //ayakkabi.fiyat = 600;
            //ayakkabi.bagcikTip = "İpli";
            

            //MessageBox.Show(ayakkabi.Numara.ToString());

            



        }

        Ayakkabi ayakkabi = new Ayakkabi();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ayakkabi.Marka = txtMarka.Text;
            ayakkabi.Numara = (int)nudNumara.Value;
            ayakkabi.Fiyat = nudFiyat.Value;

            listBox1.Items.Add(ayakkabi.Marka+" "+ayakkabi.Numara+" "+ayakkabi.KdvDahilFiyat);
        }
    }
}
