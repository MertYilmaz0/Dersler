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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //butona her basıldığında form alanına rastgele butonlar eklensin.
            Random rnd = new Random();// random classda bir örnek alıyoruz.
            Button btn = new Button();//button classda bir örnek alıyoruz.
            int x = rnd.Next(0, this.ClientSize.Width-btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height-btn.Height);
            btn.Left = x;
            btn.Top = y;

            this.Controls.Add(btn);// bulunduğun formun controllerine btn yi ekle.

        }
    }
}
