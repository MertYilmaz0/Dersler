using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Foreach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            object nesne = 1;

            if (nesne.GetType() == typeof(int))
            {
                MessageBox.Show("veri tipi int");
            }
            else
            {
                MessageBox.Show("veri tipi object");
            }

            //boxing (kutulama)
            object nesne1 = "ahmet";
            object nesne2 = 1.25f;
            object nesne3 = 'c';
            object nesne4 = true;

            //unboxing (kutudan dışarı çıkarma)

            //string gelenNesne1 = nesne1.ToString();
            //string gelenNesne1 = nesne1 as string;
            string gelenNesne1 = (string)nesne1;
            float gelenNesne2 = (float)nesne2; //cast işlemi (rica işlemi)


        }
    }
}
