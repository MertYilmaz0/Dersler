using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        private void btnGetir_Click(object sender, EventArgs e)
        {
            //Eğer dışarıdan girilen sayı 0 dan küçük ise veya 100'den büyük ise kullanıcıyta uyarı versin.,
            sayi = Convert.ToInt32(txtSayi.Text);
            //if (sayi < 0)
            //{
            //    MessageBox.Show("0'dan küçük bir sayı giremezsiniz");
            //}
            //else
            //{
            //    if (sayi <= 100)
            //    {
            //        MessageBox.Show("Tebrikler doğru tanımlama");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Girmiş olduğunuz sayı 100'den büyük olamaz");
            //    }
            //}

            if (sayi < 0) 
            {
                MessageBox.Show("0'dan küçük bir sayı giremezsiniz");
            }
            else if (sayi > 100)
            {
                MessageBox.Show("100'den büyük bir sayı giremezsiniz");
            }
            else
            {
                MessageBox.Show("doğru tanımlama");
            }

        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            //textbox'a girilen sayı çift ise "sayı çifttir", tek ise "sayı tektir" mesajını kullancıya gösterin.

            //10%2==0

            sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi % 2 == 0)//gelen sayının 2'ye bölümünden geriye kalan sayı 0'a eşit ise...//true
            {
                MessageBox.Show("bu sayı ÇİFTTİR");
            }
            else//false
            {
                MessageBox.Show("bu sayı TEKTİR");
            }
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen kelimenin uzunluğu 8 karaktere eşit ya da büyükse "kayıt onaylandı" yazsın, değilse "lütfen daha uzun bir şifre tanımlayın" yazsın.

            //1.textbox içerisindeki kelimeyi değişken içerisine al
            //2. değişken içerisindeki kelimenin uzunluğunu al
            //3. kelimenin uzunluğu 8'e eşit mi veya 8'den büyük mü
                    //4. büyükse doğru
                    //5. küçükse yanlış.

            //string kelime = txtSayi.Text;
            //int kelimeUzunlugu = kelime.Length;
            //if (kelimeUzunlugu >= 8)
            //{
            //    MessageBox.Show("kayıt onaylandı");
            //}
            //else
            //{
            //    MessageBox.Show("lütfen daha uzun bir şifre tanımlayın");
            //}


            if (txtSayi.Text.Length>=8)//true
            {
                MessageBox.Show("kayıt onaylandı");
            }
            else//false
            {
                MessageBox.Show("lütfen daha uzun bir şifre tanımlayın");
            }



        }
    }
}
