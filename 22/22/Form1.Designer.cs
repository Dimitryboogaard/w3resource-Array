namespace _22
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
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.lblAantal = new System.Windows.Forms.Label();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.btnInvoeren2 = new System.Windows.Forms.Button();
            this.lblNogTeGaan = new System.Windows.Forms.Label();
            this.lblNogTeGaan2 = new System.Windows.Forms.Label();
            this.rtMatrix = new System.Windows.Forms.RichTextBox();
            this.rtTranspose = new System.Windows.Forms.RichTextBox();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblTranspose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAantalElementen
            // 
            this.tbAantalElementen.Location = new System.Drawing.Point(77, 12);
            this.tbAantalElementen.Name = "tbAantalElementen";
            this.tbAantalElementen.Size = new System.Drawing.Size(100, 20);
            this.tbAantalElementen.TabIndex = 0;
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(77, 38);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren.TabIndex = 1;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(34, 15);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 2;
            this.lblAantal.Text = "Aantal";
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(77, 67);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 3;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(34, 70);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 4;
            this.lblInvoer.Text = "Invoer";
            // 
            // btnInvoeren2
            // 
            this.btnInvoeren2.Location = new System.Drawing.Point(77, 93);
            this.btnInvoeren2.Name = "btnInvoeren2";
            this.btnInvoeren2.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren2.TabIndex = 5;
            this.btnInvoeren2.Text = "Inv. Matrix";
            this.btnInvoeren2.UseVisualStyleBackColor = true;
            this.btnInvoeren2.Click += new System.EventHandler(this.btnInvoeren2_Click);
            // 
            // lblNogTeGaan
            // 
            this.lblNogTeGaan.AutoSize = true;
            this.lblNogTeGaan.Location = new System.Drawing.Point(183, 70);
            this.lblNogTeGaan.Name = "lblNogTeGaan";
            this.lblNogTeGaan.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan.TabIndex = 6;
            this.lblNogTeGaan.Text = "0";
            // 
            // lblNogTeGaan2
            // 
            this.lblNogTeGaan2.AutoSize = true;
            this.lblNogTeGaan2.Location = new System.Drawing.Point(202, 70);
            this.lblNogTeGaan2.Name = "lblNogTeGaan2";
            this.lblNogTeGaan2.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan2.TabIndex = 7;
            this.lblNogTeGaan2.Text = "0";
            // 
            // rtMatrix
            // 
            this.rtMatrix.Location = new System.Drawing.Point(77, 122);
            this.rtMatrix.Name = "rtMatrix";
            this.rtMatrix.Size = new System.Drawing.Size(75, 72);
            this.rtMatrix.TabIndex = 8;
            this.rtMatrix.Text = "";
            // 
            // rtTranspose
            // 
            this.rtTranspose.Location = new System.Drawing.Point(77, 200);
            this.rtTranspose.Name = "rtTranspose";
            this.rtTranspose.Size = new System.Drawing.Size(75, 72);
            this.rtTranspose.TabIndex = 9;
            this.rtTranspose.Text = "";
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(36, 125);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(35, 13);
            this.lblMatrix.TabIndex = 10;
            this.lblMatrix.Text = "Matrix";
            // 
            // lblTranspose
            // 
            this.lblTranspose.AutoSize = true;
            this.lblTranspose.Location = new System.Drawing.Point(14, 203);
            this.lblTranspose.Name = "lblTranspose";
            this.lblTranspose.Size = new System.Drawing.Size(57, 13);
            this.lblTranspose.TabIndex = 11;
            this.lblTranspose.Text = "Transpose";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 278);
            this.Controls.Add(this.lblTranspose);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.rtTranspose);
            this.Controls.Add(this.rtMatrix);
            this.Controls.Add(this.lblNogTeGaan2);
            this.Controls.Add(this.lblNogTeGaan);
            this.Controls.Add(this.btnInvoeren2);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.btnInvoeren);
            this.Controls.Add(this.tbAantalElementen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAantalElementen;
        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Button btnInvoeren2;
        private System.Windows.Forms.Label lblNogTeGaan;
        private System.Windows.Forms.Label lblNogTeGaan2;
        private System.Windows.Forms.RichTextBox rtMatrix;
        private System.Windows.Forms.RichTextBox rtTranspose;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblTranspose;
    }
}

