using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Abstraction
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<MuzikAleti> muzikAletleri = new List<MuzikAleti>();
        List<Muzisyen> muzisyen = new List<Muzisyen>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //MuzikAleti muzikAleti = new MuzikAleti();

            Keman keman = new Keman();
            Klavye klavye = new Klavye();

            BasGitar basGitar = new BasGitar();

            keman.Marka = "Gibson";
            keman.Aciklama = "Çok pahalı";

            klavye.Marka = "KORG";
            klavye.Aciklama = "Düğünlerde çalınır";

            basGitar.Marka = "Yamaha";
            basGitar.Aciklama = "İyi ses çıkar";


            Muzisyen klavyeci = new Muzisyen();
            
            klavyeci.Ad = "Mert";
            klavyeci.Soyad = "Yılmaz";
            klavyeci.CaldigiEnstruman = klavye;

            MessageBox.Show(string.Format("Muzisyen Adı:{0}\nSoyad:{1}\nÇaldığı Enstruman Sesi:{2}\nÇaldığı Enstruman Markası:{3}", klavyeci.Ad, klavyeci.Soyad, klavye.Cal(),klavye.Marka));


            muzikAletleri.Add(keman);
            muzikAletleri.Add(klavye);
            muzikAletleri.Add(basGitar);

            muzisyen.Add(klavyeci);

        }
        List<string> enstrumanlar = new List<string>();
        private List<string> addItems()
        {

            Enstrüman enstrüman = new Enstrüman();
            enstrüman.ensAd = txtEns.Text;
            enstrumanlar.Add(txtEns.Text);


            return enstrumanlar;
        }

        private void btnEns_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.AddRange(addItems().ToArray());
            listBox1.MouseDoubleClick += ListBox1_MouseDoubleClick;
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Visible = true;
            lblMuzisyen.Visible = true;
            txtMuzisyen.Visible = true;
            btnMuzisyen.Visible = true;
        }

        private void btnMuzisyen_Click(object sender, EventArgs e)
        {
            Muzisyen sanatci = new Muzisyen();

            sanatci.Ad = txtMuzisyen.Text;
            sanatci.ensAd = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(sanatci.Ad +"=>"+ sanatci.ensAd);
            muzisyen.Add(sanatci);
            
            
            
        }
    }
}
