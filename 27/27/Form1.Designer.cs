﻿namespace _27
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
            this.btnIvoeren = new System.Windows.Forms.Button();
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblNogTeGaan = new System.Windows.Forms.Label();
            this.lblNogTeGaan2 = new System.Windows.Forms.Label();
            this.btnInvoeren2 = new System.Windows.Forms.Button();
            this.rtMatrix = new System.Windows.Forms.RichTextBox();
            this.rtTriangle = new System.Windows.Forms.RichTextBox();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAantalElementen
            // 
            this.tbAantalElementen.Location = new System.Drawing.Point(63, 12);
            this.tbAantalElementen.Name = "tbAantalElementen";
            this.tbAantalElementen.Size = new System.Drawing.Size(100, 20);
            this.tbAantalElementen.TabIndex = 0;
            // 
            // lblAantalElementen
            // 
            this.lblAantalElementen.AutoSize = true;
            this.lblAantalElementen.Location = new System.Drawing.Point(20, 15);
            this.lblAantalElementen.Name = "lblAantalElementen";
            this.lblAantalElementen.Size = new System.Drawing.Size(37, 13);
            this.lblAantalElementen.TabIndex = 1;
            this.lblAantalElementen.Text = "Aantal";
            // 
            // btnIvoeren
            // 
            this.btnIvoeren.Location = new System.Drawing.Point(63, 38);
            this.btnIvoeren.Name = "btnIvoeren";
            this.btnIvoeren.Size = new System.Drawing.Size(75, 23);
            this.btnIvoeren.TabIndex = 2;
            this.btnIvoeren.Text = "Invoeren";
            this.btnIvoeren.UseVisualStyleBackColor = true;
            this.btnIvoeren.Click += new System.EventHandler(this.btnIvoeren_Click);
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(64, 67);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbInvoer.TabIndex = 3;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(20, 43);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 4;
            this.lblInvoer.Text = "Invoer";
            // 
            // lblNogTeGaan
            // 
            this.lblNogTeGaan.AutoSize = true;
            this.lblNogTeGaan.Location = new System.Drawing.Point(170, 70);
            this.lblNogTeGaan.Name = "lblNogTeGaan";
            this.lblNogTeGaan.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan.TabIndex = 5;
            this.lblNogTeGaan.Text = "0";
            // 
            // lblNogTeGaan2
            // 
            this.lblNogTeGaan2.AutoSize = true;
            this.lblNogTeGaan2.Location = new System.Drawing.Point(189, 70);
            this.lblNogTeGaan2.Name = "lblNogTeGaan2";
            this.lblNogTeGaan2.Size = new System.Drawing.Size(13, 13);
            this.lblNogTeGaan2.TabIndex = 6;
            this.lblNogTeGaan2.Text = "0";
            // 
            // btnInvoeren2
            // 
            this.btnInvoeren2.Location = new System.Drawing.Point(63, 93);
            this.btnInvoeren2.Name = "btnInvoeren2";
            this.btnInvoeren2.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren2.TabIndex = 7;
            this.btnInvoeren2.Text = "Inv. Matrix";
            this.btnInvoeren2.UseVisualStyleBackColor = true;
            this.btnInvoeren2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtMatrix
            // 
            this.rtMatrix.Location = new System.Drawing.Point(63, 122);
            this.rtMatrix.Name = "rtMatrix";
            this.rtMatrix.Size = new System.Drawing.Size(75, 72);
            this.rtMatrix.TabIndex = 8;
            this.rtMatrix.Text = "";
            // 
            // rtTriangle
            // 
            this.rtTriangle.Location = new System.Drawing.Point(63, 200);
            this.rtTriangle.Name = "rtTriangle";
            this.rtTriangle.Size = new System.Drawing.Size(75, 72);
            this.rtTriangle.TabIndex = 9;
            this.rtTriangle.Text = "";
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(22, 125);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(35, 13);
            this.lblMatrix.TabIndex = 10;
            this.lblMatrix.Text = "Matrix";
            // 
            // lblTriangle
            // 
            this.lblTriangle.AutoSize = true;
            this.lblTriangle.Location = new System.Drawing.Point(12, 203);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(45, 13);
            this.lblTriangle.TabIndex = 11;
            this.lblTriangle.Text = "Triangle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 283);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.rtTriangle);
            this.Controls.Add(this.rtMatrix);
            this.Controls.Add(this.btnInvoeren2);
            this.Controls.Add(this.lblNogTeGaan2);
            this.Controls.Add(this.lblNogTeGaan);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Controls.Add(this.btnIvoeren);
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
        private System.Windows.Forms.Button btnIvoeren;
        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblNogTeGaan;
        private System.Windows.Forms.Label lblNogTeGaan2;
        private System.Windows.Forms.Button btnInvoeren2;
        private System.Windows.Forms.RichTextBox rtMatrix;
        private System.Windows.Forms.RichTextBox rtTriangle;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblTriangle;
    }
}

