using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        int sayac = 1;
        Random rnd = new Random();
       
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Runtime ile btnOlustur isimli butona her tıklandığında form alanına yeni bir buton eklensin. Eklenen butonun genişliği 90px; yüksekliği 20px; olsun aynı zamanda her eklenen butonun üzerinde butonun index numarası yazsın. Ancak eklenen butonlar form alanın dışına çıkmasın.
            Button btn = new Button();
            btn.Width = 90;
            btn.Height = 20;
            int x = rnd.Next(0, this.ClientSize.Width-btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height-btn.Height);
            btn.Left = x;
            btn.Top = y;
            btn.Text = sayac.ToString();
            btn.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            sayac++;
            this.Controls.Add(btn);
            btn.Click += Btn_Click;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button gelenButon = (Button)sender;
            MessageBox.Show(gelenButon.Text);
        }

        //Ödev: butona tıklandığında sınıf mevcudu kadar tek seferde ve formda rastgele alanlarda butonlar oluşturulsun. her bir buton bir öğrenciyi temsil etsin ancak üzerinde rakam görüntülensin. o butona tıklandığında içerisinde bulunan öğrencin adı mesaj kutusunda gösterilsin.

    }
}
