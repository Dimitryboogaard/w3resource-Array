namespace _5
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
            this.lblDuplicaten = new System.Windows.Forms.Label();
            this.rtTest = new System.Windows.Forms.RichTextBox();
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
            // lblDuplicaten
            // 
            this.lblDuplicaten.AutoSize = true;
            this.lblDuplicaten.Location = new System.Drawing.Point(12, 38);
            this.lblDuplicaten.Name = "lblDuplicaten";
            this.lblDuplicaten.Size = new System.Drawing.Size(58, 13);
            this.lblDuplicaten.TabIndex = 1;
            this.lblDuplicaten.Text = "Duplicaten";
            // 
            // rtTest
            // 
            this.rtTest.Location = new System.Drawing.Point(93, 12);
            this.rtTest.Name = "rtTest";
            this.rtTest.Size = new System.Drawing.Size(145, 153);
            this.rtTest.TabIndex = 2;
            this.rtTest.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 186);
            this.Controls.Add(this.rtTest);
            this.Controls.Add(this.lblDuplicaten);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDuplicaten;
        private System.Windows.Forms.RichTextBox rtTest;
    }
}

