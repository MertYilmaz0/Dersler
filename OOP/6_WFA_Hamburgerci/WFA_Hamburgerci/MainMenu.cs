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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

       

        void ChildForm(Form _childForm)
        {
            //parametreden yakaladığımız formun genişlik ve yüksekliğini bağlı bulunan form'a atıyoruz.
            this.Width = _childForm.Width+23;
            this.Height = _childForm.Height+68;

            //varsayılan değer false
            bool durum = false;

            //formun içerisinde birden fazla Mdi form olduğu için tıklanan ile açılacak olan form aynı mı değil mi kontrol yapmamız gerekiyor. bu kontrolü aşağıdaki döngü ve içerisinde tanımlanan karar yapısı ile sağlıyoruz.
            foreach (Form item in this.MdiChildren)
            {
                //eğer tıklanan formun text özelliği tanımlı olan formlardan herhangi birinin text özelliğine eşit ise formu kapatıp açmak yerine durumu aktif olarak değiştirip, yakaladığımız formu Activate() yapıyoruz. Bu sayede tek bir sayfada görüntüleme imkanı sağlamış oluyoruz.
                if (item.Text == _childForm.Text)
                {
                    durum = true;
                    item.Activate();
                }
                //değil ise kapatıyoruz.
                else
                {
                    item.Close();
                }
            }
            //durum false olması durumunda formun görünürlüğünü çağırıyoruz.
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

       

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SiparisEkle siparisEkleForm = new SiparisEkle();
            //siparisEkleForm.Show();
            ChildForm(new SiparisEkle());

        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisBilgileri_());
        }
        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuEkle());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new EkstraEkle());
        }
    }
}
