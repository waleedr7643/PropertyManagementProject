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
    public partial class frmRecoveryDueReport : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;

        public frmRecoveryDueReport()
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
            frm.reportType = ReportType.RecoveryDueReport;
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

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.Text == "2016")
            {
                dTPFromDate.Value = new DateTime(2016, 1, 1);
                dTPToDate.Value = new DateTime(2016, 12, 31);
            }
            if (cmbYear.Text == "2017")
            {
                dTPFromDate.Value = new DateTime(2017, 1, 1);
                dTPToDate.Value = new DateTime(2017, 12, 31);
            }
            if (cmbYear.Text == "2018")
            {
                dTPFromDate.Value = new DateTime(2018, 1, 1);
                dTPToDate.Value = new DateTime(2018, 12, 31);
            }
            if (cmbYear.Text == "2019")
            {
                dTPFromDate.Value = new DateTime(2019, 1, 1);
                dTPToDate.Value = new DateTime(2019, 12, 31);
            }
            if (cmbYear.Text == "2020")
            {
                dTPFromDate.Value = new DateTime(2020, 1, 1);
                dTPToDate.Value = new DateTime(2020, 12, 31);
            }
            if (cmbYear.Text == "2021")
            {
                dTPFromDate.Value = new DateTime(2021, 1, 1);
                dTPToDate.Value = new DateTime(2021, 12, 31);
            }
            if (cmbYear.Text == "2022")
            {
                dTPFromDate.Value = new DateTime(2022, 1, 1);
                dTPToDate.Value = new DateTime(2022, 12, 31);
            }
            if (cmbYear.Text == "2023")
            {
                dTPFromDate.Value = new DateTime(2023, 1, 1);
                dTPToDate.Value = new DateTime(2023, 12, 31);
            }
        }
    }
}
