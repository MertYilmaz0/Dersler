namespace WFA_KararYapilari
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
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.btnBilgiKontrol = new System.Windows.Forms.Button();
            this.btnNotKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger1
            // 
            this.txtDeger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger1.Location = new System.Drawing.Point(65, 12);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(272, 34);
            this.txtDeger1.TabIndex = 0;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger2.Location = new System.Drawing.Point(65, 61);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(272, 34);
            this.txtDeger2.TabIndex = 0;
            // 
            // btnBilgiKontrol
            // 
            this.btnBilgiKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiKontrol.Location = new System.Drawing.Point(65, 101);
            this.btnBilgiKontrol.Name = "btnBilgiKontrol";
            this.btnBilgiKontrol.Size = new System.Drawing.Size(272, 57);
            this.btnBilgiKontrol.TabIndex = 1;
            this.btnBilgiKontrol.Text = "Giriş Bilgi Kontrol";
            this.btnBilgiKontrol.UseVisualStyleBackColor = true;
            this.btnBilgiKontrol.Click += new System.EventHandler(this.btnBilgiKontrol_Click);
            // 
            // btnNotKontrol
            // 
            this.btnNotKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotKontrol.Location = new System.Drawing.Point(65, 164);
            this.btnNotKontrol.Name = "btnNotKontrol";
            this.btnNotKontrol.Size = new System.Drawing.Size(272, 57);
            this.btnNotKontrol.TabIndex = 1;
            this.btnNotKontrol.Text = "Not Kontrol";
            this.btnNotKontrol.UseVisualStyleBackColor = true;
            this.btnNotKontrol.Click += new System.EventHandler(this.btnNotKontrol_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotKontrol);
            this.Controls.Add(this.btnBilgiKontrol);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.Button btnBilgiKontrol;
        private System.Windows.Forms.Button btnNotKontrol;
    }
}