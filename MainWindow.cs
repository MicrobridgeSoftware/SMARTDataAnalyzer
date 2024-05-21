using SmartDataAnalyzer.ApplicationUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Globalization;
using SmartDataAnalyzer.UserInputs;
using System.IO;

namespace SmartDataAnalyzer
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {
        SMARTPayEntities dbContext = new SMARTPayEntities();
        List<Company> companies;
        List<XRM1CurrentTransactions> currentTransactions;
        List<MonthOfYearUtil> monthsOfYear;
        Dictionary<string, int> processedTransactions;
        Dictionary<string, int> processedTransactionBreakDown;
        Dictionary<string, decimal> processedTransactionValue;
        Dictionary<string, decimal> processedTransactionsYtdValue;
        List<XRM1ActivePayrollDays> ActivePayrollDays;
        public static string applicationUser;

        public MainWindow()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Default";

            mnuCurrentBreakDown.Click += new EventHandler(mnuCurrentBreakDown_Click);
            mnuCurrentValue.Click += new EventHandler(mnuCurrentValue_Click);
            mnuMainChart.Click += new EventHandler(mnuMainChart_Click);
            mnuMainValue.Click += new EventHandler(mnuMainValue_Click);
        }

        private void mnuCurrentBreakDown_Click(object sender, EventArgs e)
        {
            printDataChart(pieCount);
        }

        private void mnuCurrentValue_Click(object sender, EventArgs e)
        {
            printDataChart(funnelValue);
        }
        private void mnuMainChart_Click(object sender, EventArgs e)
        {
            printDataChart(barTransactions);
        }

        private void mnuMainValue_Click(object sender, EventArgs e)
        {
            printDataChart(barValue);
        }

        private void printDataChart(RadChartView chart)
        {
            try
            {
                string chartExportFolder = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Exported Charts";
                bool _exportFolderExist = Directory.Exists(chartExportFolder);

                if (!_exportFolderExist)
                    Directory.CreateDirectory(chartExportFolder);

                string filePath = chartExportFolder + "\\" + "exportedChart.png";

                if (File.Exists(filePath))
                {
                    RadMessageBox.Show("A file containing the same name is already in this location!", Application.ProductName);
                    return;
                }

                chart.ExportToImage(filePath, chart.Size, System.Drawing.Imaging.ImageFormat.Png);
                RadMessageBox.Show("File created successfully!", Application.ProductName);
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            monthsOfYear = new List<MonthOfYearUtil>();
            DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();

            for (short monthId = 1; monthId < 13; monthId++)            
                monthsOfYear.Add(new MonthOfYearUtil { monthId = monthId, monthName = dateTimeFormat.GetAbbreviatedMonthName(monthId) });           
            
            this.barTransactions.AreaType = ChartAreaType.Cartesian;
            this.pieCount.AreaType = ChartAreaType.Pie;
            this.barValue.AreaType = ChartAreaType.Cartesian;
            this.funnelValue.AreaType = ChartAreaType.Funnel;

            try
            {
                bgwProcess.RunWorkerAsync();
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void bgwProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            companies = new List<Company>();
            currentTransactions = new List<XRM1CurrentTransactions>();
            int currentYear = DateTime.Today.Year;
            int currentMonth = DateTime.Today.Month;
            processedTransactions = new Dictionary<string, int>();
            processedTransactionBreakDown = new Dictionary<string, int>();
            processedTransactionValue = new Dictionary<string, decimal>();
            processedTransactionsYtdValue = new Dictionary<string, decimal>();
            ActivePayrollDays = new List<XRM1ActivePayrollDays>();

            companies = dbContext.Companies.AsNoTracking().ToList();
            currentTransactions = dbContext.XRM1CurrentTransactions.Where(x => x.TransactionDate.Year == currentYear).AsNoTracking().ToList();
            ActivePayrollDays = dbContext.XRM1ActivePayrollDays.AsNoTracking().ToList();

            foreach (MonthOfYearUtil month in monthsOfYear)
                processedTransactions.Add(month.monthName, currentTransactions.Where(x => x.TransactionDate.Month == month.monthId).Count());

            foreach (Company company in companies)
                processedTransactionBreakDown.Add(company.Description, currentTransactions.Where(x => x.PayrollNo == company.CompanyId && x.TransactionDate.Month == currentMonth).Count());

            foreach (Company company in companies)
                processedTransactionValue.Add(company.Description, Convert.ToDecimal(currentTransactions.Where(x => x.PayrollNo == company.CompanyId && x.TransactionDate.Month == currentMonth).Sum(x => x.TransactionAmount)));

            foreach (Company company in companies)
                processedTransactionsYtdValue.Add(company.Description, Convert.ToDecimal(currentTransactions.Where(x => x.PayrollNo == company.CompanyId).Sum(x => x.TransactionAmount)));
        }

        private void bgwProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            grdData.DataSource = companies;

            if (ActivePayrollDays.Count > 0 && companies.Count > 0)
            {
                for(int i=0; i < grdData.Rows.Count; i++)
                {
                    short companyId = Convert.ToInt16(grdData.Rows[i].Cells["CompanyId"].Value);
                    var activeDays = ActivePayrollDays.Where(x => x.CompanyId == companyId).FirstOrDefault();

                    if (activeDays != null)
                        grdData.Rows[i].Cells["ActivePeriod"].Value = activeDays.ActiveDaysInPeriod;
                }
            }

            foreach (var valuePairs in processedTransactions)
            {
                BarSeries barSeries = new BarSeries();
                barSeries.Name = valuePairs.Key.Trim();
                barSeries.ShowLabels = true;
                barSeries.LegendTitle = valuePairs.Key.Trim();

                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(valuePairs.Value), valuePairs.Key.Trim()));
                this.barTransactions.Series.Add(barSeries);
            }

            PieSeries pieSeries = new PieSeries();

            foreach (var valuePairs in processedTransactionBreakDown.Where(x=> x.Value > 0))
            {
                pieSeries.DataPoints.Add(new PieDataPoint(Convert.ToDouble(valuePairs.Value), valuePairs.Key.Trim()));
                pieSeries.ShowLabels = true;
                pieSeries.LegendTitleMember = valuePairs.Key.Trim();
            }

            this.pieCount.Series.Add(pieSeries);

            FunnelSeries funnelSeries = new FunnelSeries();

            foreach (var valuePairs in processedTransactionValue.Where(x => x.Value > 0))
            {
                funnelSeries.DataPoints.Add(new FunnelDataPoint(Convert.ToDouble(string.Format("{0:N2}", valuePairs.Value)), valuePairs.Key.Trim()));
                funnelSeries.ShowLabels = true;
            }

            this.funnelValue.Series.Add(funnelSeries);

            foreach (var valuePairs in processedTransactionsYtdValue.Where(x=> x.Value > 0))
            {
                BarSeries barSeries = new BarSeries();
                barSeries.Name = valuePairs.Key.Trim();
                barSeries.ShowLabels = true;
                barSeries.LegendTitle = valuePairs.Key.Trim();

                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(valuePairs.Value), valuePairs.Key.Trim()));
                this.barValue.Series.Add(barSeries);
            }
                        
            ChartPanZoomController panZoomController = new ChartPanZoomController();
            panZoomController.PanZoomMode = ChartPanZoomMode.Both;
            barValue.Controllers.Add(panZoomController);
            barValue.Zoom(3, 1);

            lblCost.Text = "Y-T-D Transaction(s) Value: " + string.Format("{0:C}", currentTransactions.Sum(x => x.TransactionAmount));
            lblCount.Text = "Y-T-D Transaction(s) Count: " + string.Format("{0:N0}", currentTransactions.Count());

            lblCost.Visible = true;
            lblCount.Visible = true;
        }

        private void grdData_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Row.Cells["CompanyId"].Value != null && Convert.ToInt16(e.Row.Cells["CompanyId"].Value) > 0)
            {
                if (applicationUser == null || applicationUser == string.Empty)
                {
                    FrmUserAuthentication userAuthentication = new FrmUserAuthentication();
                    userAuthentication.ShowDialog();
                }

                if (applicationUser == null || applicationUser == string.Empty)
                {
                    RadMessageBox.Show("A valid system user is required to continue!", Application.ProductName);
                    return;
                }

                try
                {
                    short companyId = Convert.ToInt16(e.Row.Cells["CompanyId"].Value);
                    string companyDescription = e.Row.Cells["Description"].Value.ToString().Trim();

                    FrmActivePeriod activePeriod = new FrmActivePeriod(companyId, applicationUser, companyDescription);
                    activePeriod.ShowDialog();

                    ActivePayrollDays = new List<XRM1ActivePayrollDays>();
                    ActivePayrollDays = dbContext.XRM1ActivePayrollDays.AsNoTracking().ToList();

                    var activeDays = ActivePayrollDays.Where(x => x.CompanyId == companyId).FirstOrDefault();
                    var gridViewRow = grdData.Rows.Where(x => Convert.ToInt16(x.Cells["CompanyId"].Value) == companyId).FirstOrDefault();

                    if (activeDays != null && gridViewRow != null)
                        gridViewRow.Cells["ActivePeriod"].Value = activeDays.ActiveDaysInPeriod;
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void funnelValue_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {            
            //CategoricalPointElement element = (CategoricalPointElement)e.LabelElement.Parent;
            //CategoricalDataPoint dataPoint = (CategoricalDataPoint)element.DataPoint;
            //e.LabelElement.Text = e.LabelElement.Text = string.Format("Category: {0}, Value: {1}", dataPoint.Category, dataPoint.Value); //string.Format("{0:C}", dataPoint.Value);
            //e.Series.LabelRotationAngle = 90;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext.Dispose();
        }

        private void barValue_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            CategoricalPointElement element = (CategoricalPointElement)e.LabelElement.Parent;
            CategoricalDataPoint dataPoint = (CategoricalDataPoint)element.DataPoint;
            e.LabelElement.Text = e.LabelElement.Text = string.Format("{0:C}", dataPoint.Value);
            e.Series.LabelRotationAngle = 90;
        }
    }
}
