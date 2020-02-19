using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            //tooltip=> metotların kullanımı hakkında özet veren küçük ekrandır. Ctrl+shift+space tuş kombinasyonu ile tooltipi açabilirsiniz.

            //Form ekranına eklemiş olduğumuz tool(araçları) yönetebilmemiz için zaman kavramlarını çpk iyi biliyor olmamız gerekmektedir. Bu anlamda herhangi bir işlem yapmadan önce kendimize sormamız gerekren 2 adet soru bulunmaktadır;

            /*
             * 
             *  1.Ne zaman yapcağım?
                2. Ne yapacağım?

            yukarıdaki soruları biraz daha açacak olursak örneğin;
                1. Ne zaman yapacağım?
                    cevap: butona tıklandığında
                2.Ne yapacağım?
                    cevap: mesaj kutusu göstereceğim.

            yukarıdaki zaman kavramlarını yönetebildiğimiz takdirde C# programlama dili beraber toollara atamış olduğumuz her bir eventi tam anlamıyla yönetebiliriz.
             */
            MessageBox.Show("Merhaba Dünya!");
        }
    }
}
