namespace WFA_Metotlar
{
    partial class Form5
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.BtnCikart = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Location = new System.Drawing.Point(9, 77);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(208, 53);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(175, 38);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(42, 23);
            this.btnBol.TabIndex = 5;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(127, 38);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(42, 23);
            this.btnCarp.TabIndex = 6;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // BtnCikart
            // 
            this.BtnCikart.Location = new System.Drawing.Point(175, 10);
            this.BtnCikart.Name = "BtnCikart";
            this.BtnCikart.Size = new System.Drawing.Size(42, 23);
            this.BtnCikart.TabIndex = 7;
            this.BtnCikart.Text = "-";
            this.BtnCikart.UseVisualStyleBackColor = true;
            this.BtnCikart.Click += new System.EventHandler(this.BtnCikart_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(127, 9);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(42, 23);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.BtnCikart);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button BtnCikart;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}