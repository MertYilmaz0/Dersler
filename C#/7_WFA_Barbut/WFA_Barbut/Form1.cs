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
        //instance (örnek alma)
        Random rnd = new Random();
        int oyuncuZar1;
        int oyuncuZar2;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Random Sınıfı
            //Rastgele sayı tanımlamak için Random isimli sınıfı kullanmalıyız.

            //Instance(örnek alma)
            //int rastgeleSayi = rnd.Next(1, 7);
            //MessageBox.Show(rastgeleSayi.ToString());

            #endregion

            #region Oyun Kuralları
            /*
                 * seviye 1
                   form load olduğunda  btnOyuncuZar2 pasif olarak form açılacak. ilk önce  btnOyuncuZar1 butonu tıklandığında bağlı bulunan label'da 1-6 arasında rastgele bir sayı tanımlanarak gösterilecek. ardından  btnOyuncuZar1 butonu pasif,  btnOyuncuZar2 butonu aktif hale gelecek.  btnOyuncuZar2 butonuna tıklandığında bağlı bulunan label'a yine 1-6 arasında rastgele bir sayı tanımlanacak. hemen ardından kazanma durumu belli olacak (hangisi büyükse o kazanmış olacak) lblSonuc isimli label da büyük sayı atanı kazandı olarak gösterielcek.  aynı sayı gelmesi durumunda berabere yazacak.

                seviye 2

                    form alanı içerisinde 1. oyuncu ve 2. oyuncuya ait bakiye alanları tanımlayın her bir oyuncu bakiyesine yükleme işlemi ve bakiyeden çekme işlemi gerçekleştirebilsin. ilk önce 1. oyuncu ortaya tanımlamış olduğu bakiyeyi yatıracak ardından 2. oyuncu tanımlamış olduğu bakiyeyi yatıracak. seviye 1 de gerçekleşen sonuçla beraber ortadaki toplam bara kazananın bakiyesine aktarılacak.

                seviye 3

                      uygulama açıldığında 1. oyuncu ve 2. oyuncu yerine textboxlar atanacak. oyuncuların isimleri girilmeden oyuna başlanmayacak. seviye 1 ve seviye 2 gerçekleştikten sonra işlemlerin tamamı listbox'a aktarılacak.

                 */
            #endregion

            
            btnOyuncuZar2.Enabled = false;
        }

        private void btnOyuncuZar1_Click(object sender, EventArgs e)
        {
            btnOyuncuZar1.Enabled = false;
            btnOyuncuZar2.Enabled = true;
            oyuncuZar1 = rnd.Next(1, 7);
            lblOyuncuZar1.Text = oyuncuZar1.ToString();
        }

        private void btnOyuncuZar2_Click(object sender, EventArgs e)
        {
            btnOyuncuZar2.Enabled = false;
            oyuncuZar2 = rnd.Next(1, 7);
            lblOyuncuZar2.Text = oyuncuZar2.ToString();
            //todo oyunu bitir
            if (oyuncuZar1 == oyuncuZar2)
            {
                lblSonuc.Text = "Berabere...";
            }else if (oyuncuZar1 > oyuncuZar2)
            {
                lblSonuc.Text = "1. Oyuncu Kazandı";
            }
            else
            {
                lblSonuc.Text = "2. oyuncu kazandı";
            }

            DialogResult dr = MessageBox.Show("Tekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                MessageBox.Show("Tamam sen bilirsin.. oynayalım.");
                btnOyuncuZar1.Enabled = true;

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
