namespace WFA_Donguler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTekToplam = new System.Windows.Forms.Label();
            this.lblCiftToplam = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaktoriyel = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 290);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tek Toplam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(231, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çift Toplam:";
            // 
            // lblTekToplam
            // 
            this.lblTekToplam.AutoSize = true;
            this.lblTekToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTekToplam.Location = new System.Drawing.Point(332, 22);
            this.lblTekToplam.Name = "lblTekToplam";
            this.lblTekToplam.Size = new System.Drawing.Size(19, 20);
            this.lblTekToplam.TabIndex = 1;
            this.lblTekToplam.Text = "0";
            // 
            // lblCiftToplam
            // 
            this.lblCiftToplam.AutoSize = true;
            this.lblCiftToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiftToplam.Location = new System.Drawing.Point(332, 55);
            this.lblCiftToplam.Name = "lblCiftToplam";
            this.lblCiftToplam.Size = new System.Drawing.Size(19, 20);
            this.lblCiftToplam.TabIndex = 1;
            this.lblCiftToplam.Text = "0";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(235, 88);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(116, 33);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(256, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Faktoriyel Hesaplama:";
            // 
            // txtFaktoriyel
            // 
            this.txtFaktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaktoriyel.Location = new System.Drawing.Point(428, 151);
            this.txtFaktoriyel.Name = "txtFaktoriyel";
            this.txtFaktoriyel.Size = new System.Drawing.Size(149, 26);
            this.txtFaktoriyel.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(428, 183);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(149, 33);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(375, 219);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(264, 57);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "0";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 443);
            this.Controls.Add(this.txtFaktoriyel);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblCiftToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTekToplam);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTekToplam;
        private System.Windows.Forms.Label lblCiftToplam;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaktoriyel;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

