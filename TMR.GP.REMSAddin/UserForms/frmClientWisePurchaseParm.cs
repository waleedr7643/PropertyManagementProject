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
    public partial class frmClientWisePurchaseParm : Form
    {
        public ReportType reportType { get; set; }


        DataAccess da = new DataAccess();
        frmReport frm;
        public frmClientWisePurchaseParm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(frm == null || frm.IsDisposed)
            {
                frm = new frmReport();
                frm.strDocumentNumber = cmbProject.Text;
                frm.reportType = this.reportType;
                frm.Show();
            }
            frm.BringToFront();
            
        }

        private void frmGeneralProcessesReport_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }
        public void LoadProjects()
        {
            cmbProject.Items.Clear();
            var result = da.GetClientIdsFromGP();
            foreach (var id in result)
                cmbProject.Items.Add(id);
        }

        private void frmClientWisePurchaseParm_Activated(object sender, EventArgs e)
        {
            if (reportType == ReportType.ClientWisePurchaseHistory)
            {
                this.Text = "Client Wise Purchase History";
            }
            else if (reportType == ReportType.ClientWiseMemberProfile)
            {
                this.Text = "Client Profile And Payment History";
            }
        }
    }
}
