using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Temizle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //uygulamayı çalıştırmadan önce breakpoint bırakarak işlem adımlarını takip edin!!!
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    //unboxing
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
                else if(ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if(ctrl is RadioButton)
                {
                    RadioButton rb = ctrl as RadioButton;
                    rb.Checked = false;
                }
                else if(ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
                else if(ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
                else if(ctrl is ListBox)
                {
                    ListBox lst = ctrl as ListBox;
                    lst.ClearSelected();
                }
            }
        }
    }
}
