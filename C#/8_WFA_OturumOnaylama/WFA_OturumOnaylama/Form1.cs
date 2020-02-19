using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OturumOnaylama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;
        int karmasikSayi;
        private void Form1_Load(object sender, EventArgs e)
        {
            //form load (yüklendiğinde) 7 haneli random bir sayı oluştur. Bu sayıyı lblKaraktere yazdır.
           rnd= new Random();
           karmasikSayi = rnd.Next(1000000, 10000000);//form load olduğunda 3260263 random bir int değer oluşturuldu.
            lblKarakter.Text = karmasikSayi.ToString();//oluşturulan 3260263 int değerini lblKarakter'e text yani string formatta gönderiyor.
            timer1.Start(); // bu değer dahilinde timer start alıyor.          
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //textboxın içerisindeki minimum karakter sayısı 0 dan büyük ise kontrolü gerçekleştirmesi için aşağıdaki koşulu tanımladık.
            if (txtDeger.Text.Length > 0)// girilen değerin 0 dan büyük olup olmadığı  kontrol ediliyor büyükse bir sonraki komut satırına geçiyor.
            {
                //lblkarakter içerisindeki değer ile txtDeger içerisindeki değer eşit ise "Başarılı Giriş!"
                if (Convert.ToInt32(lblKarakter.Text) == Convert.ToInt32(txtDeger.Text))
                {
                    MessageBox.Show("Başarılı Giriş!");
                    //karmasikSayi = rnd.Next(1000000, 10000000);
                    //lblKarakter.Text = karmasikSayi.ToString();
                }
                //eğer girilen değerler uyuşmuyorsa lblKalanHak bir kez azaltılacak.
                else
                {
                    //eğer kalanhak 0'a eşit değilse aşağıdaki işlemler uygulanacak.
                    if (lblKalanHak.Text != "0")
                    {
                        int kalanHak = Convert.ToInt32(lblKalanHak.Text);
                        kalanHak--;
                        lblKalanHak.Text = kalanHak.ToString();
                        karmasikSayi = rnd.Next(1000000, 10000000);
                        lblKarakter.Text = karmasikSayi.ToString();


                    }
                    //kalanhak 0'a eşit olması durumunda aşağıdaki kod satırına yönlenecek.
                    else
                    {
                        MessageBox.Show("Hakkınız Bitti");
                        btnGiris.Enabled = false;
                        txtDeger.Enabled = false;
                    }
                }
            }          
            else
            {
                MessageBox.Show("Lütfen en az 1 değer tanımlayın");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sure = Convert.ToInt32(lblSure.Text);//lblsure içindeki string değerdeki sayı in sure değerimize eşitleniyor.
            sure--;//süre 1 eksiliyor
            lblSure.Text = sure.ToString();//eksilen değer yine lblsure içine string formatta gönderiliyor.
            //süre 0 olduğunda buton ve textbox pasif hale gelerek zamanlayıcı duracak.
            if (sure == 0)//int süre değeri 0'a eşit olması durumunda aşağıdaki kod satırları devreye giriyor.
            {
                btnGiris.Enabled = false;//giriş butonu deaktif oluyor.
                txtDeger.Enabled = false;//txt değer deaktif oluyor.
                timer1.Stop();// sayaç saymayı durduruyor.
            }
            if (sure < 6)// süre değerimiz yani zaman 6 saniyeden aşağı düşmesi durumunda aşağıdaki kod satırı devreye giriyor.
            {
                lblSure.ForeColor = Color.Red;// lblsüre yazı rengi kırmızıya dönüyor.
            }
            
        }
        //textbox'a herhangi bir değer girildiğinde timer duracak.
        private void txtDeger_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();//txtdeger'e herhangi bir yazı yazıldığında timer duruyor.
            if (txtDeger.Text.Length < 1)//eğer textin uzunluğu 1den yani tek haneden aşağı düşmesi durumunda aşağıdaki kod satırı devreye giriyor.
            {
                timer1.Start();//timer başlıyor.
            }                      
                         
        }
        
    }
}
