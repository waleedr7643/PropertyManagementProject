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
    public partial class frmUnitListReport : Form
    {

        DataAccess da = new DataAccess();
        List<clsProjects> lstProjects;
        List<clsBlock> lstBlocks;
        public frmUnitListReport()
        {
            InitializeComponent();
        }

        private void frmUnitListReport_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            lstProjects = da.GetAllProjectsInfo();
            foreach (var proj in lstProjects)
                cmbProjectID.Items.Add(proj.strProjectid);
        }

        private void cmbProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlockID.Items.Clear();
            lstBlocks = da.GetBlocksByProjectNo(cmbProjectID.Text);
            foreach (var block in lstBlocks)
                cmbBlockID.Items.Add(block.BlockNo);
            LoadSizeCodes();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (cmbProjectID.SelectedIndex == -1)
                return;
            else if (cmbBlockID.SelectedIndex == -1)
                return;


            frmReport frm = new frmReport();
            frm.reportType = ReportType.UnitList;
            frm.strProjectID = cmbProjectID.Text;
            frm.strSizeCode = cmbSizeCode.Text;
            frm.strStatusCode = cmbStatus.Text;
            frm.strBlockNo = cmbBlockID.Text;
            frm.Show();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSizeCodes()
        {
            cmbSizeCode.Items.Clear();

            var lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProjectID.Text);
            foreach (var sizecode in lstSizeCodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
        }
    }
}
