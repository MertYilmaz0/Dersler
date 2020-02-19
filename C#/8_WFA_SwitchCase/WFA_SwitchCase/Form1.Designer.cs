namespace WFA_SwitchCase
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(234, 30);
            this.txtDeger.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(12, 87);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(234, 38);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(12, 131);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(234, 38);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtDeger2
            // 
            this.txtDeger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger2.Location = new System.Drawing.Point(12, 51);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(234, 30);
            this.txtDeger2.TabIndex = 1;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(12, 175);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(234, 38);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 652);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnKontrol;
    }
}

