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
    public partial class frmInventoryReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;
        List<clsSizeCodes> lstSizecodes = new List<clsSizeCodes>();
        
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
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
            
            cmbBlock.Items.Clear();
            cmbBlock.Items.Add("All");
            lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);
            cmbBlock.Enabled = true;
            cmbBlock.Text = "All";


            cmbSizeCode.Items.Clear();
            cmbSizeCode.Items.Add("All");
            lstSizecodes = da.GetAllSizeCodeInfoByProject(cmbProject.Text);
            foreach (var proj in lstSizecodes)
                cmbSizeCode.Items.Add(proj.strUnitSizeCode);
            cmbSizeCode.Enabled = true;
            cmbSizeCode.Text = "All";
            cmbStatus.Enabled = true;
            cmbStatus.Text = "All";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            if (cmbBlock.SelectedIndex == -1)
                return;
            if (cmbSizeCode.SelectedIndex == -1)
                return;
            if (cmbStatus.SelectedIndex == -1)
                return;

            frmReport frm = new frmReport();
            frm.reportType = ReportType.InventoryReport;
            frm.strProjectID = cmbProject.Text;
            frm.strBlockNo = cmbBlock.Text;
            frm.strSizeCode = cmbSizeCode.Text;

            if (cmbStatus.Text == "All")
            {
                frm.intStatusCode = -1;
            }
            else if (cmbStatus.Text == "Available")
            {
                frm.intStatusCode = 1;
            }
            else if (cmbStatus.Text == "Allocated")
            {
                frm.intStatusCode = 2;
            }

            frm.Show();
        }

       
    }
}
