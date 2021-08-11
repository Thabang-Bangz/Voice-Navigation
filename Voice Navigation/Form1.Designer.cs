namespace Voice_Navigation
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
            this.btnenable = new System.Windows.Forms.Button();
            this.btndisable = new System.Windows.Forms.Button();
            this.rtb11 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnenable
            // 
            this.btnenable.Location = new System.Drawing.Point(28, 221);
            this.btnenable.Name = "btnenable";
            this.btnenable.Size = new System.Drawing.Size(111, 52);
            this.btnenable.TabIndex = 0;
            this.btnenable.Text = "Enable Voice Control";
            this.btnenable.UseVisualStyleBackColor = true;
            this.btnenable.Click += new System.EventHandler(this.btnenable_Click);
            // 
            // btndisable
            // 
            this.btndisable.Enabled = false;
            this.btndisable.Location = new System.Drawing.Point(242, 221);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(103, 52);
            this.btndisable.TabIndex = 1;
            this.btndisable.Text = "Disable Voice Control";
            this.btndisable.UseVisualStyleBackColor = true;
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // rtb11
            // 
            this.rtb11.Location = new System.Drawing.Point(28, 6);
            this.rtb11.Name = "rtb11";
            this.rtb11.Size = new System.Drawing.Size(317, 188);
            this.rtb11.TabIndex = 2;
            this.rtb11.Text = "-Ready To Go-";
            this.rtb11.TextChanged += new System.EventHandler(this.rtb11_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 305);
            this.Controls.Add(this.rtb11);
            this.Controls.Add(this.btndisable);
            this.Controls.Add(this.btnenable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Navigation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnenable;
        private System.Windows.Forms.Button btndisable;
        private System.Windows.Forms.RichTextBox rtb11;
    }
}

