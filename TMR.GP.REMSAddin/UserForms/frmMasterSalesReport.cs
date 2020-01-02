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
    public partial class frmMasterSalesReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;

        public frmMasterSalesReport()
        {
            InitializeComponent();
        }
       
        private void frmSoldPlotsReport_Load(object sender, EventArgs e)
        {
            LoadProjects();
            dTPFromDate.Value = DateTime.Now.Date;
            dTPToDate.Value = DateTime.Now.Date;

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

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedIndex == -1)
                return;
            else if (cmbBlock.SelectedIndex == -1)
                return;


            frmReport frm = new frmReport();
            frm.reportType = ReportType.MasterSales;
            frm.strProjectID = cmbProject.Text;
            frm.strBlockNo = cmbBlock.Text;
            frm.dtFromDate = dTPFromDate.Value.Date;
            frm.dtToDate = dTPToDate.Value.Date;

            frm.Show();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
