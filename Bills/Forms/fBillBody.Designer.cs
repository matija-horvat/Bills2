namespace Bills.Forms
{
    partial class BillBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillBody));
            this.dataBody = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillPurpose = new System.Windows.Forms.TextBox();
            this.txtBillCategory = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.lblBillCategory = new System.Windows.Forms.Label();
            this.lblBillPurpose = new System.Windows.Forms.Label();
            this.txtArticl = new System.Windows.Forms.TextBox();
            this.lblArticl = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblPdv = new System.Windows.Forms.Label();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbUoM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPdvTotal = new Bills.Controls.Amount();
            this.txtSumTotal = new Bills.Controls.Amount();
            ((System.ComponentModel.ISupportInitialize)(this.dataBody)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBody
            // 
            this.dataBody.AllowUserToAddRows = false;
            this.dataBody.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBody.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBody.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBody.Location = new System.Drawing.Point(5, 341);
            this.dataBody.Name = "dataBody";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataBody.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataBody.RowTemplate.Height = 24;
            this.dataBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBody.Size = new System.Drawing.Size(760, 250);
            this.dataBody.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Image = global::Bills.Properties.Resources.save_2;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(171, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Spremi račun";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::Bills.Properties.Resources.add24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(7, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Dodaj stavku ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumber.Location = new System.Drawing.Point(134, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(176, 21);
            this.txtNumber.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Broj računa:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.Location = new System.Drawing.Point(18, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 15);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Datum plaćanja:";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStore.Location = new System.Drawing.Point(316, 24);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(86, 15);
            this.lblStore.TabIndex = 25;
            this.lblStore.Text = "Mjesto troška :";
            // 
            // mtxtDate
            // 
            this.mtxtDate.Enabled = false;
            this.mtxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtxtDate.Location = new System.Drawing.Point(134, 57);
            this.mtxtDate.Mask = "00/00/0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(84, 21);
            this.mtxtDate.TabIndex = 26;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBillPurpose);
            this.groupBox1.Controls.Add(this.txtBillCategory);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.lblBillCategory);
            this.groupBox1.Controls.Add(this.lblBillPurpose);
            this.groupBox1.Controls.Add(this.lblStore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.mtxtDate);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 123);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaglavlje";
            // 
            // txtBillPurpose
            // 
            this.txtBillPurpose.Enabled = false;
            this.txtBillPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBillPurpose.Location = new System.Drawing.Point(461, 81);
            this.txtBillPurpose.Name = "txtBillPurpose";
            this.txtBillPurpose.Size = new System.Drawing.Size(287, 21);
            this.txtBillPurpose.TabIndex = 33;
            // 
            // txtBillCategory
            // 
            this.txtBillCategory.Enabled = false;
            this.txtBillCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBillCategory.Location = new System.Drawing.Point(461, 51);
            this.txtBillCategory.Name = "txtBillCategory";
            this.txtBillCategory.Size = new System.Drawing.Size(287, 21);
            this.txtBillCategory.TabIndex = 32;
            // 
            // txtStore
            // 
            this.txtStore.Enabled = false;
            this.txtStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStore.Location = new System.Drawing.Point(461, 21);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(287, 21);
            this.txtStore.TabIndex = 31;
            // 
            // lblBillCategory
            // 
            this.lblBillCategory.AutoSize = true;
            this.lblBillCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBillCategory.Location = new System.Drawing.Point(316, 54);
            this.lblBillCategory.Name = "lblBillCategory";
            this.lblBillCategory.Size = new System.Drawing.Size(107, 15);
            this.lblBillCategory.TabIndex = 29;
            this.lblBillCategory.Text = "Kategorija računa:";
            // 
            // lblBillPurpose
            // 
            this.lblBillPurpose.AutoSize = true;
            this.lblBillPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBillPurpose.Location = new System.Drawing.Point(316, 84);
            this.lblBillPurpose.Name = "lblBillPurpose";
            this.lblBillPurpose.Size = new System.Drawing.Size(102, 15);
            this.lblBillPurpose.TabIndex = 30;
            this.lblBillPurpose.Text = "Namjena računa:";
            // 
            // txtArticl
            // 
            this.txtArticl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtArticl.Location = new System.Drawing.Point(120, 21);
            this.txtArticl.Name = "txtArticl";
            this.txtArticl.Size = new System.Drawing.Size(247, 21);
            this.txtArticl.TabIndex = 1;
            this.txtArticl.TextChanged += new System.EventHandler(this.txtArticl_TextChanged);
            // 
            // lblArticl
            // 
            this.lblArticl.AutoSize = true;
            this.lblArticl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArticl.Location = new System.Drawing.Point(15, 28);
            this.lblArticl.Name = "lblArticl";
            this.lblArticl.Size = new System.Drawing.Size(84, 15);
            this.lblArticl.TabIndex = 30;
            this.lblArticl.Text = "Artikl / Usluga:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 56);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 15);
            this.lblQuantity.TabIndex = 32;
            this.lblQuantity.Text = "Količina:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtQuantity.Location = new System.Drawing.Point(120, 53);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 21);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSum.Location = new System.Drawing.Point(15, 84);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(63, 15);
            this.lblSum.TabIndex = 34;
            this.lblSum.Text = "Iznos (kn):";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSum.Location = new System.Drawing.Point(120, 81);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(247, 21);
            this.txtSum.TabIndex = 4;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // lblPdv
            // 
            this.lblPdv.AutoSize = true;
            this.lblPdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPdv.Location = new System.Drawing.Point(15, 112);
            this.lblPdv.Name = "lblPdv";
            this.lblPdv.Size = new System.Drawing.Size(58, 15);
            this.lblPdv.TabIndex = 36;
            this.lblPdv.Text = "PDV (kn):";
            // 
            // txtPDV
            // 
            this.txtPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPDV.Location = new System.Drawing.Point(120, 109);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(247, 21);
            this.txtPDV.TabIndex = 5;
            this.txtPDV.TextChanged += new System.EventHandler(this.txtPDV_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(423, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 15);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Opis:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDescription.Location = new System.Drawing.Point(470, 21);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 106);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // cmbUoM
            // 
            this.cmbUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbUoM.FormattingEnabled = true;
            this.cmbUoM.Location = new System.Drawing.Point(283, 53);
            this.cmbUoM.Name = "cmbUoM";
            this.cmbUoM.Size = new System.Drawing.Size(84, 23);
            this.cmbUoM.TabIndex = 3;
            this.cmbUoM.SelectedIndexChanged += new System.EventHandler(this.cmbUoM_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(247, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "JM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArticl);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.cmbUoM);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblArticl);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.lblPdv);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Controls.Add(this.txtPDV);
            this.groupBox2.Location = new System.Drawing.Point(5, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 143);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(517, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ukupna cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(530, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ukupni PDV:";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(5, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 29);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPdvTotal);
            this.groupBox4.Controls.Add(this.txtSumTotal);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(5, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 54);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox4_Paint);
            // 
            // txtPdvTotal
            // 
            this.txtPdvTotal.AutoScaleDimensions = new System.Drawing.SizeF(0F, 0F);
            this.txtPdvTotal.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.txtPdvTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPdvTotal.Location = new System.Drawing.Point(612, 27);
            this.txtPdvTotal.Name = "txtPdvTotal";
            this.txtPdvTotal.Size = new System.Drawing.Size(139, 22);
            this.txtPdvTotal.TabIndex = 47;
            // 
            // txtSumTotal
            // 
            this.txtSumTotal.AutoScaleDimensions = new System.Drawing.SizeF(0F, 0F);
            this.txtSumTotal.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.txtSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSumTotal.Location = new System.Drawing.Point(612, 3);
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.Size = new System.Drawing.Size(139, 22);
            this.txtSumTotal.TabIndex = 46;
            // 
            // BillBody
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(767, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillBody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stavke računa";
            this.Load += new System.EventHandler(this.BillBody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBody)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBody;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBillCategory;
        private System.Windows.Forms.Label lblBillPurpose;
        private System.Windows.Forms.TextBox txtBillPurpose;
        private System.Windows.Forms.TextBox txtBillCategory;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtArticl;
        private System.Windows.Forms.Label lblArticl;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblPdv;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbUoM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Controls.Amount txtPdvTotal;
        private Controls.Amount txtSumTotal;
    }
}