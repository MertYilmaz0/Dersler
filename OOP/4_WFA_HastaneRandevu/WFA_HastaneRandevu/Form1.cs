using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Brans> bolumler = new List<Brans>();
        List<string> saatler = new List<string>()
        {
            "09:00","09:30","10:00","10:30","11:00","11:30","12:00"
        };
        List<Randevu> randevular = new List<Randevu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Olustur();
            
        }

        void Olustur()
        {
            for (int i = 0; i < saatler.Count; i++)
            {
                Button button = new Button();
                button.Text = saatler[i];
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Bu saatte maalesef randevunuz uygun değildir.");
               
            }
            if (txtTcKimlikNo.Text == string.Empty || txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || cmbRandevuBrans.SelectedIndex < 0 || cmbRandevuDoktor.SelectedIndex < 0 || dtpRandevu.Value < DateTime.Now)
            {
                MessageBox.Show("Lütfen randevu bilgilerinizi eksiksiz ve doğru bir şekilde giriniz!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Randevu almak istediğinize emin misiniz?", "Randevu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    button.BackColor = Color.Red;
                    //button.Enabled = false;
                    Randevu randevu = new Randevu();
                    randevu.Ad = txtAd.Text;
                    randevu.Soyad = txtSoyad.Text;
                    randevu.Doktor = cmbRandevuDoktor.SelectedItem as Doktor;
                    randevu.Brans = cmbRandevuBrans.SelectedItem as Brans;
                    randevu.Tarih = dtpRandevu.Value;
                    randevu.TCKN = txtTcKimlikNo.Text;
                    randevu.Saat = button.Text;
                    randevular.Add(randevu);
                }
            }
        }

        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.Ad = txtBransAd.Text;
            brans.Doktorlar = new List<Doktor>();
            bolumler.Add(brans);
            //combobox'ın datasource özelliği içerisine datanın kaynağını aldığı için biz aşağıdaki işlemde hem doktorun hem de randevunun comboBoxlarına globalde oluşturmuş ve brans ekle event'ı içerisinde atamış olduğumuz bölümleri liste halinde gösnderdik. Bu gönderim esnasında bolumlerin içerisinde birden fazla property olduğu için ve hangisni gösterceğini bilemediği içind de bağlı bulunun class içerisinde Polymorphism yani çok biçimlilik uygulayarak geriye doğrudan bağlı bulunan (Branş) içerisindeki Ad isimli özelliği döndürdük.
            cmbDoktorBrans.DataSource = cmbRandevuBrans.DataSource = bolumler.ToList();
            txtBransAd.Clear();

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktorAd.Text;
            Brans b = cmbDoktorBrans.SelectedItem as Brans; //Dahiliye
            b.Doktorlar.Add(doktor);
            cmbDoktorBrans.SelectedIndex = -1;
            txtDoktorAd.Clear();

        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans brans = cmbRandevuBrans.SelectedItem as Brans;
            cmbRandevuDoktor.DataSource = brans.Doktorlar.ToList();
        }

      
    }
}
