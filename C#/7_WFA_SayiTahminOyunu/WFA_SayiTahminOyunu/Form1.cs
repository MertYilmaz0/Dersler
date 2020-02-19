using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //instance (örnek)
        Random rnd = new Random();
        int tutulanSayi;
        int tahminHakki = 5;
        int seviye = 1;
        int seviyeMax=10;

        private void Form1_Load(object sender, EventArgs e)
        {
            tutulanSayi = rnd.Next(1, 11);
            //this anahtar kelimesi bağlı bulunan alanı temsil eder.
            this.Text = tutulanSayi.ToString();

        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahminEdilenSayi = Convert.ToInt32(txtTahmin.Text);
            if (tahminEdilenSayi > 0)
            {
                if (tahminHakki > 0)
                {
                    if (tahminEdilenSayi == tutulanSayi)
                    {
                        MessageBox.Show("Tebrikler! Doğru tahmin");
                        seviye++;
                        lblSeviye.Text = seviye.ToString();
                        tahminHakki = 5;
                        lblTahminHakki.Text = tahminHakki.ToString();
                        tutulanSayi = rnd.Next(1, seviye * seviyeMax + 1);
                        this.Text = tutulanSayi.ToString();
                    }
                    else if (tahminEdilenSayi < tutulanSayi)
                    {
                        lblSonuc.Text = "daha büyük bir sayı giriniz";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                    else
                    {
                        lblSonuc.Text = "daha küçük bir sayı giriniz";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                }
                else
                {
                    if (tahminHakki == 0)
                    {
                        MessageBox.Show("Tahmin hakkınız olmadığı için oyunu oynamazsınız");
                        btnTahminEt.Enabled = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen 0'dan büyük bir değer giriniz");
            }
        }
    }
}
