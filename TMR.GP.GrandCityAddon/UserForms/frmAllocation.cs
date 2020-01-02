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
    public partial class frmAllocation : Form
    {
        public int id { get; set; }
        ApprovalStatus EntryApproved;
        DataAccess da = new DataAccess();
        clsMemberRegistration infoMember = new clsMemberRegistration();
        List<clsDirector> lstDirectors = new List<clsDirector>();
        //int statusCode = 0;

        public frmAllocation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function Loads information
        /// against RegNo From Member Registration
        /// </summary>
        private void LoadInformation()
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            infoMember.RegistrationNo = txtRegistrationNo.Text;
            infoMember = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (infoMember == null)
            {
                MessageBox.Show("Please select a valid Registration Number.");
                txtRegistrationNo.Text = "";
                return;
            }


            txtRegistrationNo.Text = infoMember.RegistrationNo;
            dTPBooking.Value = infoMember.Booking;
            txtRebatAmt.Text = Convert.ToString(infoMember.RebatAmt);
            txtNetRetailPrice.Text = Convert.ToString(infoMember.NetOrRetailPrice);
            txtBookingPrice.Text = Convert.ToString(infoMember.BookingPrice);

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
        private void Allocation_Load(object sender, EventArgs e)
        {
            SetUserSecurity();

            LoadFunction();
            if (id != 0)
            {
                var infoAloc = da.GetAllocationByID(id);
                txtRegistrationNo.Enabled = false;
                btnSelect.Enabled = false;
                txtRegistrationNo.Text = infoAloc.RegistrationOrBookingNo;
                txtClientID.Text = infoAloc.strClientID;
                cmbProject.Text = infoAloc.strProjectid;
                cmbBlock.Text = infoAloc.strBlock;
                dTAllocationDate.Value = infoAloc.dtAllocationDate;
                txtUnit.Text = infoAloc.strUnitID;
                txtRemarks.Text = infoAloc.strRemarks;
                chkBoxApproved.Checked = infoAloc.bitApprove;
                cmbDirector.Text = infoAloc.strDirector;

                EntryApproved = (ApprovalStatus)infoAloc.ApprovalStatusCode;
                if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Pending)
                    cmbApprovalStatus.Text = "Pending";
                else if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Approved)
                    cmbApprovalStatus.Text = "Approved";
                else if ((ApprovalStatus)infoAloc.ApprovalStatusCode == ApprovalStatus.Rejected)
                    cmbApprovalStatus.Text = "Rejected";

                var v = da.GetMemberRegistrationInfoByMembershipAndCNIC(infoAloc.RegistrationOrBookingNo, infoAloc.strClientID);

                txtSizeCode.Text = v.Plan;
                txtClientName.Text = v.Name;
                txtBookingPrice.Text = v.BookingPrice.ToString("N2");
                txtTotalPrice.Text = v.TotalPrice.ToString("N2");
                txtRebatAmt.Text = v.RebatAmt.ToString("N2");
                txtNetRetailPrice.Text = v.NetOrRetailPrice.ToString("N2");
                LoadMemberImage();
            }
        }

        /// <summary>
        /// This Function Loads
        /// Data in Projects combobox
        /// </summary>
        private void LoadFunction()
        {
            cmbApprovalStatus.Text = "Not Saved";

            var projects = da.GetAllProjectsInfo();

            foreach (var project in projects)
                cmbProject.Items.Add(project.strProjectid);

            lstDirectors = da.GetAllDirectors();
            foreach (var director in lstDirectors)
                cmbDirector.Items.Add(director.strName);
        }

        private void cmbRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {

            infoMember.RegistrationNo = txtRegistrationNo.Text;
            infoMember = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);
            txtRegistrationNo.Text = infoMember.RegistrationNo;
            dTPBooking.Value = infoMember.Booking;
            txtTotalPrice.Text = Convert.ToString(infoMember.TotalPrice);
            txtRebatAmt.Text = Convert.ToString(infoMember.RebatAmt);
            txtNetRetailPrice.Text = Convert.ToString(infoMember.NetOrRetailPrice);
            txtBookingPrice.Text = Convert.ToString(infoMember.BookingPrice);
            string strMemCurrentStatus = infoMember.strStatus;

        }

        private void btnAllocationSave_Click(object sender, EventArgs e)
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

            SaveAllocation(approvalStatus);
        }

        private void SaveAllocation(ApprovalStatus approvalStatus)
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

            var infoAloc = new clsAllocation();

            infoAloc.id = this.id;
            infoAloc.strProjectid = cmbProject.Text;
            infoAloc.strBlock = cmbBlock.Text;
            infoAloc.dtAllocationDate = dTAllocationDate.Value;
            infoAloc.RegistrationOrBookingNo = txtRegistrationNo.Text;
            infoAloc.strUnitID = txtUnit.Text;
            infoAloc.strClientID = txtClientID.Text;
            infoAloc.bitApprove = chkBoxApproved.Checked;
            infoAloc.strDirector = cmbDirector.Text;
            infoAloc.strRemarks = txtRemarks.Text;

            if (id == 0)
            {
                infoAloc.CreatedBy = Program._userid;
                infoAloc.CreationDate = DateTime.Now;
                infoAloc.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                infoAloc.LastUpdateDate = new DateTime(1900, 1, 1);
                infoAloc.LastUpdateUser = "";
                infoAloc.ApprovalActionUser = "";
                infoAloc.ApprovalActionDate = new DateTime(1900, 1, 1);
                infoAloc.intPreviousStatusCode = infoMember.intStatusCode;
            }
            else if (id != 0)
            {
                infoAloc.CreatedBy = Program._userid;
                infoAloc.CreationDate = DateTime.Now;

                infoAloc.LastUpdateDate = DateTime.Now;
                infoAloc.LastUpdateUser = Program._userid;



                infoAloc.ApprovalStatusCode = (int)approvalStatus;

                if (approvalStatus != ApprovalStatus.Pending)
                {
                    infoAloc.ApprovalActionUser = Program._userid; ;
                    infoAloc.ApprovalActionDate = DateTime.Now;
                }
                else
                {
                    infoAloc.ApprovalActionUser = "";
                    infoAloc.ApprovalActionDate = new DateTime(1900, 1, 1);

                }
            }



            bool result = da.AddAllocationINFO(infoAloc);

            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }

            infoMember.RegistrationNo = txtRegistrationNo.Text;
            infoMember.ClientID = txtClientID.Text;
            infoMember.strProjectid = cmbProject.Text;
            infoMember.Block = cmbBlock.Text;
            infoMember.Plan = txtSizeCode.Text;
            infoMember.Plot = txtUnit.Text;
            infoMember.bitAllocated = true;



            // if (this.chkBoxApproved.Checked == true)
            if (approvalStatus == ApprovalStatus.Approved)
                infoMember.intStatusCode = (int)memberLookupCodes.Allocated;
            else if (approvalStatus == ApprovalStatus.Pending)
                infoMember.intStatusCode = (int)memberLookupCodes.MarkedForAllocation;

            infoMember.strDirectorName = cmbDirector.Text;

            result = da.UpdateMemberRegistrationAfterAllocation(infoMember);

            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }

            #region    //////////////////// Unit Status Unit

            if (approvalStatus == ApprovalStatus.Approved)
            {
                result = da.UpdateUnitStatus("Allocated", txtUnit.Text, txtRegistrationNo.Text, (int)unitLookupCodes.Allocated);
            }
            else if (approvalStatus == ApprovalStatus.Pending)
                result = da.UpdateUnitStatus("Allocated", txtUnit.Text, txtRegistrationNo.Text, (int)unitLookupCodes.MarkedForAllocation);

            if (result == false)
            {
                MessageBox.Show("An Error Occoured While Update Process");
                return;
            }

            if (result == true)
            {
                MessageBox.Show("Allocation successful.");
            }
            #endregion


            Clear();
        }

        private bool ValidateFields()
        {

            if (txtRegistrationNo.Text.Trim() == "")
            {
                MessageBox.Show("Please select a valid member registration No.");
                cmbProject.Focus();
                return false;
            }
            if (txtClientID.Text.Trim() == "")
            {
                MessageBox.Show("Please select a valid Client id.");
                cmbProject.Focus();
                return false;
            }

            if (cmbProject.Text == "")
            {
                MessageBox.Show("Please select a valid Project No.");
                cmbProject.Focus();
                return false;
            }
            if (cmbBlock.Text == "")
            {
                MessageBox.Show("Please select a valid Block No.");
                cmbBlock.Focus();
                return false;
            }
            return true;
        }

        private void Clear()
        {
            txtRegistrationNo.Enabled = true;
            txtClientName.Text = "";
            id = 0;
            txtRegistrationNo.Text = "";
            txtRemarks.Clear();
            txtClientID.Text = "";
            txtSizeCode.Text = "";
            txtTotalPrice.Text = "0.00";
            txtRebatAmt.Text = "0.00";
            txtNetRetailPrice.Text = "0.00";
            txtBookingPrice.Text = "0.00";
            dTAllocationDate.Value = System.DateTime.Now.Date;
            cmbProject.Text = "";
            cmbBlock.Text = "";
            txtUnit.Text = "";
            chkBoxApproved.Checked = false;
            pBMemberRegistration.Image = null;
            pBMemberCNIC.Image = null;
            EntryApproved = ApprovalStatus.Pending;
            cmbApprovalStatus.Text = "Not Saved";

        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            var blocks = da.GetBlocksByProjectNo(cmbProject.Text);
            foreach (var block in blocks)
                cmbBlock.Items.Add(block.BlockNo);
        }
        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            if (cmbBlock.SelectedIndex == -1)
            {
                cmbBlock.Focus();
                return;
            }
            if (cmbProject.SelectedIndex == -1)
            {
                cmbProject.Focus();
                return;
            }

            if (txtRegistrationNo.Text == "")
            {
                txtRegistrationNo.Focus();
                return;
            }


            frmUnitsLookUp lookup = new frmUnitsLookUp();
            lookup.strProject = cmbProject.Text;
            lookup.strBlock = cmbBlock.Text;
            lookup.strSizeCode = txtSizeCode.Text;

            if (lookup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnit.Text = lookup.strunitID;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.memberlookupCode = memberLookupCodes.Unallocated;
            frm.bForProcess = true;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                
                txtRegistrationNo.Focus();
                

                btnSelect.Focus();
            }
          
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

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
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

                if (infoMember.bitAllocated == true)
                {
                    MessageBox.Show("Selected registration number is already allocated.");
                    Clear();
                    txtRegistrationNo.Focus();
                    return;
                }
                if (infoMember.intStatusCode == (int)memberLookupCodes.Cancelled)
                {
                    MessageBox.Show("Selected registration number is cancelled.");
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

                txtRegistrationNo.Text = infoMember.RegistrationNo;
                txtClientName.Text = infoMember.Name;
                txtSizeCode.Text = infoMember.Plan;
                dTPBooking.Value = infoMember.Booking;
                txtClientID.Text = infoMember.ClientID;
                txtRebatAmt.Text = infoMember.RebatAmt.ToString("N2");
                txtNetRetailPrice.Text = infoMember.NetOrRetailPrice.ToString("N2"); ;
                txtBookingPrice.Text = infoMember.BookingPrice.ToString("N2"); ;
                txtTotalPrice.Text = infoMember.TotalPrice.ToString("N2");

                LoadMemberImage();
                cmbProject.Text = infoMember.strProjectid;
            }
            else
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




    }
}
