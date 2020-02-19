using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //uygulamayı çalıştırmadan önce breakpoint bırakarak işlem adımlarını takip edin!!!
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    //unboxing
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }               
                
                
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
                else if (ctrl is ListBox)
                {
                    ListBox lst = ctrl as ListBox;
                    lst.ClearSelected();
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    cmb.Items.Clear();
                }
                else if (ctrl is ListView)
                {
                    ListView lmv = ctrl as ListView;
                    lmv.Items.();
                }
            }
        }


        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            #region If-else
            //if (cmbMarka.Text == "Mercedes")
            //{
            //    cmbModel.Items.Add("CLK200");
            //    cmbModel.Items.Add("AMG200");
            //}
            //else if (cmbMarka.Text == "Toyota")
            //{
            //    cmbModel.Items.Add("Corolla");
            //    cmbModel.Items.Add("CHR");

            //} 
            #endregion

            switch (cmbMarka.Text)//marka comboboxda hangi değer seçli ise(örn: mercedes)
            {
                case "Mercedes":// case kontrol ediliyor mercedes değerine eşit ise alt satırdaki durumlar devreye giriyor.
                    cmbModel.Items.Add("CLK200");//sonuç olarak bir sonraki kadegoride seçim hakkı açılıyor oradan da combobox model seçiyoruz
                    cmbModel.Items.Add("AMG200");
                    break;
                case "Toyota":
                    cmbModel.Items.Add("Corolla");
                    cmbModel.Items.Add("CHR");
                    break;
                case "Volkswagen":
                  cmbModel.Items.Add("Passat");
                    cmbModel.Items.Add("Golf");
                    break;
                case "Lamborghini":
                    cmbModel.Items.Add("Gallardo");
                    cmbModel.Items.Add("Aventador");
                    break;
                case "Aston Martin":
                    cmbModel.Items.Add("DBX");
                    cmbModel.Items.Add("DBS11");
                    break;
                case "Opel":
                    cmbModel.Items.Add("Astra");
                    cmbModel.Items.Add("Corsa");
                    break;
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Merhaba", "Bilgi", MessageBoxButtons.YesNo);

            //Renk atama işlemi
           DialogResult dr= colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //listiew1'in içerisine bir değer eklemek istediğimizde "listView1.Items.Add(deger);" metodunu kullanmalıyız. ancak Add() metodu bizden tip olarak ListViewItem tipini ister. o yüzden ilk etapta ListViewItem nesnesinden bir instance almamız gerekmektedir. Almış olduğumuz instance ile beraber RAM bellek üzerine ListViewItem'ın bir kopyasını oluşturuyoruz. Bu kopyanın adı "lvi" lvi (yani özünde tip olarak ListViewItem) içerisine form içerisinde tanımlamış olduğumuz değerleri tek tek gönderiyoruz. Bu gönderim işleminde aslında ListViewItem'ın bizden istediği index sıralamaları üzerinden gerçekleştiriyoruz. Örneğin listView içerisinde buluınan ilk kolon 0 nolu indexi temsil etmektedir. Aynı zamanda listViewItem'ın Text özelliği de aslında 0'a karşılık gelmektedir. Bu yüzden aşağıdaki sıralı numaralar bu index sıralamalarını temsil etmektedir. 

            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = cmbMarka.Text;//0
            lvi.SubItems.Add(cmbModel.Text);//1
            lvi.SubItems.Add(cmbYakit.Text);//2
            lvi.SubItems.Add(cmbKasa.Text);//3
            lvi.SubItems.Add(cmbVites.Text);//4
            lvi.SubItems.Add(string.Empty);//5
            lvi.SubItems[5].BackColor = btnRenk.BackColor; //[] bağlı bulunan özelliğin (propertynin index numarasını temsil eder.)
            //lvi.SubItems.Add("", Color.Azure, btnRenk.BackColor, null);
            lvi.SubItems.Add(dateTimePicker1.Text);//6
            listView1.Items.Add(lvi);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //listview içerisinde seçili olan satır nasıl silinir?
            //if (listView1.Items.Count == 0)
            //{
            //    MessageBox.Show("silme işlemi önce veri ekleyin.");
            //}
            //else
            //{
            //    listView1.Items.Remove(listView1.SelectedItems[0]);
            //}
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);//silme işlemi için atadığımız try catch karar yapısı seçilmiş olan Itemları siliyor.
            }
            catch
            {
                MessageBox.Show("Lütfen bir seçim yapın");// eğer herhangi bir seçim yapmadıysak karşımıza girili mesajı ıkarıyor.
            }
        }

        
    }
}
