using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFTelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KisiEklemeEntities kisiDb = new KisiEklemeEntities();  
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            kisiDb.Bilgilers.Add(
                new Bilgiler
                {
                    PersonelAd = txtAd.Text,
                    PersonelSoyad = txtSoyad.Text,
                    PersonelTel = Convert.ToInt32(txtTelefonNo.Text)

                }
                );
            kisiDb.SaveChanges();
        }
    }
}
