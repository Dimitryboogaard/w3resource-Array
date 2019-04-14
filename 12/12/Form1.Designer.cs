namespace _12
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
            this.tbAantalElementen = new System.Windows.Forms.TextBox();
            this.lblAantalElementen = new System.Windows.Forms.Label();
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblNogTeGaan = new System.Windows.Forms.Label();
            this.btnInvoeren2 = new System.Windows.Forms.Button();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAantalElementen
            // 
            this.tbAantalElementen.Location = new System.Drawing.Point(55, 12);
            this.tbAantalElementen.Name = "tbAantalElementen";
            this.tbAantalElementen.Size = new System.Drawing.Size(100, 20);
            this.tbAantalElementen.TabIndex = 0;
            // 
            // lblAantalElementen
            // 
            this.lblAantalElementen.AutoSize = true;
            this.lblAantalElementen.Location = new System.Drawing.Point(12, 15);
            this.lblAantalElementen.Name = "lblAantalElementen";
            this.lblAantalElementen.Size = new System.Drawing.Size(37, 13);
            this.lblAantalElementen.TabIndex = 1;
            this.lblAantalElementen.Text = "Aantal";
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(55, 38);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren.TabIndex = 2;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(55, 67);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 3;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(12, 70);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 4;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblNogTeGaan
            // 
            this.lblNogTeGaan.AutoSize = true;
            this.lblNogTeGaan.Location = new System.Drawing.Point(161, 70);
            this.lblNogTeGaan.Name = "lblNogTeGaan";
            this.lblNogTeGaan.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan.TabIndex = 5;
            this.lblNogTeGaan.Text = "0";
            // 
            // btnInvoeren2
            // 
            this.btnInvoeren2.Location = new System.Drawing.Point(55, 93);
            this.btnInvoeren2.Name = "btnInvoeren2";
            this.btnInvoeren2.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren2.TabIndex = 6;
            this.btnInvoeren2.Text = "Invoeren";
            this.btnInvoeren2.UseVisualStyleBackColor = true;
            this.btnInvoeren2.Click += new System.EventHandler(this.btnInvoeren2_Click);
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(52, 119);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(41, 13);
            this.lblUitvoer.TabIndex = 7;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 143);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnInvoeren2);
            this.Controls.Add(this.lblNogTeGaan);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.btnInvoeren);
            this.Controls.Add(this.lblAantalElementen);
            this.Controls.Add(this.tbAantalElementen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAantalElementen;
        private System.Windows.Forms.Label lblAantalElementen;
        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblNogTeGaan;
        private System.Windows.Forms.Button btnInvoeren2;
        private System.Windows.Forms.Label lblUitvoer;
    }
}

