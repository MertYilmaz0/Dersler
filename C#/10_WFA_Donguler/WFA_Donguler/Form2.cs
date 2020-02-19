using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Donguler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Do While

            /*
                Do while döngüsü, while döngüsü ile aynı yapıya sahiptir. Tek farkı do while döngüsü ne olursa olsun en az bir kez çalışır.

             */

            //int sayac = 1;
            //while (sayac <= 100)
            //{
            //    listBox1.Items.Add(sayac);
            //    sayac++;
            //}

            //i => iterayonu temsil etmektedir. yani döngü her çalıştığında i bir kez artacak veya azalacak.
            int i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i <= 100);



        }
    }
}
