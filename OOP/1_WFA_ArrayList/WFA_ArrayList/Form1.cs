

using System;
using System.Windows.Forms;
using System.Collections;//ArrayList kullanabilmek için bu kütüphaneye ihtiyacımız var.
using System.Collections.Generic;//Generic yapıları kullanmak için bu kütüphaneye ihtiyacımız var.
namespace WFA_ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Array
        string[] sehirler = { "İstanbul", "Ankara", "İzmir" };

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generic 
            //ArrayList

            //ArrayList nesneler = new ArrayList();
            //nesneler.Add("İstanbul");//boxing
            //nesneler.Add(1);//boxing
            //nesneler.Add(true);
            //nesneler.Add(12.5);

            //string gelenSehir = (string)nesneler[0];//unboxing
            //bool gelenSart = (bool)nesneler[2];
            //MessageBox.Show(gelenSart.ToString());

            List<int> sayilar = new List<int>();

            sayilar.Add(1);









        }
    }
}
