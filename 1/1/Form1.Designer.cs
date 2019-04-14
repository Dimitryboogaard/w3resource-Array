namespace _1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoer";
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 1;
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(55, 38);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren.TabIndex = 2;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.lblInvoeren_Click);
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(55, 67);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(100, 135);
            this.rtUitvoer.TabIndex = 3;
            this.rtUitvoer.Text = "";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(161, 15);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(19, 13);
            this.lblAantal.TabIndex = 4;
            this.lblAantal.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 214);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.btnInvoeren);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.Label lblAantal;
    }
}

