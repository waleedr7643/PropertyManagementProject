using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon
{
    public partial class frmReactivation : Form
    {
        public int id { get; set; }
        ApprovalStatus EntryApproved;
        DataAccess da = new DataAccess();
        clsMemberRegistration infoMember = new clsMemberRegistration();
        clsReactivation clsReac = new clsReactivation();

        
        public frmReactivation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This Function Loads
        /// Data in Projects combobox
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.memberlookupCode = memberLookupCodes.Reactivate;
            frm.bForProcess = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                //txtRegistrationNo.Enabled = false;
                txtProject.Text = frm.strProjectID; 
                txtRegistrationNo.Focus();
                btnSelect.Focus();
            }

           
        }
        private void ClearReord()
        {
            txtRegistrationNo.Text = "";
            txtClientID.Text = "";
            txtClientName.Text = "";
            txtSizeCode.Text = "";
            txtTotalPrice.Text = "0.0";
            txtRebatAmt.Text = "0.0";
            txtNetRetailPrice.Text = "0.0";
            txtBookingPrice.Text = "0.0";
            dTReactivationDate.Value = System.DateTime.Now.Date;
            txtProject.Text = "";            
            txtRemarks.Clear();
            chkBoxApproved.Checked = false;

        }
        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {
            //#region Member Registration Table Info
            //if (!String.IsNullOrEmpty(txtRegistrationNo.Text))
            //{
            //    info1.RegistrationNo = txtRegistrationNo.Text;
            //    info1 = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);
            //    txtRegistrationNo.Text = info1.RegistrationNo;
            //    txtClientName.Text = info1.Name;
            //    txtSizeCode.Text = info1.Plan;
            //    txtBookingDate.Text = info1.Booking.ToShortDateString();
            //    txtClientID.Text = info1.ClientID;
            //    txtRebatAmt.Text = Convert.ToString(info1.RebatAmt);
            //    txtNetRetailPrice.Text = Convert.ToString(info1.NetOrRetailPrice);
            //    txtBookingPrice.Text = Convert.ToString(info1.BookingPrice);
            //    txtBlockNo.Text = info1.Block;
            //    txtProjectNo.Text = info1.strProjectid;
            //    txtUnit.Text = info1.Plot;

            //    var res = da.GetMemberImage(txtRegistrationNo.Text, txtClientID.Text);

            //    if (!(res == null || res.Image == null))
            //        pBMemberRegistration.Image = byteArrayToImage(res.Image);

            //}
            //#endregion

            //#region Cancelltion Table Info
            //if (!string.IsNullOrEmpty(txtRegistrationNo.Text) && !string.IsNullOrEmpty(txtRegistrationNo.Text))
            //{

            //}

            //#endregion

        }
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
        }
        private void btnReactivationSave_Click(object sender, EventArgs e)
        {




        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtRegistrationNo.Enabled = true;
            id = 0;

            txtRegistrationNo.Text = "";
            txtClientName.Text = "";
            txtClientID.Text = "";
            txtSizeCode.Text = "";
            txtTotalPrice.Text = "0.00";
            txtRebatAmt.Text = "0.00";
            txtNetRetailPrice.Text = "0.00";
            txtBookingPrice.Text = "0.00";
            dTReactivationDate.Text = "";
            txtProject.Text = "";            
            txtRemarks.Text = "";
            chkBoxApproved.Checked = false;
            pBMemberRegistration.Image = null;
            pBMemberCNIC.Image = null;
            txtBookingDate.Clear();
            EntryApproved = ApprovalStatus.Pending;
            id = 0;
            /////Enabling
            btnSelect.Enabled = true;


        }
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            /*if (cmbBlock.Text == null)
                return;
            if (cmbProject.Text == null)
                return;
            if (txtRegistrationNo.Text == "")
                return;

            frmUnitsLookUp lookup = new frmUnitsLookUp();
            lookup.strProject = cmbProject.Text;
            lookup.strBlock = cmbBlock.Text;
            lookup.strSizeCode = txtSizeCode.Text;

            

            if (lookup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnit.Text = lookup.strunitID;
            }
             */
        }

        private void txtRegistrationNo_Leave(object sender, EventArgs e)
        {
            #region Member Registration Table Info
            if (!String.IsNullOrEmpty(txtRegistrationNo.Text))
            {

                infoMember = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

                if (infoMember == null)
                {
                    MessageBox.Show("Please select a valid registration no.");
                    Clear();
                    txtRegistrationNo.Focus();
                    return;
                }
                if (infoMember.intStatusCode != (int)memberLookupCodes.Cancelled)
                {
                    MessageBox.Show("Selected registration number is not cancelled. Only cancelled registration numbers can be refunded.");
                    Clear();
                    txtRegistrationNo.Focus();
                    return;
                }

                if (infoMember.intStatusCode == (int)memberLookupCodes.MarkedForAllocation ||
                    infoMember.intStatusCode == (int)memberLookupCodes.MarkedForCancellation ||
                    infoMember.intStatusCode == (int)memberLookupCodes.MarkedForReactivation ||
                    infoMember.intStatusCode == (int)memberLookupCodes.MarkedForRefund ||
                    infoMember.intStatusCode == (int)memberLookupCodes.MarkedForTransfer)
                {
                    MessageBox.Show("Selected registration number is locked.");
                    Clear();
                    txtRegistrationNo.Focus();
                    return;
                }

              
                Clear();

                txtProject.Text = infoMember.strProjectid;               
                txtClientName.Text = infoMember.Name;

                txtRegistrationNo.Text = infoMember.RegistrationNo;
                txtSizeCode.Text = infoMember.Plan;
                txtBookingDate.Text = infoMember.Booking.ToString("dd/MM/yyyy");
                txtClientID.Text = infoMember.ClientID;
                txtTotalPrice.Text = Convert.ToString(infoMember.TotalPrice);
                txtRebatAmt.Text = Convert.ToString(infoMember.RebatAmt);
                txtNetRetailPrice.Text = Convert.ToString(infoMember.NetOrRetailPrice);
                txtBookingPrice.Text = Convert.ToString(infoMember.BookingPrice);



                LoadMemberImage();

                txtProject.Text = infoMember.strProjectid;



            }
            else
            {

            }
            #endregion

            #region Allocation Table Info
            if (!string.IsNullOrEmpty(txtRegistrationNo.Text) && !string.IsNullOrEmpty(txtRegistrationNo.Text))
            {


            }
            #endregion
        }

        private void LoadMemberImage()
        {
            var res = da.GetMemberImage(txtRegistrationNo.Text, txtClientID.Text);

            if (!(res == null || res.Image == null))
                pBMemberRegistration.Image = byteArrayToImage(res.Image);

            res = da.GetMemberCnic(txtRegistrationNo.Text, txtClientID.Text);

            if (!(res == null || res.Image == null))
                pBMemberCNIC.Image = byteArrayToImage(res.Image);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {


            if (ValidateFields() == false)
                return;

            ApprovalStatus approvalStatus = ApprovalStatus.Pending;

            if (((ToolStripButton)sender).Name == "tsbSave")
                approvalStatus = ApprovalStatus.Pending;

            else if (((ToolStripButton)sender).Name == "tsbApprove")
                approvalStatus = ApprovalStatus.Approved;

            else if (((ToolStripButton)sender).Name == "tsbReject")
                approvalStatus = ApprovalStatus.Rejected;


            SaveCancellation(approvalStatus);


        }

        private void tsbClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReactivation_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            cmbApprovalStatus.Text = "Not Saved";
            if (id != 0)
            {
                txtRegistrationNo.Enabled = false;
                clsReac = da.GetReactivationById(id);
                btnSelect.Enabled = false;
                txtRegistrationNo.Text = clsReac.RegistrationOrBookingNo;
                txtClientID.Text = clsReac.ClientID;
                dTReactivationDate.Value = clsReac.ReActivationDate;
                txtRemarks.Text = clsReac.Remarks;
                txtProject.Text = clsReac.strProjectid; 
                chkBoxApproved.Checked = clsReac.Approved;

                EntryApproved = (ApprovalStatus)clsReac.ApprovalStatusCode;
                if ((ApprovalStatus)clsReac.ApprovalStatusCode == ApprovalStatus.Pending)
                    cmbApprovalStatus.Text = "Pending";
                else if ((ApprovalStatus)clsReac.ApprovalStatusCode == ApprovalStatus.Approved)
                    cmbApprovalStatus.Text = "Approved";
                else if ((ApprovalStatus)clsReac.ApprovalStatusCode == ApprovalStatus.Rejected)
                    cmbApprovalStatus.Text = "Rejected";

                var v = da.GetMemberRegistrationInfoByMembershipAndCNIC(clsReac.RegistrationOrBookingNo, clsReac.ClientID);
                txtSizeCode.Text = v.Plan;
                txtClientName.Text = v.Name;
                txtBookingDate.Text = v.Booking.ToString("dd/MM/yyy");
                txtBookingPrice.Text = v.BookingPrice.ToString("N2");
                txtNetRetailPrice.Text = v.NetOrRetailPrice.ToString("N2");
                txtRebatAmt.Text = v.RebatAmt.ToString("N2");
                txtTotalPrice.Text = v.TotalPrice.ToString("N2");
                

                LoadMemberImage();
            }
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Program._userid, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            this.tsbSave.Enabled = userRights.AllowSave;
            this.tsbApprove.Enabled = userRights.AllowPost;

        }
        private bool ValidateFields()
        {


            if (txtRegistrationNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtRegistrationNo.Focus();
                return false;
            }

            if (dTReactivationDate.Value == null)
            {
                MessageBox.Show("Date Cannot Be Empty");
                dTReactivationDate.Focus();
                return false;
            }

            if (txtClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client ID Cannot Be Empty");
                txtClientID.Focus();
                return false;
            }

            if (txtRemarks.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Remarks Cannot Be Empty");
                txtRemarks.Focus();
                return false;
            }

            return true;

        }

        private void SaveCancellation(ApprovalStatus approvalStatus)
        {

            if (EntryApproved != ApprovalStatus.Pending)
            {
                MessageBox.Show("This entry has already been Approved/Rejected");
                return;
            }

            if (id == 0 && approvalStatus != ApprovalStatus.Pending)
            {

                MessageBox.Show("This entry needs to be saved first before approval process.");
                return;
            }

            var clsReac = new clsReactivation();
            clsReac.id = id;
            clsReac.RegistrationOrBookingNo = txtRegistrationNo.Text;
            clsReac.ClientID = txtClientID.Text;
            clsReac.ReActivationDate = dTReactivationDate.Value;
            clsReac.Remarks = txtRemarks.Text.Trim();
            clsReac.Approved = chkBoxApproved.Checked;
            clsReac.strProjectid = txtProject.Text;

            if (id == 0)
            {
                clsReac.CreatedBy = Program._userid;
                clsReac.CreationDate = DateTime.Now;
                clsReac.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                clsReac.LastUpdateDate = new DateTime(1900, 1, 1);
                clsReac.LastUpdateUser = "";
                clsReac.ApprovalActionUser = "";
                clsReac.ApprovalActionDate = new DateTime(1900, 1, 1);
                clsReac.intPreviousStatusCode = infoMember.intStatusCode;
            }
            else if (id != 0)
            {
                clsReac.CreatedBy = Program._userid;
                clsReac.CreationDate = DateTime.Now;

                clsReac.ApprovalStatusCode = (int)approvalStatus;

                clsReac.LastUpdateDate = DateTime.Now;
                clsReac.LastUpdateUser = Program._userid;

                if (approvalStatus != ApprovalStatus.Pending)
                {
                    clsReac.ApprovalActionUser = Program._userid;
                    clsReac.ApprovalActionDate = DateTime.Now;
                }
                else
                {
                    clsReac.ApprovalActionUser = "";
                    clsReac.ApprovalActionDate = new DateTime(1900, 1, 1);
                }
            }

            

            bool result = da.AddReActivation(clsReac);

            if (result == false)
            {
                MessageBox.Show("An Error Occurred.");
                return;
            }

            infoMember.RegistrationNo = txtRegistrationNo.Text;
            infoMember.ClientID = txtClientID.Text;

            if (approvalStatus == ApprovalStatus.Approved)
                infoMember.intStatusCode = (int)memberLookupCodes.Reactivate;
            else if (approvalStatus == ApprovalStatus.Pending)
                infoMember.intStatusCode = (int)memberLookupCodes.MarkedForReactivation;


            result = da.UpdateMemberRegistrationAfterCancellation(infoMember);
            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }

            if (result == true)
            {
                MessageBox.Show("Reactivation successful.");
                Clear();
            }
        }

    }
}
