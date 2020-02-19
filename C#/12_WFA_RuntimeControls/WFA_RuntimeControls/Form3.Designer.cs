namespace WFA_RuntimeControls
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
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSatir = new System.Windows.Forms.NumericUpDown();
            this.nudSutun = new System.Windows.Forms.NumericUpDown();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSutun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(12, 507);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(168, 40);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "10X5";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.nudSutun);
            this.groupBox1.Controls.Add(this.nudSatir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satır ve Sütun Oluştur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "satır adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "sütun adet";
            // 
            // nudSatir
            // 
            this.nudSatir.Location = new System.Drawing.Point(72, 26);
            this.nudSatir.Name = "nudSatir";
            this.nudSatir.Size = new System.Drawing.Size(120, 20);
            this.nudSatir.TabIndex = 2;
            // 
            // nudSutun
            // 
            this.nudSutun.Location = new System.Drawing.Point(72, 52);
            this.nudSutun.Name = "nudSutun";
            this.nudSutun.Size = new System.Drawing.Size(120, 20);
            this.nudSutun.TabIndex = 3;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(49, 77);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSutun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.NumericUpDown nudSutun;
        private System.Windows.Forms.NumericUpDown nudSatir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}