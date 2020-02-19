namespace WFA_ForDongusu
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
            this.txtFaktoriyel = new System.Windows.Forms.TextBox();
            this.btnFaktoriyel = new System.Windows.Forms.Button();
            this.btnBindenBire = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnAdanZye = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 303);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faktoriyel";
            // 
            // txtFaktoriyel
            // 
            this.txtFaktoriyel.Location = new System.Drawing.Point(363, 20);
            this.txtFaktoriyel.Name = "txtFaktoriyel";
            this.txtFaktoriyel.Size = new System.Drawing.Size(100, 20);
            this.txtFaktoriyel.TabIndex = 2;
            // 
            // btnFaktoriyel
            // 
            this.btnFaktoriyel.Location = new System.Drawing.Point(469, 17);
            this.btnFaktoriyel.Name = "btnFaktoriyel";
            this.btnFaktoriyel.Size = new System.Drawing.Size(75, 23);
            this.btnFaktoriyel.TabIndex = 3;
            this.btnFaktoriyel.Text = "Faktoriyel";
            this.btnFaktoriyel.UseVisualStyleBackColor = true;
            this.btnFaktoriyel.Click += new System.EventHandler(this.btnFaktoriyel_Click);
            // 
            // btnBindenBire
            // 
            this.btnBindenBire.Location = new System.Drawing.Point(0, 309);
            this.btnBindenBire.Name = "btnBindenBire";
            this.btnBindenBire.Size = new System.Drawing.Size(245, 36);
            this.btnBindenBire.TabIndex = 3;
            this.btnBindenBire.Text = "1000\'den 1\'e";
            this.btnBindenBire.UseVisualStyleBackColor = true;
            this.btnBindenBire.Click += new System.EventHandler(this.btnBindenBire_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(0, 351);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(245, 36);
            this.btnToplam.TabIndex = 3;
            this.btnToplam.Text = "100\'e kadar toplam";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnAdanZye
            // 
            this.btnAdanZye.Location = new System.Drawing.Point(0, 393);
            this.btnAdanZye.Name = "btnAdanZye";
            this.btnAdanZye.Size = new System.Drawing.Size(245, 36);
            this.btnAdanZye.TabIndex = 3;
            this.btnAdanZye.Text = "A\'dan Z\'ye Alfabe";
            this.btnAdanZye.UseVisualStyleBackColor = true;
            this.btnAdanZye.Click += new System.EventHandler(this.btnAdanZye_Click);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(0, 435);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(245, 36);
            this.btnSonuc.TabIndex = 3;
            this.btnSonuc.Text = "Sonuç";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnAdanZye);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnBindenBire);
            this.Controls.Add(this.btnFaktoriyel);
            this.Controls.Add(this.txtFaktoriyel);
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
        private System.Windows.Forms.TextBox txtFaktoriyel;
        private System.Windows.Forms.Button btnFaktoriyel;
        private System.Windows.Forms.Button btnBindenBire;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnAdanZye;
        private System.Windows.Forms.Button btnSonuc;
    }
}

