using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPIntroduction
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();

            //Field
            araba1.cikisYil = "2020";
            araba1.kasaTip = "sedan";
            araba1.marka = "Tofaş";
            araba1.model = "Doğan Slx";
            araba1.renk = "Beyaz";
            araba1.tekerlekCap = 15;
            araba1.tork = 1500;
            araba1.vitesTip = "triptonik";
            araba1.yakitTip = "Dizel";

            Araba araba2 = new Araba();
            araba2.cikisYil = "2019";
            araba2.kasaTip = "Hatchback";
            araba2.marka = "Auidi";
            araba2.model = "A5";
            araba2.renk = "Gece Mavisi";
            araba2.vitesTip = "Triptonik";

            List<Araba> arabalar = new List<Araba>();
            arabalar.Add(araba1);
            arabalar.Add(araba2);

            foreach (Araba item in arabalar)
            {
                MessageBox.Show(item.marka);
            }


            #region Form'a ekleme
            //FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            //ListBox list = new ListBox();
            //flowLayoutPanel.Width = this.ClientSize.Width;
            //list.Width = this.ClientSize.Width;
            //list.Items.Add(string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", araba.marka, araba.model, araba.cikisYil, araba.kasaTip, araba.renk, araba.tekerlekCap, araba.tork, araba.vitesTip, araba.yakitTip));
            //flowLayoutPanel.Controls.Add(list);
            //this.Controls.Add(flowLayoutPanel); 
            #endregion


        }
    }
}
