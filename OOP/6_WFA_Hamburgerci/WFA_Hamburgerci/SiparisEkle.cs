using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Hamburgerci
{
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }
        //Object Initializer

        public static List<Siparis> siparisler = new List<Siparis>();
       public static List<Menu> menuler = new List<Menu>()
            {
                new Menu{MenuAd="Whooper",MenuFiyat=18},
                new Menu{MenuAd="McAdana",MenuFiyat=20},
                new Menu{MenuAd="McBitlis",MenuFiyat=22},
                new Menu{MenuAd="McBolu",MenuFiyat=25}

            };
        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraAd="Hardal",Fiyat=0.50m},
           new Ekstra{EkstraAd="Ranch",Fiyat=0.50m},
           new Ekstra{EkstraAd="Acı Sos",Fiyat=1},
           new Ekstra{EkstraAd="BBQ",Fiyat=1},
           new Ekstra{EkstraAd="Buffalo",Fiyat=1},
           new Ekstra{EkstraAd="Hardal",Fiyat=0.50m},
           new Ekstra{EkstraAd="Ketçap",Fiyat=0.50m}
        };
        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            rbKucuk.Checked = true;
            #region Alternatif Menü Oluşturma
            //#region Menüler
            //Menu hamburger1 = new Menu();
            //hamburger1.MenuAd = "Whooper";
            //hamburger1.MenuFiyat = 18;

            //Menu hamburger2 = new Menu();
            //hamburger2.MenuAd = "McAdana";
            //hamburger2.MenuFiyat = 20;

            //Menu hamburger3 = new Menu();
            //hamburger3.MenuAd = "McBitlis";
            //hamburger3.MenuFiyat = 22;


            //Menu hamburger4 = new Menu();
            //hamburger4.MenuAd = "McBolu";
            //hamburger4.MenuFiyat = 25;
            //#endregion

            //#region Menü Listesi
            //List<Menu> menuler = new List<Menu>();
            //menuler.Add(hamburger1);
            //menuler.Add(hamburger2);
            //menuler.Add(hamburger3);
            //menuler.Add(hamburger4); 
            //#endregion 
            #endregion

            foreach (Menu menu in menuler)
            {
                cmbMenu.Items.Add(menu);
            }

            foreach (Ekstra ekstra in ekstralar)
            {
                #region Neden Tag Tanımlandı?
                //her bir controlün tag özelliği bulunmaktadır. Tag içerisine object tipte herşeyi alabilir. Bizler contorlü istediğimiz yerden çağırdığımızda beraberindeki tag özelliğinin değerini de yakalamış oluruz. yakaladığımız yerde unboxing yaparak işlemlerimizde kullanabiliriz. 
                #endregion
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text=ekstra.EkstraAd,Tag=ekstra});
            }
        }
        Siparis yeniSiparis = new Siparis();
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            yeniSiparis.SeciliMenu = (Menu)cmbMenu.SelectedItem;
            if (rbKucuk.Checked)
                yeniSiparis.Boyut = Boyut.Küçük;
            else if(rbOrta.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Büyük;

            yeniSiparis.EkstraMalzemesi = new List<Ekstra>();
            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                    yeniSiparis.EkstraMalzemesi.Add((Ekstra)chk.Tag);
            }
            yeniSiparis.Adet = Convert.ToInt32(nudAdet.Value);
            yeniSiparis.Hesapla();
            //siparişi listbox'a ekleme
            siparisler.Add(yeniSiparis);
            listBox1.Items.Add(yeniSiparis);
            TutarHesapla();
            Fonksiyon.Temizle(this.Controls);
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)listBox1.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            return toplamTutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Ücreti:" + TutarHesapla().ToString() + "satın almayı tamamalamak istiyor musunuz?", "Sipariş Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
               
                //todo Kredi kartı bilgileri de dahil edilecek.
                listBox1.Items.Clear();
                //todo sipariş bilgileri diğer forma aktarılacak.
               DialogResult dr2= MessageBox.Show("Sipariş Tamamlandı\nMemnun Kaldınız mı","Memnuniyet",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dr2 == DialogResult.Yes)
                {
                    
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }
    }
}
