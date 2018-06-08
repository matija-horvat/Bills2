namespace Bills.Forms
{
    partial class wBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Danas");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Jučer");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ovaj mjesec");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Siječanj");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Veljača");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ožujak");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Travanj");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Svibanj");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Lipanj");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Srpanj");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Kolovoz");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Rujan");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Listopad");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Studeni");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Prosinac");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Trenutna godina", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wBill));
            this.dataHead = new System.Windows.Forms.DataGridView();
            this.dataBody = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnBillPaid = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBody)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHead
            // 
            this.dataHead.AllowUserToAddRows = false;
            this.dataHead.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHead.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHead.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataHead.Location = new System.Drawing.Point(175, 32);
            this.dataHead.Name = "dataHead";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHead.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataHead.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataHead.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataHead.RowTemplate.Height = 24;
            this.dataHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHead.Size = new System.Drawing.Size(868, 288);
            this.dataHead.TabIndex = 0;
            this.dataHead.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataHead_CellFormatting);
            this.dataHead.SelectionChanged += new System.EventHandler(this.dataHead_SelectionChanged);
            // 
            // dataBody
            // 
            this.dataBody.AllowUserToAddRows = false;
            this.dataBody.AllowUserToDeleteRows = false;
            this.dataBody.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataBody.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBody.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataBody.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBody.Location = new System.Drawing.Point(175, 353);
            this.dataBody.Name = "dataBody";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBody.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataBody.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataBody.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataBody.RowTemplate.Height = 24;
            this.dataBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBody.Size = new System.Drawing.Size(868, 294);
            this.dataBody.TabIndex = 1;
            this.dataBody.SelectionChanged += new System.EventHandler(this.dataBody_SelectionChanged);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView1.Location = new System.Drawing.Point(5, 32);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeToday";
            treeNode1.Text = "Danas";
            treeNode2.Name = "nodeYesterday";
            treeNode2.Text = "Jučer";
            treeNode3.Name = "nodeThisMonth";
            treeNode3.Text = "Ovaj mjesec";
            treeNode4.Name = "nodeMonth1";
            treeNode4.Text = "Siječanj";
            treeNode5.Name = "nodeMonth2";
            treeNode5.Text = "Veljača";
            treeNode6.Name = "nodeMonth3";
            treeNode6.Text = "Ožujak";
            treeNode7.Name = "nodeMonth4";
            treeNode7.Text = "Travanj";
            treeNode8.Name = "nodeMonth5";
            treeNode8.Text = "Svibanj";
            treeNode9.Name = "nodeMonth6";
            treeNode9.Text = "Lipanj";
            treeNode10.Name = "nodeMonth7";
            treeNode10.Text = "Srpanj";
            treeNode11.Name = "nodeMonth8";
            treeNode11.Text = "Kolovoz";
            treeNode12.Name = "nodeMonth9";
            treeNode12.Text = "Rujan";
            treeNode13.Name = "nodeMonth10";
            treeNode13.Text = "Listopad";
            treeNode14.Name = "nodeMonth11";
            treeNode14.Text = "Studeni";
            treeNode15.Name = "nodeMonth12";
            treeNode15.Text = "Prosinac";
            treeNode16.Name = "nodeThisYear";
            treeNode16.Text = "Trenutna godina";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(168, 615);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vremensko razdoblje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(174, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zaglavlja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stavke:";
            // 
            // btnNewBill
            // 
            this.btnNewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewBill.Image = global::Bills.Properties.Resources.document_add_24;
            this.btnNewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBill.Location = new System.Drawing.Point(172, 8);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(99, 40);
            this.btnNewBill.TabIndex = 6;
            this.btnNewBill.Text = "Novi račun";
            this.btnNewBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBill.UseVisualStyleBackColor = true;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddItem.Image = global::Bills.Properties.Resources.add24;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(293, 8);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 40);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Dodaj stavku";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditItem.Image = global::Bills.Properties.Resources.Files_Edit32;
            this.btnEditItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditItem.Location = new System.Drawing.Point(430, 8);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(125, 40);
            this.btnEditItem.TabIndex = 8;
            this.btnEditItem.Text = "Izmjeni stavku";
            this.btnEditItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnBillPaid
            // 
            this.btnBillPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBillPaid.Location = new System.Drawing.Point(905, 8);
            this.btnBillPaid.Name = "btnBillPaid";
            this.btnBillPaid.Size = new System.Drawing.Size(127, 40);
            this.btnBillPaid.TabIndex = 9;
            this.btnBillPaid.Text = "Račun otplaćen";
            this.btnBillPaid.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteItem.Image = global::Bills.Properties.Resources.Trash_icon32;
            this.btnDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteItem.Location = new System.Drawing.Point(579, 8);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(113, 40);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "Obriši stavku";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.Image = global::Bills.Properties.Resources.Search_icon32;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(18, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(123, 40);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter podataka";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Controls.Add(this.btnBillPaid);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnNewBill);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.btnEditItem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(5, 648);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 56);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(175, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 33);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // wBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataBody);
            this.Controls.Add(this.dataHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled računa";
            this.Load += new System.EventHandler(this.wBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBody)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHead;
        private System.Windows.Forms.DataGridView dataBody;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnBillPaid;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}