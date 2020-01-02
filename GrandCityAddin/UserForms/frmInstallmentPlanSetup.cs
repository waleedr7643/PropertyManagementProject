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
    public partial class frmInstallmentPlanSetup : Form
    {
        DataAccess da = new DataAccess();
        public int id { get; set; }
        public frmInstallmentPlanSetup()
        {
            InitializeComponent();
        }

        private void frmInstallmentPlanSetup_Load(object sender, EventArgs e)
        {
            id = 1;

            if (id != 0)
                LoadInstallments();
        }
        private void LoadInstallments()
        {
            if (id != 0)
            {
                var header = da.GetInstallmentPlanById(id);
                var details = da.GetInstallmentPlanDetailsByPlanId(id);

                txtPlanCode.Text = header.strIntallmentPlanCode;
                txtPlanName.Text = header.strInstallmentPlanName;
                chkInactive.Checked = header.bInactive;

                foreach(var detail in details)
                {
                    int rowIndex = dgInstallments.Rows.Add();
                    dgInstallments.Rows[rowIndex].Cells["InstallmentId"].Value = detail.intId;
                    dgInstallments.Rows[rowIndex].Cells["SNo"].Value = detail.intInstallmentNumber;
                    dgInstallments.Rows[rowIndex].Cells["Percentage"].Value = detail.intInstallmentPercentage;
                    dgInstallments.Rows[rowIndex].Cells["DueAfter"].Value = detail.intInstallmentDueAfterMonths;
                    dgInstallments.Rows[rowIndex].Cells["InstallmentTypeId"].Value = detail.intInstallmentType;
                    dgInstallments.Rows[rowIndex].Cells["PaymentType"].Value = detail.strInstallmentTypeName;                    
                }
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            var header = new clsInstallmentPlan();
            header.strInstallmentPlanName = txtPlanName.Text.Trim();
            header.strIntallmentPlanCode = txtPlanCode.Text.Trim();
            header.bInactive = chkInactive.Checked;
            int PlanID = 0;
            var result = da.AddInstallmentPlan(header, ref PlanID);
            List<clsInstallmentPlanDetails> lst = new List<clsInstallmentPlanDetails>();

            foreach(DataGridViewRow dgr in dgInstallments.Rows)
            {
                clsInstallmentPlanDetails detail = new clsInstallmentPlanDetails();
                detail.strInstallmentPlanCode = txtPlanCode.Text;
                detail.intInstallmentDueAfterMonths = Convert.ToInt32(dgr.Cells["DueAfter"].Value);
                detail.intInstallmentPercentage = Convert.ToInt32(dgr.Cells["Percentage"].Value);
                detail.intInstallmentNumber = Convert.ToInt32(dgr.Cells["SNo"].Value);
                detail.intInstallmentType = Convert.ToInt32(dgr.Cells["InstallmentTypeId"].Value);
                detail.intId = Convert.ToInt32(dgr.Cells["InstallmentId"].Value);
                detail.intInstallmentPlanID = PlanID;

                lst.Add(detail);
            }

            foreach (var item in lst)
                result = da.AddInstallmentPlanDetail(item);

        }

        private void tsbtn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            int rowIndex = dgInstallments.Rows.Add();
            dgInstallments.Rows[rowIndex].Cells["InstallmentId"].Value = 0;
            dgInstallments.Rows[rowIndex].Cells["SNo"].Value = 1;
            dgInstallments.Rows[rowIndex].Cells["Percentage"].Value = txtDuePercentage.Text;
            dgInstallments.Rows[rowIndex].Cells["DueAfter"].Value = txtDueAfterMonths.Text;
            dgInstallments.Rows[rowIndex].Cells["InstallmentTypeId"].Value = cmbInstallmentType.SelectedIndex;
            dgInstallments.Rows[rowIndex].Cells["PaymentType"].Value = cmbInstallmentType.Text;
            
            int i = 1;
            foreach(DataGridViewRow dgr in dgInstallments.Rows)
            {
                dgr.Cells["SNo"].Value = i++;
            }
        }
    }
}
