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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //butona tıklandığında 10 sütunlu ve 5 satırlı buton tanımlayınız.
            

        }

        private void btnSatirveSutunOlustur_Click(object sender, EventArgs e)
        {
            int sutunSayisi = Convert.ToInt32(nudSutun.Value);
            int satirSayisi = Convert.ToInt32(nudSatir.Value);

            #region Hava
            //for (int i = 1; i <= satirSayisi; i++)
            //{
            //    for (int j = 1; j <= sutunSayisi; j++)
            //    {
            //        Button btn = new Button();
            //        btn.Width = 90;
            //        btn.Height = 20;
            //        btn.Text = i + "x" + j;
            //        flowLayoutPanel1.Controls.Add(btn);

            //    }
            //}
            #endregion

            for (int i = 0; i < sutunSayisi; i++)
            {
                for (int j = 0; j < satirSayisi; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);
                    btn.Width = 90;
                    btn.Height = 23;
                    btn.Top = j * 23;
                    btn.Left = i * 90;
                    this.Controls.Add(btn);
                }
            }
            this.AutoSize = true;
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    MessageBox.Show(btn.Text);
        //}
    }
}
