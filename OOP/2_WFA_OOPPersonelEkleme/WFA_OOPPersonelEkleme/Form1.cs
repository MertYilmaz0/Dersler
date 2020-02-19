using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPPersonelEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Personel Personel = new Personel();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.SelectedItem as string;
            string departman = cmbDpartman.SelectedItem as string;
            Personel.PersonelEkle(PersonelBilgileri(),departman,cinsiyet);
           

            //personeller.Add(p);
          

           
        }

        public Personel PersonelBilgileri()
        {
            Personel p = new Personel();
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.Adres = txtAdres.Text;
            p.Cinsiyet = cmbCinsiyet.SelectedItem as string;
            p.Departman = cmbDpartman.SelectedItem as string;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.MaasBrut = nudMaasBrut.Value;
            p.MaasNet = nudMaasNet.Value;
            p.SgkNo = txtSgkNo.Text;
            p.TCKN = txtTCKN.Text;
            p.TelefonNo = txtTelefonNo.Text;

            return p;
        }

        List<string> Departman = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Departman.Add("Finans");
            Departman.Add("IT");
            Departman.Add("Satın Alma");
            Departman.Add("Satış Pazarlama");

            foreach (string departman in Departman)
            {
                cmbDpartman.Items.Add(departman);
            }

            #region Eski Yöntem
            ////Departmanlar
            //cmbDpartman.Items.Add("Finans");
            //cmbDpartman.Items.Add("IT");
            //cmbDpartman.Items.Add("Satın Alma");
            //cmbDpartman.Items.Add("Satış Pazarlama"); 
            #endregion

            //Cinsiyet
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");


        }
    }
}
