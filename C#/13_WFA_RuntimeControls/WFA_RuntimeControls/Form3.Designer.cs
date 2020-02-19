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
            this.btnSatirveSutunOlustur = new System.Windows.Forms.Button();
            this.nudSutun = new System.Windows.Forms.NumericUpDown();
            this.nudSatir = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSutun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(21, 517);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(168, 40);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "10X5";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatirveSutunOlustur);
            this.groupBox1.Controls.Add(this.nudSutun);
            this.groupBox1.Controls.Add(this.nudSatir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satır ve Sütun Oluştur";
            // 
            // btnSatirveSutunOlustur
            // 
            this.btnSatirveSutunOlustur.Location = new System.Drawing.Point(20, 92);
            this.btnSatirveSutunOlustur.Name = "btnSatirveSutunOlustur";
            this.btnSatirveSutunOlustur.Size = new System.Drawing.Size(183, 37);
            this.btnSatirveSutunOlustur.TabIndex = 3;
            this.btnSatirveSutunOlustur.Text = "Oluştur";
            this.btnSatirveSutunOlustur.UseVisualStyleBackColor = true;
            this.btnSatirveSutunOlustur.Click += new System.EventHandler(this.btnSatirveSutunOlustur_Click);
            // 
            // nudSutun
            // 
            this.nudSutun.Location = new System.Drawing.Point(108, 61);
            this.nudSutun.Name = "nudSutun";
            this.nudSutun.Size = new System.Drawing.Size(95, 26);
            this.nudSutun.TabIndex = 3;
            // 
            // nudSatir
            // 
            this.nudSatir.Location = new System.Drawing.Point(106, 27);
            this.nudSatir.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSatir.Name = "nudSatir";
            this.nudSatir.Size = new System.Drawing.Size(95, 26);
            this.nudSatir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sütun Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satır Adet:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSutun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSatirveSutunOlustur;
        private System.Windows.Forms.NumericUpDown nudSutun;
        private System.Windows.Forms.NumericUpDown nudSatir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}