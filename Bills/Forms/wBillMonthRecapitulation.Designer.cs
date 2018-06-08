namespace Bills.Forms
{
    partial class wBillMonthRecapitulation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wBillMonthRecapitulation));
            this.dataBillMonthRecap = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.chartRekap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbDijagramTip = new System.Windows.Forms.ComboBox();
            this.cbtn3d = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDiagrams = new System.Windows.Forms.GroupBox();
            this.chartRekapDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRekapMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataBillMonthRecap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekap)).BeginInit();
            this.groupDiagrams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekapDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekapMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBillMonthRecap
            // 
            this.dataBillMonthRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBillMonthRecap.Location = new System.Drawing.Point(12, 96);
            this.dataBillMonthRecap.Name = "dataBillMonthRecap";
            this.dataBillMonthRecap.RowTemplate.Height = 24;
            this.dataBillMonthRecap.Size = new System.Drawing.Size(536, 635);
            this.dataBillMonthRecap.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(418, 26);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(101, 40);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Prikaži";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(22, 42);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(19, 24);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Godina:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDay);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.lblMonth);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(316, 24);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(38, 17);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Dan:";
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(319, 42);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(59, 24);
            this.cmbDay.TabIndex = 6;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(167, 24);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(56, 17);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Mjesec:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "NULL",
            "Siječanj",
            "Veljača",
            "Ožujak",
            "Travanj",
            "Svibanj",
            "Lipanj",
            "Srpanj",
            "Kolovoz",
            "Rujan",
            "Listopad",
            "Studeni",
            "Prosinac"});
            this.cmbMonth.Location = new System.Drawing.Point(170, 42);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 4;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // chartRekap
            // 
            this.chartRekap.BackColor = System.Drawing.Color.DarkGray;
            this.chartRekap.BorderlineColor = System.Drawing.Color.Black;
            this.chartRekap.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartRekap.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chartRekap.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DarkGray;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartRekap.Legends.Add(legend1);
            this.chartRekap.Location = new System.Drawing.Point(6, 84);
            this.chartRekap.Name = "chartRekap";
            series1.BackSecondaryColor = System.Drawing.Color.DimGray;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Iznos u kn";
            this.chartRekap.Series.Add(series1);
            this.chartRekap.Size = new System.Drawing.Size(536, 195);
            this.chartRekap.TabIndex = 5;
            this.chartRekap.Text = "chart1";
            // 
            // cmbDijagramTip
            // 
            this.cmbDijagramTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDijagramTip.FormattingEnabled = true;
            this.cmbDijagramTip.Items.AddRange(new object[] {
            "Bubble",
            "Line",
            "Spline",
            "StepLine",
            "FastLine",
            "Bar",
            "Column",
            "StackedColumn",
            "Area",
            "SplineArea",
            "StackedArea",
            "Pie ",
            "Doughnut ",
            "Range ",
            "SplineRange ",
            "RangeBar ",
            "RangeColumn ",
            "BoxPlot ",
            "Renko ",
            "ThreeLineBreak ",
            "Kagi "});
            this.cmbDijagramTip.Location = new System.Drawing.Point(136, 46);
            this.cmbDijagramTip.Name = "cmbDijagramTip";
            this.cmbDijagramTip.Size = new System.Drawing.Size(169, 24);
            this.cmbDijagramTip.TabIndex = 6;
            this.cmbDijagramTip.SelectedIndexChanged += new System.EventHandler(this.cmbDijagramTip_SelectedIndexChanged);
            // 
            // cbtn3d
            // 
            this.cbtn3d.AutoSize = true;
            this.cbtn3d.Location = new System.Drawing.Point(397, 48);
            this.cbtn3d.Name = "cbtn3d";
            this.cbtn3d.Size = new System.Drawing.Size(106, 21);
            this.cbtn3d.TabIndex = 7;
            this.cbtn3d.Text = "3D dijagram";
            this.cbtn3d.UseVisualStyleBackColor = true;
            this.cbtn3d.CheckedChanged += new System.EventHandler(this.cbtn3d_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tip dijagrama:";
            // 
            // groupDiagrams
            // 
            this.groupDiagrams.Controls.Add(this.chartRekapDay);
            this.groupDiagrams.Controls.Add(this.chartRekapMonth);
            this.groupDiagrams.Controls.Add(this.cbtn3d);
            this.groupDiagrams.Controls.Add(this.chartRekap);
            this.groupDiagrams.Controls.Add(this.label1);
            this.groupDiagrams.Controls.Add(this.cmbDijagramTip);
            this.groupDiagrams.Location = new System.Drawing.Point(569, 12);
            this.groupDiagrams.Name = "groupDiagrams";
            this.groupDiagrams.Size = new System.Drawing.Size(546, 733);
            this.groupDiagrams.TabIndex = 9;
            this.groupDiagrams.TabStop = false;
            this.groupDiagrams.Text = "Grafički prikaz";
            // 
            // chartRekapDay
            // 
            this.chartRekapDay.BackColor = System.Drawing.Color.DarkGray;
            this.chartRekapDay.BorderlineColor = System.Drawing.Color.Black;
            this.chartRekapDay.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartRekapDay.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Name = "ChartArea1";
            this.chartRekapDay.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.DarkGray;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartRekapDay.Legends.Add(legend2);
            this.chartRekapDay.Location = new System.Drawing.Point(4, 486);
            this.chartRekapDay.Name = "chartRekapDay";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Iznos u kn";
            this.chartRekapDay.Series.Add(series2);
            this.chartRekapDay.Size = new System.Drawing.Size(536, 195);
            this.chartRekapDay.TabIndex = 10;
            this.chartRekapDay.Text = "chart1";
            // 
            // chartRekapMonth
            // 
            this.chartRekapMonth.BackColor = System.Drawing.Color.DarkGray;
            this.chartRekapMonth.BorderlineColor = System.Drawing.Color.Black;
            this.chartRekapMonth.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartRekapMonth.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Angle = -45;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea3.Name = "ChartArea1";
            this.chartRekapMonth.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.DarkGray;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartRekapMonth.Legends.Add(legend3);
            this.chartRekapMonth.Location = new System.Drawing.Point(4, 285);
            this.chartRekapMonth.Name = "chartRekapMonth";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Iznos u kn";
            this.chartRekapMonth.Series.Add(series3);
            this.chartRekapMonth.Size = new System.Drawing.Size(536, 195);
            this.chartRekapMonth.TabIndex = 9;
            this.chartRekapMonth.Text = "chart1";
            // 
            // wBillMonthRecapitulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 750);
            this.Controls.Add(this.groupDiagrams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataBillMonthRecap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wBillMonthRecapitulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rekapitulacija računa po mjesecima";
            this.Load += new System.EventHandler(this.wBillMonthRecapitulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBillMonthRecap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekap)).EndInit();
            this.groupDiagrams.ResumeLayout(false);
            this.groupDiagrams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekapDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRekapMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBillMonthRecap;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRekap;
        private System.Windows.Forms.ComboBox cmbDijagramTip;
        private System.Windows.Forms.CheckBox cbtn3d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDiagrams;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRekapDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRekapMonth;
    }
}