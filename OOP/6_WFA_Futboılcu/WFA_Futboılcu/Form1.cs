using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Futboılcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kaleci kaleci1 = new Kaleci();

            kaleci1.Ad = "RÜŞTÜ";
            kaleci1.Soyad = "REÇBER";
            kaleci1.FormaNumarasi = "11";
            kaleci1.Takım = "FENERBAHÇE";
            

            kaleci1.SutGucu = 4;
            kaleci1.Agresiflik = 10;
            kaleci1.TopKapma = 1;
            kaleci1.BeceriGucu = 5;

            btn1.Text = kaleci1.FormaNumarasi;
            btn1.Tag = kaleci1;           

            OrtaSaha ortasaha1 = new OrtaSaha();

            ortasaha1.Ad = "HAKIM";
            ortasaha1.Soyad = "ZIYECH";
            ortasaha1.FormaNumarasi = "10";
            ortasaha1.Takım = "TWENTE FC";

            ortasaha1.SutGucu = 8;
            ortasaha1.Agresiflik = 2;
            ortasaha1.TopKapma = 7;
            ortasaha1.BeceriGucu = 9;

            btn2.Text = ortasaha1.FormaNumarasi;
            btn2.Tag = ortasaha1;

            OrtaSaha ortasaha2 = new OrtaSaha();

            ortasaha2.Ad = "HAKAN";
            ortasaha2.Soyad = "ÇALHANOĞLU";
            ortasaha2.FormaNumarasi = "9";
            ortasaha2.Takım = "Leverkusen";

            ortasaha2.SutGucu = 7;
            ortasaha2.Agresiflik = 5;
            ortasaha2.TopKapma = 7;
            ortasaha2.BeceriGucu = 7;

            btn3.Text = ortasaha2.FormaNumarasi;
            btn3.Tag = ortasaha2;

            OrtaSaha ortasaha3 = new OrtaSaha();

            ortasaha3.Ad = "LUCAS";
            ortasaha3.Soyad = "MOURA";
            ortasaha3.FormaNumarasi = "8";
            ortasaha3.Takım = "PSG";

            ortasaha3.SutGucu =4 ;
            ortasaha3.Agresiflik =8 ;
            ortasaha3.TopKapma = 6;
            ortasaha3.BeceriGucu = 10;

            btn4.Text = ortasaha3.FormaNumarasi;
            btn4.Tag = ortasaha3;

            OrtaSaha ortasaha4 = new OrtaSaha();

            ortasaha4.Ad = "PAUL";
            ortasaha4.Soyad = "POGBA";
            ortasaha4.FormaNumarasi = "7";
            ortasaha4.Takım = "JUVENTUS";

            ortasaha4.SutGucu = 6;
            ortasaha4.Agresiflik =7 ;
            ortasaha4.TopKapma = 8;
            ortasaha4.BeceriGucu =9 ;

            btn5.Text = ortasaha4.FormaNumarasi;
            btn5.Tag = ortasaha4;

            Defans defans1 = new Defans();

            defans1.Ad = " VIRGIL";
            defans1.Soyad = "VAN DIJK";
            defans1.FormaNumarasi = "6";
            defans1.Takım = "LIVERPOOL";

            defans1.SutGucu =6 ;
            defans1.Agresiflik =8 ;
            defans1.TopKapma = 9;
            defans1.BeceriGucu = 7;

            btn6.Text = defans1.FormaNumarasi;
            btn6.Tag = defans1;

            Defans defans2 = new Defans();

            defans2.Ad = " SERGIO";
            defans2.Soyad = "RAMOS";
            defans2.FormaNumarasi = "5";
            defans2.Takım = "REAL MADRID";

            defans2.SutGucu = 3;
            defans2.Agresiflik = 1;
            defans2.TopKapma = 9;
            defans2.BeceriGucu = 7;

            btn7.Text = defans2.FormaNumarasi;
            btn7.Tag = defans2;

            Defans defans3 = new Defans();

            defans3.Ad = " KALIDOU";
            defans3.Soyad = "KOULIBALY";
            defans3.FormaNumarasi = "4";
            defans3.Takım = "NAPOLI";

            defans3.SutGucu = 5;
            defans3.Agresiflik = 8;
            defans3.TopKapma = 8;
            defans3.BeceriGucu = 7;

            btn8.Text = defans3.FormaNumarasi;
            btn8.Tag = defans3;

            Defans defans4 = new Defans();

            defans4.Ad = " JORDI";
            defans4.Soyad = "ALBA";
            defans4.FormaNumarasi = "3";
            defans4.Takım = "FC BARCELONA";

            defans4.SutGucu = 7;
            defans4.Agresiflik = 8;
            defans4.TopKapma = 9;
            defans4.BeceriGucu = 6;

            btn9.Text = defans4.FormaNumarasi;
            btn9.Tag = defans4;

            Forvet forvet1 = new Forvet();

            forvet1.Ad = "ZLATAN";
            forvet1.Soyad = "IBRAHIMOVIC";
            forvet1.FormaNumarasi = "2";
            forvet1.Takım = "AC MILAN";

            forvet1.SutGucu = 9;
            forvet1.Agresiflik = 1;
            forvet1.TopKapma = 7;
            forvet1.BeceriGucu = 9;

            btn10.Text = forvet1.FormaNumarasi;
            btn10.Tag = forvet1;

            Forvet forvet2 = new Forvet();

            forvet2.Ad = "CRISTIANO";
            forvet2.Soyad = "RONALDO";
            forvet2.FormaNumarasi = "1";
            forvet2.Takım = "JUVENTUS";

            forvet2.SutGucu = 10;
            forvet2.Agresiflik = 3;
            forvet2.TopKapma = 8;
            forvet2.BeceriGucu = 10;

            btn11.Text = forvet2.FormaNumarasi;
            btn11.Tag = forvet2;

            

            futbolcular.Add(kaleci1);
            futbolcular.Add(defans1);
            futbolcular.Add(defans2);
            futbolcular.Add(defans3);
            futbolcular.Add(defans4);
            futbolcular.Add(ortasaha1);
            futbolcular.Add(ortasaha2);
            futbolcular.Add(ortasaha3);
            futbolcular.Add(ortasaha4);
            futbolcular.Add(forvet1);
            futbolcular.Add(forvet2);

            foreach (var button in Controls.OfType<Button>())
            {
                button.Click += button_Click;
            }
        }
        public static List<Futbolcu> futbolcular = new List<Futbolcu>();
        public void button_Click(object sender, EventArgs e)
        {

            Form bilgi = new Form();
            bilgi.ShowDialog();
            ListBox lstBilgi = new ListBox();

            Button thisButton = (Button)sender;

            //switch (thisButton.Text)
            //{
            //    case "1":
            //        lstBilgi.Items.Add(f)
            //        break;
            //    case "2":
            //        MessageBox.Show("Northern button clicked");
            //        break;
            //    case "3":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "4":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "5":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "6":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "7":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "8":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "9":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "10":
            //        MessageBox.Show("North East button clicked");
            //        break;
            //    case "11":
            //        MessageBox.Show("North East button clicked");
            //        break;


        }            //bilgi.Controls.Add(lstBilgi)
    }
}

