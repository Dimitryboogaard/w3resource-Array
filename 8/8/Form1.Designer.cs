namespace _8
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
            this.btnInvoerAantal = new System.Windows.Forms.Button();
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.tbInvoerGetallen = new System.Windows.Forms.TextBox();
            this.btnInvoerenGetallen = new System.Windows.Forms.Button();
            this.lblNogTeGaan = new System.Windows.Forms.Label();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInvoerAantal
            // 
            this.btnInvoerAantal.Location = new System.Drawing.Point(55, 38);
            this.btnInvoerAantal.Name = "btnInvoerAantal";
            this.btnInvoerAantal.Size = new System.Drawing.Size(75, 23);
            this.btnInvoerAantal.TabIndex = 0;
            this.btnInvoerAantal.Text = "Invoeren";
            this.btnInvoerAantal.UseVisualStyleBackColor = true;
            this.btnInvoerAantal.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(12, 122);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(134, 172);
            this.rtUitvoer.TabIndex = 1;
            this.rtUitvoer.Text = "";
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 2;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(12, 15);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 3;
            this.lblAantal.Text = "Aantal";
            // 
            // tbInvoerGetallen
            // 
            this.tbInvoerGetallen.Location = new System.Drawing.Point(55, 67);
            this.tbInvoerGetallen.Name = "tbInvoerGetallen";
            this.tbInvoerGetallen.Size = new System.Drawing.Size(100, 20);
            this.tbInvoerGetallen.TabIndex = 4;
            // 
            // btnInvoerenGetallen
            // 
            this.btnInvoerenGetallen.Location = new System.Drawing.Point(55, 93);
            this.btnInvoerenGetallen.Name = "btnInvoerenGetallen";
            this.btnInvoerenGetallen.Size = new System.Drawing.Size(75, 23);
            this.btnInvoerenGetallen.TabIndex = 5;
            this.btnInvoerenGetallen.Text = "Invoeren";
            this.btnInvoerenGetallen.UseVisualStyleBackColor = true;
            this.btnInvoerenGetallen.Click += new System.EventHandler(this.btnInvoerenGetallen_Click);
            // 
            // lblNogTeGaan
            // 
            this.lblNogTeGaan.AutoSize = true;
            this.lblNogTeGaan.Location = new System.Drawing.Point(136, 98);
            this.lblNogTeGaan.Name = "lblNogTeGaan";
            this.lblNogTeGaan.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan.TabIndex = 6;
            this.lblNogTeGaan.Text = "0";
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(12, 70);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 7;
            this.lblInvoer.Text = "Invoer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 302);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.lblNogTeGaan);
            this.Controls.Add(this.btnInvoerenGetallen);
            this.Controls.Add(this.tbInvoerGetallen);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.rtUitvoer);
            this.Controls.Add(this.btnInvoerAantal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoerAantal;
        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox tbInvoerGetallen;
        private System.Windows.Forms.Button btnInvoerenGetallen;
        private System.Windows.Forms.Label lblNogTeGaan;
        private System.Windows.Forms.Label lblInvoer;
    }
}

