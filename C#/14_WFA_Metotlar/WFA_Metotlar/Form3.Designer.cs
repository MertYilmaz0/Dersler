namespace WFA_Metotlar
{
    partial class Form3
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
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Location = new System.Drawing.Point(61, 64);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(100, 23);
            this.btnMesajVer.TabIndex = 4;
            this.btnMesajVer.Text = "Mesaj Ver";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(61, 38);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(100, 20);
            this.txtDeger2.TabIndex = 2;
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(61, 12);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(100, 20);
            this.txtDeger1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(251, 40);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(100, 23);
            this.btnTekCift.TabIndex = 4;
            this.btnTekCift.Text = "Tek mi Çift mi";
            this.btnTekCift.UseVisualStyleBackColor = true;
            this.btnTekCift.Click += new System.EventHandler(this.btnTekCift_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDeger1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesajVer;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTekCift;
    }
}