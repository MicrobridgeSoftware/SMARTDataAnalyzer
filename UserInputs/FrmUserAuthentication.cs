using SmartDataAnalyzer.ApplicationUtil;
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
    public partial class FrmUserAuthentication : Telerik.WinControls.UI.RadForm
    {
        SMARTPayEntities dbContext = new SMARTPayEntities();

        public FrmUserAuthentication()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim().Equals(string.Empty) || txtPassword.Text.Trim().Equals(string.Empty))
                {
                    RadMessageBox.Show("Username and Password are required fields!", Application.ProductName);
                    return;
                }

                string username = txtUserName.Text.Trim().ToUpper();
                string password = txtPassword.Text.Trim();

                var authenticateUser = dbContext.SysUsers.Where(x => x.UserName.Trim().ToUpper().Equals(username)).FirstOrDefault();

                if (authenticateUser == null)
                {
                    RadMessageBox.Show("This user cannot be authenticated. Verify the username that was entered!", Application.ProductName);
                    return;
                }

                string savedPassword = DecryptFoxProHash.Decrypt(authenticateUser.UserPassword.Trim());

                if (savedPassword.Equals(password))
                {
                    MainWindow.applicationUser = authenticateUser.UserName.Trim();
                    Close();
                }
                else
                    RadMessageBox.Show("An invalid password was supplied for this user!", Application.ProductName);
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }
    }
}