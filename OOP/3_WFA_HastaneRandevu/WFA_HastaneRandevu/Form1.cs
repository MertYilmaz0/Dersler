using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  
        void button_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            MessageBox.Show("Randevunuz Alınmıştır.");
        }
        private void button1_Click(object sender, EventArgs e)
        {    
            Brans b = new Brans();
            b.bransadi = txtBrans.Text;
            cmbBrans1.Items.Add(b.bransadi);
            txtBrans.Text = "";                     
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Doktorekle d = new Doktorekle();
            d.doktoradsoyad = txtdoktoradsoyad.Text;
            d.bransadi = cmbBrans1.SelectedItem.ToString();
            cmbBrans2.Items.Add(d.bransadi);
            cmbDoktor.Items.Add(d.doktoradsoyad);
            txtdoktoradsoyad.Text = "";
            cmbBrans1.SelectedItem = null;
        }      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {                                                   
            for (int i = 1; i < 6; i++)
            {
                Button btn = new Button();
                Random rnd = new Random();
                Random rnd2 = new Random();
                btn.Click += new EventHandler(this.button_click);
                flpRandevu.Controls.Add(btn);
                btn.Text = (rnd.Next(1, 12)).ToString()+":"+(rnd2.Next(1, 59)).ToString();                                       
            }          
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            flpRandevu.Controls.Clear();
            txtTcn.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbDoktor.Text = "";
            cmbBrans2.Text = "";                      
        }
    }          
}
