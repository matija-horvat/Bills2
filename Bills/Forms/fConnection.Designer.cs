namespace Bills.Forms
{
    partial class fConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConnection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loaderBase = new System.Windows.Forms.PictureBox();
            this.loaderServer = new System.Windows.Forms.PictureBox();
            this.txtConnStatus = new System.Windows.Forms.TextBox();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.groupConnString = new System.Windows.Forms.GroupBox();
            this.lblConnString = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbBaseName = new System.Windows.Forms.ComboBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaderServer)).BeginInit();
            this.groupConnString.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.loaderBase);
            this.groupBox1.Controls.Add(this.loaderServer);
            this.groupBox1.Controls.Add(this.txtConnStatus);
            this.groupBox1.Controls.Add(this.lblConnStatus);
            this.groupBox1.Controls.Add(this.groupConnString);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.cmbBaseName);
            this.groupBox1.Controls.Add(this.lblServerName);
            this.groupBox1.Controls.Add(this.cmbServerName);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(248, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Troškovnik koristi bazu pod nazivom Bills.";
            // 
            // btnTest
            // 
            this.btnTest.Image = global::Bills.Properties.Resources.test24;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(376, 280);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 36);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.btnAttach);
            this.groupBox2.Controls.Add(this.txtBrowse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 136);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje baze na server";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::Bills.Properties.Resources.document_add_24;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(311, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(115, 35);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Kreiraj novu";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::Bills.Properties.Resources.Search_icon32;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(15, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 35);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Pretraži";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = global::Bills.Properties.Resources.add24;
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.Location = new System.Drawing.Point(151, 30);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(144, 35);
            this.btnAttach.TabIndex = 15;
            this.btnAttach.Text = "Dodaj postojeću";
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrowse.Location = new System.Drawing.Point(15, 71);
            this.txtBrowse.Multiline = true;
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(411, 35);
            this.txtBrowse.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(84, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "(Putanja do postojeće baze koja nije  Attach-irana na server)";
            // 
            // loaderBase
            // 
            this.loaderBase.Image = global::Bills.Properties.Resources.ajax_loaderC;
            this.loaderBase.Location = new System.Drawing.Point(440, 84);
            this.loaderBase.Name = "loaderBase";
            this.loaderBase.Size = new System.Drawing.Size(16, 16);
            this.loaderBase.TabIndex = 11;
            this.loaderBase.TabStop = false;
            this.loaderBase.Visible = false;
            // 
            // loaderServer
            // 
            this.loaderServer.Image = global::Bills.Properties.Resources.ajax_loaderC;
            this.loaderServer.Location = new System.Drawing.Point(440, 43);
            this.loaderServer.Name = "loaderServer";
            this.loaderServer.Size = new System.Drawing.Size(16, 16);
            this.loaderServer.TabIndex = 10;
            this.loaderServer.TabStop = false;
            this.loaderServer.Visible = false;
            // 
            // txtConnStatus
            // 
            this.txtConnStatus.Location = new System.Drawing.Point(117, 287);
            this.txtConnStatus.Name = "txtConnStatus";
            this.txtConnStatus.Size = new System.Drawing.Size(253, 22);
            this.txtConnStatus.TabIndex = 9;
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(21, 290);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(86, 17);
            this.lblConnStatus.TabIndex = 8;
            this.lblConnStatus.Text = "Status veze:";
            // 
            // groupConnString
            // 
            this.groupConnString.Controls.Add(this.lblConnString);
            this.groupConnString.Location = new System.Drawing.Point(4, 329);
            this.groupConnString.Name = "groupConnString";
            this.groupConnString.Size = new System.Drawing.Size(466, 103);
            this.groupConnString.TabIndex = 7;
            this.groupConnString.TabStop = false;
            this.groupConnString.Text = "Connection string";
            // 
            // lblConnString
            // 
            this.lblConnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnString.Location = new System.Drawing.Point(20, 33);
            this.lblConnString.Name = "lblConnString";
            this.lblConnString.Size = new System.Drawing.Size(356, 51);
            this.lblConnString.TabIndex = 6;
            this.lblConnString.Text = "label";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = global::Bills.Properties.Resources.Action_cancel_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(126, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Izlaz";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.Image = global::Bills.Properties.Resources.connect_icon32;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(7, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 37);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Spoji se";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(21, 84);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(69, 17);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Ime baze:";
            // 
            // cmbBaseName
            // 
            this.cmbBaseName.FormattingEnabled = true;
            this.cmbBaseName.Location = new System.Drawing.Point(117, 81);
            this.cmbBaseName.Name = "cmbBaseName";
            this.cmbBaseName.Size = new System.Drawing.Size(322, 24);
            this.cmbBaseName.TabIndex = 2;
            this.cmbBaseName.DropDown += new System.EventHandler(this.cmbBaseName_DropDown);
            this.cmbBaseName.SelectedIndexChanged += new System.EventHandler(this.cmbBaseName_SelectedIndexChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(21, 43);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(86, 17);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Ime servera:";
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(117, 40);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(322, 24);
            this.cmbServerName.TabIndex = 0;
            this.cmbServerName.SelectedIndexChanged += new System.EventHandler(this.cmbServerName_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(4, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 53);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // fConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 489);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veza s bazom podataka";
            this.Load += new System.EventHandler(this.fConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaderBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaderServer)).EndInit();
            this.groupConnString.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConnStatus;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.GroupBox groupConnString;
        private System.Windows.Forms.Label lblConnString;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cmbBaseName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.PictureBox loaderServer;
        private System.Windows.Forms.PictureBox loaderBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}