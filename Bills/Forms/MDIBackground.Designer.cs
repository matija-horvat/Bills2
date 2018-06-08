namespace Bills.Forms
{
    partial class MDIBackground
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
            this.lblTroskovnik = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTroskovnik
            // 
            this.lblTroskovnik.AutoSize = true;
            this.lblTroskovnik.BackColor = System.Drawing.Color.Transparent;
            this.lblTroskovnik.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTroskovnik.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTroskovnik.Location = new System.Drawing.Point(990, 556);
            this.lblTroskovnik.Name = "lblTroskovnik";
            this.lblTroskovnik.Size = new System.Drawing.Size(151, 33);
            this.lblTroskovnik.TabIndex = 0;
            this.lblTroskovnik.Text = "e-Troškovnik";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblDesign.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDesign.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDesign.Location = new System.Drawing.Point(936, 589);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(205, 24);
            this.lblDesign.TabIndex = 1;
            this.lblDesign.Text = "design by Matija Horvat";
            // 
            // MDIBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1250, 900);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblTroskovnik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MDIBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MDIBackground";
            this.Load += new System.EventHandler(this.MDIBackground_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MDIBackground_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTroskovnik;
        private System.Windows.Forms.Label lblDesign;
    }
}