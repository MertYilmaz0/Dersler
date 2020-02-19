namespace WFA_KararYapilari
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkHavaDurumu = new System.Windows.Forms.CheckBox();
            this.btnNeYapmali = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayisalDeger = new System.Windows.Forms.TextBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkHavaDurumu
            // 
            this.chkHavaDurumu.AutoSize = true;
            this.chkHavaDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkHavaDurumu.Location = new System.Drawing.Point(539, 12);
            this.chkHavaDurumu.Name = "chkHavaDurumu";
            this.chkHavaDurumu.Size = new System.Drawing.Size(249, 33);
            this.chkHavaDurumu.TabIndex = 0;
            this.chkHavaDurumu.Text = "Hava Yağmurlu mu?";
            this.chkHavaDurumu.UseVisualStyleBackColor = true;
            // 
            // btnNeYapmali
            // 
            this.btnNeYapmali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNeYapmali.Location = new System.Drawing.Point(562, 51);
            this.btnNeYapmali.Name = "btnNeYapmali";
            this.btnNeYapmali.Size = new System.Drawing.Size(215, 44);
            this.btnNeYapmali.TabIndex = 1;
            this.btnNeYapmali.Text = "Ne Yapmalıyım?";
            this.btnNeYapmali.UseVisualStyleBackColor = true;
            this.btnNeYapmali.Click += new System.EventHandler(this.btnNeYapmali_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.lblBilgi);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(42, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(23, 116);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(297, 34);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(23, 156);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(297, 63);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi.Location = new System.Drawing.Point(20, 49);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(66, 25);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(464, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sayısal Değer";
            // 
            // txtSayisalDeger
            // 
            this.txtSayisalDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayisalDeger.Location = new System.Drawing.Point(469, 209);
            this.txtSayisalDeger.Name = "txtSayisalDeger";
            this.txtSayisalDeger.Size = new System.Drawing.Size(159, 34);
            this.txtSayisalDeger.TabIndex = 3;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(469, 249);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(159, 47);
            this.btnKontrolEt.TabIndex = 4;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.btnNeYapmali);
            this.Controls.Add(this.txtSayisalDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHavaDurumu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHavaDurumu;
        private System.Windows.Forms.Button btnNeYapmali;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayisalDeger;
        private System.Windows.Forms.Button btnKontrolEt;
    }
}

