using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //picturebox'ın sadece sol (left) ve üst(top) özelliklerine değer ataması yapılabilir. alt ve sağ özellikleri sadece değerleri okunabilir. 
            #region Atları Koşturma
            pbAt1.Left += rnd.Next(10, 50);//40
            pbAt2.Left += rnd.Next(10, 50);//40
            pbAt3.Left += rnd.Next(10, 50);//40
            #endregion

            #region Spiker
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {
                lblSpiker.Text = "1. at önde gidiyor";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. at önde gidiyor";
            }
            else if (pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right)
            {
                lblSpiker.Text = "3. at önde gidiyor";
            } 
            #endregion

            #region Kazanma Durumu
            if (pbAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1. At Kazandı", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 19;
                    pbAt2.Left = 19;
                    pbAt3.Left = 19;
                }

            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. At Kazandı", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 19;
                    pbAt2.Left = 19;
                    pbAt3.Left = 19;
                }

            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. At Kazandı", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 19;
                    pbAt2.Left = 19;
                    pbAt3.Left = 19;
                }

            }
            #endregion


            //ÖDEV

            /*
                uygulama çalıştığında 3 adet zemin rengi tanımlansın;
                            --Çim
                            --Çamur
                            --Kum
                yukarıdaki renklerden biri yarış başladğında zemin rengi olarak atansın.
                Eğer zemin rengi çim gelirse 1. atın kazanma oranı %30 artsın.
                Eğer zemin rengi çamur olursa 2. atın kazanma oranı %30 artsın.
                Eğer zemin rengi çim olursa 3. atın kazanma %30 artsın.



             */

        }
    }
}
