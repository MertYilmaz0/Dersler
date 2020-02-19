using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Enum (Enumatration) - Sabit

            /*
                Program içerisinde kullanılan sabitlerin anlamdırılması için bir grup altında o sabitleri toplamamızı sağlayan yapıdır. (numaralandırma)

             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte i = Convert.ToByte(textBox1.Text);
            Gunler gunAdi;
            gunAdi =(Gunler)i;
            MessageBox.Show(gunAdi.ToString());
        }
    }
}
