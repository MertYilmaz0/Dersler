using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();//syntax ta code yazarak yeni bir textbox eklememizi sağlar.
            txt.Text = "Eklendi";

            this.Controls.Add(txt);// üzerinde bulunduğun formun controllerine ekle komutu.
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
