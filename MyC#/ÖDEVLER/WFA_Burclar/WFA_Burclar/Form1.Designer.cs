namespace WFA_Burclar
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
            this.dtpBurc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBurc = new System.Windows.Forms.Button();
            this.lblYorum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBurc
            // 
            this.dtpBurc.CustomFormat = "";
            this.dtpBurc.Location = new System.Drawing.Point(114, 22);
            this.dtpBurc.Name = "dtpBurc";
            this.dtpBurc.Size = new System.Drawing.Size(92, 20);
            this.dtpBurc.TabIndex = 0;
            this.dtpBurc.ValueChanged += new System.EventHandler(this.dtpBurc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // btnBurc
            // 
            this.btnBurc.Location = new System.Drawing.Point(207, 22);
            this.btnBurc.Name = "btnBurc";
            this.btnBurc.Size = new System.Drawing.Size(65, 20);
            this.btnBurc.TabIndex = 2;
            this.btnBurc.Text = "BURÇ YORUMU";
            this.btnBurc.UseVisualStyleBackColor = true;
            this.btnBurc.Click += new System.EventHandler(this.btnBurc_Click);
            // 
            // lblYorum
            // 
            this.lblYorum.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYorum.Location = new System.Drawing.Point(35, 69);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(237, 161);
            this.lblYorum.TabIndex = 3;
            this.lblYorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 268);
            this.Controls.Add(this.lblYorum);
            this.Controls.Add(this.btnBurc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBurc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBurc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBurc;
        private System.Windows.Forms.Label lblYorum;
    }
}

