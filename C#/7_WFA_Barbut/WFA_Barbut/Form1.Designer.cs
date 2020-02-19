namespace WFA_Barbut
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
            this.lblOyuncuZar1 = new System.Windows.Forms.Label();
            this.lblOyuncuZar2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOyuncuZar1 = new System.Windows.Forms.Button();
            this.btnOyuncuZar2 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOyuncuZar1
            // 
            this.lblOyuncuZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOyuncuZar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyuncuZar1.Location = new System.Drawing.Point(61, 88);
            this.lblOyuncuZar1.Name = "lblOyuncuZar1";
            this.lblOyuncuZar1.Size = new System.Drawing.Size(193, 163);
            this.lblOyuncuZar1.TabIndex = 0;
            this.lblOyuncuZar1.Text = "0";
            this.lblOyuncuZar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOyuncuZar2
            // 
            this.lblOyuncuZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOyuncuZar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyuncuZar2.Location = new System.Drawing.Point(274, 88);
            this.lblOyuncuZar2.Name = "lblOyuncuZar2";
            this.lblOyuncuZar2.Size = new System.Drawing.Size(193, 163);
            this.lblOyuncuZar2.TabIndex = 0;
            this.lblOyuncuZar2.Text = "0";
            this.lblOyuncuZar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "1. Oyuncu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(323, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "2. Oyuncu";
            // 
            // btnOyuncuZar1
            // 
            this.btnOyuncuZar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyuncuZar1.Location = new System.Drawing.Point(61, 254);
            this.btnOyuncuZar1.Name = "btnOyuncuZar1";
            this.btnOyuncuZar1.Size = new System.Drawing.Size(193, 45);
            this.btnOyuncuZar1.TabIndex = 2;
            this.btnOyuncuZar1.Text = "Zar At";
            this.btnOyuncuZar1.UseVisualStyleBackColor = true;
            this.btnOyuncuZar1.Click += new System.EventHandler(this.btnOyuncuZar1_Click);
            // 
            // btnOyuncuZar2
            // 
            this.btnOyuncuZar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyuncuZar2.Location = new System.Drawing.Point(274, 254);
            this.btnOyuncuZar2.Name = "btnOyuncuZar2";
            this.btnOyuncuZar2.Size = new System.Drawing.Size(193, 45);
            this.btnOyuncuZar2.TabIndex = 2;
            this.btnOyuncuZar2.Text = "Zar At";
            this.btnOyuncuZar2.UseVisualStyleBackColor = true;
            this.btnOyuncuZar2.Click += new System.EventHandler(this.btnOyuncuZar2_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(58, 323);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(409, 81);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Kazanma Durumu";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 439);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOyuncuZar2);
            this.Controls.Add(this.btnOyuncuZar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOyuncuZar2);
            this.Controls.Add(this.lblOyuncuZar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyuncuZar1;
        private System.Windows.Forms.Label lblOyuncuZar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOyuncuZar1;
        private System.Windows.Forms.Button btnOyuncuZar2;
        private System.Windows.Forms.Label lblSonuc;
    }
}

