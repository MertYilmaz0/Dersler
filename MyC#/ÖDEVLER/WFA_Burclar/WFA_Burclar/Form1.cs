using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Burclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpBurc.CustomFormat = "dd/MM";
            dtpBurc.Format = DateTimePickerFormat.Custom;


            
            
        }

        private void btnBurc_Click(object sender, EventArgs e)           
        {
            string yorum = lblYorum.Text;
            int gun = dtpBurc.Value.Day;
            int ay = dtpBurc.Value.Month;

            if (ay == 12)
            {

                if (gun < 22)
                    lblYorum.Text = "YAY";
                else
                    lblYorum.Text = "OĞLAK";
            }

            else if (ay == 1)
            {
                if (gun < 20)
                    lblYorum.Text = "OĞLAK";
                else
                    lblYorum.Text = "KOVA";
            }

            else if (ay == 2)
            {
                if (gun < 19)
                    lblYorum.Text = "KOVA";
                else
                    lblYorum.Text = "BALIK";
            }

            else if (ay == 3)
            {
                if (gun < 21)
                    lblYorum.Text = "BALIK";
                else
                    lblYorum.Text = "KOÇ";
            }
            else if (ay == 4)
            {
                if (gun < 20)
                    lblYorum.Text = "KOÇ";
                else
                    lblYorum.Text = "BOĞA";
            }

            else if (ay == 5)
            {
                if (gun < 21)
                    lblYorum.Text = "BOĞA";
                else
                    lblYorum.Text = "İKİZLER";
            }

            else if (ay == 6)
            {
                if (gun < 21)
                    lblYorum.Text = "İKİZLER";
                else
                    lblYorum.Text = "YENGEÇ";
            }

            else if (ay == 7)
            {
                if (gun < 23)
                    lblYorum.Text = "YENGEÇ";
                else
                    lblYorum.Text = "ASLAN";
            }

            else if (ay == 8)
            {
                if (gun < 23)
                    lblYorum.Text = "ASLAN";
                else
                    lblYorum.Text = "BAŞAK";
            }

            else if (ay == 9)
            {
                if (gun < 23)
                    lblYorum.Text = "BAŞAK";
                else
                    lblYorum.Text = "TERAZİ";
            }

            else if (ay == 10)
            {
                if (gun < 23)
                    lblYorum.Text = "TERAZİ";
                else
                    lblYorum.Text = "AKREP";
            }

            else if (ay == 11)
            {
                if (gun < 22)
                    lblYorum.Text = "AKREP";
                else
                    lblYorum.Text = "YAY";
            }           
        }

        private void dtpBurc_ValueChanged(object sender, EventArgs e)
        {
            lblYorum.Text = "";
        }
    }
}
