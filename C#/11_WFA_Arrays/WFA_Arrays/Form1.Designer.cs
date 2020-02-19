namespace WFA_Arrays
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSinifListesi = new System.Windows.Forms.Button();
            this.btnEnkucukSayi = new System.Windows.Forms.Button();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.lstTek = new System.Windows.Forms.ListBox();
            this.lstCift = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnSinifListesi
            // 
            this.btnSinifListesi.Location = new System.Drawing.Point(0, 322);
            this.btnSinifListesi.Name = "btnSinifListesi";
            this.btnSinifListesi.Size = new System.Drawing.Size(205, 30);
            this.btnSinifListesi.TabIndex = 1;
            this.btnSinifListesi.Text = "Sınıf Listesi";
            this.btnSinifListesi.UseVisualStyleBackColor = true;
            this.btnSinifListesi.Click += new System.EventHandler(this.btnSinifListesi_Click);
            // 
            // btnEnkucukSayi
            // 
            this.btnEnkucukSayi.Location = new System.Drawing.Point(0, 358);
            this.btnEnkucukSayi.Name = "btnEnkucukSayi";
            this.btnEnkucukSayi.Size = new System.Drawing.Size(205, 30);
            this.btnEnkucukSayi.TabIndex = 2;
            this.btnEnkucukSayi.Text = "En Küçük Sayı";
            this.btnEnkucukSayi.UseVisualStyleBackColor = true;
            this.btnEnkucukSayi.Click += new System.EventHandler(this.btnEnkucukSayi_Click);
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(399, 12);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(146, 30);
            this.btnTekCift.TabIndex = 2;
            this.btnTekCift.Text = "Tek Cift";
            this.btnTekCift.UseVisualStyleBackColor = true;
            this.btnTekCift.Click += new System.EventHandler(this.btnTekCift_Click);
            // 
            // lstTek
            // 
            this.lstTek.FormattingEnabled = true;
            this.lstTek.Location = new System.Drawing.Point(266, 48);
            this.lstTek.Name = "lstTek";
            this.lstTek.Size = new System.Drawing.Size(205, 316);
            this.lstTek.TabIndex = 0;
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.Location = new System.Drawing.Point(492, 48);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(205, 316);
            this.lstCift.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.btnEnkucukSayi);
            this.Controls.Add(this.btnSinifListesi);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.lstTek);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSinifListesi;
        private System.Windows.Forms.Button btnEnkucukSayi;
        private System.Windows.Forms.Button btnTekCift;
        private System.Windows.Forms.ListBox lstTek;
        private System.Windows.Forms.ListBox lstCift;
    }
}

