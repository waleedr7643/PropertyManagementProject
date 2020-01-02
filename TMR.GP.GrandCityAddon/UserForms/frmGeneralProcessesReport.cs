using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon.UserForms
{
    public partial class frmGeneralProcessesReport : Form
    {
        public enum ProcessType { Allocations, Cancellations, Reactivations, Refund, Transfer }
        
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
       
        public ProcessType processtype { get; set; }
        public frmGeneralProcessesReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void frmGeneralProcessesReport_Load(object sender, EventArgs e)
        {
           
            if (processtype == ProcessType.Allocations)
            {
                this.Text = "Allocation Report";
            }
            else if (processtype == ProcessType.Cancellations)
            {
                this.Text = "Cancellation Report";
            }
            else if (processtype == ProcessType.Reactivations)
            {
                this.Text = "Reactivation Report";
            }
            else if (processtype == ProcessType.Refund)
            {
                this.Text = "Refund Report";
            }
            else if (processtype == ProcessType.Transfer)
            {
                this.Text = "Transfer Report";
            }
            LoadProjects();
        }
        public void LoadProjects()
        {
            cmbProject.Items.Clear();
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            else if (cmbStatus.SelectedIndex == -1)
                return;
            else if (dTPFromDate.Value == Convert.ToDateTime("7/5/2019 2:46 PM"))
                return;
            else if (dTPToDate.Value == Convert.ToDateTime("7/5/2019 2:46 PM"))
                return;

            frmReport frm = new frmReport();

            if (processtype == ProcessType.Allocations)
            {
                frm.reportType = ReportType.Allocations;
            }
            else if (processtype == ProcessType.Cancellations)
            {
                frm.reportType = ReportType.Cancellations;
            }
            else if (processtype == ProcessType.Reactivations)
            {
                frm.reportType = ReportType.Reactivations;
            }
            else if (processtype == ProcessType.Transfer)
            {
                frm.reportType = ReportType.Transfer;
            }
            else if (processtype == ProcessType.Refund)
            {
                frm.reportType = ReportType.Refund;
            }
            frm.strProjectID = cmbProject.Text;
            frm.dtFromDate = dTPFromDate.Value;
            frm.dtToDate = dTPToDate.Value;

            //0
            if (cmbStatus.Text == "All")
            {
                frm.intStatusCode = -1;
            }
            //1
            else if (cmbStatus.Text == "Pending")
            {
                frm.intStatusCode = 1;
            }
            //2
            else if (cmbStatus.Text == "Approved")
            {
                frm.intStatusCode = 2;
            }
            else if (cmbStatus.Text == "Rejected")
            {
                frm.intStatusCode = 3;
            }

            frm.Show();
        }

        
    
        private void frmGeneralProcessesReport_Activated(object sender, EventArgs e)
        {
            if (processtype == ProcessType.Allocations)
            {
                this.Text = "Allocation Report";
            }
            else if (processtype == ProcessType.Cancellations)
            {
                this.Text = "Cancellation Report";
            }
            else if (processtype == ProcessType.Reactivations)
            {
                this.Text = "Reactivation Report";
            }
            else if (processtype == ProcessType.Refund)
            {
                this.Text = "Refund Report";
            }
            else if (processtype == ProcessType.Transfer)
            {
                this.Text = "Transfer Report";
            }
        }
    }
}
