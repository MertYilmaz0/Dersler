using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RakamlarinOkunusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtRakam.Text);

            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

            int onlarBasamagi = sayi / 10;
            int birlerBasamagi = sayi % 10;

            lblOku.Text = onlar[onlarBasamagi] + " " + birler[birlerBasamagi];

        }
    }
}
