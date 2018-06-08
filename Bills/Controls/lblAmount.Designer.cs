namespace Bills.Controls
{
    partial class lblAmount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(21, 14);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(46, 17);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "label1";
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            this.Amount.Leave += new System.EventHandler(this.Amount_Leave);
            // 
            // lblAmount
            // 
            this.Controls.Add(this.Amount);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount;
    }
}
