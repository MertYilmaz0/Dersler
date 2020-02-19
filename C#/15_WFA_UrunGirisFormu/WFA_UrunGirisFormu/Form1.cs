using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UrunGirisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kategoriler = { "Giyim", "Teknoloji", "Ayakkabı", "Gıda" };
        private void Form1_Load(object sender, EventArgs e)
        {
            //ürün kaytme işlemini gerçekleştiren bir metot yazın. Metot içerisinde listview doğrudan değerleri göndersin.
            foreach (string kategori in kategoriler)
            {
                cmbKategoriler.Items.Add(kategori);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = txtUrunAd.Text;
            //lvi.SubItems.Add(kategoriler[cmbKategoriler.SelectedIndex]);//köşeli parantezler 
            //lvi.SubItems.Add(nudFiyat.Value.ToString());
            //lvi.SubItems.Add(nudStok.Value.ToString());

            //listView1.Items.Add(lvi);
            Ekle();
        }

        void Ekle()
        {
            foreach (var item in this.Controls)
            {
                if(item is ListView)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.UseItemStyleForSubItems = false;
                    lvi.Text = txtUrunAd.Text;
                    lvi.SubItems.Add(kategoriler[cmbKategoriler.SelectedIndex]);//köşeli parantezler 
                    lvi.SubItems.Add(nudFiyat.Value.ToString());
                    lvi.SubItems.Add(nudStok.Value.ToString());

                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}
