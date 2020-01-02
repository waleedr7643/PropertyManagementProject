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
    public partial class frmReceiptEntry : Form
    {
        DataAccess da = new DataAccess();
        List<clsMemberRecoveryPlan> lstRecoveryPlan = new List<clsMemberRecoveryPlan>();
        List<clsCheckBook> lstCheckbooks = new List<clsCheckBook>();

        clsReceiptEntry receiptEntry = new clsReceiptEntry();

        public int receiptId { get; set; }
        public frmReceiptEntry()
        {
            InitializeComponent();
        }
        private void frmReceiptEntry_Load(object sender, EventArgs e)
        {
            LoadProjects();
            LoadCheckBooks();

            dgInstallmentList.CellValueChanged -= dgInstallmentList_CellValueChanged;

            //receiptId = 17;

            if (receiptId != 0)
            {
                LoadReceiptEntry();
                //txtReceiptNumber.Text = "10001";
                //LoadMemberInstallmentPlanFromReceipt();
                //LoadMemberOtherPaymentPlanFromReceipt();
            }
            else
            {
                var number = da.GetNextReceiptNumber();
                txtReceiptNumber.Text = number;
            }
            dgInstallmentList.CellValueChanged += dgInstallmentList_CellValueChanged;

        }
        private void LoadCheckBooks()
        {
            lstCheckbooks = da.GetCheckBooks();
            foreach (var checkbook in lstCheckbooks)
            {
                cmbDepositBank.Items.Add(checkbook.strCheckbookid);

            }

        }
        private void cmbDepositBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepositBank.SelectedIndex == -1)
                return;

            var checkbook = lstCheckbooks.Where(x => x.strCheckbookid == cmbDepositBank.Text);
            if (checkbook.Count() != 0)
                txtDepositAcc.Text = checkbook.First().strCheckbookDesc;
        }
        private void LoadProjects()
        {
            var lstProject = da.GetAllProjectsInfo();
            foreach (var item in lstProject)
                cmbProjects.Items.Add(item.strProjectid);
            if (cmbProjects.Items.Count != 0)
                cmbProjects.SelectedIndex = 0;
            //Clear();
        }
        private void LoadReceiptEntry()
        {
            receiptEntry = da.GetReceiptEntry(receiptId);

            if (receiptEntry != null)
            {
                txtRegistrationNo.Text = receiptEntry.RegistrationNo;
                txtName.Text = receiptEntry.ClientName;
                txtClientID.Text = receiptEntry.ClientID;
                txtReceiptAmount.Text = receiptEntry.ReceiptAmount.ToString("N2");
                txtAppliedAmount.Text = receiptEntry.AppliedAmount.ToString("N2");
                txtRemainingAmount.Text = receiptEntry.CurrentAmount.ToString("N2");
                cmbReceiptMode.Text = receiptEntry.ReceiptMode;
                txtInstrumentNo.Text = receiptEntry.InstrumentNumber;
                dtpInstrument.Value = receiptEntry.InstrumentDate;
                txtDraweeBank.Text = receiptEntry.DraweeBank;
                txtDraweeBranch.Text = receiptEntry.DraweeBranch;
                cmbDepositBank.Text = receiptEntry.DepositBank;
                txtDepositAcc.Text = receiptEntry.DepositAccount;
                txtDepositBy.Text = receiptEntry.DepositBy;
                dtpDeposit.Value = receiptEntry.DepositDate;
                dtpClearance.Value = receiptEntry.ClearanceDate;
                txtRemarks.Text = receiptEntry.Remarks;
                dtpReceived.Value = receiptEntry.ReceiptDate;
                txtReceiptNumber.Text = receiptEntry.ReceiptNumber;
                txtAccount.Text = receiptEntry.OnAccountOf;
                cmbClearanceStatus.Text = receiptEntry.ClearStatus;

                //if (receiptEntry.Cleared == true)
                //    cmbClearanceStatus.Text = "Cleared";
                //else if (receiptEntry.Cleared == false)
                //    cmbClearanceStatus.Text = "Not Cleared"; 

                LoadMemberInstallmentPlanFromReceipt();

                var info = da.GetMemberRegistrationInfo(receiptEntry.RegistrationNo);
                txtName.Text = info.Name;
                txtFatherName.Text = info.FatherOrHusband;
                txtPlotSize.Text = info.Plan;
                txtUnitID.Text = info.Plot;

                if (info.Plot != "" || info.Plot != null)
                {
                    var unit = da.GetUnitByUnitID(info.Plot);
                    txtPlotCategory.Text = unit.strUnitTypeID;

                }

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.strProject = cmbProjects.Text;
            //LoadSizeCodes();
            frm.memberlookupCode = memberLookupCodes.All;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Clear();
                txtRegistrationNo.Text = frm.strMemberShipID;

                LoadInformation();
                txtRegistrationNo.Focus();
                btnSelectRegistration.Focus();
            }
        }
        private void LoadInformation()
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            var info = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (info == null || info.id == 0)
                return;

            if (info.bSendToGP == false)
            {
                MessageBox.Show("A corresponding customer entry does not exist in Dynamics GP. \n A receipt entry cannot be created.");
                return;
            }

            txtClientID.Enabled = false;
            txtRegistrationNo.Enabled = false;
            txtRegistrationNo.Text = info.RegistrationNo;
            txtClientID.Text = info.ClientID;
            txtName.Text = info.Name;
            txtFatherName.Text = info.FatherOrHusband;
            txtPlotSize.Text = info.Plan;
            txtUnitID.Text = info.Plot;

            if (info.Plot != "" || info.Plot != null)
            {
                var unit = da.GetUnitByUnitID(info.Plot);
                txtPlotCategory.Text = unit.strUnitTypeID;

            }
            

            LoadMemberInstallmentPlan();

        }
        private void LoadMemberInstallmentPlanFromReceipt()
        {
            dgInstallmentList.Rows.Clear();
            var list = da.GetMemberInstallmentPlanFromReceipt(txtReceiptNumber.Text);
            var list1 = da.GetMemberOtherRecoveryPlanFromReceipt(txtReceiptNumber.Text);
            list.AddRange(list1);

            list.Sort((x, y) => DateTime.Compare(x.dateDue, y.dateDue));
            foreach (var row in list)
            {
                if (row.decOutStandingAmount == 0 && row.Applied == false)
                    continue;

                int rowIndex = dgInstallmentList.Rows.Add();
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentNumber"].Value = row.intInstallmentNo;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentRecoveryType"].Value = row.strRecoveryType;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = row.decAmountDue.ToString("N2");

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = row.decOutStandingAmount.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentReceivedAmount"].Value = row.decTotalAmountReceived.ToString("N2");

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentID"].Value = row.intId;

                dgInstallmentList.Rows[rowIndex].Cells["AppliedAmountInst"].Value = row.decAmountApplied.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentWaived"].Value = row.decAmountWaived.ToString("N2");
                //TotalWaivedInst
                dgInstallmentList.Rows[rowIndex].Cells["TotalWaivedInst"].Value = row.decTotalAmountWaived.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueDate"].Value = row.dateDue.ToString("dd/MM/yyyy");
                dgInstallmentList.Rows[rowIndex].Cells["ApplyInstallment"].Value = row.Applied;
                dgInstallmentList.Rows[rowIndex].Cells["OApplyInstallment"].Value = row.Applied;
                lstRecoveryPlan.Add(row);
            }
        }

        private void LoadMemberInstallmentPlan()
        {
            dgInstallmentList.Rows.Clear();
            var list = da.GetMemberInstallmentPlan(txtRegistrationNo.Text);
            var list1 = da.GetMemberOtherRecoveryPlan(txtRegistrationNo.Text);
            list.AddRange(list1);
            list.Sort((x, y) => DateTime.Compare(x.dateDue, y.dateDue));
            foreach (var row in list)
            {
                if (row.decOutStandingAmount == 0)
                    continue;

                int rowIndex = dgInstallmentList.Rows.Add();
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentNumber"].Value = row.intInstallmentNo;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentRecoveryType"].Value = row.strRecoveryType;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = row.decAmountDue.ToString("N2");

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = row.decOutStandingAmount.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentReceivedAmount"].Value = row.decTotalAmountReceived.ToString("N2");

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentID"].Value = row.intId;


                dgInstallmentList.Rows[rowIndex].Cells["AppliedAmountInst"].Value = 0.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentWaived"].Value = 0.ToString("N2");

                //TotalWaivedInst
                dgInstallmentList.Rows[rowIndex].Cells["TotalWaivedInst"].Value = row.decTotalAmountWaived.ToString("N2");


                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueDate"].Value = row.dateDue.ToString("dd/MM/yyyy");

                lstRecoveryPlan.Add(row);
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            receiptId = 0;
            dgInstallmentList.Rows.Clear();

            txtRegistrationNo.Text = "";
            txtName.Text = "";
            txtClientID.Text = "";
            txtReceiptAmount.Text = "0";
            txtAppliedAmount.Text = "0";
            txtRemainingAmount.Text = "0";
            cmbReceiptMode.SelectedIndex = -1;
            txtInstrumentNo.Text = "";

            txtDraweeBank.Text = "";
            txtDraweeBranch.Text = "";
            cmbDepositBank.SelectedIndex = -1;
            txtDepositAcc.Text = "";
            txtDepositBy.Text = "";
            cmbClearanceStatus.Text = "";
            txtRemarks.Text = "";
            txtReceiptNumber.Text = da.GetNextReceiptNumber();

            txtAccount.Text = "";
        }
        private void CalculateTotals()
        {
            decimal totalReceived = 0;

            foreach (DataGridViewRow dgr in dgInstallmentList.Rows)
                totalReceived += Convert.ToDecimal(dgr.Cells["AppliedAmountInst"].Value);


            txtAppliedAmount.Text = totalReceived.ToString("N2");

            decimal receiptAmount = Convert.ToDecimal(txtReceiptAmount.Text);

            txtRemainingAmount.Text = (receiptAmount - totalReceived).ToString("N2");
        }
        private bool ValidateBeforeSave()
        {
            CalculateTotals();
            bool result = false;

            if (cmbProjects.Text == "")
            {
                MessageBox.Show("A valid project selected.");
                return false;
            }

            if (txtRegistrationNo.Text == "")
            {
                MessageBox.Show("A valid registration number must be selected.");
                return false;
            }

            decimal decReceivedAmount = 0;
            result = decimal.TryParse(txtReceiptAmount.Text, out decReceivedAmount);
            if (result == false || decReceivedAmount <= 0)
            {
                MessageBox.Show("Receipt Amount is not a valid figure.");
                txtReceiptAmount.Focus();
                return false;
            }
            decimal decAppliedAmount = 0;
            result = decimal.TryParse(txtAppliedAmount.Text, out decAppliedAmount);
            if (result == false)
            {
                MessageBox.Show("Receipt Amount is not a valid figure.");
                txtAppliedAmount.Focus();
                return false;
            }
            if (decReceivedAmount < decAppliedAmount)
            {
                MessageBox.Show("Receipt Amount must be greater than Applied Amount.");
                txtReceiptAmount.Focus();
                return false;
            }
            if (cmbReceiptMode.SelectedIndex == -1)
            {
                MessageBox.Show("Receipt Mode must be selected.");
                cmbReceiptMode.Focus();
                return false;
            }
            if (cmbDepositBank.SelectedIndex == -1)
            {
                MessageBox.Show("Deposit Bank cannot be empty");
                cmbDepositBank.Focus();
                return false;
            }
            if (cmbReceiptMode.Text != "Cash")
            {
                if (txtDraweeBank.Text == "" || txtDraweeBranch.Text == "")
                {
                    MessageBox.Show("Drawee Bank and branch cannot be empty.");
                    txtDraweeBank.Focus();
                    return false;
                }
                if (txtInstrumentNo.Text == "")
                {
                    MessageBox.Show("Instrument cannot be empty.");
                    txtInstrumentNo.Focus();
                    return false;
                }
            }
            return true;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (!ValidateBeforeSave())
                return;

            clsReceiptEntry entry = new clsReceiptEntry();
            entry.intId = this.receiptId;
            entry.RegistrationNo = txtRegistrationNo.Text;
            entry.ClientName = txtName.Text;
            entry.ClientID = txtClientID.Text;
            entry.ReceiptAmount = Convert.ToDecimal(txtReceiptAmount.Text);
            entry.AppliedAmount = Convert.ToDecimal(txtAppliedAmount.Text);
            entry.CurrentAmount = Convert.ToDecimal(txtRemainingAmount.Text);
            entry.ReceiptMode = cmbReceiptMode.Text;
            entry.InstrumentNumber = txtInstrumentNo.Text;
            entry.InstrumentDate = dtpInstrument.Value.Date;
            entry.DraweeBank = txtDraweeBank.Text;
            entry.DraweeBranch = txtDraweeBranch.Text;
            entry.DepositBank = cmbDepositBank.Text;
            entry.DepositAccount = txtDepositAcc.Text;
            entry.DepositBy = txtDepositBy.Text;
            entry.DepositDate = dtpDeposit.Value.Date;
            entry.ClearanceDate = dtpClearance.Value.Date;
            entry.Remarks = txtRemarks.Text;
            entry.ReceiptDate = dtpReceived.Value.Date;
            entry.ReceiptNumber = txtReceiptNumber.Text;
            entry.Project = cmbProjects.Text;
            entry.OnAccountOf = txtAccount.Text;
            entry.ClearStatus = cmbClearanceStatus.Text;

            if (receiptId == 0)
                entry.SentToGP = false;
            else
                entry.SentToGP = this.receiptEntry.SentToGP;

            if (cmbClearanceStatus.Text == "Cleared")
                entry.Cleared = true;
            else
                entry.Cleared = false;

            bool result = da.AddReceiptEntry(entry);

            if (result == false)
            {
                MessageBox.Show("Receipt Entry could not be saved.");
                return;
            }

            List<clsMemberRecoveryPlan> lst = new List<clsMemberRecoveryPlan>();
            List<clsReceiptApply> lstApply = new List<clsReceiptApply>();

            foreach (DataGridViewRow dgr in dgInstallmentList.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["ApplyInstallment"].Value) == true)
                {
                    clsMemberRecoveryPlan line = new clsMemberRecoveryPlan();
                    line.intId = Convert.ToInt32(dgr.Cells["InstallmentID"].Value);
                    line.decAmountWaived = Convert.ToDecimal(dgr.Cells["TotalWaivedInst"].Value);
                    line.decAmountApplied = Convert.ToDecimal(dgr.Cells["InstallmentReceivedAmount"].Value);
                    line.decOutStandingAmount = Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value);
                    lst.Add(line);

                    clsReceiptApply applyLine = new clsReceiptApply();
                    applyLine.RecoveryPlanid = Convert.ToInt32(dgr.Cells["InstallmentID"].Value);
                    applyLine.RegistrationNo = txtRegistrationNo.Text;
                    applyLine.ClientID = txtClientID.Text;
                    applyLine.Receiptnumber = txtReceiptNumber.Text;
                    applyLine.decAppliedAmount = Convert.ToDecimal(dgr.Cells["AppliedAmountInst"].Value);
                    applyLine.decWaivedAmount = Convert.ToDecimal(dgr.Cells["InstallmentWaived"].Value);
                    lstApply.Add(applyLine);
                }
                if (Convert.ToBoolean(dgr.Cells["OApplyInstallment"].Value) == true && Convert.ToBoolean(dgr.Cells["ApplyInstallment"].Value) == false)
                {
                    clsMemberRecoveryPlan line = new clsMemberRecoveryPlan();
                    line.intId = Convert.ToInt32(dgr.Cells["InstallmentID"].Value);
                    line.decAmountWaived = Convert.ToDecimal(dgr.Cells["TotalWaivedInst"].Value);
                    line.decAmountApplied = Convert.ToDecimal(dgr.Cells["InstallmentReceivedAmount"].Value);
                    line.decOutStandingAmount = Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value);
                    lst.Add(line);

                    clsReceiptApply applyLine = new clsReceiptApply();
                    applyLine.RecoveryPlanid = Convert.ToInt32(dgr.Cells["InstallmentID"].Value);
                    applyLine.RegistrationNo = txtRegistrationNo.Text;
                    applyLine.ClientID = txtClientID.Text;
                    applyLine.Receiptnumber = txtReceiptNumber.Text;
                    applyLine.decAppliedAmount = Convert.ToDecimal(dgr.Cells["AppliedAmountInst"].Value);
                    applyLine.decWaivedAmount = Convert.ToDecimal(dgr.Cells["InstallmentWaived"].Value);
                    lstApply.Add(applyLine);
                }
            }
            result = da.UpdateMemberOtherRecoveryPlan(lst);
            if (result == false)
            {
                MessageBox.Show("Member recovery plan could not be updated.");
                return;
            }

            result = da.AddReceiptApply(lstApply);
            if (result == false)
            {
                MessageBox.Show("Receipts apply information could not be saved.");
                return;
            }

            Clear();
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            dgInstallmentList.CellValueChanged -= dgInstallmentList_CellValueChanged;
            decimal decAmount = Convert.ToDecimal(txtReceiptAmount.Text);

            foreach (DataGridViewRow dgr in dgInstallmentList.Rows)
            {
                dgr.Cells["ApplyInstallment"].Value = false;

                dgr.Cells["InstallmentOutStanding"].Value = (Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value) +
                    Convert.ToDecimal(dgr.Cells["AppliedAmountInst"].Value)).ToString("N2");

                dgr.Cells["AppliedAmountInst"].Value = 0.ToString("N2");

                if (decAmount != 0)
                {
                    decimal AmountToApply = 0;
                    decimal decOutStandingAmount = Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value);

                    if (decOutStandingAmount != 0)
                    {
                        if (decAmount >= decOutStandingAmount)
                        {
                            AmountToApply = decOutStandingAmount;
                            decAmount -= AmountToApply;
                        }
                        else
                        {
                            AmountToApply = decAmount;
                            decAmount -= AmountToApply;
                        }
                    }

                    dgr.Cells["AppliedAmountInst"].Value = (Convert.ToDecimal(dgr.Cells["AppliedAmountInst"].Value) + AmountToApply).ToString("N2");
                    dgr.Cells["InstallmentOutStanding"].Value = (Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value) - AmountToApply).ToString("N2");
                    dgr.Cells["InstallmentReceivedAmount"].Value = (Convert.ToDecimal(dgr.Cells["InstallmentDueAmount"].Value) -
                        Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value)).ToString("N2");
                    dgr.Cells["ApplyInstallment"].Value = true;

                }
                dgr.Cells["InstallmentReceivedAmount"].Value = (Convert.ToDecimal(dgr.Cells["InstallmentDueAmount"].Value) -
                        Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value)).ToString("N2");
            }

            dgInstallmentList.CellValueChanged += dgInstallmentList_CellValueChanged;
        }

        decimal decApplied = 0;
        private void dgOtherRecoveryList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void numerictextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtReceiptAmount_Leave(object sender, EventArgs e)
        {
            decimal decReceiptAmount = 0;
            bool result = decimal.TryParse(txtReceiptAmount.Text, out decReceiptAmount);
            if (result == true)
            {
                txtReceiptAmount.Text = decReceiptAmount.ToString("N2");
            }
        }
        private void dgInstallmentList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == true)
            {
                dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].ReadOnly = false;
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].ReadOnly = false;

                if (dgInstallmentList.Columns["AppliedAmountInst"].Index == e.ColumnIndex)
                    decApplied = Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);
            }

            if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == false)
            {
                dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].ReadOnly = true;
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].ReadOnly = true;
            }
        }
        private void dgInstallmentList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dgInstallmentList.IsCurrentCellDirty)
            //{
            //    dgInstallmentList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }
        private void dgInstallmentList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == true)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].ReadOnly = false;
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].ReadOnly = false;
            //}

            //if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == false)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].ReadOnly = true;
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].ReadOnly = true;
            //}
        }
        private void dgInstallmentList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["AppliedAmountInst"].Index)
            //{
            //    var textbox = ((TextBox)e.Control);
            //    textbox.KeyPress -= numerictextBox_KeyPress;
            //    textbox.KeyPress += numerictextBox_KeyPress;
            //}

            //if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["InstallmentWaived"].Index)
            //{
            //    var textbox = ((TextBox)e.Control);
            //    textbox.KeyPress -= numerictextBox_KeyPress;
            //    textbox.KeyPress += numerictextBox_KeyPress;
            //}
        }
        private void dgInstallmentList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            dgInstallmentList.CellValueChanged -= dgInstallmentList_CellValueChanged;
            if (e.RowIndex == -1)
                return;

            var recoveryPlanRow = lstRecoveryPlan.Where(x => x.intId == Convert.ToInt32(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentID"].Value));

            if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == true)
            {
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
                     (Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value) -
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value)).ToString("N2");

                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
                   (Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value) +
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value)).ToString("N2");


                dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
                    (recoveryPlanRow.First().decTotalAmountWaived +
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value)).ToString("N2");

            }
            else if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == false)
            {
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value) +
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);

                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value) -
                    Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);


                //dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
                //    recoveryPlanRow.First().decTotalAmountReceived;

                //dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
                //    recoveryPlanRow.First().decTotalAmountWaived;

                dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value = 0.ToString("N2");
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value = 0.ToString("N2");
            }
            dgInstallmentList.CellValueChanged += dgInstallmentList_CellValueChanged;
        }
        private void dgInstallmentList_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //var recoveryPlanRow = lstRecoveryPlan.Where(x => x.intId == Convert.ToInt32(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentID"].Value));

            //if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == true)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
            //         (recoveryPlanRow.First().decOutStandingAmount -
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value) +
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value)).ToString("N2");

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
            //       (recoveryPlanRow.First().decTotalAmountReceived +
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value)).ToString("N2");


            //    dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
            //        (recoveryPlanRow.First().decTotalAmountWaived +
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value)).ToString("N2");

            //}
            //else if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == false)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value) +
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value) -
            //        Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);


            //    //dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
            //    //    recoveryPlanRow.First().decTotalAmountReceived;

            //    //dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
            //    //    recoveryPlanRow.First().decTotalAmountWaived;

            //    dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value = 0.ToString("N2");
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value = 0.ToString("N2");
            //}


            //if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == true)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
            //            Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["OInstallmentReceivedAmount"].Value) +
            //            Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value);

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
            //            Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["OInstallmentOutStanding"].Value) -
            //            Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value) -
            //            Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value); //OtherWaivedAmt

            //    dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
            //          Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["OTotalWaivedInst"].Value) +
            //          Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value);
            //}
            //else if (Convert.ToBoolean(dgInstallmentList.Rows[e.RowIndex].Cells["ApplyInstallment"].Value) == false)
            //{
            //    dgInstallmentList.Rows[e.RowIndex].Cells["AppliedAmountInst"].Value =
            //        dgInstallmentList.Rows[e.RowIndex].Cells["OAppliedAmountInst"].Value;

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value =
            //        dgInstallmentList.Rows[e.RowIndex].Cells["OInstallmentReceivedAmount"].Value;

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value =
            //        dgInstallmentList.Rows[e.RowIndex].Cells["OInstallmentWaived"].Value;

            //    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
            //        dgInstallmentList.Rows[e.RowIndex].Cells["OInstallmentOutStanding"].Value;

            //    dgInstallmentList.Rows[e.RowIndex].Cells["TotalWaivedInst"].Value =
            //           Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["OTotalWaivedInst"].Value);
            //}
            CalculateTotals();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.reportType = ReportType.Receipt;

            clsReceiptEntry entry = new clsReceiptEntry();
            entry.RegistrationNo = txtRegistrationNo.Text;
            entry.ClientName = txtName.Text;            
            entry.ReceiptAmount = Convert.ToDecimal(txtReceiptAmount.Text);            
            entry.ReceiptMode = cmbReceiptMode.Text;
            entry.InstrumentNumber = txtInstrumentNo.Text;
            entry.InstrumentDate = dtpInstrument.Value.Date;
            entry.DraweeBank = txtDraweeBank.Text;
            entry.DraweeBranch = txtDraweeBranch.Text;            
            entry.DepositBy = txtDepositBy.Text;
            entry.DepositDate = dtpDeposit.Value.Date;            
            entry.Remarks = txtRemarks.Text;
            entry.ReceiptDate = dtpReceived.Value.Date;
            entry.ReceiptNumber = txtReceiptNumber.Text;
            entry.FatherName = txtFatherName.Text;
            entry.OnAccountOf = txtAccount.Text;
            entry.PlotSize = txtPlotSize.Text;
            report.receipt = entry;

            report.Show();

        }

        private void tsbAttach_Click(object sender, EventArgs e)
        {
            frmReceiptAttachmentList attachments = new frmReceiptAttachmentList();            
            attachments.strRegistrationNo = txtRegistrationNo.Text;
            attachments.strReceiptNumber = txtReceiptNumber.Text;
            attachments.ShowDialog();
        }
    }
}