namespace WFA_OOPInheritance
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMuzik = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnFilmler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 303);
            this.listBox1.TabIndex = 0;
            // 
            // btnMuzik
            // 
            this.btnMuzik.Location = new System.Drawing.Point(12, 321);
            this.btnMuzik.Name = "btnMuzik";
            this.btnMuzik.Size = new System.Drawing.Size(75, 23);
            this.btnMuzik.TabIndex = 1;
            this.btnMuzik.Text = "Müzikler";
            this.btnMuzik.UseVisualStyleBackColor = true;
            this.btnMuzik.Click += new System.EventHandler(this.btnMuzik_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(402, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(551, 303);
            this.listBox2.TabIndex = 0;
            // 
            // btnFilmler
            // 
            this.btnFilmler.Location = new System.Drawing.Point(402, 321);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(75, 23);
            this.btnFilmler.TabIndex = 1;
            this.btnFilmler.Text = "Filmler";
            this.btnFilmler.UseVisualStyleBackColor = true;
            this.btnFilmler.Click += new System.EventHandler(this.btnFilmler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 466);
            this.Controls.Add(this.btnFilmler);
            this.Controls.Add(this.btnMuzik);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMuzik;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnFilmler;
    }
}

