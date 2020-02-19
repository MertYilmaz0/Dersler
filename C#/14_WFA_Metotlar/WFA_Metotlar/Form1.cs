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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //METOTLAR (Fonksiyon)

            /*
             Geriye değer döndürmeyen, yalnızca üzerine düşen işi yapan işlemlere void metotlar ya da subrutinler denir.
             //metotlar ikiye ayrılır;
                    --Geriye değer döndüren
                        --Parametre alan
                        --Parametre almayan
                    --Geriye değer döndürmeyen metotlar
                        --Parametre alan
                        --Parametre almayan

            //Metot isimleri PascalCase olarak emir kipi şeklinde verilmelidir.
             */
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            #region TextBox temizle işlemleri
            //textBox1.Clear();
            //textBox2.Text = "";
            //textBox3.Text = string.Empty;
            //textBox4.Text = null;
            //textBox5.Text = default(string); 
            #endregion

            Temizle();
        }

        //geriye değer döndürmeyen ve parametre almayan metot.
        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
