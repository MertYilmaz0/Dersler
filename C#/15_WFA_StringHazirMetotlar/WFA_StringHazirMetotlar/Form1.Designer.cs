namespace WFA_StringHazirMetotlar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartswith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(23, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(23, 44);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(194, 35);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "COMPARE TO";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONTAINS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartswith
            // 
            this.btnStartswith.Location = new System.Drawing.Point(23, 126);
            this.btnStartswith.Name = "btnStartswith";
            this.btnStartswith.Size = new System.Drawing.Size(194, 35);
            this.btnStartswith.TabIndex = 1;
            this.btnStartswith.Text = "STARTSWITH";
            this.btnStartswith.UseVisualStyleBackColor = true;
            this.btnStartswith.Click += new System.EventHandler(this.btnStartswith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(23, 167);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(194, 35);
            this.btnEndsWith.TabIndex = 1;
            this.btnEndsWith.Text = "ENDSWITH";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(23, 208);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(194, 35);
            this.btnIndexOf.TabIndex = 1;
            this.btnIndexOf.Text = "INDEX OF";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(23, 249);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(194, 35);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(23, 290);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(194, 35);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(23, 331);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(194, 35);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 601);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnStartswith);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartswith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplit;
    }
}

