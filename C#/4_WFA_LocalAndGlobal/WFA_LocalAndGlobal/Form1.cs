using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LocalAndGlobal
{
    public partial class Form1 : Form
    {
        //global alan
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Local ve Global Değişkenler
             C#'ta oluşturduğumuz yapıların scope {} alanlarına göre erişebilirlik durumları vardır. Bunlara yaşan alanı denir. Bir event içerisinde tanımlanan bir değişkene başka bir event içerisinden erişemeyiz. Bir değişken birden fazla event içerisinden erişmek istediğimizde değişkeni scope alanları dışında yani global alana tanımlamamız gerekmektedir.
             */

            //local alan
            //string deger = "deneme";
            //MessageBox.Show(deger);
            //deger = "form yüklendi!";
            //MessageBox.Show(deger);

        }
        //global alan
        string deger;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            //local alan
            //string deger = "deneme 2";
            //MessageBox.Show(deger);
            //deger = "Buton Tıklandı";
            //MessageBox.Show(deger);
            //MessageBox.Show(deger);
            textBox1.Text = deger;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            deger = textBox1.Text;
            textBox1.Clear();
        }
    }
}
