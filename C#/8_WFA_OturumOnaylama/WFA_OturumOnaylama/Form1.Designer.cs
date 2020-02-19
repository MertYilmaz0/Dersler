namespace WFA_OturumOnaylama
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKarakter = new System.Windows.Forms.Label();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen aşağıda görmüş olduğunuz karakterleri ilgili yazı alanına yazınız.";
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarakter.ForeColor = System.Drawing.Color.Maroon;
            this.lblKarakter.Location = new System.Drawing.Point(32, 58);
            this.lblKarakter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(61, 29);
            this.lblKarakter.TabIndex = 0;
            this.lblKarakter.Text = "........";
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger.Location = new System.Drawing.Point(35, 103);
            this.txtDeger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(263, 35);
            this.txtDeger.TabIndex = 1;
            this.txtDeger.TextChanged += new System.EventHandler(this.txtDeger_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(302, 103);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(177, 41);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalan Hatalı Giriş Hakkınız:";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.Location = new System.Drawing.Point(298, 157);
            this.lblKalanHak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(29, 31);
            this.lblKalanHak.TabIndex = 0;
            this.lblKalanHak.Text = "5";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(510, 93);
            this.lblSure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(75, 53);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 212);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKarakter);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKarakter;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
    }
}

