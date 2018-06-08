namespace Bills
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elemetaryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trgovinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedinicaMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namjeneRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prihoditoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrstePrihodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uplatiteljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaPrihodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiPoKategorijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosPlanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planStvarnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konekcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblconnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elemetaryDataToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.prihoditoolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.planToolStripMenuItem,
            this.konekcijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elemetaryDataToolStripMenuItem
            // 
            this.elemetaryDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.regionToolStripMenuItem,
            this.gradToolStripMenuItem,
            this.trgovinaToolStripMenuItem,
            this.jedinicaMjereToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.elemetaryDataToolStripMenuItem.Name = "elemetaryDataToolStripMenuItem";
            this.elemetaryDataToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.elemetaryDataToolStripMenuItem.Text = "Osnovni podaci";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.countryToolStripMenuItem.Text = "Država";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.regionToolStripMenuItem.Text = "Županija";
            this.regionToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // trgovinaToolStripMenuItem
            // 
            this.trgovinaToolStripMenuItem.Name = "trgovinaToolStripMenuItem";
            this.trgovinaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.trgovinaToolStripMenuItem.Text = "Trgovina";
            this.trgovinaToolStripMenuItem.Click += new System.EventHandler(this.trgovinaToolStripMenuItem_Click);
            // 
            // jedinicaMjereToolStripMenuItem
            // 
            this.jedinicaMjereToolStripMenuItem.Name = "jedinicaMjereToolStripMenuItem";
            this.jedinicaMjereToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.jedinicaMjereToolStripMenuItem.Text = "Jedinica mjere";
            this.jedinicaMjereToolStripMenuItem.Click += new System.EventHandler(this.jedinicaMjereToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorijeRačunaToolStripMenuItem,
            this.namjeneRačunaToolStripMenuItem,
            this.računiToolStripMenuItem1});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.računiToolStripMenuItem.Text = "Troškovi";
            // 
            // kategorijeRačunaToolStripMenuItem
            // 
            this.kategorijeRačunaToolStripMenuItem.Name = "kategorijeRačunaToolStripMenuItem";
            this.kategorijeRačunaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kategorijeRačunaToolStripMenuItem.Text = "Vrste (grupe) troškova";
            this.kategorijeRačunaToolStripMenuItem.Click += new System.EventHandler(this.kategorijeRačunaToolStripMenuItem_Click);
            // 
            // namjeneRačunaToolStripMenuItem
            // 
            this.namjeneRačunaToolStripMenuItem.Name = "namjeneRačunaToolStripMenuItem";
            this.namjeneRačunaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.namjeneRačunaToolStripMenuItem.Text = "Namjene troškova";
            this.namjeneRačunaToolStripMenuItem.Click += new System.EventHandler(this.namjeneRačunaToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem1
            // 
            this.računiToolStripMenuItem1.Name = "računiToolStripMenuItem1";
            this.računiToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.računiToolStripMenuItem1.Text = "Računi";
            this.računiToolStripMenuItem1.Click += new System.EventHandler(this.računiToolStripMenuItem1_Click);
            // 
            // prihoditoolStripMenuItem
            // 
            this.prihoditoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrstePrihodaToolStripMenuItem,
            this.uplatiteljiToolStripMenuItem,
            this.evidencijaPrihodaToolStripMenuItem});
            this.prihoditoolStripMenuItem.Name = "prihoditoolStripMenuItem";
            this.prihoditoolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.prihoditoolStripMenuItem.Text = "Prihodi";
            this.prihoditoolStripMenuItem.Click += new System.EventHandler(this.prihoditoolStripMenuItem_Click);
            // 
            // vrstePrihodaToolStripMenuItem
            // 
            this.vrstePrihodaToolStripMenuItem.Name = "vrstePrihodaToolStripMenuItem";
            this.vrstePrihodaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.vrstePrihodaToolStripMenuItem.Text = "Vrste prihoda";
            this.vrstePrihodaToolStripMenuItem.Click += new System.EventHandler(this.vrstePrihodaToolStripMenuItem_Click);
            // 
            // uplatiteljiToolStripMenuItem
            // 
            this.uplatiteljiToolStripMenuItem.Name = "uplatiteljiToolStripMenuItem";
            this.uplatiteljiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uplatiteljiToolStripMenuItem.Text = "Uplatitelji";
            this.uplatiteljiToolStripMenuItem.Click += new System.EventHandler(this.uplatiteljiToolStripMenuItem_Click);
            // 
            // evidencijaPrihodaToolStripMenuItem
            // 
            this.evidencijaPrihodaToolStripMenuItem.Name = "evidencijaPrihodaToolStripMenuItem";
            this.evidencijaPrihodaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.evidencijaPrihodaToolStripMenuItem.Text = "Evidencija prihoda";
            this.evidencijaPrihodaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaPrihodaToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.računToolStripMenuItem,
            this.računiPoKategorijamaToolStripMenuItem,
            this.testResizeToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // računToolStripMenuItem
            // 
            this.računToolStripMenuItem.Name = "računToolStripMenuItem";
            this.računToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.računToolStripMenuItem.Text = "Račun";
            this.računToolStripMenuItem.Click += new System.EventHandler(this.računToolStripMenuItem_Click);
            // 
            // računiPoKategorijamaToolStripMenuItem
            // 
            this.računiPoKategorijamaToolStripMenuItem.Name = "računiPoKategorijamaToolStripMenuItem";
            this.računiPoKategorijamaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.računiPoKategorijamaToolStripMenuItem.Text = "Računi po kategorijama";
            this.računiPoKategorijamaToolStripMenuItem.Click += new System.EventHandler(this.računiPoKategorijamaToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosPlanaToolStripMenuItem,
            this.planStvarnoToolStripMenuItem});
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.planToolStripMenuItem.Text = "Plan";
            // 
            // unosPlanaToolStripMenuItem
            // 
            this.unosPlanaToolStripMenuItem.Name = "unosPlanaToolStripMenuItem";
            this.unosPlanaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.unosPlanaToolStripMenuItem.Text = "Unos plana";
            this.unosPlanaToolStripMenuItem.Click += new System.EventHandler(this.unosPlanaToolStripMenuItem_Click);
            // 
            // planStvarnoToolStripMenuItem
            // 
            this.planStvarnoToolStripMenuItem.Name = "planStvarnoToolStripMenuItem";
            this.planStvarnoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.planStvarnoToolStripMenuItem.Text = "Plan - stvarno";
            this.planStvarnoToolStripMenuItem.Click += new System.EventHandler(this.planStvarnoToolStripMenuItem_Click);
            // 
            // konekcijaToolStripMenuItem
            // 
            this.konekcijaToolStripMenuItem.Name = "konekcijaToolStripMenuItem";
            this.konekcijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.konekcijaToolStripMenuItem.Text = "Konekcija";
            this.konekcijaToolStripMenuItem.Click += new System.EventHandler(this.konekcijaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblconnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblconnection
            // 
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(114, 17);
            this.lblconnection.Text = "Trenutna konekcija: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testResizeToolStripMenuItem
            // 
            this.testResizeToolStripMenuItem.Name = "testResizeToolStripMenuItem";
            this.testResizeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.testResizeToolStripMenuItem.Text = "Test Resize";
            this.testResizeToolStripMenuItem.Click += new System.EventHandler(this.testResizeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troškovnik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elemetaryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trgovinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namjeneRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jedinicaMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konekcijaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblconnection;
        private System.Windows.Forms.ToolStripMenuItem računiPoKategorijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prihoditoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrstePrihodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaPrihodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uplatiteljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosPlanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planStvarnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testResizeToolStripMenuItem;
    }
}

