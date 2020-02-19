using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye1 = 500;
        decimal bakiye2 = 500;
        //instance (örnek alma)
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

            lblOyuncu1Bakiye.Text = bakiye1.ToString();
            lblOyuncu2Bakiye.Text = bakiye2.ToString();

            lblOyuncu1Bakiye.Visible = false;
            oyuncu1Box1.Visible = false;
            oyuncu1Box2.Visible = false;
            lblOyuncu2Bakiye.Visible = false;
            oyuncu2Box1.Visible = false;
            oyuncu2Box2.Visible = false;
            btnKumar1.Visible = false;
            btnKumar2.Visible = false;

            btnZar2.Enabled = false;

            #region Random Sınıfı
            //Rastgele sayı tanımlamak için Random isimli sınıfı kullanmalıyız.

            //Instance(örnek alma)
            //int rastgeleSayi = rnd.Next(1, 7);
            //MessageBox.Show(rastgeleSayi.ToString());
           
            #endregion           
        }

        private void btnZar1_Click(object sender, EventArgs e)
        {
            int sayi1 = rnd.Next(1, 7);
            lblOyuncuZar1.Text = sayi1.ToString();
            btnZar1.Enabled = false;
            btnZar2.Enabled = true;

        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
            int sayi2 = rnd.Next(1, 7);
            lblOyuncuZar2.Text = sayi2.ToString();
            btnZar2.Enabled = false;
            btnZar1.Enabled = true;

            if ((Convert.ToInt32(lblOyuncuZar1.Text)) > (Convert.ToInt32(lblOyuncuZar2.Text)))

                lblSonuc.Text = "1. OYUNCU KAZANDI!";

            if ((Convert.ToInt32(lblOyuncuZar2.Text)) > (Convert.ToInt32(lblOyuncuZar1.Text)))

                lblSonuc.Text = "2. OYUNCU KAZANDI!";

            if ((Convert.ToInt32(lblOyuncuZar1.Text)) == (Convert.ToInt32(lblOyuncuZar2.Text)))

                lblSonuc.Text = "BERABERE";



        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void oyuncu1ATM_Click(object sender, EventArgs e)
        {
            lblOyuncu1Bakiye.Visible = true;
            oyuncu1Box1.Visible = true;
            oyuncu1Box2.Visible = true;
            btnKumar1.Visible = true;
        }

        

        private void oyuncu2ATM_Click(object sender, EventArgs e)
        {
            lblOyuncu2Bakiye.Visible = true;
            oyuncu2Box1.Visible = true;
            oyuncu2Box2.Visible = true;
            btnKumar2.Visible = true;
        }

        private void btnCik2_Click(object sender, EventArgs e)
        {
            lblOyuncu2Bakiye.Visible = false;
            oyuncu2Box1.Visible = false;
            oyuncu2Box2.Visible = false;
            btnKumar2.Visible = false;
        }

        private void btnCik1_Click(object sender, EventArgs e)
        {
            lblOyuncu1Bakiye.Visible = false;
            oyuncu1Box1.Visible = false;
            oyuncu1Box2.Visible = false;
            btnKumar1.Visible = false;
        }

        /*
             * seviye 1
               form load olduğunda  btnOyuncuZar2 pasif olarak form açılacak. ilk önce  btnOyuncuZar1 butonu tıklandığında bağlı bulunan label'da 1-6 arasında rastgele bir sayı tanımlanarak gösterilecek. ardından  btnOyuncuZar1 butonu pasif,  btnOyuncuZar2 butonu aktif hale gelecek.  btnOyuncuZar2 butonuna tıklandığında bağlı bulunan label'a yine 1-6 arasında rastgele bir sayı tanımlanacak. hemen ardından kazanma durumu belli olacak (hangisi büyükse o kazanmış olacak) lblSonuc isimli label da büyük sayı atanı kazandı olarak gösterielcek.  aynı sayı gelmesi durumunda berabere yazacak.

            seviye 2

                form alanı içerisinde 1. oyuncu ve 2. oyuncuya ait bakiye alanları tanımlayın her bir oyuncu bakiyesine yükleme işlemi ve bakiyeden çekme işlemi gerçekleştirebilsin. ilk önce 1. oyuncu ortaya tanımlamış olduğu bakiyeyi yatıracak ardından 2. oyuncu tanımlamış olduğu bakiyeyi yatıracak. seviye 1 de gerçekleşen sonuçla beraber ortadaki toplam bara kazananın bakiyesine aktarılacak.

            seviye 3

                  uygulama açıldığında 1. oyuncu ve 2. oyuncu yerine textboxlar atanacak. oyuncuların isimleri girilmeden oyuna başlanmayacak. seviye 1 ve seviye 2 gerçekleştikten sonra işlemlerin tamamı listbox'a aktarılacak.

             */
    }
}
