using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapisiTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            ////Karar Yapisi

            //int a = 5;
            //int b = 6;

            ////ya da b 6 a eşitse doğru işlemi gösterin.
            //if (a == b)//true
            //{
            //    MessageBox.Show("Doğru işlem");
            //}
            //else if (b == 6)
            //{
            //    MessageBox.Show("Doğru işlem");
            //}
            //else
            //{
            //    MessageBox.Show("Yanlış işlem");
            //}



            //Hata Yönetimi
            //Syntax hatası
            MessageBox.Show("merhaba");
            //Runtime (çalışma zamanı) hatası

            //Mantıksal hata

                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);//textBox1 int bir değer bekliyor.
            int toplam = sayi + 5;//textboxdan gelen sayı değerini int formata çevirdikten sonra 5 ile topluyor.

            MessageBox.Show(toplam.ToString());//int toplam değeri string formatına çevrilip messagebox içinde gösteriliyor.
        }
    }
}
