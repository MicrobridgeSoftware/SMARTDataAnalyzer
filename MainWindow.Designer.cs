namespace SmartDataAnalyzer
{
    partial class MainWindow
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea3 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea4 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.grdData = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.barValue = new Telerik.WinControls.UI.RadChartView();
            this.funnelValue = new Telerik.WinControls.UI.RadChartView();
            this.pieCount = new Telerik.WinControls.UI.RadChartView();
            this.barTransactions = new Telerik.WinControls.UI.RadChartView();
            this.bgwProcess = new System.ComponentModel.BackgroundWorker();
            this.lblCount = new Telerik.WinControls.UI.RadLabel();
            this.lblCost = new Telerik.WinControls.UI.RadLabel();
            this.btnArchive = new Telerik.WinControls.UI.RadSplitButtonElement();
            this.mnuMainChart = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuMainValue = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuCurrentBreakDown = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuCurrentValue = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funnelValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grdData.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdData.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdData.ForeColor = System.Drawing.Color.Black;
            this.grdData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdData.Location = new System.Drawing.Point(2, 2);
            // 
            // 
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowColumnReorder = false;
            this.grdData.MasterTemplate.AllowDragToGroup = false;
            this.grdData.MasterTemplate.AllowSearchRow = true;
            this.grdData.MasterTemplate.AutoExpandGroups = true;
            this.grdData.MasterTemplate.AutoGenerateColumns = false;
            this.grdData.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CompanyId";
            gridViewTextBoxColumn1.HeaderText = "CompanyId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "CompanyId";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CompanyName";
            gridViewTextBoxColumn2.HeaderText = "Company Name";
            gridViewTextBoxColumn2.Name = "CompanyName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 81;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 81;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "FrequencyId";
            gridViewTextBoxColumn4.HeaderText = "Frequency";
            gridViewTextBoxColumn4.Name = "FrequencyId";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 48;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "NoOfPeriodsInYear";
            gridViewTextBoxColumn5.HeaderText = "No. Periods (Year)";
            gridViewTextBoxColumn5.Name = "NoOfPeriodsInYear";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 48;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "CurrentPeriod";
            gridViewTextBoxColumn6.HeaderText = "Current Period";
            gridViewTextBoxColumn6.Name = "CurrentPeriod";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 48;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "CurrentYear";
            gridViewTextBoxColumn7.HeaderText = "Current Year";
            gridViewTextBoxColumn7.Name = "CurrentYear";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 48;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "CurrentPeriodEndingDate";
            gridViewTextBoxColumn8.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn8.HeaderText = "Period End Date";
            gridViewTextBoxColumn8.Name = "CurrentPeriodEndingDate";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 44;
            gridViewTextBoxColumn9.HeaderText = "Active Period (Days)";
            gridViewTextBoxColumn9.Name = "ActivePeriod";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 34;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "PayrollType";
            gridViewTextBoxColumn10.HeaderText = "Payroll Type";
            gridViewTextBoxColumn10.MaxWidth = 75;
            gridViewTextBoxColumn10.Name = "PayrollType";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 6;
            gridViewCommandColumn1.DefaultText = "Update";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Update Cut-Off Period";
            gridViewCommandColumn1.MaxWidth = 120;
            gridViewCommandColumn1.MinWidth = 120;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.StretchVertically = false;
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 120;
            this.grdData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn1});
            this.grdData.MasterTemplate.EnableFiltering = true;
            this.grdData.MasterTemplate.EnableGrouping = false;
            this.grdData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdData.Name = "grdData";
            this.grdData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdData.Size = new System.Drawing.Size(588, 228);
            this.grdData.TabIndex = 0;
            this.grdData.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdData_CommandCellClick);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnArchive});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 625);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(592, 30);
            this.radStatusStrip1.TabIndex = 3;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.lblCount);
            this.radGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "<------------------------------ Data Analytics ------------------------------>";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(2, 236);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(588, 389);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "<------------------------------ Data Analytics ------------------------------>";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.SystemColors.HotTrack;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.barTransactions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.barValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.funnelValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pieCount, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // barValue
            // 
            this.barValue.AreaDesign = cartesianArea2;
            this.barValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barValue.Location = new System.Drawing.Point(391, 213);
            this.barValue.Name = "barValue";
            this.barValue.ShowGrid = false;
            this.barValue.ShowTitle = true;
            this.barValue.Size = new System.Drawing.Size(190, 153);
            this.barValue.TabIndex = 3;
            this.barValue.Title = "Y-T-D Transaction(s) Value";
            this.barValue.LabelFormatting += new Telerik.WinControls.UI.ChartViewLabelFormattingEventHandler(this.barValue_LabelFormatting);
            // 
            // funnelValue
            // 
            this.funnelValue.AreaDesign = cartesianArea3;
            this.funnelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funnelValue.Location = new System.Drawing.Point(197, 213);
            this.funnelValue.Name = "funnelValue";
            this.funnelValue.ShowGrid = false;
            this.funnelValue.ShowLegend = true;
            this.funnelValue.ShowTitle = true;
            this.funnelValue.Size = new System.Drawing.Size(188, 153);
            this.funnelValue.TabIndex = 4;
            this.funnelValue.Title = "Current Transaction(s) Value";
            this.funnelValue.LabelFormatting += new Telerik.WinControls.UI.ChartViewLabelFormattingEventHandler(this.funnelValue_LabelFormatting);
            // 
            // pieCount
            // 
            this.pieCount.AreaDesign = cartesianArea4;
            this.pieCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieCount.Location = new System.Drawing.Point(3, 213);
            this.pieCount.Name = "pieCount";
            this.pieCount.ShowGrid = false;
            this.pieCount.ShowLegend = true;
            this.pieCount.ShowTitle = true;
            this.pieCount.Size = new System.Drawing.Size(188, 153);
            this.pieCount.TabIndex = 5;
            this.pieCount.Title = "Current Transaction(s) Breakdown";
            // 
            // barTransactions
            // 
            cartesianArea1.ShowGrid = true;
            this.barTransactions.AreaDesign = cartesianArea1;
            this.tableLayoutPanel1.SetColumnSpan(this.barTransactions, 3);
            this.barTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barTransactions.Location = new System.Drawing.Point(3, 3);
            this.barTransactions.Name = "barTransactions";
            this.barTransactions.ShowLegend = true;
            this.barTransactions.ShowTitle = true;
            this.barTransactions.Size = new System.Drawing.Size(578, 204);
            this.barTransactions.TabIndex = 6;
            this.barTransactions.Title = "Processed Transaction(s) - Y-T-D";
            // 
            // bgwProcess
            // 
            this.bgwProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProcess_DoWork);
            this.bgwProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProcess_RunWorkerCompleted);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCount.Location = new System.Drawing.Point(6, -1);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 22);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "radLabel1";
            this.lblCount.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCost.Location = new System.Drawing.Point(294, 235);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 22);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "radLabel2";
            this.lblCost.Visible = false;
            // 
            // btnArchive
            // 
            this.btnArchive.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.btnArchive.DefaultItem = null;
            this.btnArchive.DropDownDirection = Telerik.WinControls.UI.RadDirection.Up;
            this.btnArchive.ExpandArrowButton = false;
            this.btnArchive.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuMainChart,
            this.mnuMainValue,
            this.mnuCurrentBreakDown,
            this.mnuCurrentValue});
            this.btnArchive.Name = "btnArchive";
            this.radStatusStrip1.SetSpring(this.btnArchive, false);
            this.btnArchive.Text = "Archive Displayed Data";
            // 
            // mnuMainChart
            // 
            this.mnuMainChart.Name = "mnuMainChart";
            this.mnuMainChart.Text = "Processed Transaction(s) - Y-T-D";
            // 
            // mnuMainValue
            // 
            this.mnuMainValue.Name = "mnuMainValue";
            this.mnuMainValue.Text = "Y-T-D Transaction(s) Value";
            // 
            // mnuCurrentBreakDown
            // 
            this.mnuCurrentBreakDown.Name = "mnuCurrentBreakDown";
            this.mnuCurrentBreakDown.Text = "Current Transaction(s) Breakdown";
            // 
            // mnuCurrentValue
            // 
            this.mnuCurrentValue.Name = "mnuCurrentValue";
            this.mnuCurrentValue.Text = "Current Transaction(s) Value";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 655);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.grdData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SMART Data Analyzer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funnelValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdData;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadChartView barValue;
        private Telerik.WinControls.UI.RadChartView funnelValue;
        private Telerik.WinControls.UI.RadChartView pieCount;
        private Telerik.WinControls.UI.RadChartView barTransactions;
        private System.ComponentModel.BackgroundWorker bgwProcess;
        private Telerik.WinControls.UI.RadLabel lblCost;
        private Telerik.WinControls.UI.RadLabel lblCount;
        private Telerik.WinControls.UI.RadSplitButtonElement btnArchive;
        private Telerik.WinControls.UI.RadMenuItem mnuMainChart;
        private Telerik.WinControls.UI.RadMenuItem mnuMainValue;
        private Telerik.WinControls.UI.RadMenuItem mnuCurrentBreakDown;
        private Telerik.WinControls.UI.RadMenuItem mnuCurrentValue;
    }
}
