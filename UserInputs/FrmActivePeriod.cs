using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartDataAnalyzer.UserInputs
{
    public partial class FrmActivePeriod : Telerik.WinControls.UI.RadForm
    {
        SMARTPayEntities dbContext = new SMARTPayEntities();
        private short companyId;
        private string applicationUser;
        private string companyDescription;

        public FrmActivePeriod()
        {
            InitializeComponent();
        }

        public FrmActivePeriod(short companyId, string applicationUser, string companyDescription) : this()
        {
            this.companyId = companyId;
            this.applicationUser = applicationUser;
            this.companyDescription = companyDescription;
        }

        private void FrmActivePeriod_Load(object sender, EventArgs e)
        {
            txtDescription.Text = companyDescription;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult promptUser = RadMessageBox.Show("Are you sure you want to commit these changes?", Application.ProductName, MessageBoxButtons.YesNo);

            if (promptUser == DialogResult.Yes)
            {
                try
                {
                    var getCompanyInfo = dbContext.XRM1ActivePayrollDays.Where(x => x.CompanyId == companyId).FirstOrDefault();

                    if (getCompanyInfo == null)
                    {
                        XRM1ActivePayrollDays activePayrollDays = new XRM1ActivePayrollDays();
                        activePayrollDays.CompanyId = companyId;
                        activePayrollDays.ActiveDaysInPeriod = Convert.ToInt32(spinDays.Value);
                        activePayrollDays.CreatedBy = applicationUser;
                        activePayrollDays.DateCreated = DateTime.Now;
                        dbContext.XRM1ActivePayrollDays.Add(activePayrollDays);
                    }
                    else
                    {
                        getCompanyInfo.ActiveDaysInPeriod = Convert.ToInt32(spinDays.Value);
                        getCompanyInfo.LastModifiedBy = applicationUser;
                        getCompanyInfo.LastModifiedDate = DateTime.Now;
                    }

                    dbContext.SaveChanges();

                    RadMessageBox.Show("Changes cmmitted successfully!", Application.ProductName);
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }

                Close();
            }
        }
    }
}