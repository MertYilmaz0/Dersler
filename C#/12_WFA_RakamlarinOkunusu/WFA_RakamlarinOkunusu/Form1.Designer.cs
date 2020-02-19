namespace WFA_RakamlarinOkunusu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRakam = new System.Windows.Forms.TextBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.lblOku = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rakam Girin(Max 99): ";
            // 
            // txtRakam
            // 
            this.txtRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRakam.Location = new System.Drawing.Point(271, 36);
            this.txtRakam.Name = "txtRakam";
            this.txtRakam.Size = new System.Drawing.Size(149, 29);
            this.txtRakam.TabIndex = 1;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(271, 71);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(149, 33);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "OKU";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // lblOku
            // 
            this.lblOku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOku.Location = new System.Drawing.Point(165, 107);
            this.lblOku.Name = "lblOku";
            this.lblOku.Size = new System.Drawing.Size(380, 94);
            this.lblOku.TabIndex = 0;
            this.lblOku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 249);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.txtRakam);
            this.Controls.Add(this.lblOku);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRakam;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Label lblOku;
    }
}

