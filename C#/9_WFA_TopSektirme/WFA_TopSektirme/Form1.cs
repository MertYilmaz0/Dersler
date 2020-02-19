using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("ok");
           


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// form içinde herhangi bir tuşa basıldığında...
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode)//left// yaratmış olduğumuz swtch case yapısı devreye giriyor(örn: klavyeden sol tuşuna bastık.)
            {
                case Keys.Left:// sol tuşa basılması durumunda
                    pictureBox1.Left -= 5;//picturebox 1in soluna -5 bir değer geliyor yani solundan tutup -5 değer kadar çekiyoruz.
                    break;//yapılan işlemden sonrada break yazarak işlemi durduruyoruz yani bitiriyoruz.
                case Keys.Right:
                    pictureBox1.Left += 5;
                    break;
                case Keys.Up:
                    pictureBox1.Top -= 5;
                    break;
                case Keys.Down:
                    pictureBox1.Top += 5;
                    break;
                case Keys.D:
                    timer1.Start();
                    break;
                case Keys.S:
                    timer2.Start();
                    break;
                case Keys.E:
                    timer1.Stop();
                    break;
                case Keys.A:
                    timer2.Stop();
                    break;
            }
        }

        int hizYatay = 10;//hareket etmesini istediğimiz objeye(burada bir picture box) + bir değer atıyoruz. Bu objeye nin üstünden veya solundan hareket etmesi için uygulanan değer.
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += hizYatay;//picturboxun saoluna atadığımız 10 değeri ekleniyor

            if (pictureBox1.Right >= this.Width)//eğer ki picture boxun sağı bulunduğu formun yatay konumuna eşit yada büyükse yani dokunuyorsa
            {
                hizYatay -= 10;//10 değer kaybediyor yani duruyor
            }
            else if (pictureBox1.Left <= 0)// eğer picture boxun solu küçük yada 0a eşit ise 
            {
                hizYatay = 10;// tekrar 10 oluyor
            }
        }

        int hizDikey = 10;// aynı işlem hız dikey için de geçerli  fakat timerlar herhangi bir komutla durdurulmadığı için sonsuz döngü içerisinde bu işlemler devam ediyor.
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += hizDikey;
            if (pictureBox1.Bottom >= this.Height)
            {
                hizDikey -= 10;
            }else if (pictureBox1.Top <= 0)
            {
                hizDikey = 10;
            }
        }
    }
}
