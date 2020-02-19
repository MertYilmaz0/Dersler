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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //parametre olarak bir kontrol alan metot yazınız. bu metot ilgili kontrolün arkplan rengini geri döndürsün. 
        }

        Color ArkaplanYakalayici(Control arkaplan)
        {
            return arkaplan.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = ArkaplanYakalayici(button1);
        }
    }
}
