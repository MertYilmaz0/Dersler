using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Design2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üzgünüz bir hata meydana geldi!");
            pbResim.Visible = false;
            btnNext.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem iptal Edildi!");
            lblYazi.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
