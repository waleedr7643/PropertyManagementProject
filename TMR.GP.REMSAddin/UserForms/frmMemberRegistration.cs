using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{
    public partial class frmMemberRegistration : Form
    {
        int id = 0;
        bool bEdit = false;
        string strPrefix = "";
        string strNumber = "";
        //public enum ReportCategory { AccountStatement }
        //public ReportCategory Reporcategory { get; set; }

        DataAccess da = new DataAccess();
        clsMemberRegistration info = new clsMemberRegistration();
        clsNominee info1 = new clsNominee();
        clsPartner infoP = new clsPartner();
        List<clsProjects> lstProject;
        List<clsBlock> lstBlocks;
        List<clsSizeCodes> lstSizeCodes;
        List<clsRecoveryType> lstRecoveryTypes;

        public frmMemberRegistration()
        {
            InitializeComponent();
        }
        private void frmMemberRegistration_Load(object sender, EventArgs e)
        {

            SetUserSecurity();

            LoadProjects();
            LoadNomineeGrid();
            LoadPartnerGrid();

            lstRecoveryTypes = da.GetRecoveryTypes();
            SetOtherGridViewRecoveryTypes();
            dgOtherRecoveryList.CellValueChanged += dgList_CellValueChanged;
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            this.tsbSave.Enabled = userRights.AllowSave;
            this.tsbAttach.Enabled = userRights.AllowSave;
            this.tsbViewAttachments.Enabled = userRights.AllowSave;
            this.btnAddNominee.Enabled = userRights.AllowSave;
            this.btnAddPartner.Enabled = userRights.AllowSave;
        }
        private void SetOtherGridViewRecoveryTypes()
        {
            BindingList<clsRecoveryType> bnLstRecoveryTypes = new BindingList<clsRecoveryType>();
            foreach (clsRecoveryType obj in lstRecoveryTypes)
            {
                if (obj.bDueMonthly == false)
                    bnLstRecoveryTypes.Add(new clsRecoveryType() { strCode = obj.strCode });
            }

            ((DataGridViewComboBoxColumn)dgOtherRecoveryList.Columns["RecoveryType"]).DataSource = bnLstRecoveryTypes;
            ((DataGridViewComboBoxColumn)dgOtherRecoveryList.Columns["RecoveryType"]).ValueMember = "strCode";
            ((DataGridViewComboBoxColumn)dgOtherRecoveryList.Columns["RecoveryType"]).DisplayMember = "strCode";

        }
        private void LoadMemberInstallmentPlan()
        {
            dgInstallmentList.Rows.Clear();
            dgInstallmentList.CellValueChanged -= dgInstallmentList_CellValueChanged;
            var list = da.GetMemberInstallmentPlan(txtRegistrationNo.Text);
            foreach (var row in list)
            {
                int rowIndex = dgInstallmentList.Rows.Add();
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentNumber"].Value = row.intInstallmentNo;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentRecoveryType"].Value = row.strRecoveryType;
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = row.decAmountDue.ToString("N2");

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = row.decOutStandingAmount.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentReceivedAmount"].Value = row.decTotalAmountReceived.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentWaived"].Value = row.decTotalAmountWaived.ToString("N2");
                dgInstallmentList.Rows[rowIndex].Cells["InstallmentID"].Value = row.intId;

                dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueDate"].Value = row.dateDue.ToString("dd/MM/yyyy");
            }
            dgInstallmentList.CellValueChanged -= dgInstallmentList_CellValueChanged;
            CalculateAmounts();
        }
        private void LoadMemberOtherPaymentPlan()
        {
            dgOtherRecoveryList.Rows.Clear();
            dgOtherRecoveryList.CellValueChanged -= dgList_CellValueChanged;
            var list = da.GetMemberOtherRecoveryPlan(txtRegistrationNo.Text);
            foreach (var row in list)
            {
                int rowIndex = dgOtherRecoveryList.Rows.Add();
                dgOtherRecoveryList.Rows[rowIndex].Cells["InstallmentNo"].Value = row.intInstallmentNo;
                dgOtherRecoveryList.Rows[rowIndex].Cells["RecoveryType"].Value = row.strRecoveryType;
                dgOtherRecoveryList.Rows[rowIndex].Cells["AmountDue"].Value = row.decAmountDue.ToString("N2");

                dgOtherRecoveryList.Rows[rowIndex].Cells["OutStandingOther"].Value = row.decOutStandingAmount.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherReceivedAmount"].Value = row.decTotalAmountReceived.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherWaivedAmt"].Value = row.decTotalAmountWaived.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["otherId"].Value = row.intId;

                dgOtherRecoveryList.Rows[rowIndex].Cells["DueDate"].Value = row.dateDue.ToString("dd/MM/yyyy");
            }
            dgOtherRecoveryList.CellValueChanged += dgList_CellValueChanged;
            CalculateAmounts();
        }
        private void btnCreateOther_Click(object sender, EventArgs e)
        {
            generateOtherRecoveryPlan();
            CalculateAmounts();
        }
        private void generateOtherRecoveryPlan()
        {
            decimal decNetPrice = 0, decBookingAmount = 0;
            bool valid = decimal.TryParse(txtNetRetailPrice.Text, out decNetPrice);
            if (valid == false)
            {
                MessageBox.Show("Net Retail Price is not valid.");
                return;
            }
            valid = decimal.TryParse(txtBookingPrice.Text, out decBookingAmount);
            if (valid == false)
            {
                MessageBox.Show("Booking Amount is not valid.");
                return;
            }

            if (cmbSizeCode.SelectedIndex == -1)
                return;
            //dgOtherRecoveryList.Rows.Clear();
            foreach (DataGridViewRow dgr in dgOtherRecoveryList.Rows)
            {
                if (!dgr.IsNewRow)
                    dgr.Visible = false;
            }


            var otherRecoveryPlan = da.GetOtherRecoveryPlan(cmbPaymentPlan.Text);

            if (decBookingAmount != 0)
            {
                int rowIndex = dgOtherRecoveryList.Rows.Add();
                dgOtherRecoveryList.Rows[rowIndex].Cells["InstallmentNo"].Value = 0;
                dgOtherRecoveryList.Rows[rowIndex].Cells["RecoveryType"].Value = "BOOKING";
                dgOtherRecoveryList.Rows[rowIndex].Cells["AmountDue"].Value = decBookingAmount.ToString("N2");

                dgOtherRecoveryList.Rows[rowIndex].Cells["OutStandingOther"].Value = decBookingAmount.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherReceivedAmount"].Value = 0.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherWaivedAmt"].Value = 0.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["otherId"].Value = 0;
                dgOtherRecoveryList.Rows[rowIndex].Cells["DueDate"].Value = dTPBooking.Value.ToString("dd/MM/yyyy");

            }

            foreach (var row in otherRecoveryPlan)
            {
                if (row.strRecoveryType == "BOOKING")
                {
                    continue;
                }

                int rowIndex = dgOtherRecoveryList.Rows.Add();
                dgOtherRecoveryList.Rows[rowIndex].Cells["InstallmentNo"].Value = row.intInstallmentNo;
                dgOtherRecoveryList.Rows[rowIndex].Cells["RecoveryType"].Value = row.strRecoveryType;
                dgOtherRecoveryList.Rows[rowIndex].Cells["AmountDue"].Value = (row.decAmountDue).ToString("N2");

                dgOtherRecoveryList.Rows[rowIndex].Cells["OutStandingOther"].Value = (row.decAmountDue).ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherReceivedAmount"].Value = 0.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["OtherWaivedAmt"].Value = 0.ToString("N2");
                dgOtherRecoveryList.Rows[rowIndex].Cells["otherId"].Value = 0;

                dgOtherRecoveryList.Rows[rowIndex].Cells["DueDate"].Value = dTPBooking.Value.AddMonths(row.intDueAfterMonths).ToString("dd/MM/yyyy");
            }
        }
        private void CalculateAmounts()
        {
            decimal decOtherRecovery = 0;
            foreach (DataGridViewRow dgr in dgOtherRecoveryList.Rows)
            {
                if (dgr.IsNewRow == false && dgr.Visible == true)
                    decOtherRecovery += Convert.ToDecimal(dgr.Cells["AmountDue"].Value);
            }

            lblTotalOtherRecovery.Text = decOtherRecovery.ToString("N2");
            decimal decInstallments = 0;
            foreach (DataGridViewRow dgr in dgInstallmentList.Rows)
            {
                if (dgr.IsNewRow == false && dgr.Visible == true)
                    decInstallments += Convert.ToDecimal(dgr.Cells["InstallmentDueAmount"].Value);
            }
            lblTotalInstallmentDue.Text = decInstallments.ToString("N2");
        }


        private void btnGenerateInstallment_Click(object sender, EventArgs e)
        {
            generateInstallmentPlan();
            CalculateAmounts();
        }
        private void generateInstallmentPlan()
        {
            decimal decNetPrice = 0, decBookingAmount = 0;
            bool valid = decimal.TryParse(txtNetRetailPrice.Text, out decNetPrice);



            if (valid == false)
            {
                MessageBox.Show("Net Retail Price is not valid.");
                return;
            }
            valid = decimal.TryParse(txtNetRetailPrice.Text, out decBookingAmount);
            if (valid == false)
            {
                MessageBox.Show("Booking Amount is not valid.");
                return;
            }
            decimal decRemaining = 0, decOther = 0;
            foreach (DataGridViewRow dgr in dgOtherRecoveryList.Rows)
            {

                if (dgr.IsNewRow == false && dgr.Visible == true)
                {
                    var recType = lstRecoveryTypes.Where(x => x.strCode.Trim().ToUpper() == dgr.Cells["RecoveryType"].Value.ToString().Trim().ToUpper());
                    if (recType.First().bIncludeTotal == true)
                        decOther += Convert.ToDecimal(dgr.Cells["AmountDue"].Value);
                }
            }
            decRemaining = decNetPrice - decOther;

            int intIntallmentCount = 0;

            valid = Int32.TryParse(txtNumInstallments.Text, out intIntallmentCount);
            if (valid == false)
            {
                MessageBox.Show("Installment count is not valid.");
                return;
            }
            decimal decInstallmentAmount = decRemaining / intIntallmentCount;

            if (cmbSizeCode.SelectedIndex == -1)
                return;

            if (cmbFrequency.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid frequency.");
                return;
            }
            //dgInstallmentList.Rows.Clear();
            int intFactor = 0;

            if (cmbFrequency.Text == "Monthly") intFactor = 1;
            else if (cmbFrequency.Text == "BiMonthly") intFactor = 2;
            else if (cmbFrequency.Text == "Quarterly") intFactor = 3;
            else if (cmbFrequency.Text == "BiAnnually") intFactor = 6;
            else if (cmbFrequency.Text == "Annually") intFactor = 12;

            decimal totalInstallmentsAmount = 0;
            if (dgInstallmentList.Rows.Count == 0)
            {
                for (int i = 1; i <= intIntallmentCount; i++)
                {
                    int rowIndex = dgInstallmentList.Rows.Add();
                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentNumber"].Value = i;
                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentRecoveryType"].Value = "INSTALLMENT";

                    if (i != intIntallmentCount)
                    {
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = Math.Floor(decInstallmentAmount).ToString("N2");
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = Math.Floor(decInstallmentAmount).ToString("N2");
                        totalInstallmentsAmount += Math.Floor(decInstallmentAmount);
                    }

                    if (i == intIntallmentCount)
                    {

                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                    }

                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueDate"].Value = dtpInstallmentStart.Value.AddMonths((i - 1) * intFactor).ToString("dd/MM/yyyy");

                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentReceivedAmount"].Value = 0.ToString("N2");
                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentWaived"].Value = 0.ToString("N2");
                    dgInstallmentList.Rows[rowIndex].Cells["InstallmentID"].Value = 0;

                }
            }

            else if (dgInstallmentList.Rows.Count != 0)
            {
                for (int i = 1; i <= intIntallmentCount; i++)
                {
                    if (dgInstallmentList.Rows.Count >= i)
                    {
                        dgInstallmentList.Rows[i - 1].Visible = true;
                        dgInstallmentList.Rows[i - 1].Cells["InstallmentDueAmount"].Value = Math.Floor(decInstallmentAmount).ToString("N2");
                        dgInstallmentList.Rows[i - 1].Cells["InstallmentOutStanding"].Value =
                            Math.Floor(decInstallmentAmount) - Convert.ToDecimal(dgInstallmentList.Rows[i - 1].Cells["InstallmentReceivedAmount"].Value)
                            - Convert.ToDecimal(dgInstallmentList.Rows[i - 1].Cells["InstallmentWaived"].Value);



                        dgInstallmentList.Rows[i - 1].Cells["InstallmentDueDate"].Value = dtpInstallmentStart.Value.AddMonths((i - 1) * intFactor).ToString("dd/MM/yyyy");

                        if (i == intIntallmentCount)
                        {

                            dgInstallmentList.Rows[i - 1].Cells["InstallmentDueAmount"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                            dgInstallmentList.Rows[i - 1].Cells["InstallmentOutStanding"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                        }
                        else
                        {
                            totalInstallmentsAmount += Math.Floor(decInstallmentAmount);
                        }

                    }
                    else
                    {
                        int rowIndex = dgInstallmentList.Rows.Add();
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentNumber"].Value = i;
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentRecoveryType"].Value = "INSTALLMENT";

                        if (i != intIntallmentCount)
                        {
                            dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = Math.Floor(decInstallmentAmount).ToString("N2");
                            dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = Math.Floor(decInstallmentAmount).ToString("N2");
                            totalInstallmentsAmount += Math.Floor(decInstallmentAmount);
                        }

                        if (i == intIntallmentCount)
                        {

                            dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueAmount"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                            dgInstallmentList.Rows[rowIndex].Cells["InstallmentOutStanding"].Value = (decRemaining - totalInstallmentsAmount).ToString("N2");
                        }

                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentDueDate"].Value = dtpInstallmentStart.Value.AddMonths((i - 1) * intFactor).ToString("dd/MM/yyyy");

                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentReceivedAmount"].Value = 0.ToString("N2");
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentWaived"].Value = 0.ToString("N2");
                        dgInstallmentList.Rows[rowIndex].Cells["InstallmentID"].Value = 0;
                    }
                }
            }

            if (dgInstallmentList.Rows.Count > intIntallmentCount)
            {
                for (int i = intIntallmentCount; i < dgInstallmentList.Rows.Count; i++)
                {
                    dgInstallmentList.Rows[i].Cells["InstallmentDueAmount"].Value = 0.ToString("N2");
                    dgInstallmentList.Rows[i].Cells["InstallmentOutStanding"].Value = 0.ToString("N2");
                    dgInstallmentList.Rows[i].Visible = false;
                }
            }
        }
        private void LoadProjects()
        {
            lstProject = da.GetAllProjectsInfo();
            foreach (var item in lstProject)
                cmbProjects.Items.Add(item.strProjectid);
            if (cmbProjects.Items.Count != 0)
                cmbProjects.SelectedIndex = 0;



            //Clear();
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
                btnSelect.Focus();
            }
        }
        private void LoadInformation()
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            info = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (info == null || info.id == 0)
                return;

            if (info.bSendToGP == true)
                txtClientID.Enabled = false;
            txtRegistrationNo.Enabled = false;

            bEdit = true;
            id = info.id;
            txtRegistrationNo.Text = info.RegistrationNo;
            txtClientID.Text = info.ClientID;
            txtName.Text = info.Name;
            cBFatherHusband.Text = info.FatherOrHusbandType;
            txtFatherHusband.Text = info.FatherOrHusband;
            txtNIDCNIC.Text = info.NIDOrCNIC;
            cmbNationality.Text = info.Nationality;
            dTPDOB.Value = info.DOB;
            txtCurrentAddress1.Text = info.CurrentAddress1;
            txtCurrentAddress2.Text = info.CurrentAddress2;
            txtCurrentAddress3.Text = info.CurrentAddress3;
            cmbCountry.Text = info.Country.ToString().ToUpper();
            txtCity.Text = info.City.ToString().ToUpper();
            txtPh.Text = info.PhOff;
            txtRes.Text = info.Res;
            txtMob.Text = info.Mob;
            txtFax.Text = info.Fax;
            txtEmailAddress.Text = info.EmailAddress;

            cmbCustomerClass.Text = info.strCustomerClass;

            txtUnitCategory.Text = info.UnitCategory;
            txtUnitType.Text = info.UnitType;

            txtPlotPrice.Text = info.UnitRate.ToString("N2");
            txtChargesPercentage.Text = info.UnitAdditionPerc.ToString("N2");
            txtPlotTypeCharges.Text = info.UntiAdditionalCharges.ToString("N2");

            dTPBooking.Value = info.Booking;
            cmbProjects.Text = info.strProjectid;
            cmbSizeCode.Text = info.Plan;
            cmbBlock.Text = info.Block;
            cmbUnit.Text = info.Plot;

            txtUnitRate.Text = Convert.ToString(info.UnitRate);
            txtTotalPrice.Text = info.TotalPrice.ToString("N2");
            txtFinancialAmt.Text = Convert.ToString(info.FinanceAmt);
            txtRebatAmt.Text = info.RebatAmt.ToString("N2");
            txtNetRetailPrice.Text = info.NetOrRetailPrice.ToString("N2");
            txtBookingPrice.Text = info.BookingPrice.ToString("N2");
            txtMemberRegPercentage.Text = info.intPercentage.ToString();
            txtStatus.Text = info.strStatus;
            txtAccountTitle.Text = info.AccountTitle;
            txtAccountNumber.Text = info.AccountNumber;
            txtBankName.Text = info.BankName;
            txtCustomerNumber.Text = info.CustomerNumber;
            cmbSalesRep.Text = info.strSalesRep;
            chkSoleProprieter.Checked = info.bSoleOwner;

            txtNumInstallments.Text = info.intInstallmentCount.ToString();
            cmbPlanType.Text = info.strInstallmentPlanType;
            dtpInstallmentStart.Value = info.dateInstallmentStartDate;

            if (info.intInstallmentFrequency == 1)
            {
                cmbFrequency.Text = "Monthly";
            }
            else if (info.intInstallmentFrequency == 2)
            {
                cmbFrequency.Text = "BiMonthly";
            }
            else if (info.intInstallmentFrequency == 3)
            {
                cmbFrequency.Text = "Quaterly";
            }
            else if (info.intInstallmentFrequency == 4)
            {
                cmbFrequency.Text = "BiAnnually";
            }
            else if (info.intInstallmentFrequency == 5)
            {
                cmbFrequency.Text = "Annually";
            }
            cmbPaymentPlan.Text = info.strInstallmentPlan;
            cmbDealer.Text = info.strDealer;
            cmbSubDealer.Text = info.strSubDealer;
            cmbSalesPerson.Text = info.strSalesRep;

            txtDealerPercentage.Text = info.decDealerPercentage.ToString("N2");
            txtSPPercentage.Text = info.decSalesRepPercentage.ToString("N2");
            txtSubDealerPercentage.Text = info.decSubDealerPercentage.ToString("N2");
            LoadNomineeGrid();
            LoadPartnerGrid();

            LoadMemberInstallmentPlan();
            LoadMemberOtherPaymentPlan();
            txtNumInstallments.Text = info.intInstallmentCount.ToString();
            CalculateAmounts();


            pBMemberCNIC.Image = null;
            txtPictureName.Text = "";
            pBMemberRegistration.Image = null;
            txtCNICName.Text = "";


            if (txtRegistrationNo.Text.Trim() != "")
            {
                //Member image
                var res = da.GetMemberImage(txtRegistrationNo.Text, txtClientID.Text);

                if (!(res == null || res.Image == null))
                {
                    pBMemberRegistration.Image = byteArrayToImage(res.Image);
                    txtPictureName.Text = res.ImageId;
                }
                //Member cinic

                var res2 = da.GetMemberCnic(txtRegistrationNo.Text, txtClientID.Text);

                if (!(res2 == null || res2.Image == null))
                {
                    pBMemberCNIC.Image = byteArrayToImage(res2.Image);
                    txtCNICName.Text = res2.ImageId; ;
                }
            }

        }
        public byte[] imageToByteArray(System.Drawing.Image ImageIn)
        {
            MemoryStream ms = new MemoryStream();
            ImageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }           //imageToByteArray
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);

            if (ms != null)
            {
                Image returnimage = Image.FromStream(ms);
                return returnimage;
            }

            else
            {
                return null;
            }
        }                     //byteArrayToImage
        private void btnAddNominee_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please Save Membership information first.");
                return;
            }

            if (txtNomineeID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nominee Cannot Be Empty");
                txtNomineeID.Focus();
                return;
            }
            if (txtNomineeName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name Cannot Be Empty");
                txtNomineeName.Focus();
                return;
            }
            if (txtNomineeFatherHusband.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Father Name Cannot Be Empty");
                txtNomineeFatherHusband.Focus();
                return;
            }
            //if (txtNomineeNIDCNIC.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("CNIC Cannot Be Empty");
            //    txtNomineeNIDCNIC.Focus();
            //    return;
            //}
            if (txtNomineeCurrentAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Current Address Cannot Be Empty");
                txtNomineeCurrentAddress1.Focus();

                return;
            }
            if (cmbNomineeCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Country Cannot Be Empty");
                cmbNomineeCountry.Focus();
                return;
            }
            if (txtNomineeCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("City Cannot Be Empty");
                txtNomineeCity.Focus();
                return;
            }
            if (txtNomineeRelation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Relation Cannot Be Empty");
                txtNomineeRelation.Focus();
                return;
            }

            int perc = 0;
            bool b = int.TryParse(txtNomineePercentage.Text, out perc);

            if (b == false)
            {
                MessageBox.Show("Nominee percentage is not a valid value.");
                txtNomineePercentage.Focus();
                return;
            }

            foreach (DataGridViewRow row in dgNominee.Rows)
            {

                string nomineeid = row.Cells["NomineeID1"].Value.ToString();
                if (txtNomineeID.Text == nomineeid && Nomineeid != Convert.ToInt32(row.Cells["ID1"].Value))
                {
                    MessageBox.Show("Nominee Id Already exist");
                    return;
                }
                //More code here
            }

            info1.RegistrationOrBookingNo = txtRegistrationNo.Text;
            info1.NomineeID = txtNomineeID.Text;
            info1.ClientID = txtClientID.Text;
            info1.Name = txtNomineeName.Text;
            info1.FatherOrHusband = txtNomineeFatherHusband.Text;
            info1.NIDOrCNIC = txtNomineeNIDCNIC.Text;
            info1.CurrentAddress1 = txtNomineeCurrentAddress1.Text;
            info1.CurrentAddress2 = txtNomineeCurrentAddress2.Text;
            info1.CurrentAddress3 = txtNomineeCurrentAddress3.Text;
            info1.Country = cmbNomineeCountry.Text;
            info1.City = txtNomineeCity.Text;
            info1.Relation = txtNomineeRelation.Text;
            info1.Percentage = perc;
            info1.id = Nomineeid;


            bool result = da.AddNomineeINFO(info1);

            Nomineeid = 0;

            if (result == false)
            {
                MessageBox.Show("An error occoured.");
            }

            #region//////// Add Nominee Image
            clsNomineeImage nomineeImage = new clsNomineeImage();
            if (pbNomineeImage.Image != null)
            {
                nomineeImage.Image = imageToByteArray(this.pbNomineeImage.Image); //pBNominee.Image.

                da.AddNomineeImage(new clsNomineeImage()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtNomineePictureName.Text,
                    RegistrationOrBookingNo = txtRegistrationNo.Text,
                    NomineeID = txtNomineeID.Text,
                    Image = nomineeImage.Image
                });
            }
            #endregion

            #region////////// Add Nominee CNIC
            clsNomineeCNIC nomineeCNIC = new clsNomineeCNIC();
            if (pbNomineeImage.Image != null)
            {
                nomineeCNIC.Image = imageToByteArray(this.pbNomineeCNIC.Image); //pBNominee.CNIC.

                da.AddNomineeCNIC(new clsNomineeCNIC()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtNomineeCNICName.Text,
                    RegistrationNo = txtRegistrationNo.Text,
                    NomineeID = txtNomineeID.Text,
                    Image = nomineeCNIC.Image
                });
            }
            #endregion

            LoadNomineeGrid();

            NomineeClear();
        }
        private void LoadNomineeGrid()
        {
            dgNominee.Rows.Clear();
            List<clsNominee> lstnominee = new List<clsNominee>();
            lstnominee = da.GetNomineeByMemberRegistrationNo(txtRegistrationNo.Text, txtClientID.Text);

            foreach (var item in lstnominee)
            {
                int intRowIndex = dgNominee.Rows.Add();
                dgNominee.Rows[intRowIndex].Cells["RegistrationNo"].Value = item.RegistrationOrBookingNo;
                dgNominee.Rows[intRowIndex].Cells["NomineeID1"].Value = item.NomineeID;
                dgNominee.Rows[intRowIndex].Cells["NomineeClientID"].Value = item.ClientID;
                dgNominee.Rows[intRowIndex].Cells["Name1"].Value = item.Name;
                dgNominee.Rows[intRowIndex].Cells["FatherOrHusband"].Value = item.FatherOrHusband;
                dgNominee.Rows[intRowIndex].Cells["NIDOrCNIC"].Value = item.NIDOrCNIC;
                dgNominee.Rows[intRowIndex].Cells["Address1"].Value = item.CurrentAddress1;
                dgNominee.Rows[intRowIndex].Cells["Address2"].Value = item.CurrentAddress2;
                dgNominee.Rows[intRowIndex].Cells["Address3"].Value = item.CurrentAddress3;
                dgNominee.Rows[intRowIndex].Cells["Country"].Value = item.Country;
                dgNominee.Rows[intRowIndex].Cells["City"].Value = item.City;
                dgNominee.Rows[intRowIndex].Cells["Relation"].Value = item.Relation;
                dgNominee.Rows[intRowIndex].Cells["NomineePercentage"].Value = item.Percentage;
                dgNominee.Rows[intRowIndex].Cells["ID1"].Value = item.id;
            }
        }

        int Nomineeid = 0;
        private void txtRegistrationNo_Leave(object sender, EventArgs e)
        {
            if (cmbProjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a project first.");
                return;
            }

            if (txtRegistrationNo.Text.Trim() == "")
                return;

            info = new clsMemberRegistration();
            info.RegistrationNo = txtRegistrationNo.Text;
            info = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (info == null)
            {
                MessageBox.Show("Please select a valid Registration Number.");
                txtRegistrationNo.Text = "";
                tsbClear_Click(null, null);
                return;
            }


            LoadInformation();
        }

        ///////////////////////////////////////////////////////////////Clear
        private void MemberRegistrationClear()
        {
            id = 0;
            bEdit = false;
            strPrefix = "";
            strNumber = "";

            txtClientID.Enabled = true;
            cmbSizeCode.SelectedIndex = -1;
            txtMemberRegPercentage.Text = "0";
            pBMemberRegistration.Image = null;
            txtPictureName.Text = "";
            txtRegistrationNo.Text = "";
            pBMemberCNIC.Image = null;
            txtCNICName.Text = "";
            txtClientID.Text = "";
            txtName.Text = "";
            cBFatherHusband.Text = null;
            txtFatherHusband.Text = "";
            txtNIDCNIC.Text = "";
            cmbNationality.Text = null;
            //dTPDOB.Value = "";
            txtCurrentAddress1.Text = "";
            txtCurrentAddress2.Text = "";
            txtCurrentAddress3.Text = "";
            cmbCountry.Text = null;
            txtCity.Text = "";
            txtPh.Text = "";
            txtRes.Text = "";
            txtMob.Text = "";
            txtFax.Text = "";
            txtEmailAddress.Text = "";
            cmbSizeCode.Text = "";
            //cmbProjects.Text = null;
            //dTPBooking.Value = "";

            txtUnitCategory.Text = "";
            txtUnitType.Text = "";

            txtPlotPrice.Text = "0.00";
            txtChargesPercentage.Text = "0.00";
            txtPlotTypeCharges.Text = "0.00";

            cmbBlock.Text = "";
            cmbUnit.Text = "";
            txtUnitRate.Text = "0.00";
            txtTotalPrice.Text = "0.00";
            txtFinancialAmt.Text = "0.00";
            txtRebatAmt.Text = "0.00";
            txtNetRetailPrice.Text = "0.00";
            txtBookingPrice.Text = "0.00";
            txtStatus.Text = "";
            txtAccountTitle.Clear();
            txtAccountNumber.Clear();
            txtBankName.Clear();
            txtCustomerNumber.Clear();
            cmbSalesRep.SelectedIndex = -1;
            chkSoleProprieter.Checked = true;
            txtRegistrationNo.Enabled = true;
        }
        private void NomineeClear()
        {
            txtNomineePercentage.Text = "0";
            txtNomineeCNICName.Text = "";
            pbNomineeCNIC.Image = null;
            txtNomineePictureName.Text = "";
            pbNomineeImage.Image = null;
            txtNomineeID.Text = "";
            txtNomineeName.Text = "";
            txtNomineeFatherHusband.Text = "";
            txtNomineeNIDCNIC.Text = "";
            txtNomineeCurrentAddress1.Text = "";
            txtNomineeCurrentAddress2.Text = "";
            txtNomineeCurrentAddress3.Text = "";
            cmbNomineeCountry.Text = null;
            txtNomineeCity.Text = "";
            txtNomineeRelation.Text = "";
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            //if (chkSoleProprieter.Checked == true)
            //{
            //    MessageBox.Show("Client is marked as sole owner. Partners cannot be added.");
            //    return;
            //}
            if (id == 0)
            {
                MessageBox.Show("Please Save Membership information first.");
                return;
            }

            if (txtPartnerID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ID Cannot Be Empty");
                txtPartnerID.Focus();
                return;
            }
            if (txtPartnerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Partner Name Cannot Be Empty");
                txtPartnerName.Focus();
                return;
            }
            if (txtPartnerFatherHusband.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Father Name Cannot Be Empty");
                txtPartnerFatherHusband.Focus();
                return;
            }
            //if (txtPartnerNIDCNIC.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("CNIC Cannot Be Empty");
            //    txtPartnerNIDCNIC.Focus();
            //    return;
            //}
            if (txtPartnerCurrentAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("CurrentAddress Cannot Be Empty");
                txtPartnerCurrentAddress1.Focus();
                return;
            }
            if (cmbPartnerCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Country Cannot Be Empty");
                cmbPartnerCountry.Focus();
                return;
            }
            if (txtPartnerCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("City Cannot Be Empty");
                txtPartnerCity.Focus();
                return;
            }
            if (txtPartnerRelation.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Relation Cannot Be Empty");
                txtPartnerRelation.Focus();
                return;
            }
            int perc = 0;
            bool b = int.TryParse(txtPartnerPercentage.Text, out perc);

            if (b == false)
            {
                MessageBox.Show("Partner percentage is not a valid value.");
                txtPartnerPercentage.Focus();
                return;
            }

            foreach (DataGridViewRow row in dgPartner.Rows)
            {
                string partnerid = row.Cells["PartnerID"].Value.ToString();
                if (txtPartnerID.Text == partnerid && intPartnerID != Convert.ToInt32(row.Cells["PID"].Value))
                {
                    MessageBox.Show("Partner Already exist");
                    return;
                }
                //More code here
            }

            infoP.RegistrationOrBookingNo = txtRegistrationNo.Text;
            infoP.PartnerID = txtPartnerID.Text;
            infoP.ClientID = txtClientID.Text;
            infoP.Name = txtPartnerName.Text;
            infoP.FatherOrHusband = txtPartnerFatherHusband.Text;
            infoP.NIDOrCNIC = txtPartnerNIDCNIC.Text;
            infoP.CurrentAddress1 = txtPartnerCurrentAddress1.Text;
            infoP.CurrentAddress2 = txtPartnerCurrentAddress2.Text;
            infoP.CurrentAddress3 = txtPartnerCurrentAddress3.Text;
            infoP.Country = cmbPartnerCountry.Text;
            infoP.City = txtPartnerCity.Text;
            infoP.Relation = txtPartnerRelation.Text;
            infoP.Percentage = perc;
            infoP.AccountNumber = txtPAccountNumber.Text;
            infoP.AccountTitle = txtPAccountTitle.Text;
            infoP.BankName = txtPBankName.Text;
            infoP.id = intPartnerID;

            bool result = da.AddPartnerINFO(infoP);

            if (result == false)
            {
                MessageBox.Show("An error occoured.");
            }

            #region////// Add Partner Image
            clsPartnerImage partnerImage = new clsPartnerImage();
            if (pbPartnerImage.Image != null)
            {
                partnerImage.Image = imageToByteArray(this.pbPartnerImage.Image); //pBPartner.Image.

                da.AddPartnerImage(new clsPartnerImage()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtPartnerImageName.Text,
                    RegistrationNo = txtRegistrationNo.Text,
                    PartnerID = txtPartnerID.Text,
                    Image = partnerImage.Image
                });
            }

            #endregion////////

            #region////// Add Partner CNIC
            clsPartnerCNIC partnerCNIC = new clsPartnerCNIC();
            if (pbPartnerCNIC.Image != null)
            {
                partnerCNIC.Image = imageToByteArray(this.pbPartnerCNIC.Image); //pBPartner.CNIC.

                da.AddPartnerCNIC(new clsPartnerCNIC()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtPartnerCNICName.Text,
                    RegistrationNo = txtRegistrationNo.Text,
                    PartnerID = txtPartnerID.Text,
                    Image = partnerCNIC.Image
                });
            }
            #endregion///////

            LoadPartnerGrid();
            PClear();
        }
        private void LoadPartnerGrid()
        {
            dgPartner.Rows.Clear();

            List<clsPartner> lstnominee = da.GetPartnerByMemberRegistrationNo(txtRegistrationNo.Text, txtClientID.Text);
            foreach (var item in lstnominee)
            {
                int intRowIndex = dgPartner.Rows.Add();
                dgPartner.Rows[intRowIndex].Cells["PRegistrationNo"].Value = item.RegistrationOrBookingNo;
                dgPartner.Rows[intRowIndex].Cells["PartnerID"].Value = item.PartnerID;
                dgPartner.Rows[intRowIndex].Cells["PName"].Value = item.Name;
                dgPartner.Rows[intRowIndex].Cells["PFatherHusband"].Value = item.FatherOrHusband;
                dgPartner.Rows[intRowIndex].Cells["PNIDCNIC"].Value = item.NIDOrCNIC;
                dgPartner.Rows[intRowIndex].Cells["PAddress1"].Value = item.CurrentAddress1;
                dgPartner.Rows[intRowIndex].Cells["PAddress2"].Value = item.CurrentAddress2;
                dgPartner.Rows[intRowIndex].Cells["PAddress3"].Value = item.CurrentAddress3;
                dgPartner.Rows[intRowIndex].Cells["PCountry"].Value = item.Country;
                dgPartner.Rows[intRowIndex].Cells["PCity"].Value = item.City;
                dgPartner.Rows[intRowIndex].Cells["PRelation"].Value = item.Relation;
                dgPartner.Rows[intRowIndex].Cells["PartnerPercentage"].Value = item.Percentage;

                dgPartner.Rows[intRowIndex].Cells["PAccountNumber"].Value = item.AccountNumber;
                dgPartner.Rows[intRowIndex].Cells["PAccountTitle"].Value = item.AccountTitle;
                dgPartner.Rows[intRowIndex].Cells["PBankName"].Value = item.BankName;

                dgPartner.Rows[intRowIndex].Cells["PID"].Value = item.id;
            }
        }
        private void PClear()
        {
            txtPartnerPercentage.Text = "0";
            txtPartnerImageName.Text = "";
            pbPartnerImage.Image = null;
            txtPartnerCNICName.Text = "";
            pbPartnerCNIC.Image = null;
            txtPartnerID.Text = "";
            txtPartnerName.Text = "";
            txtPartnerFatherHusband.Text = "";
            txtPartnerNIDCNIC.Text = "";
            txtPartnerCurrentAddress1.Text = "";
            txtPartnerCurrentAddress2.Text = "";
            txtPartnerCurrentAddress3.Text = "";
            cmbPartnerCountry.Text = null;
            txtPartnerCity.Text = "";
            txtPartnerRelation.Text = "";

        }

        int intPartnerID = 0;
        private void dgPartner_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            pbPartnerCNIC.Image = null;
            txtPartnerCNICName.Text = "";

            pbPartnerImage.Image = null;
            txtPartnerImageName.Text = "";

            intPartnerID = 0;

            if (e.RowIndex == -1)
                return;
            txtRegistrationNo.Text = dgPartner.Rows[e.RowIndex].Cells["PRegistrationNo"].Value.ToString();
            txtPartnerID.Text = dgPartner.Rows[e.RowIndex].Cells["PartnerID"].Value.ToString();
            txtPartnerName.Text = dgPartner.Rows[e.RowIndex].Cells["PName"].Value.ToString();
            txtPartnerFatherHusband.Text = dgPartner.Rows[e.RowIndex].Cells["PFatherHusband"].Value.ToString();
            txtPartnerNIDCNIC.Text = dgPartner.Rows[e.RowIndex].Cells["PNIDCNIC"].Value.ToString();
            txtPartnerCurrentAddress1.Text = dgPartner.Rows[e.RowIndex].Cells["PAddress1"].Value.ToString();
            txtPartnerCurrentAddress2.Text = dgPartner.Rows[e.RowIndex].Cells["PAddress2"].Value.ToString();
            txtPartnerCurrentAddress3.Text = dgPartner.Rows[e.RowIndex].Cells["PAddress3"].Value.ToString();
            cmbPartnerCountry.Text = dgPartner.Rows[e.RowIndex].Cells["PCountry"].Value.ToString();
            txtPartnerCity.Text = dgPartner.Rows[e.RowIndex].Cells["PCity"].Value.ToString();
            txtPartnerRelation.Text = dgPartner.Rows[e.RowIndex].Cells["PRelation"].Value.ToString();
            txtPartnerPercentage.Text = dgPartner.Rows[e.RowIndex].Cells["PartnerPercentage"].Value.ToString();

            txtPBankName.Text = dgPartner.Rows[e.RowIndex].Cells["PBankName"].Value.ToString();
            txtPAccountTitle.Text = dgPartner.Rows[e.RowIndex].Cells["PAccountTitle"].Value.ToString();
            txtPAccountNumber.Text = dgPartner.Rows[e.RowIndex].Cells["PAccountNumber"].Value.ToString();


            intPartnerID = Convert.ToInt32(dgPartner.Rows[e.RowIndex].Cells["PID"].Value);

            ////////// Get Partner Image
            clsPartnerImage clsimg = da.GetPartnerImage(txtRegistrationNo.Text, txtClientID.Text, txtPartnerID.Text);

            if (!(clsimg == null || clsimg.Image == null))
            {
                pbPartnerImage.Image = byteArrayToImage(clsimg.Image);
                txtPartnerImageName.Text = clsimg.ImageId;
            }

            //////////// Get Partner CNIC

            clsPartnerCNIC clsCI = da.GetPartnerCNIC(txtRegistrationNo.Text, txtClientID.Text, txtPartnerID.Text);

            if (!(clsCI == null || clsCI.Image == null))
            {
                pbPartnerCNIC.Image = byteArrayToImage(clsCI.Image);
                txtPartnerCNICName.Text = clsCI.ImageId;
            }



        }
        private void dgNominee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            pbNomineeCNIC.Image = null;
            txtNomineeCNICName.Text = "";

            pbNomineeImage.Image = null;
            txtNomineePictureName.Text = "";

            if (e.RowIndex == -1)
                return;
            txtRegistrationNo.Text = dgNominee.Rows[e.RowIndex].Cells["RegistrationNo"].Value.ToString();
            txtNomineeID.Text = dgNominee.Rows[e.RowIndex].Cells["NomineeID1"].Value.ToString();
            txtNomineeName.Text = dgNominee.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
            txtNomineeFatherHusband.Text = dgNominee.Rows[e.RowIndex].Cells["FatherOrHusband"].Value.ToString();
            txtNomineeNIDCNIC.Text = dgNominee.Rows[e.RowIndex].Cells["NIDOrCNIC"].Value.ToString();
            txtNomineeCurrentAddress1.Text = dgNominee.Rows[e.RowIndex].Cells["Address1"].Value.ToString();
            txtNomineeCurrentAddress2.Text = dgNominee.Rows[e.RowIndex].Cells["Address2"].Value.ToString();
            txtNomineeCurrentAddress3.Text = dgNominee.Rows[e.RowIndex].Cells["Address3"].Value.ToString();
            cmbNomineeCountry.Text = dgNominee.Rows[e.RowIndex].Cells["Country"].Value.ToString();
            txtNomineeCity.Text = dgNominee.Rows[e.RowIndex].Cells["City"].Value.ToString();
            txtNomineeRelation.Text = dgNominee.Rows[e.RowIndex].Cells["Relation"].Value.ToString();
            txtNomineePercentage.Text = dgNominee.Rows[e.RowIndex].Cells["NomineePercentage"].Value.ToString();
            Nomineeid = Convert.ToInt32(dgNominee.Rows[e.RowIndex].Cells["ID1"].Value);


            ////////// Get Nominee Image
            clsNomineeImage climg = da.GetNomineeImage(txtRegistrationNo.Text, txtClientID.Text, txtNomineeID.Text);

            if (!(climg == null || climg.Image == null))
            {
                pbNomineeImage.Image = byteArrayToImage(climg.Image);
                txtNomineePictureName.Text = climg.ImageId;
            }

            //////////// Get Nominee CNIC

            clsNomineeCNIC clsnomicnic = da.GetNomineeCNIC(txtRegistrationNo.Text, txtClientID.Text, txtNomineeID.Text);

            if (!(clsnomicnic == null || clsnomicnic.Image == null))
            {
                pbNomineeCNIC.Image = byteArrayToImage(clsnomicnic.Image);
                txtNomineeCNICName.Text = clsnomicnic.ImageId;
            }
        }
        private void PartnerClear()
        {

            cmbPartnerCountry.SelectedIndex = -1;
            pbPartnerCNIC.Image = null;         // Clear CNIC Image
            txtPartnerCNICName.Text = "";       // Clear CNIC Name
            pbPartnerImage.Image = null;        // Clear Image Image
            txtPartnerImageName.Text = "";      // Clear Imaeg Name
            txtPartnerPercentage.Text = "0";    // Clear textbox Percentage
            txtPartnerID.Text = "";
            txtPartnerName.Text = "";
            txtPartnerFatherHusband.Text = "";
            txtPartnerNIDCNIC.Text = "";
            txtPartnerCurrentAddress1.Text = "";
            txtPartnerCurrentAddress2.Text = "";
            txtPartnerCurrentAddress3.Text = "";
            cmbCountry.Text = null;
            txtPartnerCity.Text = "";
            txtPartnerRelation.Text = "";

        }
        private void installmentsPlanClear()
        {
            dtpInstallmentStart.Value = System.DateTime.Now.Date;
            cmbFrequency.SelectedIndex = -1;
            txtNumInstallments.Text = "0";
            dgInstallmentList.Rows.Clear();
        }
        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            LoadSectors();
            LoadSizeCodes();
            LoadSalesPersons();
            LoadDealers();
            LoadCustomerClasses();
            if (bEdit == true)
            {
                strNumber = ""; strPrefix = "";
                return;
            }

            if (cmbProjects.SelectedIndex == -1)
                return;

            var obj = da.GetMemberShipNoByProjectID(cmbProjects.Text);
            txtRegistrationNo.Text = obj.strPrefix + obj.strNumber;
            strNumber = obj.strNumber; strPrefix = obj.strPrefix;

            txtRegistrationNo.Enabled = false;

        }
        private void LoadSectors()
        {
            cmbBlock.Items.Clear();
            if (cmbProjects.SelectedIndex == -1)
                return;
            lstBlocks = da.GetBlocksByProjectNo(cmbProjects.Text);
            foreach (var sizecode in lstBlocks)
                cmbBlock.Items.Add(sizecode.BlockNo);

        }
        private void LoadSizeCodes()
        {
            cmbSizeCode.Items.Clear();

            lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProjects.Text);
            foreach (var sizecode in lstSizeCodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
        }
        private void LoadCustomerClasses()
        {
            string dbName = da.GetProjectDBName(cmbProjects.Text);
            var list = da.GetCustomerClasses(dbName);

            cmbCustomerClass.Items.Clear();

            foreach (var cls in list)
                cmbCustomerClass.Items.Add(cls);
        }
        private void LoadDealers()
        {
            string dbName = da.GetProjectDBName(cmbProjects.Text);
            var list = da.GetDealers(dbName);

            cmbDealer.Items.Clear();

            foreach (var cls in list)
            {
                cmbDealer.Items.Add(cls);
                cmbSubDealer.Items.Add(cls);
            }
        }
        private void LoadSalesPersons()
        {
            string dbName = da.GetProjectDBName(cmbProjects.Text);
            var list = da.GetSalesPersons(dbName);

            cmbSalesPerson.Items.Clear();

            foreach (var cls in list)
                cmbSalesPerson.Items.Add(cls);
        }

        private void btnMemberRegistrationImage_Click(object sender, EventArgs e)
        {

            if (txtRegistrationNo.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Member Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pBMemberRegistration.Image = new Bitmap(dlg.FileName);
                    pBMemberRegistration.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtPictureName.Text = txtRegistrationNo.Text + "-Image";
                }
            }
        }
        private void btnMemberShipCNIC_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select CNIC Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pBMemberCNIC.Image = new Bitmap(dlg.FileName);
                    pBMemberCNIC.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtCNICName.Text = txtRegistrationNo.Text + "-CNIC";
                }
            }
        }
        private void btnNomineeImage_Click(object sender, EventArgs e)
        {
            if (txtNomineeID.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Nominee Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbNomineeImage.Image = new Bitmap(dlg.FileName);
                    pbNomineeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtNomineePictureName.Text = txtRegistrationNo.Text + "-" + txtNomineeID.Text + "-Image";
                }
            }
        }
        private void btnNomineeCNIC_Click(object sender, EventArgs e)
        {
            if (txtNomineeID.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Nominee CNIC Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbNomineeCNIC.Image = new Bitmap(dlg.FileName);
                    pbNomineeCNIC.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtNomineeCNICName.Text = txtRegistrationNo.Text + "-" + txtNomineeID.Text + "-CNIC";
                }
            }
        }
        private void btnPicPartnetImage_Click(object sender, EventArgs e)
        {
            if (txtPartnerID.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Partner Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbPartnerImage.Image = new Bitmap(dlg.FileName);
                    pbPartnerImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtPartnerImageName.Text = txtRegistrationNo.Text + "-" + txtPartnerID.Text + "-Image";
                }
            }
        }
        private void btnPartnerCNIC_Click(object sender, EventArgs e)
        {
            if (txtPartnerID.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Partner CNIC Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbPartnerCNIC.Image = new Bitmap(dlg.FileName);
                    pbPartnerCNIC.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtPartnerCNICName.Text = txtRegistrationNo.Text + "-" + txtPartnerID.Text + "-CNIC";
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            if (txtRegistrationNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtName.Focus();
                return;
            }
            if (txtClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client Id Cannot Be Empty");
                txtClientID.Focus();
                return;
            }
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name Cannot Be Empty");
                txtName.Focus();
                return;
            }

            //if (txtCurrentAddress1.Text.Trim() + "" + txtCurrentAddress2.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Current Address Cannot Be Empty");
            //    txtCurrentAddress1.Focus();
            //    return;
            //}

            //if (cmbCountry.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Country Cannot Be Empty");
            //    cmbCountry.Focus();
            //    return;
            //}
            //if (txtCity.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("City Cannot Be Empty");
            //    txtCity.Focus();
            //    return;
            //}


            bool result;
            decimal value;
            int value2;

            //result = decimal.TryParse(txtUnitRate.Text, out value);

            //if (result == false)
            //{
            //    MessageBox.Show("UnitRate contains decimal number only.");
            //    txtUnitRate.Focus();
            //    return;
            //}
            result = int.TryParse(txtMemberRegPercentage.Text, out value2);
            if (result == false)
            {
                MessageBox.Show("Percentage contains interger value only.");
                txtMemberRegPercentage.Focus();
                return;
            }
            result = decimal.TryParse(txtTotalPrice.Text, out value);
            if (result == false)
            {
                MessageBox.Show("Total Price contains decimal number only.");
                txtTotalPrice.Focus();
                return;
            }

            result = decimal.TryParse(txtFinancialAmt.Text, out value);
            if (result == false)
            {
                MessageBox.Show("Financial Amt contains decimal number only.");
                txtFinancialAmt.Focus();
                return;
            }

            result = decimal.TryParse(txtRebatAmt.Text, out value);
            if (result == false)
            {
                MessageBox.Show("Rebat Amt contains decimal number only.");
                txtRebatAmt.Focus();
                return;
            }

            result = decimal.TryParse(txtNetRetailPrice.Text, out value);
            if (result == false)
            {
                MessageBox.Show("Net Retail Price contains decimal number only.");
                txtNetRetailPrice.Focus();
                return;
            }

            result = decimal.TryParse(txtBookingPrice.Text, out value);
            if (result == false)
            {
                MessageBox.Show("BookingPrice contains decimal number only.");
                txtBookingPrice.Focus();
                return;
            }

            info = new clsMemberRegistration();
            info.RegistrationNo = txtRegistrationNo.Text.Trim();
            info.strNumber = this.strNumber;
            info.strPrefix = this.strPrefix;
            info.ClientID = txtClientID.Text;
            info.bSoleOwner = chkSoleProprieter.Checked;
            info.strSalesRep = cmbSalesRep.Text;
            info.Name = txtName.Text;
            info.FatherOrHusbandType = cBFatherHusband.Text;
            info.FatherOrHusband = txtFatherHusband.Text;
            info.NIDOrCNIC = txtNIDCNIC.Text;
            info.Nationality = cmbNationality.Text;
            info.DOB = dTPDOB.Value;
            info.CurrentAddress1 = txtCurrentAddress1.Text.Trim();
            info.CurrentAddress2 = txtCurrentAddress2.Text.Trim();
            info.CurrentAddress3 = txtCurrentAddress3.Text.Trim();
            info.Country = cmbCountry.Text;
            info.City = txtCity.Text;
            info.PhOff = txtPh.Text;
            info.Res = txtRes.Text;
            info.Mob = txtMob.Text;
            info.Fax = txtFax.Text;
            info.EmailAddress = txtEmailAddress.Text;
            info.Plan = cmbSizeCode.Text;
            info.Booking = dTPBooking.Value.Date;
            info.Block = cmbBlock.Text;
            info.Plot = cmbUnit.Text;

            info.UnitCategory = txtUnitCategory.Text;
            info.UnitType = txtUnitType.Text;

            info.UnitRate = Convert.ToDecimal(txtPlotPrice.Text);
            info.UnitAdditionPerc = Convert.ToDecimal(txtChargesPercentage.Text);
            info.UntiAdditionalCharges = Convert.ToDecimal(txtPlotTypeCharges.Text);


            info.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            info.FinanceAmt = Convert.ToDecimal(txtFinancialAmt.Text);
            info.RebatAmt = Convert.ToDecimal(txtRebatAmt.Text);
            info.NetOrRetailPrice = Convert.ToDecimal(txtNetRetailPrice.Text);
            info.BookingPrice = Convert.ToDecimal(txtBookingPrice.Text);
            info.strProjectid = cmbProjects.Text;
            info.MembershipStatus = memberLookupCodes.New;
            info.intPercentage = Convert.ToInt32(txtMemberRegPercentage.Text);
            info.AccountNumber = txtAccountNumber.Text;
            info.AccountTitle = txtAccountTitle.Text;
            info.BankName = txtBankName.Text;
            info.CustomerNumber = txtCustomerNumber.Text;
            info.bActive = true;
            info.bTransferPending = false;
            info.bSendToGP = false;

            info.strInstallmentPlan = cmbPaymentPlan.Text;

            info.strCustomerClass = cmbCustomerClass.Text;

            info.intInstallmentCount = Convert.ToInt32(txtNumInstallments.Text);
            info.strInstallmentPlanType = cmbPlanType.Text;
            info.dateInstallmentStartDate = dtpInstallmentStart.Value.Date;

            if (cmbFrequency.Text == "Monthly")
            {
                info.intInstallmentFrequency = 1;
            }
            else if (cmbFrequency.Text == "BiMonthly")
            {
                info.intInstallmentFrequency = 2;
            }
            else if (cmbFrequency.Text == "Quaterly")
            {
                info.intInstallmentFrequency = 3;
            }
            else if (cmbFrequency.Text == "BiAnnually")
            {
                info.intInstallmentFrequency = 4;
            }
            else if (cmbFrequency.Text == "Annually")
            {
                info.intInstallmentFrequency = 5;
            }

            info.strDealer = cmbDealer.Text;
            info.strSalesRep = cmbSalesPerson.Text;
            info.decDealerPercentage = Convert.ToDecimal(txtDealerPercentage.Text);
            info.decSalesRepPercentage = Convert.ToDecimal(txtSPPercentage.Text);

            info.strSubDealer = cmbSubDealer.Text;
            info.decSubDealerPercentage = Convert.ToDecimal(txtSubDealerPercentage.Text);


            if (info.TotalPrice <= info.RebatAmt)
            {
                MessageBox.Show("Total Price is invalid. It cannot be equal or greater than rebate amount.");
                txtTotalPrice.Focus();
                return;
            }
            if (info.NetOrRetailPrice < info.BookingPrice)
            {
                MessageBox.Show("Booking Price is invalid. It must be less than or Net price.");
                txtBookingPrice.Focus();
                return;
            }


            //Saving Mameber Registration Info 
            result = da.AddRegistrationINFO(info);
            if (result == false)
            {
                MessageBox.Show("An Error Occoured.");
                return;
            }

            if (id == 0 && cmbUnit.Text != "")
            {
                result = da.UpdateUnitStatus("", cmbUnit.Text, txtRegistrationNo.Text, 3, "");
                if (result == false)
                {
                    MessageBox.Show("An Error Occoured.");
                    return;
                }

            }
            //Add GP Customer 
            //if (id == 0)
            //    result = da.AddGPCustomer(info);
            //else result = da.UpdateGPCustomer(info);

            //if (result == false)
            //{
            //    MessageBox.Show("An Error Occoured saving customer to Dynamics GP.");
            //    return;
            //}
            //Saving Mameber Images 
            clsMemberImage memberImage = new clsMemberImage();
            if (pBMemberRegistration.Image != null)
            {
                memberImage.Image = imageToByteArray(this.pBMemberRegistration.Image); //pBMemberRegistration.Image.

                result = da.AddMemberImage(new clsMemberImage()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtPictureName.Text,
                    RegistrationOrBookingNo = txtRegistrationNo.Text,
                    Image = memberImage.Image
                });
            }
            if (result == false)
            {
                MessageBox.Show("An Error Occoured during saving member picture.");
                return;
            }
            clsMemberImage memberImage1 = new clsMemberImage();
            if (pBMemberCNIC.Image != null)
            {
                memberImage1.Image = imageToByteArray(this.pBMemberCNIC.Image); //pBMemberRegistration.Image.

                result = da.AddMemberCnic(new clsMemberImage()
                {
                    ClientID = txtClientID.Text,
                    ImageId = txtCNICName.Text,
                    RegistrationOrBookingNo = txtRegistrationNo.Text,
                    Image = memberImage1.Image
                });
            }
            if (result == false)
            {
                MessageBox.Show("An Error Occoured during saving member cnic.");
                return;
            }

            if (dgOtherRecoveryList.Rows.Count > 0 && dgOtherRecoveryList.Rows[0].IsNewRow != true)
            {
                List<clsMemberRecoveryPlan> lstPlans = GetRecoveryPlan();
                var totalDueAmount = lstPlans.Where(x => x.Delete == false && x.bIncludeInTotal == true).Sum(x => x.decAmountDue);
                if (info.NetOrRetailPrice != totalDueAmount)
                {
                    MessageBox.Show("Net retail price is not equal to recovery amount.");
                    return;
                }

                if (lstPlans.Count > 0)
                {
                    //result = da.DeleteMemberInstallments(txtRegistrationNo.Text.Trim());
                    result = da.AddMemberOtherRecoveryPlan(lstPlans);
                }

                if (result == false)
                {
                    MessageBox.Show("An Error Occoured during saving payment plan.");
                    return;
                }
            }

            MessageBox.Show("Member Information saved.");
            LoadInformation();
        }

        private List<clsMemberRecoveryPlan> GetRecoveryPlan()
        {
            List<clsMemberRecoveryPlan> memberRecoveryPlan = new List<clsMemberRecoveryPlan>();
            foreach (DataGridViewRow dgr in dgInstallmentList.Rows)
            {
                if (!dgr.IsNewRow)
                {

                    var recoveryRow = new clsMemberRecoveryPlan()
                    {
                        intId = Convert.ToInt32(dgr.Cells["InstallmentID"].Value),
                        strClientID = txtClientID.Text,
                        strRegistrationNo = txtRegistrationNo.Text,
                        strRecoveryType = dgr.Cells["InstallmentRecoveryType"].Value.ToString(),
                        decAmountWaived = Convert.ToDecimal(dgr.Cells["InstallmentWaived"].Value),
                        decAmountDue = Convert.ToDecimal(dgr.Cells["InstallmentDueAmount"].Value),
                        decOutStandingAmount = Convert.ToDecimal(dgr.Cells["InstallmentOutStanding"].Value),
                        decAmountApplied = Convert.ToDecimal(dgr.Cells["InstallmentReceivedAmount"].Value),
                        intInstallmentNo = Convert.ToInt32(dgr.Cells["InstallmentNumber"].Value),
                        dateDue = GetDateFromString(dgr.Cells["InstallmentDueDate"].Value.ToString()),
                        Delete = !dgr.Visible

                    };
                    var recType = lstRecoveryTypes.Where(x => x.strCode.Trim().ToUpper() == recoveryRow.strRecoveryType.Trim().ToUpper());
                    recoveryRow.bIncludeInTotal = recType.First().bIncludeTotal;

                    if (recoveryRow.intId == 0 && recoveryRow.Delete == true)
                    { }
                    else
                        memberRecoveryPlan.Add(recoveryRow);
                }
            }
            foreach (DataGridViewRow dgr in dgOtherRecoveryList.Rows)
            {
                if (!dgr.IsNewRow)
                {
                    var recoveryRow = new clsMemberRecoveryPlan()
                    {
                        intId = Convert.ToInt32(dgr.Cells["otherId"].Value),
                        strClientID = txtClientID.Text,
                        strRegistrationNo = txtRegistrationNo.Text,
                        strRecoveryType = dgr.Cells["RecoveryType"].Value.ToString(),
                        decAmountWaived = Convert.ToDecimal(dgr.Cells["OtherWaivedAmt"].Value),
                        decAmountDue = Convert.ToDecimal(dgr.Cells["AmountDue"].Value),
                        decOutStandingAmount = Convert.ToDecimal(dgr.Cells["OutStandingOther"].Value),
                        decAmountApplied = Convert.ToDecimal(dgr.Cells["OtherReceivedAmount"].Value),
                        intInstallmentNo = Convert.ToInt32(dgr.Cells["InstallmentNo"].Value),
                        dateDue = GetDateFromString(dgr.Cells["DueDate"].Value.ToString()),
                        Delete = !dgr.Visible
                    };
                    var recType = lstRecoveryTypes.Where(x => x.strCode.Trim().ToUpper() == recoveryRow.strRecoveryType.Trim().ToUpper());
                    recoveryRow.bIncludeInTotal = recType.First().bIncludeTotal;

                    if (recoveryRow.intId == 0 && recoveryRow.Delete == true)
                    { }
                    else
                        memberRecoveryPlan.Add(recoveryRow);
                }
            }

            List<KeyValuePair<int, string>> dataSerials = new List<KeyValuePair<int, string>>();
            foreach (var row in memberRecoveryPlan)
            {
                var matches = from data in dataSerials where data.Value == row.strRecoveryType select data.Key;
                int intInstallmentNumber = 0;
                if (matches.Count() == 0)
                {
                    if (row.strRecoveryType == "BOOKING")
                    {
                        intInstallmentNumber = 0;
                        dataSerials.Add(new KeyValuePair<int, string>(0, row.strRecoveryType));
                    }
                    else
                    {
                        intInstallmentNumber = 1;
                        dataSerials.Add(new KeyValuePair<int, string>(1, row.strRecoveryType));
                    }
                }
                else
                {
                    intInstallmentNumber = matches.Max() + 1;
                    dataSerials.Add(new KeyValuePair<int, string>(intInstallmentNumber, row.strRecoveryType));
                }

                row.intInstallmentNo = intInstallmentNumber;
            }

            return memberRecoveryPlan;
        }
        private DateTime GetDateFromString(string dateString)
        {
            string monthpart = "", datepart = "", yearPart = "";
            var dates = dateString.Split(new char[] { '/' });
            if (dates.Length == 3)
            {
                monthpart = dates[1];
                datepart = dates[0];
                yearPart = dates[2];
            }
            DateTime dateDue = new DateTime(Convert.ToInt32(yearPart), Convert.ToInt32(monthpart), Convert.ToInt32(datepart));
            return dateDue;
        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            MemberRegistrationClear();
            NomineeClear();
            PartnerClear();

            dgNominee.Rows.Clear();
            dgPartner.Rows.Clear();
            dgOtherRecoveryList.Rows.Clear();
            installmentsPlanClear();
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbAttach_Click(object sender, EventArgs e)
        {
            frmAttachmentList attachments = new frmAttachmentList();
            attachments.attachmentType = AttachmentType.MemberRegistration;
            attachments.strRegistrationNo = txtRegistrationNo.Text;
            attachments.strClientID = txtClientID.Text;
            attachments.ShowDialog();
        }
        private void tsbViewAttachments_Click(object sender, EventArgs e)
        {
            frmAttachmentList attachments = new frmAttachmentList();
            attachments.attachmentType = AttachmentType.MemberRegistration;
            attachments.strRegistrationNo = txtRegistrationNo.Text;
            attachments.strClientID = txtClientID.Text;
            attachments.Show();
        }
        private void txtTotalPrice_Leave(object sender, EventArgs e)
        {
            bool result; decimal totalPrice, rebateAmount;

            result = decimal.TryParse(txtTotalPrice.Text, out totalPrice);
            txtTotalPrice.Text = totalPrice.ToString("N2");
            if (result == false)
            {
                MessageBox.Show("Please enter a valid total price.");
                txtTotalPrice.Focus();
                return;
            }
            result = decimal.TryParse(txtRebatAmt.Text, out rebateAmount);
            txtRebatAmt.Text = rebateAmount.ToString("N2");
            if (result == false)
            {
                MessageBox.Show("Please enter a valid rebate amount.");
                txtRebatAmt.Focus();
                return;
            }
            txtNetRetailPrice.Text = (totalPrice - rebateAmount).ToString("N2");
        }
        private void txtClientID_Leave(object sender, EventArgs e)
        {
            if (bEdit)
                return;
            var memberInfo = da.GetMemberInfoByClientId(txtClientID.Text);
            if (memberInfo == null || memberInfo.ClientID == null)
            {
                return;
            }
            txtClientID.Text = memberInfo.ClientID;
            txtName.Text = memberInfo.Name;
            cBFatherHusband.Text = memberInfo.FatherOrHusbandType;
            txtFatherHusband.Text = memberInfo.FatherOrHusband;
            txtNIDCNIC.Text = memberInfo.NIDOrCNIC;
            cmbNationality.Text = memberInfo.Nationality;
            dTPDOB.Value = memberInfo.DOB;
            txtCurrentAddress1.Text = memberInfo.CurrentAddress1;
            txtCurrentAddress2.Text = memberInfo.CurrentAddress2;
            txtCurrentAddress3.Text = memberInfo.CurrentAddress3;
            cmbCountry.Text = memberInfo.Country.ToString().ToUpper();
            txtCity.Text = memberInfo.City.ToString().ToUpper();
            txtPh.Text = memberInfo.PhOff;
            txtRes.Text = memberInfo.Res;
            txtMob.Text = memberInfo.Mob;
            txtFax.Text = memberInfo.Fax;
            txtEmailAddress.Text = memberInfo.EmailAddress;
            txtBankName.Text = memberInfo.BankName;
            txtAccountNumber.Text = memberInfo.AccountNumber;
            txtAccountTitle.Text = memberInfo.AccountTitle;
            txtCustomerNumber.Text = memberInfo.CustomerNumber;
        }
        private void frmMemberRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (id == 0)
                return;

            if (chkSoleProprieter.Checked == true)
                return;
            bool bFormat = false; decimal result = 0; decimal TotalPercentage = 0;

            bFormat = decimal.TryParse(txtMemberRegPercentage.Text, out result);

            if (bFormat == false)
            {
                MessageBox.Show("Client percentage is not in valid format.");
                txtMemberRegPercentage.Focus();
                e.Cancel = true;
                return;
            }

            TotalPercentage += result;
            foreach (DataGridViewRow dgr in dgPartner.Rows)
            {
                bFormat = decimal.TryParse(dgr.Cells["PartnerPercentage"].Value.ToString(), out result);
                if (bFormat == false)
                {
                    MessageBox.Show("Partner percentage is not in valid format.");
                    dgr.Selected = true;
                    e.Cancel = true;
                    return;
                }
                TotalPercentage += result;
            }
            if (TotalPercentage != 100)
            {
                var dlg = MessageBox.Show("Total Partnership Percentage is not equal to 100. Do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            TotalPercentage = 0;
            foreach (DataGridViewRow dgr in dgNominee.Rows)
            {
                bFormat = decimal.TryParse(dgr.Cells["NomineePercentage"].Value.ToString(), out result);
                if (bFormat == false)
                {
                    MessageBox.Show("Nominee percentage is not in valid format.");
                    dgr.Selected = true;
                    e.Cancel = true;
                    return;
                }
                TotalPercentage += result;
            }

            if (TotalPercentage != 100)
            {
                var dlg = MessageBox.Show("Total Nominee Percentage is not equal to 100. Do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            e.Cancel = false;
        }
        private void chkSoleProprieter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoleProprieter.Checked == true)
                txtMemberRegPercentage.Text = "100";
        }
        private void dgList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOtherRecoveryList.CurrentCell.ColumnIndex == dgOtherRecoveryList.Columns["DueDate"].Index)
            {
                if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["DueDate"].Value == null)
                    dgOtherRecoveryList.Rows[e.RowIndex].Cells["DueDate"].Value = "01/01/1900";
                DateTime dDate;
                string inputString = dgOtherRecoveryList.Rows[e.RowIndex].Cells["DueDate"].Value.ToString();

                try
                {
                    dDate = this.GetDateFromString(inputString);
                    dgOtherRecoveryList.CurrentCell.Value = dDate.ToString("dd/MM/yyyy");
                }
                catch
                {
                    dgOtherRecoveryList.CurrentCell.Value = "01/01/1900";
                }
            }
            if (dgOtherRecoveryList.CurrentCell.ColumnIndex == dgOtherRecoveryList.Columns["AmountDue"].Index)
            {
                if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value == null)
                    dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value = 0;
                string inputString = dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value.ToString();
                decimal val = Convert.ToDecimal(inputString);
                dgOtherRecoveryList.CurrentCell.Value = val.ToString("N2");
            }
        }
        private void dgOtherRecoveryList_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgOtherRecoveryList.Rows[e.RowIndex].IsNewRow)
                return;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value = 0;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["RecoveryType"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["RecoveryType"].Value = "";
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["DueDate"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["DueDate"].Value = "01/01/1900";


            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["otherId"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["otherId"].Value = 0;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["OutStandingOther"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["OutStandingOther"].Value = dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherReceivedAmount"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherReceivedAmount"].Value = 0;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherWaivedAmt"].Value == null)
                dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherWaivedAmt"].Value = 0;
            if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["RecoveryType"].Value == null)
            {
                MessageBox.Show("Please select a valid recovery type");
                e.Cancel = true;
            }
            else
            {
                if (dgOtherRecoveryList.Rows[e.RowIndex].Cells["InstallmentNo"].Value == null)
                    dgOtherRecoveryList.Rows[e.RowIndex].Cells["InstallmentNo"].Value = 1;
            }
            dgOtherRecoveryList.Rows[e.RowIndex].Cells["OutStandingOther"].Value =
                Convert.ToDecimal(dgOtherRecoveryList.Rows[e.RowIndex].Cells["AmountDue"].Value) -
                Convert.ToDecimal(dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherReceivedAmount"].Value)
                - Convert.ToDecimal(dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherWaivedAmt"].Value);
            ;

            CalculateAmounts();
        }
        private void dgList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgOtherRecoveryList.CurrentCell.ColumnIndex == dgOtherRecoveryList.Columns["AmountDue"].Index)
            {
                var textbox = ((TextBox)e.Control);
                textbox.KeyPress -= datetextBox_KeyPress;
                textbox.KeyPress -= numerictextBox_KeyPress;
                textbox.KeyPress += numerictextBox_KeyPress;
            }

            if (dgOtherRecoveryList.CurrentCell.ColumnIndex == dgOtherRecoveryList.Columns["DueDate"].Index)
            {
                var textbox = ((TextBox)e.Control);
                textbox.KeyPress -= datetextBox_KeyPress;
                textbox.KeyPress -= numerictextBox_KeyPress;
                textbox.KeyPress += datetextBox_KeyPress;
            }
        }
        private void datetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
        private void inttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

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
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (tabMain.SelectedTab == tabPage4 || tabMain.SelectedTab == tabPage5)
                {
                    MessageBox.Show("Please save membership first before working on recovery plan");
                    tabMain.SelectedTab = tabPage1;
                }
            }
        }
        private void txtBookingPrice_Leave(object sender, EventArgs e)
        {
            bool result; decimal bookingPrice;
            result = decimal.TryParse(txtBookingPrice.Text, out bookingPrice);
            txtBookingPrice.Text = bookingPrice.ToString("N2");
            if (result == false)
            {
                MessageBox.Show("Please enter a valid total booking price.");
                txtBookingPrice.Focus();
                return;
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            frmReport frm = new frmReport();
            frm.reportType = ReportType.Membership;
            frm.strRegistrationNo = txtRegistrationNo.Text;

            frm.Show();
        }

        private void cmbPlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanType.SelectedIndex == -1)
                return;
            if (cmbSizeCode.SelectedIndex == -1)
                return;
            if (cmbPlanType.Text == "Standard Plan")
            {
                var insp = da.GetInstallmentPlanByPlanCode(cmbPaymentPlan.Text);
                if (insp == null)
                    return;

                dtpInstallmentStart.Value = dTPBooking.Value.Date.AddMonths(insp.intInstallmentStartAfter);
                if (insp.intInstallmentFrequency == 1)
                    cmbFrequency.Text = "Monthly";
                else if (insp.intInstallmentFrequency == 2)
                    cmbFrequency.Text = "BiMonthly";
                else if (insp.intInstallmentFrequency == 3)
                    cmbFrequency.Text = "Quaterly";
                else if (insp.intInstallmentFrequency == 4)
                    cmbFrequency.Text = "BiAnnually";
                else if (insp.intInstallmentFrequency == 5)
                    cmbFrequency.Text = "Annually";
                txtNumInstallments.Text = insp.intNoOfInstallments.ToString();
            }
        }
        private void dgInstallmentList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["InstallmentDueDate"].Index)
            {
                if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueDate"].Value == null)
                    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueDate"].Value = "01/01/1900";
                DateTime dDate;
                string inputString = dgInstallmentList.Rows[e.RowIndex].Cells["DueDate"].Value.ToString();

                try
                {
                    dDate = this.GetDateFromString(inputString);
                    dgInstallmentList.CurrentCell.Value = dDate.ToString("dd/MM/yyyy");
                }
                catch
                {
                    dgInstallmentList.CurrentCell.Value = "01/01/1900";
                }
            }
            if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["InstallmentDueAmount"].Index)
            {
                if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value == null)
                    dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value = 0;
                string inputString = dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value.ToString();
                decimal val = Convert.ToDecimal(inputString);
                dgInstallmentList.CurrentCell.Value = val.ToString("N2");
            }
        }
        private void dgInstallmentList_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgInstallmentList.Rows[e.RowIndex].IsNewRow)
                return;
            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value = 0;
            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueDate"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueDate"].Value = "01/01/1900";


            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentID"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentID"].Value = 0;
            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value = dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value;
            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value = 0;
            if (dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value == null)
                dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value = 0;

            dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentOutStanding"].Value =
                Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentDueAmount"].Value) -
                Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value) -
                Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentWaived"].Value);

            CalculateAmounts();
        }
        private void dgInstallmentList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["InstallmentDueAmount"].Index)
            {
                var textbox = ((TextBox)e.Control);
                textbox.KeyPress -= datetextBox_KeyPress;
                textbox.KeyPress -= numerictextBox_KeyPress;
                textbox.KeyPress += numerictextBox_KeyPress;
            }

            if (dgInstallmentList.CurrentCell.ColumnIndex == dgInstallmentList.Columns["InstallmentDueDate"].Index)
            {
                var textbox = ((TextBox)e.Control);
                textbox.KeyPress -= datetextBox_KeyPress;
                textbox.KeyPress -= numerictextBox_KeyPress;
                textbox.KeyPress += datetextBox_KeyPress;
            }
        }

        private void dgOtherRecoveryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgOtherRecoveryList.Columns["DeleteOther"].Index)
            {
                if (dgOtherRecoveryList.Rows[e.RowIndex].IsNewRow == true)
                {
                    return;
                }

                if (Convert.ToDecimal(dgOtherRecoveryList.Rows[e.RowIndex].Cells["OtherReceivedAmount"].Value) > 0)
                {
                    MessageBox.Show("Cannot delete a row against which some amount has been received.");
                    return;
                }

                int id = Convert.ToInt32(dgOtherRecoveryList.Rows[e.RowIndex].Cells["otherId"].Value);
                if (id == 0)
                    dgOtherRecoveryList.Rows.RemoveAt(e.RowIndex);
                else
                {
                    dgOtherRecoveryList.Rows[e.RowIndex].Visible = false;
                    //da.DeleteMemberInstallmentRow(id);
                    //LoadMemberInstallmentPlan();
                }
            }
            CalculateAmounts();
        }

        private void dgInstallmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgInstallmentList.Columns["DeleteInstallment"].Index)
            {

                if (Convert.ToDecimal(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentReceivedAmount"].Value) > 0)
                {
                    MessageBox.Show("Cannot delete a row against which some amount has been received.");
                    return;
                }

                int id = Convert.ToInt32(dgInstallmentList.Rows[e.RowIndex].Cells["InstallmentID"].Value);
                if (id == 0)
                    dgInstallmentList.Rows.RemoveAt(e.RowIndex);
                else
                {
                    dgInstallmentList.Rows[e.RowIndex].Visible = false;
                    //da.DeleteMemberInstallmentRow(id);
                    //LoadMemberInstallmentPlan();
                }
            }
            CalculateAmounts();
        }

        private void dgOtherRecoveryList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // ToDo: insert your own column index magic number 
            if (e.ColumnIndex == dgOtherRecoveryList.Columns["DeleteOther"].Index)
            {
                e.Value = Properties.Resources.b_deltbl;
            }
        }

        private void btnUnitSelect_Click(object sender, EventArgs e)
        {
            frmUnitsLookUp lookup = new frmUnitsLookUp();
            lookup.strProject = cmbProjects.Text;
            lookup.strBlock = cmbBlock.Text;
            lookup.strSizeCode = cmbSizeCode.Text;


            if (lookup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cmbUnit.Text = lookup.strunitID;

                clsUnit unit = da.GetUnitByUnitID(cmbUnit.Text);

                if (unit == null)
                    return;
                decimal decPlotPrice = 0, decPlotCharges = 0, decPlotChargesPerc = 0;
                decPlotPrice = unit.decPrice;


                txtPlotPrice.Text = decPlotPrice.ToString("N2");

                txtUnitType.Text = unit.strUnitTypeID;
                txtUnitCategory.Text = unit.strUnitCategoryID;

                if (unit.strUnitTypeID == "GENERAL")
                    txtChargesPercentage.Text = 0.ToString("N2");
                else if (unit.strUnitTypeID == "PARK FACE" || unit.strUnitTypeID == "WIDE ROAD" || unit.strUnitTypeID == "CORNER")
                {
                    decPlotChargesPerc = 10;
                    txtChargesPercentage.Text = 10.ToString("N2");
                }
                else if (unit.strUnitTypeID == "P. F. CORNER" || unit.strUnitTypeID == "WIDE ROAD +PARK FACE" || unit.strUnitTypeID == "WD.ROAD+CORNER")
                {
                    decPlotChargesPerc = 20;
                    txtChargesPercentage.Text = 20.ToString("N2");
                }

                txtPlotPrice.Text = decPlotPrice.ToString("N2");
                decPlotCharges = decPlotPrice * decPlotChargesPerc / 100;
                txtPlotTypeCharges.Text = decPlotCharges.ToString("N2");
                txtTotalPrice.Text = (decPlotPrice + decPlotCharges).ToString("N2");

                txtTotalPrice_Leave(null, null);
            }
        }

        private void cmbSizeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaymentPlans();
        }
        private void LoadPaymentPlans()
        {
            if (cmbProjects.SelectedIndex == -1)
                return;
            if (cmbSizeCode.SelectedIndex == -1)
                return;
            cmbPaymentPlan.Items.Clear();
            var lstPaymentPlans = da.GetInstallmentPlanByProjectSizeCode(cmbSizeCode.Text, cmbProjects.Text);
            if (lstPaymentPlans != null)
                foreach (var PaymentPlan in lstPaymentPlans)
                    cmbPaymentPlan.Items.Add(PaymentPlan.strIntallmentPlanCode);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(info.bSendToGP == true || info.bitAllocated == true)
            {
                MessageBox.Show("Member cannot be deleted. It has already been sent to GP or allocation has been done.");
                return;
            }
            if (txtRegistrationNo.Text == "")
            {
                Clear();
                return;
            }
            if (info.id == 0)
            {
                Clear();
                return;
            }
            bool result = da.DeleteRegistrationINFO(txtRegistrationNo.Text);

            if(result == true)
            {
                MessageBox.Show("Deletion successful");
                Clear();
            }
            else
            {
                MessageBox.Show("Error in deletion");
            }

        }

        private void cmbPaymentPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentPlan.SelectedIndex == -1)
                return;
            if (id == 0)
            {
                var otherRecoveryPlan = da.GetOtherRecoveryPlan(cmbPaymentPlan.Text);

                foreach (var row in otherRecoveryPlan)
                {
                    if (row.strRecoveryType.Trim().ToUpper() == "BOOKING")
                    {
                        txtBookingPrice.Text = row.decAmountDue.ToString("N2");
                        break;
                    }
                }
            }
        }

        private void tsbPrintStatement_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            frmReport frm = new frmReport();
            frm.reportType = ReportType.AccountStatement;
            frm.strRegistrationNo = txtRegistrationNo.Text;

            frm.Show();
        }
    }
}