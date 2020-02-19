namespace WFA_Abstraction
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
            this.txtEns = new System.Windows.Forms.TextBox();
            this.btnEns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblMuzisyen = new System.Windows.Forms.Label();
            this.btnMuzisyen = new System.Windows.Forms.Button();
            this.txtMuzisyen = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtEns
            // 
            this.txtEns.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEns.Location = new System.Drawing.Point(131, 12);
            this.txtEns.Name = "txtEns";
            this.txtEns.Size = new System.Drawing.Size(129, 29);
            this.txtEns.TabIndex = 1;
            // 
            // btnEns
            // 
            this.btnEns.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnEns.Location = new System.Drawing.Point(131, 47);
            this.btnEns.Name = "btnEns";
            this.btnEns.Size = new System.Drawing.Size(129, 29);
            this.btnEns.TabIndex = 2;
            this.btnEns.Text = "EKLE";
            this.btnEns.UseVisualStyleBackColor = true;
            this.btnEns.Click += new System.EventHandler(this.btnEns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enstrüman Ekle:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 11F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(266, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 436);
            this.listBox1.TabIndex = 4;
            // 
            // lblMuzisyen
            // 
            this.lblMuzisyen.AutoSize = true;
            this.lblMuzisyen.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMuzisyen.Location = new System.Drawing.Point(12, 103);
            this.lblMuzisyen.Name = "lblMuzisyen";
            this.lblMuzisyen.Size = new System.Drawing.Size(105, 19);
            this.lblMuzisyen.TabIndex = 7;
            this.lblMuzisyen.Text = "Müzisyen Ekle:";
            this.lblMuzisyen.Visible = false;
            // 
            // btnMuzisyen
            // 
            this.btnMuzisyen.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnMuzisyen.Location = new System.Drawing.Point(131, 134);
            this.btnMuzisyen.Name = "btnMuzisyen";
            this.btnMuzisyen.Size = new System.Drawing.Size(129, 29);
            this.btnMuzisyen.TabIndex = 6;
            this.btnMuzisyen.Text = "EKLE";
            this.btnMuzisyen.UseVisualStyleBackColor = true;
            this.btnMuzisyen.Visible = false;
            this.btnMuzisyen.Click += new System.EventHandler(this.btnMuzisyen_Click);
            // 
            // txtMuzisyen
            // 
            this.txtMuzisyen.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuzisyen.Location = new System.Drawing.Point(131, 99);
            this.txtMuzisyen.Name = "txtMuzisyen";
            this.txtMuzisyen.Size = new System.Drawing.Size(129, 29);
            this.txtMuzisyen.TabIndex = 5;
            this.txtMuzisyen.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Calibri", 11F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(476, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(275, 436);
            this.listBox2.TabIndex = 8;
            this.listBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblMuzisyen);
            this.Controls.Add(this.btnMuzisyen);
            this.Controls.Add(this.txtMuzisyen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEns);
            this.Controls.Add(this.txtEns);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEns;
        private System.Windows.Forms.Button btnEns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMuzisyen;
        private System.Windows.Forms.Button btnMuzisyen;
        private System.Windows.Forms.TextBox txtMuzisyen;
        private System.Windows.Forms.ListBox listBox2;
    }
}

