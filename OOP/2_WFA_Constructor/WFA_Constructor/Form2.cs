using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //3 farklı yoldan nesnenin ram üzerinde örneğini oluşturun.
            //ilk olarak nesne örneği oluşturulsun. Değer tanımlamaları daha sonra yapılsın.
            Araba araba = new Araba();
            araba.Marka = "Mercedes";
            araba.Model = "Amg200";
            araba.MotorGucu = 2;

            // ikinci olarak nesne örneği oluşturulurken nesne içerisindeki özelliklere değer tanımlaması yapılsın.
            Araba araba1 = new Araba("Honda", "Civic", 2);

            //üçüncü olarak nesne oluşturma esnasında yapıcı metot kullanılmadan özelliklere değer tanımlaması yapılsın.
            Araba araba2 = new Araba()
            {
                Marka = "Toyota",
                Model = "Corolla",
                MotorGucu = 1.4
            };

        }
    }
}
