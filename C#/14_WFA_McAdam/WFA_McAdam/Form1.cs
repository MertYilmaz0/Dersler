using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Hamburger otomasyon
         *Menüleri oluştur
         * Fiyatları oluştur
         * 
             */
        string[] menuler = { "McChicken", "Whooper", "DoubleQuarterPounder", "McAdana" };
        decimal[] fiyatlar = { 12.90m, 20, 45, 30 };
        decimal toplamTutar;
        private void Form1_Load(object sender, EventArgs e)
        {
            rbOrta.Checked = true;
            //cmbMenu.Items.Add(menuler);
            foreach (string menu in menuler)
            {
                cmbMenu.Items.Add(menu);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal siparisFiyat = 0;
           siparisFiyat+= fiyatlar[cmbMenu.SelectedIndex];
            string siparisBilgisi = string.Empty;
            siparisBilgisi += cmbMenu.SelectedItem + " ";

            if (rbKing.Checked)
            {
                siparisFiyat += 5;
                siparisBilgisi += rbKing.Text + " ";
            }
            else if (rbBuyuk.Checked)
            {
                siparisFiyat += 2;
                siparisBilgisi += rbBuyuk.Text + " ";
            }
            else
            {
                siparisBilgisi += rbOrta.Text + " ";
            }

            string ekstraBilgileri = "(";
            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    siparisFiyat += 1;
                    ekstraBilgileri += item.Text + " ";
                }
            }
            ekstraBilgileri += ")";

            siparisBilgisi += ekstraBilgileri + " ";
            siparisFiyat *= nudAdet.Value;
            siparisBilgisi += "Adet: " + nudAdet.Value + " ";
            siparisBilgisi += "Toplam Tutar:" + siparisFiyat.ToString();
            listBox1.Items.Add(siparisBilgisi);
            toplamTutar += siparisFiyat;
        }
        
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Toplam Sipariş Sayısı:{0}\nToplam Sipariş Tutarı:{1}", listBox1.Items.Count, toplamTutar));
            Temizle();
        }

        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = -1;
                }
                else if(item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Text == "Orta")
                    {
                        rb.Checked = true;
                    }
                }
                else if(item is GroupBox)
                {
                    foreach (CheckBox chk in item.Controls)
                    {
                        chk.Checked = false;
                    }
                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)item;
                    nud.Value = 0;
                }
                else if(item is ListBox)
                {
                    ListBox lst = (ListBox)item;
                    lst.Items.Clear();
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(1,7);
            RandomMenuler menuAdi;
            menuAdi = (RandomMenuler)i;

            DialogResult dr= MessageBox.Show("GÜNÜN MENÜSÜ: "+menuAdi.ToString());
            int deger = i;
            string mesaj = "";
            switch (deger)
            {               
                case 1:
                    CigKofte cigkofte = new CigKofte();
                    mesaj = string.Format("İçindekiler => {0}", cigkofte.Ozellik());
                    break;
                case 2:
                    UrfaKebab urfakebab = new UrfaKebab();
                    mesaj = string.Format("İçindekiler => {0}", urfakebab.Ozellik());
                    break;
                case 3:
                    AdanaKebab adanakebab = new AdanaKebab();
                    mesaj = string.Format("İçindekiler => {0}", adanakebab.Ozellik());
                    break;
                case 4:
                    Yahni yahni = new Yahni();
                    mesaj = string.Format("İçindekiler => {0}", yahni.Ozellik());
                    break;
                case 5:
                    Tavuk tavuk = new Tavuk();
                    mesaj = string.Format("İçindekiler => {0}", tavuk.Ozellik());
                    break;
                case 6:
                    KuruFasulye kurufasulye = new KuruFasulye();
                    mesaj = string.Format("İçindekiler => {0}", kurufasulye.Ozellik());
                    break;
                case 7:
                    InegolKofte inegolkofte = new InegolKofte();
                    mesaj = string.Format("İçindekiler => {0}", inegolkofte.Ozellik());
                    break;               
            }
            MessageBox.Show(mesaj);


        }
    }
}
