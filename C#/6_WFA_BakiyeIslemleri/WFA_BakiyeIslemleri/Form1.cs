using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       decimal bakiye = 500;
        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde lblBakiye.Text özelliğine 500 TL tanımla
            
            lblBakiye.Text = bakiye.ToString();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            //numericUpDown.Value geriye decimal değer döndürür.
            if (bakiye >= nudParaCek.Value)
            {
                bakiye -= nudParaCek.Value;
                lblBakiye.Text = bakiye.ToString();

            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Para Yükleyin!");
            }

        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            if (nudParaYatir.Value > 0)
            {
                bakiye += nudParaYatir.Value;
            }
            else
            {
                MessageBox.Show("En az 1 TL yükleyin");
            }
            lblBakiye.Text = bakiye.ToString();
        }
    }
}
