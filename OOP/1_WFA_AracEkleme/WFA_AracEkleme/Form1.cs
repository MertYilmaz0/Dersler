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

            switch (cmbMarka.Text)
            {
                case "Mercedes":
                    cmbModel.Items.Add("CLK200");
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
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Lütfen bir seçim yapın");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
