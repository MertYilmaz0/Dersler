namespace WindowsFormsApp8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmMenu = new System.Windows.Forms.ComboBox();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKing = new System.Windows.Forms.RadioButton();
            this.gbEkstra = new System.Windows.Forms.GroupBox();
            this.chkSogan = new System.Windows.Forms.CheckBox();
            this.chkSalgam = new System.Windows.Forms.CheckBox();
            this.chkMarul = new System.Windows.Forms.CheckBox();
            this.chkTursu = new System.Windows.Forms.CheckBox();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbEkstra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.burger;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // cbmMenu
            // 
            this.cbmMenu.FormattingEnabled = true;
            this.cbmMenu.Location = new System.Drawing.Point(52, 156);
            this.cbmMenu.Name = "cbmMenu";
            this.cbmMenu.Size = new System.Drawing.Size(108, 21);
            this.cbmMenu.TabIndex = 2;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(13, 183);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 3;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(64, 183);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 4;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Buyuk";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKing
            // 
            this.rbKing.AutoSize = true;
            this.rbKing.Location = new System.Drawing.Point(125, 183);
            this.rbKing.Name = "rbKing";
            this.rbKing.Size = new System.Drawing.Size(46, 17);
            this.rbKing.TabIndex = 5;
            this.rbKing.TabStop = true;
            this.rbKing.Text = "King";
            this.rbKing.UseVisualStyleBackColor = true;
            // 
            // gbEkstra
            // 
            this.gbEkstra.Controls.Add(this.chkSogan);
            this.gbEkstra.Controls.Add(this.chkSalgam);
            this.gbEkstra.Controls.Add(this.chkMarul);
            this.gbEkstra.Controls.Add(this.chkTursu);
            this.gbEkstra.Controls.Add(this.chkPeynir);
            this.gbEkstra.Controls.Add(this.chkRanch);
            this.gbEkstra.Location = new System.Drawing.Point(10, 206);
            this.gbEkstra.Name = "gbEkstra";
            this.gbEkstra.Size = new System.Drawing.Size(161, 98);
            this.gbEkstra.TabIndex = 6;
            this.gbEkstra.TabStop = false;
            this.gbEkstra.Text = "Ekstralar";
            // 
            // chkSogan
            // 
            this.chkSogan.AutoSize = true;
            this.chkSogan.Location = new System.Drawing.Point(95, 66);
            this.chkSogan.Name = "chkSogan";
            this.chkSogan.Size = new System.Drawing.Size(57, 17);
            this.chkSogan.TabIndex = 5;
            this.chkSogan.Text = "Soğan";
            this.chkSogan.UseVisualStyleBackColor = true;
            // 
            // chkSalgam
            // 
            this.chkSalgam.AutoSize = true;
            this.chkSalgam.Location = new System.Drawing.Point(95, 20);
            this.chkSalgam.Name = "chkSalgam";
            this.chkSalgam.Size = new System.Drawing.Size(61, 17);
            this.chkSalgam.TabIndex = 4;
            this.chkSalgam.Text = "Şalgam";
            this.chkSalgam.UseVisualStyleBackColor = true;
            // 
            // chkMarul
            // 
            this.chkMarul.AutoSize = true;
            this.chkMarul.Location = new System.Drawing.Point(95, 43);
            this.chkMarul.Name = "chkMarul";
            this.chkMarul.Size = new System.Drawing.Size(52, 17);
            this.chkMarul.TabIndex = 3;
            this.chkMarul.Text = "Marul";
            this.chkMarul.UseVisualStyleBackColor = true;
            // 
            // chkTursu
            // 
            this.chkTursu.AutoSize = true;
            this.chkTursu.Location = new System.Drawing.Point(17, 66);
            this.chkTursu.Name = "chkTursu";
            this.chkTursu.Size = new System.Drawing.Size(53, 17);
            this.chkTursu.TabIndex = 2;
            this.chkTursu.Text = "Turşu";
            this.chkTursu.UseVisualStyleBackColor = true;
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(17, 43);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(55, 17);
            this.chkPeynir.TabIndex = 1;
            this.chkPeynir.Text = "Peynir";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.Location = new System.Drawing.Point(17, 20);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(58, 17);
            this.chkRanch.TabIndex = 0;
            this.chkRanch.Text = "Ranch";
            this.chkRanch.UseVisualStyleBackColor = true;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(42, 318);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 20);
            this.nudAdet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adet";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(205, 308);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(149, 52);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparis.Location = new System.Drawing.Point(570, 308);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(149, 52);
            this.btnSiparis.TabIndex = 11;
            this.btnSiparis.Text = "SİPARİŞ";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.Location = new System.Drawing.Point(205, 12);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(514, 290);
            this.lstSiparis.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.gbEkstra);
            this.Controls.Add(this.rbKing);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.cbmMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbEkstra.ResumeLayout(false);
            this.gbEkstra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmMenu;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbKing;
        private System.Windows.Forms.GroupBox gbEkstra;
        private System.Windows.Forms.CheckBox chkSogan;
        private System.Windows.Forms.CheckBox chkSalgam;
        private System.Windows.Forms.CheckBox chkMarul;
        private System.Windows.Forms.CheckBox chkTursu;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox lstSiparis;
    }
}

