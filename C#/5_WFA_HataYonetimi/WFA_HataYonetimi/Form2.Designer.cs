namespace WFA_HataYonetimi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnOnaylaYonetimli = new System.Windows.Forms.Button();
            this.btnOnaylaDetayli = new System.Windows.Forms.Button();
            this.btnOnaylaDetayliYonetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen sayısal bir değer giriniz.";
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger.Location = new System.Drawing.Point(77, 55);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(260, 30);
            this.txtDeger.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(77, 91);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(260, 43);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "ONAYLA (Hata Yönetimsiz)";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnOnaylaYonetimli
            // 
            this.btnOnaylaYonetimli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaYonetimli.Location = new System.Drawing.Point(77, 140);
            this.btnOnaylaYonetimli.Name = "btnOnaylaYonetimli";
            this.btnOnaylaYonetimli.Size = new System.Drawing.Size(260, 43);
            this.btnOnaylaYonetimli.TabIndex = 2;
            this.btnOnaylaYonetimli.Text = "ONAYLA (Hata Yönetimli)";
            this.btnOnaylaYonetimli.UseVisualStyleBackColor = true;
            this.btnOnaylaYonetimli.Click += new System.EventHandler(this.btnOnaylaYonetimli_Click);
            // 
            // btnOnaylaDetayli
            // 
            this.btnOnaylaDetayli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaDetayli.Location = new System.Drawing.Point(77, 189);
            this.btnOnaylaDetayli.Name = "btnOnaylaDetayli";
            this.btnOnaylaDetayli.Size = new System.Drawing.Size(260, 43);
            this.btnOnaylaDetayli.TabIndex = 2;
            this.btnOnaylaDetayli.Text = "ONAYLA (Detaylı)";
            this.btnOnaylaDetayli.UseVisualStyleBackColor = true;
            this.btnOnaylaDetayli.Click += new System.EventHandler(this.btnOnaylaDetayli_Click);
            // 
            // btnOnaylaDetayliYonetim
            // 
            this.btnOnaylaDetayliYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaylaDetayliYonetim.Location = new System.Drawing.Point(77, 238);
            this.btnOnaylaDetayliYonetim.Name = "btnOnaylaDetayliYonetim";
            this.btnOnaylaDetayliYonetim.Size = new System.Drawing.Size(260, 43);
            this.btnOnaylaDetayliYonetim.TabIndex = 2;
            this.btnOnaylaDetayliYonetim.Text = "ONAYLA (Detaylı Yönetim)";
            this.btnOnaylaDetayliYonetim.UseVisualStyleBackColor = true;
            this.btnOnaylaDetayliYonetim.Click += new System.EventHandler(this.btnOnaylaDetayliYonetim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnaylaDetayliYonetim);
            this.Controls.Add(this.btnOnaylaDetayli);
            this.Controls.Add(this.btnOnaylaYonetimli);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnOnaylaYonetimli;
        private System.Windows.Forms.Button btnOnaylaDetayli;
        private System.Windows.Forms.Button btnOnaylaDetayliYonetim;
    }
}