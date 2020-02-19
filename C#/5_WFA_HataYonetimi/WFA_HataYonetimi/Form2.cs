using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HataYonetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(txtDeger.Text);
            MessageBox.Show("Güzeeeel! doğru tanımlama");
        }

        private void btnOnaylaYonetimli_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show("Güzeeeel! doğru tanımlama");
            }
            catch
            {
                MessageBox.Show("Bir şeyler oldu ama ne olduğunu bilmiyorum");
            }
        }

        private void btnOnaylaDetayli_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show("Güzeeeel! doğru tanımlama");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }

        private void btnOnaylaDetayliYonetim_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show("Güzeeeel! doğru tanımlama");
            }
            catch (FormatException)//Format hatası alındığında
            {
                MessageBox.Show("Lütfen sayısal bir karakter girin");
            }
            catch(OverflowException)//veri tipinin limiti aşıldığında
            {
                MessageBox.Show("Değer aşımı hatası");
            }
            finally//hata alınsa da alınmasa da çalışacak olan blok.
            {
                MessageBox.Show("işlem veritabanına kaydedildi!");
            }
        }
    }
}
