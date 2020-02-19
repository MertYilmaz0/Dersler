using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Temizle()
        {

            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is RadioButton)
                {
                    RadioButton rb = ctrl as RadioButton;
                    rb.Checked = false;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
                else if (ctrl is ListBox)
                {
                    ListBox lst = ctrl as ListBox;
                    lst.Items.Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.Text = null;
                }
            }
            foreach (Control ctrl in gbEkstra.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
            }
            toplam = 0.00;
            MessageBox.Show("Siparişiniz Alındı!");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cbmMenu.Items.Add("McChicken");
            cbmMenu.Items.Add("Wooper");
            cbmMenu.Items.Add("DoubleQuarterPounder");
            cbmMenu.Items.Add("McAdana");
            


        }
        double toplam = 0.00;
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            

            if (cbmMenu.SelectedItem.ToString() == "McChicken")
            {
                toplam += 12.90;
                lstSiparis.Items.Add("McChicken" );
                
                
            }
            if (cbmMenu.SelectedItem.ToString() == "Wooper")
            {
                toplam += 20.00;
                lstSiparis.Items.Add("Wooper");
                
               
            }
            if (cbmMenu.SelectedItem.ToString() == "DoubleQuarterPounder")
            {
                toplam += 45.00;
                lstSiparis.Items.Add("DoubleQuarterPounder");
                
                
                
            }
            if (cbmMenu.SelectedItem.ToString() == "McAdana")
            {
                toplam += 30.00;
                lstSiparis.Items.Add("McAdana");
                
                
                
            }



            if (rbBuyuk.Checked)
            {
                toplam += 2.00;
            }
            if (rbKing.Checked)
            {
                toplam += 5.00;
            }



            if (chkMarul.Checked)
            {
                toplam += 1.00;
            }
            if (chkPeynir.Checked)
            {
                toplam += 1.00;
            }
            if (chkRanch.Checked)
            {
                toplam += 1.00;
            }
            if (chkSalgam.Checked)
            {
                toplam += 1.00;
            }
            if (chkSogan.Checked)
            {
                toplam += 1.00;
            }
            if (chkTursu.Checked)
            {
                toplam += 1.00;
            }

            toplam = Convert.ToInt32(nudAdet.Value) * toplam;

            lstSiparis.Items.Add(toplam);


            //hesapla butonuna basıldığında...
            //cmbMenude seçilen değer fiyat basında alınacak
            //eğer rborta seçiliyse fiyat aynı kalacak, eğer rbBuyuk seçiliyse +2 Tl eklenecek,eğer king boy seçilirse +5tl menü fiyatına eklenecek.
            //Seçilen adet miktarı ile çarpılacak.
            //Listboxa toplam fiyat yazılacak.
            //seçili tüm kontroller sıfırlanacak.
            //------
            //Sipariş ver butonuna tıklandığında
            //Toplam sipariş adedi ve ödenecek tutar messagebox da gösterilecek.
            //Tüm form sıfırlanacak.
        }
        
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Temizle();
            
        }
    }
}
