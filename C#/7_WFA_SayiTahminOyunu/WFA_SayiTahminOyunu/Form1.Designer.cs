namespace WFA_SayiTahminOyunu
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
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblTahminHakki = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Girin:";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(180, 57);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(178, 41);
            this.txtTahmin.TabIndex = 1;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTahminEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahminEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahminEt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTahminEt.Location = new System.Drawing.Point(180, 104);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(178, 46);
            this.btnTahminEt.TabIndex = 2;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = false;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(40, 153);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(477, 89);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahminHakki
            // 
            this.lblTahminHakki.BackColor = System.Drawing.Color.Teal;
            this.lblTahminHakki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTahminHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminHakki.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTahminHakki.Location = new System.Drawing.Point(40, 275);
            this.lblTahminHakki.Name = "lblTahminHakki";
            this.lblTahminHakki.Size = new System.Drawing.Size(163, 163);
            this.lblTahminHakki.TabIndex = 4;
            this.lblTahminHakki.Text = "5";
            this.lblTahminHakki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeviye
            // 
            this.lblSeviye.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblSeviye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviye.Location = new System.Drawing.Point(354, 275);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(163, 163);
            this.lblSeviye.TabIndex = 4;
            this.lblSeviye.Text = "1";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tahmin Hakkı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(395, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seviye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblTahminHakki);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblTahminHakki;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

