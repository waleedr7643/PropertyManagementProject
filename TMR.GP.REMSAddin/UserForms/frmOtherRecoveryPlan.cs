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

namespace TMR.GP.REMSAddin
{
    public partial class frmOtherRecoveryPlan : Form
    {
        DataAccess da = new DataAccess();
        List<clsSizeCodes> lstSizecodes = new List<clsSizeCodes>();
        List<clsRecoveryType> lstRecoveryTypes = new List<clsRecoveryType>();
        int id = 0;
        public frmOtherRecoveryPlan()
        {
            InitializeComponent();
        }
        private void frmOtherRecoveryPlan_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            LoadCombos();

        }

        private void SetUserSecurity()
        {
            //var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            //if (userRights.AllowOpen == false)
            //{
            //    MessageBox.Show("User is not authorized to open this form.");
            //    this.Close();
            //}

            //this.tsbSave.Enabled = userRights.AllowSave;
            //this.tsbApprove.Enabled = userRights.AllowPost;

        }
        private void LoadCombos()
        {
            lstSizecodes = da.GetAllSizeCodeInfo();
            foreach (var sizecode in lstSizecodes)
                cmbPlan.Items.Add(sizecode.strUnitSizeCode);

            lstRecoveryTypes = da.GetRecoveryTypes();
            foreach (var recoveryType in lstRecoveryTypes)
            {
                if (recoveryType.bDueMonthly == false)
                    cmbRecoveryType.Items.Add(recoveryType.strCode);
            }


        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if(cmbPlan.Text == "")
            {
                MessageBox.Show("Please select a valid installment plan.");
                return;
            }

            if(lstSizecodes.Where(x=>x.strUnitSizeCode.Trim().ToUpper() == cmbPlan.Text.Trim().ToUpper()).Count() == 0)
            {
                MessageBox.Show("Please select a valid installment plan.");
                return;
            }

            List<clsOtherRecoveryPlan> lstRecPlanRow = new List<clsOtherRecoveryPlan>();

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                var recPlanRow = new clsOtherRecoveryPlan();
                recPlanRow.intInstallmentNo = Convert.ToInt32(dgr.Cells["InstallmentNo"].Value);
                recPlanRow.strRecoveryType = dgr.Cells["RecoveryType"].Value.ToString();
                recPlanRow.intRecoveryTypeid = Convert.ToInt32(dgr.Cells["RecoveryTypeid"].Value);
                recPlanRow.strSizeCode = dgr.Cells["SizeCode"].Value.ToString();
                recPlanRow.decAmountDue = Convert.ToDecimal(dgr.Cells["AmountDue"].Value);
                recPlanRow.intDueAfterMonths = Convert.ToInt32(dgr.Cells["DueAfterMonths"].Value);

                lstRecPlanRow.Add(recPlanRow);
            }

            bool result = da.DeleteOtherRecoveryPlan(cmbPlan.Text);

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
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            cmbPlan.SelectedIndex = -1;
            cmbRecoveryType.SelectedIndex = -1;
            txtDueAfterMonths.Text = "";
            txtDueAmount.Text = "";
            dgList.Rows.Clear();

        }

        private void dgList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgList.IsCurrentCellDirty)
            {
                dgList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex == -1) return;
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
            dgList.Rows[rowIndex].Cells["SizeCode"].Value = cmbPlan.Text;
            dgList.Rows[rowIndex].Cells["InstallmentNo"].Value = installment;
            dgList.Rows[rowIndex].Cells["RecoveryType"].Value = cmbRecoveryType.Text;

            int intRecoveryTypeid = lstRecoveryTypes.Where(x => x.strCode == cmbRecoveryType.Text).First().intId;

            dgList.Rows[rowIndex].Cells["RecoveryTypeid"].Value = intRecoveryTypeid;
            dgList.Rows[rowIndex].Cells["AmountDue"].Value = Amount;
            dgList.Rows[rowIndex].Cells["DueAfterMonths"].Value = months;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            id = 0;
            txtDueAfterMonths.Text = 1.ToString();
            txtDueAmount.Text = 0.ToString();
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex == -1)
                return;

            dgList.Rows.Clear();
            var recoveryPlan = da.GetOtherRecoveryPlan(cmbPlan.Text);

            foreach (var row in recoveryPlan)
            {

                int rowIndex = dgList.Rows.Add();
                dgList.Rows[rowIndex].Cells["Rowid"].Value = row.intId;
                dgList.Rows[rowIndex].Cells["SizeCode"].Value = row.strSizeCode;
                dgList.Rows[rowIndex].Cells["InstallmentNo"].Value = row.intInstallmentNo;
                dgList.Rows[rowIndex].Cells["RecoveryType"].Value = row.strRecoveryType;
                dgList.Rows[rowIndex].Cells["RecoveryTypeid"].Value = row.intRecoveryTypeid;
                dgList.Rows[rowIndex].Cells["AmountDue"].Value = row.decAmountDue.ToString("N2");
                dgList.Rows[rowIndex].Cells["DueAfterMonths"].Value = row.intDueAfterMonths;
            }

        }
    }
}
