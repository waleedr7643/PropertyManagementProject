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
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{
    public partial class frmCancellation : Form
    {
        public int id { get; set; }
        ApprovalStatus EntryApproved;
        DataAccess da = new DataAccess();
        clsMemberRegistration infoMember = new clsMemberRegistration();
        clsCancellation clsCan = new clsCancellation();
        
        //frmMemberLookup frm = new frmMemberLookup();
        //List<clsProjects> projects = new List<clsProjects>();
        //List<clsBlock> blocks = new List<clsBlock>();
        public frmCancellation()
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
            frm.memberlookupCode = memberLookupCodes.Cancelled;
            frm.bForProcess = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
               // txtRegistrationNo.Enabled = false;
                txtUnit.Text = frm.strPlot;
                txtProjectNo.Text = frm.strProjectID;
                txtBlockNo.Text = frm.strBlock;
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
            dTCancellationDate.Value = System.DateTime.Now.Date;
            txtProjectNo.Text = "";
            txtBlockNo.Text = "";
            txtUnit.Text = "";
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
        private void btnCancellationSave_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (txtRegistrationNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtRegistrationNo.Focus();
                return;
            }

            if (dTCancellationDate.Value == null)
            {
                MessageBox.Show("Date Cannot Be Empty");
                dTCancellationDate.Focus();
                return;
            }

            if (txtClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Client ID Cannot Be Empty");
                txtClientID.Focus();
                return;
            }

            if (txtRemarks.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Remarks Cannot Be Empty");
                txtRemarks.Focus();
                return;
            }

            clsCan.RegistrationOrBookingNo = txtRegistrationNo.Text;
            clsCan.ClientID = txtClientID.Text;
            clsCan.CancellationDate = dTCancellationDate.Value;
            clsCan.Remarks = txtRemarks.Text.Trim();
            clsCan.Approved = chkBoxApproved.Checked;
            result = da.AddCancellationInfo(clsCan);

            if (result == false)
            {
                MessageBox.Show("An Error Occurred.");
                return;
            }

            result = da.UpdateMemberRegistrationAfterCancellation(infoMember);

            if (result == false)
            {
                MessageBox.Show("An Error Occurred.");
                return;
            }

            if (infoMember.Plot != "")
            {

                result = da.UpdateUnitStatus("Marked for Cancellation", infoMember.Plot, txtRegistrationNo.Text, (int)unitLookupCodes.Available);
                if (result == false)
                {
                    MessageBox.Show("An Error Occurred.");
                    return;
                }
            }

            if (result == true)
            {
                MessageBox.Show("Cancellation successful.");
                Clear();
            }



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
            dTCancellationDate.Text = "";
            txtProjectNo.Text = "";
            txtBlockNo.Text = "";
            txtUnit.Text = "";
            txtRemarks.Text = "";
            chkBoxApproved.Checked = false;
            pBMemberRegistration.Image = null;
            pBMemberCNIC.Image = null;
            id = 0;
            EntryApproved = ApprovalStatus.Pending;
            cmbApprovalStatus.Text = "Not Saved";
            txtBookingDate.Clear();
           /////Enabling
            btnSelect.Enabled = true;


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
                if (infoMember.intStatusCode == (int)memberLookupCodes.Cancelled)
                {
                    MessageBox.Show("Selected registration number is already cancelled.");
                    Clear();
                    txtRegistrationNo.Focus();
                    return;
                }
                if (infoMember.intStatusCode == (int)memberLookupCodes.Refunded)
                {
                    MessageBox.Show("Selected registration number is already refunded.");
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

                //info1.RegistrationNo = txtRegistrationNo.Text;

                Clear();

                txtProjectNo.Text = infoMember.strProjectid;
                txtBlockNo.Text = infoMember.Block;
                txtUnit.Text = infoMember.Plot;
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

                txtProjectNo.Text = infoMember.strProjectid;



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
            
            var clsCan = new clsCancellation();
            clsCan.id = id;

            clsCan.RegistrationOrBookingNo = txtRegistrationNo.Text;
            clsCan.ClientID = txtClientID.Text;
            clsCan.CancellationDate = dTCancellationDate.Value;
            clsCan.Remarks = txtRemarks.Text.Trim();
            clsCan.strProjectid = txtProjectNo.Text;
            clsCan.strBlock = txtBlockNo.Text;
            clsCan.strUnitID = txtUnit.Text;
            clsCan.Approved = chkBoxApproved.Checked;


            if (id == 0)
            {
                clsCan.CreatedBy = Microsoft.Dexterity.Applications.Dynamics.Globals.UserId;
                clsCan.CreationDate = DateTime.Now;
                clsCan.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                clsCan.LastUpdateDate = new DateTime(1900, 1, 1);
                clsCan.LastUpdateUser = "";
                clsCan.ApprovalActionUser = "";
                clsCan.ApprovalActionDate = new DateTime(1900, 1, 1);
                clsCan.intPreviousStatusCode = infoMember.intStatusCode;
            }
            else if (id != 0)
            {
                clsCan.CreatedBy = Microsoft.Dexterity.Applications.Dynamics.Globals.UserId;
                clsCan.CreationDate = DateTime.Now;

                clsCan.LastUpdateDate = DateTime.Now;
                clsCan.LastUpdateUser = Microsoft.Dexterity.Applications.Dynamics.Globals.UserId;

                clsCan.ApprovalStatusCode = (int)approvalStatus;

                if (approvalStatus != ApprovalStatus.Pending)
                {
                    clsCan.ApprovalActionUser = Microsoft.Dexterity.Applications.Dynamics.Globals.UserId; 
                    clsCan.ApprovalActionDate = DateTime.Now;
                }
                else
                {
                    clsCan.ApprovalActionUser = "";
                    clsCan.ApprovalActionDate = new DateTime(1900, 1, 1);
                }
            }

            

            bool result = da.AddCancellationInfo(clsCan);

            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }


            infoMember.RegistrationNo = txtRegistrationNo.Text;
            infoMember.ClientID = txtClientID.Text;
            
            if (approvalStatus == ApprovalStatus.Approved)
                infoMember.intStatusCode = (int)memberLookupCodes.Cancelled;
            else if (approvalStatus == ApprovalStatus.Pending)
                infoMember.intStatusCode = (int)memberLookupCodes.MarkedForCancellation;
            result = da.UpdateMemberRegistrationAfterCancellation(infoMember);
            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }
            if (txtUnit.Text != "" && approvalStatus == ApprovalStatus.Approved) 
            {
                result = da.UpdateUnitStatus("Marked for Cancellation", txtUnit.Text, txtRegistrationNo.Text, (int)unitLookupCodes.Available);
                if (result == false)
                {
                    MessageBox.Show("An Error Occurred.");
                    return;
                }
            }

            if (result == true)
            {
                MessageBox.Show("Cancellation successful.");
                Clear();
            }
            
        }

        private bool ValidateFields()
        {


            if (txtRegistrationNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtRegistrationNo.Focus();
                return false;
            }

            if (dTCancellationDate.Value == null)
            {
                MessageBox.Show("Date Cannot Be Empty");
                dTCancellationDate.Focus();
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

        private void tsbClear_Click_1(object sender, EventArgs e)
        {

            Clear();
        }

        private void tsbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCancellation_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            cmbApprovalStatus.Text = "Not Saved";
            if (id != 0)
            {
                var infoAloc = da.GetCancellationById(id);
                txtRegistrationNo.Enabled = false;
                btnSelect.Enabled = false;
                clsCan = da.GetCancellationById(id);
                txtRegistrationNo.Text = clsCan.RegistrationOrBookingNo;
                txtClientID.Text = clsCan.ClientID;
                dTCancellationDate.Value = clsCan.CancellationDate.Date;
                chkBoxApproved.Checked = clsCan.Approved;
                txtRemarks.Text = clsCan.Remarks;
                txtBlockNo.Text = clsCan.strBlock;
                txtProjectNo.Text = clsCan.strProjectid;
                txtUnit.Text = clsCan.strUnitID;
               
                EntryApproved = (ApprovalStatus)clsCan.ApprovalStatusCode;

                if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Pending)
                    cmbApprovalStatus.Text = "Pending";
                else if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Approved)
                    cmbApprovalStatus.Text = "Approved";
                else if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Rejected)
                    cmbApprovalStatus.Text = "Rejected";

                var v = da.GetMemberRegistrationInfoByMembershipAndCNIC(clsCan.RegistrationOrBookingNo, clsCan.ClientID);
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
            var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            this.tsbSave.Enabled = userRights.AllowSave;
            this.tsbApprove.Enabled = userRights.AllowPost;

        }

       

    }
}
