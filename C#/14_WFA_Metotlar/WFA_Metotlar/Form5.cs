using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string sonuc;
        private void Form5_Load(object sender, EventArgs e)
        {

        }



        #region İşlemler
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = Topla(sayi1, sayi2);
            lblSonuc.Text = sonuc;
        }

        private void BtnCikart_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = Cikart(sayi1, sayi2);
            lblSonuc.Text = sonuc;
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = Carp(sayi1, sayi2);
            lblSonuc.Text = sonuc;
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = Bol(sayi1, sayi2);
            lblSonuc.Text = sonuc;
        } 
        #endregion

        #region Metotlar
        string Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam.ToString();
        }

        string Cikart(int s1, int s2)
        {
            int fark = s1 - s2;
            return fark.ToString();
        }

        string Bol(int s1, int s2)
        {
            int bolum = s1 / s2;
            return bolum.ToString();
        }

        string Carp(int s1, int s2)
        {
            int carpim = s1 * s2;
            return carpim.ToString();
        } 
        #endregion
    }
}
