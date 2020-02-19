using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Statics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Static Class, Static Member

            /*
                Static olarak işaretlenmiş bir yapıyı kullanmak için instance alma işlemini yapmak zorunda değiliz.
             */

            //FizikKutuphanesi fizik = new FizikKutuphanesi();
            //fizik.YerCekimiKuvveti = 2;
            MessageBox.Show(FizikKutuphanesi.YerCekimiKuvveti.ToString());

            //Personel isminde bir class oluşturun. ad, soyad, tc kimlik no olsun 
            //Kaç tane instance alırsak alalım toplamda kaç personel olduğunu saydırıp daha sonra sayılan personeli mesaj kutusunda gösterin.

            Personel p1=new Personel();

            Personel p2 = new Personel();

            Personel p3 = new Personel();

            MessageBox.Show(Personel.PersonelSayisi.ToString());
           
        }
    }
}
