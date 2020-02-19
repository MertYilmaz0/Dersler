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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
               
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);
                    btn.Width = 90;
                    btn.Height = 20;
                    btn.Top=j*20;
                    btn.Left = i * 90;
                    this.Controls.Add(btn);

                }
            }
            this.AutoSize = true;
            //int x = 12, y = 12;
            //for (int i = 0; i < 50; i++)
            //{
            //    if(i ==0)
            //    {

                
            //    Button b = new Button();
            //    b.Location = new Point(x, y);
            //    b.Name = "button_" + (i + 1).ToString();
            //    b.Size = new Size(116, 34);
                    
                

            //    this.Controls.Add(b);
            //    }
            //    else
            //    {
            //        if (i %2 != 0)
            //        {

                   
                
            //        x = x + 122;

            //        Button b = new Button();
            //        b.Location = new Point(x, y);
            //        b.Name = "button_" + (i + 1).ToString();
            //        b.Size = new Size(116, 34);
                    

            //        this.Controls.Add(b);
            //        }
            //        else
            //        {
            //            x = x - 122;
            //            y = y + 40;

            //            Button b = new Button();
            //            b.Location = new Point(x, y);
            //            b.Name = "button_" + (i + 1).ToString();
            //            b.Size = new Size(116, 34);
                        

            //            this.Controls.Add(b);
            //        }
            //    }
            //}
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(nudSutun.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(nudSatir.Value); j++)
                {
                    Button btn = new Button();
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);
                    btn.Width = 90;
                    btn.Height = 20;
                    btn.Top = j * 20;
                    btn.Left = i * 90;
                    this.Controls.Add(btn);

                }
            }
        }
    }
}
