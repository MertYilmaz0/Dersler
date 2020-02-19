using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnSayiUret_Click(object sender, EventArgs e)
        {

            //Sayısal Loto

            /*
             Form alanında bulunan 8 adet ListBox'a butona basıldığında rastgele olarak 1'den 49'a kadar rakamlar eklenecek.
             Her bir listbox'a 6'şar rakam eklenecek.
             ListBox içerisinde tekrar eden rakamlar olmayacak.
             */

            foreach (Control ctrl in this.Controls)
            {

                if(ctrl is ListBox)//boxing (kutulama)
                {
                    
                    ListBox lst = (ListBox)ctrl;//unboxing
                    lst.Items.Clear();
                    int sayac = 0;
                    while (sayac < 6)
                    {
                        int sayi = rnd.Next(1, 50);
                        if (!lst.Items.Contains(sayi))
                        {
                            lst.Items.Add(sayi);
                            sayac++;
                        }
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
