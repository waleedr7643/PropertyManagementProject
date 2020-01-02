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
    public partial class frmReceiptDetailReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;

        public frmReceiptDetailReport()
        {
            InitializeComponent();
            dTPFromDate.Value = DateTime.Now.Date;
            dTPToDate.Value = DateTime.Now.Date;
        }

        private void frmSoldPlotsReport_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }
        public void LoadProjects()
        {
            dTPToDate.Value = DateTime.Now;
            dTPFromDate.Value = DateTime.Now;

            cmbProject.Items.Clear();
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);




        }
        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSizeCodes();
        }
        private void LoadSizeCodes()
        {
            cmbSizeCode.Items.Clear();

            var lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProject.Text);
            foreach (var sizecode in lstSizeCodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.reportType = ReportType.ReceiptDetail;

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

            frm.dtFromDate = this.dTPFromDate.Value.Date;
            frm.dtToDate = this.dTPToDate.Value.Date;
            frm.strSizeCode = cmbSizeCode.Text;
            frm.Show();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
