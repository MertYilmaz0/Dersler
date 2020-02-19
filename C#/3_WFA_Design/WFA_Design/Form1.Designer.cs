namespace WFA_Design
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
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.BackColor = System.Drawing.Color.Chartreuse;
            this.btnMesajVer.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMesajVer.Location = new System.Drawing.Point(11, 11);
            this.btnMesajVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(104, 31);
            this.btnMesajVer.TabIndex = 0;
            this.btnMesajVer.Text = "Mesaj Ver";
            this.btnMesajVer.UseVisualStyleBackColor = false;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(926, 504);
            this.Controls.Add(this.btnMesajVer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesajVer;
    }
}

