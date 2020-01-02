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
    public partial class frmSoldPlotsReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;
     
        public frmSoldPlotsReport()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            else if (cmbBlock.SelectedIndex == -1)
                return;
            else if (dTPFromDate.Value == Convert.ToDateTime("7/5/2019 2:46 PM"))
                return;
            else if (dTPToDate.Value == Convert.ToDateTime("7/5/2019 2:46 PM"))
                return;

            frmReport frm = new frmReport();
            frm.reportType = ReportType.SoldPlotsByMemberShip;
            frm.strProjectID = cmbProject.Text;
            frm.strBlockNo = cmbBlock.Text;
            frm.dtFromDate = dTPFromDate.Value;
            frm.dtToDate = dTPToDate.Value;
            frm.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmSoldPlotsReport_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }
        public void LoadProjects()
        {
            cmbProject.Items.Clear();
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);
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

        }

    }
}
