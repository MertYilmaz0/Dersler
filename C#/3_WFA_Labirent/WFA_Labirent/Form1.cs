using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Labirent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz!");
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int eksipuan5 = -5;
            int guncelPaun = toplamPuan + eksipuan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblFin_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız!");
        }

        //private void Form1_MouseHover(object sender, EventArgs e)
        //{

        //}      
        //private void btn6_MouseHover(object sender, EventArgs e)
        //{
        //    btn6.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;          
        //}

        //private void btn7_MouseHover(object sender, EventArgs e)
        //{
        //    btn7.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;
        //}
        //private void btn2_MouseHover(object sender, EventArgs e)
        //{
        //    btn2.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;
        //}
        //private void btn1_MouseHover(object sender, EventArgs e)
        //{
        //    btn1.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;
        //}
        //private void btn3_MouseHover(object sender, EventArgs e)
        //{
        //    btn3.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;
        //}
        //private void btn5_MouseHover(object sender, EventArgs e)
        //{
        //    btn5.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;

        //}
        //private void btn4_MouseHover(object sender, EventArgs e)
        //{
        //    btn4.Visible = false;
        //    string yaziToplam = lblToplam.Text;
        //    int toplamPuan = Convert.ToInt32(yaziToplam);
        //    int puan5 = 5;
        //    int guncelPaun = toplamPuan + puan5;
        //    string sonuc = Convert.ToString(guncelPaun);
        //    lblToplam.Text = sonuc;
        //}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {          
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbPacman.Left -= 3;
                    break;
                case Keys.Right:
                    pbPacman.Left += 3;
                    break;
                case Keys.Up:
                    pbPacman.Top -= 3;
                    break;
                case Keys.Down:
                    pbPacman.Top += 3;
                    break;               
            }
             if(pbPacman.Left == label1.Left || pbPacman.Left == label1.Right || pbPacman.Left == label1.Top || pbPacman.Left == label1.Bottom || pbPacman.Right == label1.Left || pbPacman.Right == label1.Right || pbPacman.Right == label1.Top || pbPacman.Right == label1.Bottom || pbPacman.Top == label1.Left || pbPacman.Top == label1.Right || pbPacman.Top == label1.Top || pbPacman.Top == label1.Bottom || pbPacman.Bottom == label1.Left || pbPacman.Bottom == label1.Right || pbPacman.Bottom == label1.Top || pbPacman.Bottom == label1.Bottom || pbPacman.Left == label2.Left || pbPacman.Left == label2.Right || pbPacman.Left == label2.Top || pbPacman.Left == label2.Bottom || pbPacman.Right == label2.Left || pbPacman.Right == label2.Right || pbPacman.Right == label2.Top || pbPacman.Right == label2.Bottom || pbPacman.Top == label2.Left || pbPacman.Top == label2.Right || pbPacman.Top == label2.Top || pbPacman.Top == label2.Bottom || pbPacman.Bottom == label2.Left || pbPacman.Bottom == label2.Right || pbPacman.Bottom == label2.Top || pbPacman.Bottom == label2.Bottom || pbPacman.Left == label3.Left || pbPacman.Left == label3.Right || pbPacman.Left == label3.Top || pbPacman.Left == label3.Bottom || pbPacman.Right == label3.Left || pbPacman.Right == label3.Right || pbPacman.Right == label3.Top || pbPacman.Right == label3.Bottom || pbPacman.Top == label3.Left || pbPacman.Top == label3.Right || pbPacman.Top == label3.Top || pbPacman.Top == label3.Bottom || pbPacman.Bottom == label3.Left || pbPacman.Bottom == label3.Right || pbPacman.Bottom == label3.Top || pbPacman.Bottom == label3.Bottom || pbPacman.Left == label4.Left || pbPacman.Left == label4.Right || pbPacman.Left == label4.Top || pbPacman.Left == label4.Bottom || pbPacman.Right == label4.Left || pbPacman.Right == label4.Right || pbPacman.Right == label4.Top || pbPacman.Right == label4.Bottom || pbPacman.Top == label4.Left || pbPacman.Top == label4.Right || pbPacman.Top == label4.Top || pbPacman.Top == label4.Bottom || pbPacman.Bottom == label4.Left || pbPacman.Bottom == label4.Right || pbPacman.Bottom == label4.Top || pbPacman.Bottom == label4.Bottom || pbPacman.Left == label5.Left || pbPacman.Left == label5.Right || pbPacman.Left == label5.Top || pbPacman.Left == label5.Bottom || pbPacman.Right == label5.Left || pbPacman.Right == label5.Right || pbPacman.Right == label5.Top || pbPacman.Right == label5.Bottom || pbPacman.Top == label5.Left || pbPacman.Top == label5.Right || pbPacman.Top == label5.Top || pbPacman.Top == label5.Bottom || pbPacman.Bottom == label5.Left || pbPacman.Bottom == label5.Right || pbPacman.Bottom == label5.Top || pbPacman.Bottom == label5.Bottom || pbPacman.Left == label6.Left || pbPacman.Left == label6.Right || pbPacman.Left == label6.Top || pbPacman.Left == label6.Bottom || pbPacman.Right == label6.Left || pbPacman.Right == label6.Right || pbPacman.Right == label6.Top || pbPacman.Right == label6.Bottom || pbPacman.Top == label6.Left || pbPacman.Top == label6.Right || pbPacman.Top == label6.Top || pbPacman.Top == label6.Bottom || pbPacman.Bottom == label6.Left || pbPacman.Bottom == label6.Right || pbPacman.Bottom == label6.Top || pbPacman.Bottom == label6.Bottom || pbPacman.Left == label7.Left || pbPacman.Left == label7.Right || pbPacman.Left == label7.Top || pbPacman.Left == label7.Bottom || pbPacman.Right == label7.Left || pbPacman.Right == label7.Right || pbPacman.Right == label7.Top || pbPacman.Right == label7.Bottom || pbPacman.Top == label7.Left || pbPacman.Top == label7.Right || pbPacman.Top == label7.Top || pbPacman.Top == label7.Bottom || pbPacman.Bottom == label7.Left || pbPacman.Bottom == label7.Right || pbPacman.Bottom == label7.Top || pbPacman.Bottom == label7.Bottom|| pbPacman.Left == label8.Left || pbPacman.Left == label8.Right || pbPacman.Left == label8.Top || pbPacman.Left == label8.Bottom || pbPacman.Right == label8.Left || pbPacman.Right == label8.Right || pbPacman.Right == label8.Top || pbPacman.Right == label8.Bottom || pbPacman.Top == label8.Left || pbPacman.Top == label8.Right || pbPacman.Top == label8.Top || pbPacman.Top == label8.Bottom || pbPacman.Bottom == label8.Left || pbPacman.Bottom == label8.Right || pbPacman.Bottom == label8.Top || pbPacman.Bottom == label8.Bottom)
             {
                MessageBox.Show("Kaybettiniz!");
                string yaziToplam = lblToplam.Text;
                int toplamPuan = Convert.ToInt32(yaziToplam);
                int eksipuan5 = -5;
                int guncelPaun = toplamPuan + eksipuan5;
                string sonuc = Convert.ToString(guncelPaun);
                lblToplam.Text = sonuc;
             }
             
            
               
            

        }

        private void lblYem1_MouseHover(object sender, EventArgs e)
        {
            lblYem1.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem2_MouseHover(object sender, EventArgs e)
        {
            lblYem2.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem3_MouseHover(object sender, EventArgs e)
        {
            lblYem3.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem4_MouseHover(object sender, EventArgs e)
        {
            lblYem4.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem5_MouseHover(object sender, EventArgs e)
        {
            lblYem5.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem6_MouseHover(object sender, EventArgs e)
        {
            lblYem6.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }

        private void lblYem7_MouseHover(object sender, EventArgs e)
        {
            lblYem7.Visible = false;
            string yaziToplam = lblToplam.Text;
            int toplamPuan = Convert.ToInt32(yaziToplam);
            int puan5 = 5;
            int guncelPaun = toplamPuan + puan5;
            string sonuc = Convert.ToString(guncelPaun);
            lblToplam.Text = sonuc;
        }
    }
}
