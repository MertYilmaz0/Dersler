using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Personel pers = new Personel();
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            pers.Ad = txtAd.Text;
            pers.Soyad = txtSoyad.Text;
            pers.TcKimlikno = txtKimlikno.Text;
            pers.Departman = txtDepartman.Text;
            pers.TelefonNo = txtTelefonno.Text;
            pers.Adress = txtAdres.Text;
            pers.SgkNo = (int)nudSgkno.Value;
            pers.Cinsiyet = txtCinsiyet.Text;
            pers.MaasNet = (int)nudMaasnet.Value;
            pers.MaasBurut = (int)nudMaasburut.Value;
            pers.Burc = txtBurc.Text;
            pers.BankaBilgisi = txtbankaBilgisi.Text;
            pers.HesapNo = (int)nudHesapno.Value;
            pers.Yas = (int)nudYas.Value;
            listBox1.Items.Add("AD:" + pers.Ad + "SOYAD:" + pers.Soyad + "TC KİMLİK NO:" + pers.TcKimlikno + "DEPARTMAN:" + pers.Departman + "TELEFON NO:" + pers.TelefonNo + "ADRES:" + pers.Adress + "SGK NO:" + pers.SgkNo + "CİNSİYET:" + pers.Cinsiyet + "NET MAAŞ:" + pers.MaasNet + "BURUT MAAS:" + pers.MaasBurut + "BURÇ:" + pers.Burc + "BANKA BİLGİSİ:" + pers.BankaBilgisi + "HESAP NO:" + pers.HesapNo + "YAŞI:" + pers.Yas  );


            
            
        }
    }
}
