namespace _4
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblArray1 = new System.Windows.Forms.Label();
            this.lblArray2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArray1
            // 
            this.lblArray1.AutoSize = true;
            this.lblArray1.Location = new System.Drawing.Point(12, 38);
            this.lblArray1.Name = "lblArray1";
            this.lblArray1.Size = new System.Drawing.Size(40, 13);
            this.lblArray1.TabIndex = 1;
            this.lblArray1.Text = "Array 1";
            // 
            // lblArray2
            // 
            this.lblArray2.AutoSize = true;
            this.lblArray2.Location = new System.Drawing.Point(12, 51);
            this.lblArray2.Name = "lblArray2";
            this.lblArray2.Size = new System.Drawing.Size(40, 13);
            this.lblArray2.TabIndex = 2;
            this.lblArray2.Text = "Array 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 85);
            this.Controls.Add(this.lblArray2);
            this.Controls.Add(this.lblArray1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblArray1;
        private System.Windows.Forms.Label lblArray2;
    }
}

