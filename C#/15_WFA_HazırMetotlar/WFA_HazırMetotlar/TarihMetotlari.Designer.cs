namespace WFA_HazırMetotlar
{
    partial class TarihMetotlari
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(12, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 24);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih";
            // 
            // btnDateTime
            // 
            this.btnDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDateTime.Location = new System.Drawing.Point(12, 36);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(160, 38);
            this.btnDateTime.TabIndex = 1;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimeSpan.Location = new System.Drawing.Point(12, 80);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(160, 38);
            this.btnTimeSpan.TabIndex = 1;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // TarihMetotlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.lblTarih);
            this.Name = "TarihMetotlari";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TarihMetotlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnTimeSpan;
    }
}

