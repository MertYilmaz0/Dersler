using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Reference And Value Types (referans ve değer tipler)

            int sayi = 5;

            Araba araba = new Araba();
            araba.Marka = "Honda";


            
        }
    }
}
