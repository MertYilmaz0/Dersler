using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler = { "Yozgat", "Bayburt", "Burdur", "Bilecik", "Osmaniye", "Kilis"};
        private void Form1_Load(object sender, EventArgs e)
        {
            //Foreach

            /*
             Kesinlikle iterasyon bulunmamaktadır.
             Kolleksiyon döngüsü olarak adlandırılır.
             Tip bağımlı döngüdür.
             */

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    MessageBox.Show(sehirler[i]);
            //}
            
            foreach(string s in sehirler)
            {
                MessageBox.Show(s);
            }

            //int[] sayilar = { 5, 9, 11, 15, 19, 200, 60 };

            //foreach(int sayi in sayilar)
            //{
            //    MessageBox.Show(sayi.ToString());
            //}

        }

        private void btnBolunmeHavuzu_Click(object sender, EventArgs e)
        {
            //123,54,76,876,4532,23,77,83,45,190

            //yukarıdaki sayılarıdan ikiye tam bölünenleri "listBox1" e tam bölünmeyenleri "listbox2" e atın.
            //hem ikiye hem üçe bölünenlerin kaç adet olduğunu label da gösterin.

            int[] sayilar = { 123, 54, 76, 876, 4532, 23, 77, 83, 45, 190 };// sayıları dizgiye alıyoruz.
            int tamBolunenler = 0;// 2 ve 3 e tam bölünenlerin sayısını bu değer içinde vereceğiz.
            foreach(int sayi in sayilar)// sayılar dizgisindeki her bir sayı değeri için alttaki karar yapısı devreye girer.
            {
                if (sayi % 2 == 0)// eğer sayı ikiye bölümünden kalan sıfır ise yani tam bölünebiliyorsa.
                {
                    listBox1.Items.Add(sayi);// o sayı listbox1 e eklenir.
                }
                else
                {
                    listBox2.Items.Add(sayi);//eğer sayı ikiye bölümünden kalan sıfır değilse yan, tam bölünemiyorsa sayı listbox2 ye eklenir.
                }
                if (sayi % 2 == 0 && sayi % 3 == 0)// sayı iki ve üçe tam bölünebiliyorsa...
                {
                    tamBolunenler++;// tam bölünenler değeri 1 artar.
                }
            }
            lblSonuc.Text = tamBolunenler.ToString();// 2 ve 3 e tam bölünen sayıların adedi labelda yazdırılır.

        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //Renk değiştire basıldığında form üzerindeki bütün butonların arkaplan rengini kırmızı yapın.
        
           foreach(Control ctrl in this.Controls)
            {
                if(ctrl is Button)
                {
                    if(ctrl.Name!= "btnBolunmeHavuzu"&&ctrl.Name!= "btnRenkDegistir")
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    
                }
            }
        }
    }
}
