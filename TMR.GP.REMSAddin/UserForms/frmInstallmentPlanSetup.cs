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
    public partial class frmInstallmentPlanSetup : Form
    {
        DataAccess da = new DataAccess();
        List<clsRecoveryType> lstRecoveryTypes = new List<clsRecoveryType>();
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsSizeCodes> lstSizeCodes = new List<clsSizeCodes>();
        public int id { get; set; }
        public frmInstallmentPlanSetup()
        {
            InitializeComponent();
        }

        private void frmInstallmentPlanSetup_Load(object sender, EventArgs e)
        {
            LoadCombos();

            if (id != 0)
                LoadInstallmentPlan();
        }
        private void LoadCombos()
        {

            lstProjects = da.GetAllProjectsInfo();

            foreach (var project in lstProjects)
            {   
                    cmbProject.Items.Add(project.strProjectid);
            }


            lstRecoveryTypes = da.GetRecoveryTypes();
            foreach (var recoveryType in lstRecoveryTypes)
            {
                if (recoveryType.bDueMonthly == false)
                    cmbRecoveryType.Items.Add(recoveryType.strCode);
            }
        }
        private void LoadInstallmentPlan()
        {
            if (id != 0)
            {
                var header = da.GetInstallmentPlanById(id);
                //var details = da.GetInstallmentPlanDetailsByPlanId(id);

                txtPlanCode.Text = header.strIntallmentPlanCode;
                txtPlanName.Text = header.strInstallmentPlanName;
                chkInactive.Checked = header.bInactive;
                txtInstallments.Text = header.intNoOfInstallments.ToString();
                txtStartAfterBooking.Text = header.intInstallmentStartAfter.ToString();
                txtInstallmentAmount.Text = header.decInstallmentAmount.ToString("N2");

                cmbProject.Text = header.strProjectNo;
                cmbSizeCode.Text = header.strSizeCode;

                if (header.intInstallmentFrequency == 1)
                {
                    cmbFrequency.Text = "Monthly";
                }
                else if (header.intInstallmentFrequency == 2)
                {
                    cmbFrequency.Text = "BiMonthly";
                }
                else if (header.intInstallmentFrequency == 3)
                {
                    cmbFrequency.Text = "Quaterly";
                }
                else if (header.intInstallmentFrequency == 4)
                {
                    cmbFrequency.Text = "BiAnnually";
                }
                else if (header.intInstallmentFrequency == 5)
                {
                    cmbFrequency.Text = "Annually";
                }

                dgList.Rows.Clear();

                int SRNo = 1;

                var recoveryPlan = da.GetOtherRecoveryPlan(txtPlanCode.Text);

                foreach (var row in recoveryPlan)
                {

                    int rowIndex = dgList.Rows.Add();

                    dgList.Rows[rowIndex].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[rowIndex].Cells["Rowid"].Value = row.intId;
                    dgList.Rows[rowIndex].Cells["SizeCode"].Value = row.strSizeCode;
                    dgList.Rows[rowIndex].Cells["InstallmentNo"].Value = row.intInstallmentNo;
                    dgList.Rows[rowIndex].Cells["RecoveryType"].Value = row.strRecoveryType;
                    dgList.Rows[rowIndex].Cells["RecoveryTypeid"].Value = row.intRecoveryTypeid;
                    dgList.Rows[rowIndex].Cells["AmountDue"].Value = row.decAmountDue.ToString("N2");
                    dgList.Rows[rowIndex].Cells["DueAfterMonths"].Value = row.intDueAfterMonths;

                    SRNo++;
                }
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txtPlanCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a plan code.");
                return;
            }
            if (txtPlanName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a plan name.");
                return;
            }

            int intNumber = 0;
            bool result = false;

            result = Int32.TryParse(txtInstallments.Text, out intNumber);

            if (result == false || intNumber <= 0)
            {
                MessageBox.Show("Number of installments is not valid.");
                return;
            }

            result = Int32.TryParse(txtStartAfterBooking.Text, out intNumber);
            if (result == false || intNumber <= 0)
            {
                MessageBox.Show("Start after booking number is not valid.");
                return;
            }

            decimal decNumber = 0;
            result = decimal.TryParse(txtInstallmentAmount.Text, out decNumber);

            if (result == false || decNumber <= 0)
            {
                MessageBox.Show("Installment amount is not valid.");
                return;
            }


            var header = new clsInstallmentPlan();
            header.strInstallmentPlanName = txtPlanName.Text.Trim();
            header.strIntallmentPlanCode = txtPlanCode.Text.Trim();

            header.bInactive = chkInactive.Checked;

            if (cmbFrequency.Text == "Monthly")
            {
                header.intInstallmentFrequency = 1;
            }
            else if (cmbFrequency.Text == "BiMonthly")
            {
                header.intInstallmentFrequency = 2;
            }
            else if (cmbFrequency.Text == "Quaterly")
            {
                header.intInstallmentFrequency = 3;
            }
            else if (cmbFrequency.Text == "BiAnnually")
            {
                header.intInstallmentFrequency = 4;
            }
            else if (cmbFrequency.Text == "Annually")
            {
                header.intInstallmentFrequency = 5;
            }

            header.intNoOfInstallments = Convert.ToInt32(txtInstallments.Text);
            header.intInstallmentStartAfter = Convert.ToInt32(txtStartAfterBooking.Text);
            header.decInstallmentAmount = Convert.ToDecimal(txtInstallmentAmount.Text);
            header.strProjectNo = cmbProject.Text;
            header.strSizeCode = cmbSizeCode.Text;
            header.intId = id;
            int PlanID = 0;
            var res = da.AddInstallmentPlan(header, ref PlanID);

            List<clsOtherRecoveryPlan> lstRecPlanRow = new List<clsOtherRecoveryPlan>();

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                var recPlanRow = new clsOtherRecoveryPlan();
                recPlanRow.intInstallmentNo = Convert.ToInt32(dgr.Cells["InstallmentNo"].Value);
                recPlanRow.strRecoveryType = dgr.Cells["RecoveryType"].Value.ToString();
                recPlanRow.intRecoveryTypeid = Convert.ToInt32(dgr.Cells["RecoveryTypeid"].Value);
                recPlanRow.strSizeCode = cmbSizeCode.Text;
                recPlanRow.strProject = cmbProject.Text;
                recPlanRow.strPlan = txtPlanCode.Text;
                recPlanRow.decAmountDue = Convert.ToDecimal(dgr.Cells["AmountDue"].Value);
                recPlanRow.intDueAfterMonths = Convert.ToInt32(dgr.Cells["DueAfterMonths"].Value);

                lstRecPlanRow.Add(recPlanRow);
            }

            if (lstRecPlanRow.Count > 0)
            {
                result = da.DeleteOtherRecoveryPlan(txtPlanCode.Text);

                if (result == false)
                {
                    MessageBox.Show("Operation failed. Please contact system administrator.");
                    return;
                }

                result = da.AddOtherRecoveryPlan(lstRecPlanRow);

                if (result == false)
                {
                    MessageBox.Show("Operation failed. Please contact system administrator.");
                    return;
                }
            }

            Clear();

        }

        private void tsbtn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            id = 0;

            txtPlanCode.Clear();
            txtPlanName.Clear();
            txtStartAfterBooking.Text = "0";
            txtInstallments.Text = "0";
            cmbFrequency.SelectedIndex = -1;
            txtInstallmentAmount.Text = "0";
        }
        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmInstallmentPlanLookup frm = new frmInstallmentPlanLookup();
            DialogResult dlg = frm.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.id = frm.strPlanId;
                LoadInstallmentPlan();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtPlanCode.Text == "") return;
            if (cmbRecoveryType.SelectedIndex == -1) return;
            int months = 0;
            bool result = Int32.TryParse(txtDueAfterMonths.Text, out months);
            if (result == false) { MessageBox.Show("Due after value is invalid"); return; }
            decimal Amount = 0;
            result = decimal.TryParse(txtDueAmount.Text, out Amount);
            if (result == false) { MessageBox.Show("Due percentage value is invalid"); return; }



            int installment = 1;
            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["RecoveryType"].Value.ToString() == cmbRecoveryType.Text)
                    installment++;
            }

            int rowIndex = dgList.Rows.Add();
            dgList.Rows[rowIndex].Cells["Rowid"].Value = id;
            dgList.Rows[rowIndex].Cells["SizeCode"].Value = txtPlanCode.Text;
            dgList.Rows[rowIndex].Cells["InstallmentNo"].Value = installment;
            dgList.Rows[rowIndex].Cells["RecoveryType"].Value = cmbRecoveryType.Text;

            int intRecoveryTypeid = lstRecoveryTypes.Where(x => x.strCode == cmbRecoveryType.Text).First().intId;

            dgList.Rows[rowIndex].Cells["RecoveryTypeid"].Value = intRecoveryTypeid;
            dgList.Rows[rowIndex].Cells["AmountDue"].Value = Amount;
            dgList.Rows[rowIndex].Cells["DueAfterMonths"].Value = months;
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProject.SelectedIndex == -1)
                return;
            cmbSizeCode.Items.Clear();

            lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProject.Text);
            foreach(var sizecode in lstSizeCodes)
            {
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
            }
        }
    }
}
