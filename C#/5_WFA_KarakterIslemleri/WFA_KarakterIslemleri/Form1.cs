using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KarakterIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int karakterSayisi = 450;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //txtKarakterin içerisindeki karakter sayısını al
            //450'den karakter sayısını çıkar
            //çıkan sonucu label'a yaz.
           int suanKacKarakterVar= txtKarakter.Text.Length;
            int fark = karakterSayisi - suanKacKarakterVar;
            lblKarakter.Text = fark.ToString();
        }

       
    }
}
