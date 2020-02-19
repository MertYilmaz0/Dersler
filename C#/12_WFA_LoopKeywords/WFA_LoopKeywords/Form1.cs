using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LoopKeywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For
            //Foreach
            //While
            //Do While

            //Loop Keyword (Döngü Anahtar kelimeleri)

        

        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            //Break

            /*
              Bir döngü içerisinde koşullara sahipseniz ve koşulunuz sağlandığı takdirde döngüye devam etme gereği duymayacaksanız "break" anahtar kelimesiyle beraber ödngüyü sonlandırabilir ve bir sonraki işlemlerinize devam edebilirsiniz.
             */

            #region Switch case
            //string deger = "deneme";
            //switch (deger)
            //{
            //    case "deneme":
            //        MessageBox.Show("Değer Denemedir.");
            //        break;
            //    case "deneme1":
            //        MessageBox.Show("Değer deneme1'dir");
            //        break;

            //}

            //MessageBox.Show("İşlem tamamlandı"); 
            #endregion

            //1'den 100'e kadar rakamları listbox'a ekleyin. 

            for(int i=1; i<=100; i++)
            {
                listBox1.Items.Add(i);
                if (i == 50)
                {
                    break;
                    MessageBox.Show("yukarıda break abahtar kelimesi tanımlı"); //break anahtar kelimesinden sonra tanımladığınız kodlar hiç bir zaman okunmaz. çünkü break anahtar keliemsinden sonra kod bağlı bulunduğu alanı terkeder.
                }
            }

            MessageBox.Show("50'e kadar ekledim uygun mudur?");

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //Continue
            /*
                Döngümüz içerisindeki herhangi bir şartın sağlanması durumnunda işlemlerimize devam edebilmek için kullanmış olduğumuz anahtar kelime continue'dur.

             */

            //listbox içerisine 10 adet rastgele sayı ekleyin ancak aynı sayılar gelirse bir sonraki sayıyı eklesin. Aynı sayı aaynı zamanda mesaj kutusunda gösterilsin.

            Random rnd = new Random();
            for(int i=0; i<11; i++)
            {
                int rastgeleSayi = rnd.Next(1, 5);
                if (listBox1.Items.Contains(rastgeleSayi))
                {
                    MessageBox.Show(rastgeleSayi.ToString());
                    i--;
                    continue;

                }
                listBox1.Items.Add(rastgeleSayi);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Döngümüz şartı sağlandığı takdirde döngünün bağlı bulunduğu metottan komple çıkmamıza olanak sağlayan anahtar kelimedir.
            for (int i = 0; i < 100; i++)
            {
                if (i == 5)
                {
                    listBox1.Items.Add(i);
                    return;
                }
                MessageBox.Show("5'e eşit değil");
            }
            MessageBox.Show("5'e eşit");//koşul sağlandığı takdirde bu kodu okumayacak. çünkü return anahtar kelimesi tanımlı oldıuğu metodu (event) terkeder.

        }//"return" kod akışını buraya gönderir...
    }
}
