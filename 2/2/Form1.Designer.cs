namespace _2
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
            this.tbElementen = new System.Windows.Forms.TextBox();
            this.lblElementen = new System.Windows.Forms.Label();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.btnInvoer2 = new System.Windows.Forms.Button();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbElementen
            // 
            this.tbElementen.Location = new System.Drawing.Point(75, 12);
            this.tbElementen.Name = "tbElementen";
            this.tbElementen.Size = new System.Drawing.Size(100, 20);
            this.tbElementen.TabIndex = 0;
            // 
            // lblElementen
            // 
            this.lblElementen.AutoSize = true;
            this.lblElementen.Location = new System.Drawing.Point(12, 15);
            this.lblElementen.Name = "lblElementen";
            this.lblElementen.Size = new System.Drawing.Size(57, 13);
            this.lblElementen.TabIndex = 1;
            this.lblElementen.Text = "Elementen";
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(75, 38);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(75, 23);
            this.btnInvoer.TabIndex = 2;
            this.btnInvoer.Text = "Invoer";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(32, 70);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 3;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(75, 67);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 4;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(181, 70);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 5;
            this.lblAantal.Text = "Aantal";
            // 
            // btnInvoer2
            // 
            this.btnInvoer2.Location = new System.Drawing.Point(75, 93);
            this.btnInvoer2.Name = "btnInvoer2";
            this.btnInvoer2.Size = new System.Drawing.Size(75, 23);
            this.btnInvoer2.TabIndex = 6;
            this.btnInvoer2.Text = "Invoer";
            this.btnInvoer2.UseVisualStyleBackColor = true;
            this.btnInvoer2.Click += new System.EventHandler(this.btnInvoer2_Click);
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(75, 122);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(185, 81);
            this.rtUitvoer.TabIndex = 7;
            this.rtUitvoer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 223);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.btnInvoer2);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.lblElementen);
            this.Controls.Add(this.tbElementen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbElementen;
        private System.Windows.Forms.Label lblElementen;
        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnInvoer2;
        private System.Windows.Forms.RichTextBox rtUitvoer;
    }
}

