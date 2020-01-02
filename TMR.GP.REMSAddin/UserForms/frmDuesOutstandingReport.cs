using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin.UserForms
{
    public partial class frmDuesOutstandingReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;

        public frmDuesOutstandingReport()
        {
            InitializeComponent();
        }
       
        private void frmSoldPlotsReport_Load(object sender, EventArgs e)
        {
            LoadProjects();
            dTPTillDate.Value = DateTime.Now.Date;
        }
        public void LoadProjects()
        {
            cmbProject.Items.Clear();
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);

            dTPTillDate.Value = DateTime.Now.Date;

            
        }
        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Enabled = true;
            cmbBlock.Items.Clear();
            cmbBlock.Items.Add("All");
            
            lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);
            cmbBlock.Text = "All";

            clsMemberShipFilter filter = new clsMemberShipFilter()
            {
                bForProcess = false,
                strProjectID = cmbProject.Text,
                bFilterAllocated = false,
                membershipStatus = memberLookupCodes.All

            };

            var Result = da.GetMemberRegistration(filter);

            foreach (var item in Result)
            {
                cmbStartRegno.Items.Add(item.RegistrationNo);
                cmbEndRegno.Items.Add(item.RegistrationNo);
            }

        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            else if (cmbBlock.SelectedIndex == -1)
                return;


            frmReport frm = new frmReport();
            frm.reportType = ReportType.DuesOutstanding;
            frm.strBlockNo = cmbBlock.Text;
            frm.strRegistrationNo = cmbStartRegno.Text;
            frm.strDocumentNumber = cmbEndRegno.Text;
            frm.dtFromDate = dTPTillDate.Value.Date;
            if (cmbStatus.Text == "All")
                frm.intStatusCode = -1;
            else if (cmbStatus.Text == "New")
                frm.intStatusCode = 1;
            else if (cmbStatus.Text == "Cancelled")
                frm.intStatusCode = 4;
            else if (cmbStatus.Text == "Refunded")
                frm.intStatusCode = 7;
            else if (cmbStatus.Text == "Reactivated")
                frm.intStatusCode = 9;
            else if (cmbStatus.Text == "Transferred")
                frm.intStatusCode = 14;
                                          
            //cryRpt.SetParameterValue("@Block", strBlockNo);
            //cryRpt.SetParameterValue("@StartRegNo", strRegistrationNo);
            //cryRpt.SetParameterValue("@EndRegNo", strDocumentNumber);
            //cryRpt.SetParameterValue("@TillDate", dtFromDate.Date);
            //cryRpt.SetParameterValue("@StatusCode", intStatusCode);


            frm.Show();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
