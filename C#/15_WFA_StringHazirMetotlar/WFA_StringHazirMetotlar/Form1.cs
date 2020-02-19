using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_StringHazirMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        string ornekMetin;
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //CompareTo=> metodu kullandığınız string değer ile metoda verdiğiniz parametredeki string değeri sözlük mantığı ile karşılaştırır. Eğer sözlükte aynı lokasyonlarda ise 0, parametredeki değer ana değerimizden söklükten önceseyle -1, sonraysa 1 değerini döndürür.

            ornekMetin = textBox1.Text;
            int sonuc = ornekMetin.CompareTo("bilgeadam");
            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşlememektedir. Eksik karakter var";
                    break;
                case 0:
                    mesaj = "Tebrikler! Kelimeler eşleşiyor";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşleşmiyor. Fazla karakter var";
                    break;

            }
            MessageBox.Show(mesaj);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ornekMetin = textBox1.Text;
            bool varMi = ornekMetin.Contains("bilge");
            #region If-Else
            //if (varMi)
            //{
            //    MessageBox.Show("aradığınız değer bulunmaktadır!");
            //}
            //else
            //{
            //    MessageBox.Show("aradığınız değer bulunmamaktadır!");
            //} 
            #endregion
            MessageBox.Show("Aradığınız değer " + (varMi ? "bulunmaktadır" : "bulunmamaktadır")); // ternary if (tek satırda if else yapısı)

        }

        private void btnStartswith_Click(object sender, EventArgs e)
        {
            //StartsWith=> kelimenizin parametrede gönderdiğiniz değer ile başlayıp başlamadığını "bool" olarak döndürür.

            ornekMetin = textBox1.Text;
            bool sonuc = ornekMetin.StartsWith("bil");

            MessageBox.Show(sonuc ? "Kelime\"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır");
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            ornekMetin = textBox1.Text;
            bool sonuc = ornekMetin.EndsWith("dam");

            MessageBox.Show(sonuc ? "Kelime\"dam\" ile bitiyor." : "Kelime \"dam\" ile bitmiyor.");
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOF=> dizilerde gördüğümüz metodun aynı prensibi ile çalışır. Eğer harf varsa o harfin indexini, yoksa -1 değerini, gönderilen harf birden fazla varsa ilk harfin indexini döndürür.

            ornekMetin = textBox1.Text;
            int index = ornekMetin.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Bir string üzerinde yaptığınız değişikler o string'i değiştirmez, size yeni bir kopyasını teslim eder.
            ornekMetin = textBox1.Text;
            ornekMetin = ornekMetin.Remove(3, 2);
            MessageBox.Show(ornekMetin);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            //Replace=> Metniniz içerisindeki bir karakteri ya da bir bölümü bir karakter-bölüm ile değiştirmenizi sağlar.

            ornekMetin = textBox1.Text;
            ornekMetin = ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //Split=> karakter olarak tanımladığınız simge ile metini birbirinden ayırır.

            string mailAdresleri = textBox1.Text;
            string[] adresler = mailAdresleri.Split(',', ';');
            foreach (var item in adresler)
            {
                MessageBox.Show(item);
            }

           
        }
    }
}


