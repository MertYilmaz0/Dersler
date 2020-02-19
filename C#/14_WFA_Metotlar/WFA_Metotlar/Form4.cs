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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Geriye değer döndüren ve parametre almayan metot.
            int sonuc = Topla();
            MessageBox.Show(sonuc.ToString());

            //Metot Overload
            int sonuc2 = Topla(8, 3);
            MessageBox.Show(sonuc2.ToString());
        }

        int Topla()
        {
            int toplam = 10 + 5;
            return toplam;

        }

        int Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
                return toplam;

        }
    }
}
