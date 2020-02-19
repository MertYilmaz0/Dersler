using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //geriye değer döndüren ve geriye değer döndürmeyen.
            //parametre alan ve almayan
            MesajVer("Fatih");
        }

       void MesajVer(string deger)
        {
            MessageBox.Show("Hoşgeldin "+deger);
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            MesajVer(textBox1.Text);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            Topla(sayi1, sayi2);
            Topla(sayi1, sayi2, 10);
        }
        //Tanımlanan metotların parametre imzaları birbirinden farklı olması şartıyla dilediğiniz kadar aynı isme sahip metot oluşturabilirsiniz. aşağıda tanımlı olan iki adet "Topla" isminde metot tanımlandı. Görüldüğü üzere bu metotlardan ilkinde 2 adet parametre diğerinde 3 adet parametre tanımlı. eğer metotu çağırdığımız yerde 2 adet parametre gönderilirse toplama işlemi yapılacak 3 adet parametre gönderilirse toplma işlemi yaptıktan sonra gönderilen 3. parametre toplama dahil edilecek. parametre imzları tip bağımlı değildir. dilediğiniz tipi parametre olarak gönderebilirsiniz.
        void Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            MessageBox.Show(toplam.ToString());
        }

        void Topla(int s1, int s2, int ilaveSayi)
        {
            int toplam = s1 + s2;
            toplam = toplam + ilaveSayi;
            MessageBox.Show(toplam.ToString());
        }


    }
}
