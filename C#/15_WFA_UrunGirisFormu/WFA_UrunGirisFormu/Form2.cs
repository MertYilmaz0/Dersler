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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //GeriyeDegerDondurmeyenMetot();
            //GeriyeDegerDondurmeyenMetot("hava", 110, 30);
            //this.Controls.Add(GeriyeDegerDondurenMetot());
            this.Controls.Add(GeriyeDegerDondurenMetot("bilal", 50, 150));

        }

        //geriye değer döndürmeyen ve parametre almayan 
        void GeriyeDegerDondurmeyenMetot()
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            Button btn = new Button();
            btn.Text = "Cem";
            flw.Controls.Add(btn);
            this.Controls.Add(flw);
        }

        //geriye değer döndürmeyen parametre alan
        void GeriyeDegerDondurmeyenMetot(string ad, int genislik, int yukseklik)
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            Button btn = new Button();
            btn.Text = ad;
            btn.Width = genislik;
            btn.Height = yukseklik;
            flw.Controls.Add(btn);
            this.Controls.Add(flw);
        }

        //geriye değer döndüren parametre almayan metot
        Control GeriyeDegerDondurenMetot()
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            Button btn = new Button();
            btn.Text = "Ahmet";
            flw.Controls.Add(btn);
            return flw;
        }
        //Geriye değer döndüren parametre alan
        Control GeriyeDegerDondurenMetot(string ad,int yukseklik,int genislik)
        {
            FlowLayoutPanel flw = new FlowLayoutPanel();
            Button btn = new Button();
            btn.Text = ad;
            btn.Height = yukseklik;
            btn.Width = genislik;
            flw.Controls.Add(btn);
            return flw;
        }


    }
}
