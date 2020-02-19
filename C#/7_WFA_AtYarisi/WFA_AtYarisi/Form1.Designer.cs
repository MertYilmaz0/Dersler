namespace WFA_AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSpiker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1232, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1232, 20);
            this.label2.TabIndex = 1;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Maroon;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinish.Location = new System.Drawing.Point(1228, 33);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(60, 344);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAt1
            // 
            this.pbAt1.BackColor = System.Drawing.Color.Transparent;
            this.pbAt1.Image = global::WFA_AtYarisi.Properties.Resources.ganyan;
            this.pbAt1.Location = new System.Drawing.Point(20, 58);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(88, 82);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt1.TabIndex = 3;
            this.pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.BackColor = System.Drawing.Color.Transparent;
            this.pbAt2.Image = global::WFA_AtYarisi.Properties.Resources._5139947333409;
            this.pbAt2.Location = new System.Drawing.Point(19, 175);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(89, 81);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt2.TabIndex = 3;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.BackColor = System.Drawing.Color.Transparent;
            this.pbAt3.Image = global::WFA_AtYarisi.Properties.Resources.hrs;
            this.pbAt3.Location = new System.Drawing.Point(19, 296);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(89, 81);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt3.TabIndex = 3;
            this.pbAt3.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(19, 531);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(173, 51);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSpiker
            // 
            this.lblSpiker.Location = new System.Drawing.Point(357, 518);
            this.lblSpiker.Name = "lblSpiker";
            this.lblSpiker.Size = new System.Drawing.Size(369, 84);
            this.lblSpiker.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_AtYarisi.Properties.Resources.area1;
            this.ClientSize = new System.Drawing.Size(1304, 612);
            this.Controls.Add(this.lblSpiker);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "At Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpiker;
    }
}

