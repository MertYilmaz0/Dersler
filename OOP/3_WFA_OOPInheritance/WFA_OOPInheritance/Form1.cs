using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitaplar = new List<Kitap>();
        List<Film> filmler = new List<Film>();
        List<Muzik> muzikler = new List<Muzik>();
        List<Elektronik> elektronikler = new List<Elektronik>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dil
            Dil tr = new Dil();
            tr.DilAd = "Türkçe";
            tr.Aciklama = "Türkçe";


            KisiselGelisim kisiselGelisim = new KisiselGelisim();
            kisiselGelisim.Ad = "Hayır Diyebilme Sanatı";
            kisiselGelisim.Dil = tr;
            kisiselGelisim.Fiyat = 12.92m;
            kisiselGelisim.SayfaSayisi = 200;

            //Oyuncular
            List<Oyuncu> oyuncular = new List<Oyuncu>();

            Oyuncu kerim = new Oyuncu();
            kerim.Ad = "Kerim";
            kerim.Soyad = "Yılmaz";

            Oyuncu cem = new Oyuncu();
            cem.Ad = "Cem";
            cem.Soyad = "Onur";

            oyuncular.Add(kerim);
            oyuncular.Add(cem);

            //Film
            Film film = new Film();
            film.Ad = "Dracula";
            film.Oyuncular = oyuncular;
            film.YonetmenAd = "Ahmet";

            Film film1 = new Film();
            film1.Ad = "Matrix";
            film1.Oyuncular = oyuncular;
            film1.YonetmenAd = "Hava";


            //Müzik
            Muzik muzik = new Muzik();
            muzik.Besteci = "Mert";
            muzik.Solist = "İhsan";
            muzik.Sure = "10";
            

            //Elektronik
            Elektronik elektronik = new Elektronik();
            elektronik.Marka = "Samsung";
            elektronik.Renk = "Siyah";
            elektronik.Tur = "Telefon";
            elektronik.Fiyat = 6000;
            elektronik.Aciklama = "Cep Telefonu";

            kitaplar.Add(kisiselGelisim);
            filmler.Add(film);
            filmler.Add(film1);
            muzikler.Add(muzik);
            elektronikler.Add(elektronik);

        }

        private void btnMuzik_Click(object sender, EventArgs e)
        {
            foreach (Muzik muzik in muzikler)
            {
                listBox1.Items.Add(muzik.Besteci + " " + muzik.Solist);
            }
        }

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = filmler;
         
        }
    }
}
