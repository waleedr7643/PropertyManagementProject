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
    public partial class frmTransfer : Form
    {
        public int id { get; set; }
        ApprovalStatus EntryApproved = ApprovalStatus.Pending;
        DataAccess da = new DataAccess();
        clsMemberRegistration infoMember = new clsMemberRegistration();
        clsTransfer info = new clsTransfer();
        bool bEdit;
        //List<clsSizeCodes> lstSizeCodes;
        //List<clsProjects> lstProject;
        public frmTransfer()
        {
            InitializeComponent();
        }
        private void frmTransfer_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            clsTransferHistory clsTrn = new clsTransferHistory();
            cmbApprovalStatus.Text = "Not Saved";
            if (id != 0)
            {
                bEdit = true;
                clsTrn = da.GetTransferHistoryById(id);

                //Transfer From
                var v = da.GetMemberRegistrationInfoByMembershipAndCNIC(clsTrn.strRegistrationNo, clsTrn.strTransferFromID);
                /////Disabling
                btnSelect.Enabled = false;
                txtClientID.Text = v.ClientID;
                txtName.Text = v.Name;
                cBFatherHusband.Text = v.FatherOrHusbandType;
                txtFatherHusband.Text = v.FatherOrHusband;
                txtNIDCNIC.Text = v.NIDOrCNIC;
                cmbNationality.Text = v.Nationality;
                dTPDOB.Value = v.DOB;
                txtCurrentAddress1.Text = v.CurrentAddress1;
                txtCurrentAddress2.Text = v.CurrentAddress2;
                txtCurrentAddress3.Text = v.CurrentAddress3;
                cmbCountry.Text = v.Country.ToString().ToUpper();
                txtCity.Text = v.City.ToString().ToUpper();
                txtPh.Text = v.PhOff;
                txtRes.Text = v.Res;
                txtMob.Text = v.Mob;
                txtFax.Text = v.Fax;
                txtEmailAddress.Text = v.EmailAddress;


                // Transfer TO
                txtTransferID.Text = clsTrn.strTransferToID;
                txtTransferName.Text = clsTrn.strName;
                cmbTransferFatherHusband.Text = clsTrn.strFatherOrHusbandType;
                txtTransferFatherHusband.Text = clsTrn.strFatherOrHusband;
                cmbTransferNationality.Text = clsTrn.strNationality;
                dTPTransferDOB.Value = clsTrn.dtDOB;
                txtTransferCurrentAddress1.Text = clsTrn.strCurrentAddress1;
                txtTransferCurrentAddress2.Text = clsTrn.strCurrentAddress2;
                txtTransferCurrentAddress3.Text = clsTrn.strCurrentAddress3;
                cmbTransferCountry.Text = clsTrn.strCountry.ToString().ToUpper();
                txtTransferCity.Text = clsTrn.strCity.ToString().ToUpper();
                txtTransferPh.Text = clsTrn.strPhOff;
                txtTransferRes.Text = clsTrn.strRes;
                txtTransferMob.Text = clsTrn.strMob;
                txtTransferEmailAddress.Text = clsTrn.strEmailAddress;
                txtRegistration.Text = clsTrn.strRegistrationNo;

                EntryApproved = (ApprovalStatus)clsTrn.ApprovalStatusCode;
                if ((ApprovalStatus)clsTrn.ApprovalStatusCode == ApprovalStatus.Pending)
                    cmbApprovalStatus.Text = "Pending";
                else if ((ApprovalStatus)clsTrn.ApprovalStatusCode == ApprovalStatus.Approved)
                    cmbApprovalStatus.Text = "Approved";
                else if ((ApprovalStatus)clsTrn.ApprovalStatusCode == ApprovalStatus.Rejected)
                    cmbApprovalStatus.Text = "Rejected";

                txtBlock.Text = v.Block;
                txtPlot.Text = v.Plot;
                txtProject.Text = v.strProjectid;
                txtUnitID.Text = v.Plot;

              
               
                LoadTransferImage();
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

        private void LoadMemberImage()
        {
            var res = da.GetMemberImage(txtRegistration.Text, txtClientID.Text);

            if (!(res == null || res.Image == null))
                pBMemberRegistration.Image = byteArrayToImage(res.Image);
            var res1 = da.GetMemberCnic(txtRegistration.Text, txtClientID.Text);

            if (!(res1 == null || res1.Image == null))
                pBMemberCNIC.Image = byteArrayToImage(res1.Image);
        }
        private void LoadTransferImage()
        {
            var res = da.GetTransferImage(id);

            if (!(res == null || res.Image == null))
            {
                pbTransferToImage.Image = byteArrayToImage(res.Image);
                txtPictureName.Text = res.ImageId;
            }

            var res1 = da.GetTransferCNIC(id);

            if (!(res1 == null || res1.Image == null))
            {
                pbTransferToCNIC.Image = byteArrayToImage(res1.Image);
                txtCNICName.Text = res1.ImageId;
            }

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.bForProcess = true;
            frm.memberlookupCode = memberLookupCodes.Transferred;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistration.Text = frm.strMemberShipID;
                txtRegistration.Focus();
                btnSelect.Focus();
            }

        }
        private void LoadInformation()
        {
            if (id != 0)
                return;
            if (txtRegistration.Text.Trim() == "")
                return;

            infoMember = da.GetMemberRegistrationInfo(txtRegistration.Text);

            if (infoMember == null)
            {
                MessageBox.Show("Please select a valid registration no.");
                Clear();
                txtRegistration.Focus();
                return;
            }
            if (infoMember.intStatusCode == (int)memberLookupCodes.Cancelled)
            {
                MessageBox.Show("Selected registration number is cancelled.");
                Clear();
                txtRegistration.Focus();
                return;
            }
            if (infoMember.intStatusCode == (int)memberLookupCodes.Refunded)
            {
                MessageBox.Show("Selected registration number is refunded.");
                Clear();
                txtRegistration.Focus();
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
                txtRegistration.Focus();
                return;
            }


            infoMember.RegistrationNo = txtRegistration.Text;
            infoMember = da.GetMemberRegistrationInfo(txtRegistration.Text);
            txtRegistration.Text = infoMember.RegistrationNo;
            txtClientID.Text = infoMember.ClientID;
            txtUnitID.Text = infoMember.Plot;
            txtName.Text = infoMember.Name;
            cBFatherHusband.Text = infoMember.FatherOrHusbandType;
            txtFatherHusband.Text = infoMember.FatherOrHusband;
            txtNIDCNIC.Text = infoMember.NIDOrCNIC;
            cmbNationality.Text = infoMember.Nationality;
            dTPDOB.Value = infoMember.DOB;
            txtCurrentAddress1.Text = infoMember.CurrentAddress1;
            txtCurrentAddress2.Text = infoMember.CurrentAddress2;
            txtCurrentAddress3.Text = infoMember.CurrentAddress3;
            cmbCountry.Text = infoMember.Country.ToString().ToUpper();
            txtCity.Text = infoMember.City.ToString().ToUpper();
            txtPh.Text = infoMember.PhOff;
            txtRes.Text = infoMember.Res;
            txtMob.Text = infoMember.Mob;
            txtFax.Text = infoMember.Fax;
            txtEmailAddress.Text = infoMember.EmailAddress;
            txtProject.Text = infoMember.strProjectid;
            txtBlock.Text = infoMember.Block;
            txtPlot.Text = infoMember.Plot;

            LoadMemberImages();

        }
        private void LoadTransferForm()
        {
            if (txtRegistration.Text.Trim() == "")
                return;

            info = da.GetTransferInfo(txtRegistration.Text);

            txtRegistration.Text = info.RegistrationOrBookingNo;
            txtTransferID.Text = info.TransferID;
            txtTransferName.Text = info.Name;
            cmbTransferFatherHusband.Text = info.FatherOrHusbandType;
            txtTransferFatherHusband.Text = info.FatherOrHusband;
            cmbTransferNationality.Text = info.Nationality;
            dTPTransferDOB.Value = info.DOB;
            txtTransferCurrentAddress1.Text = info.CurrentAddress1;
            txtTransferCurrentAddress2.Text = info.CurrentAddress2;
            txtTransferCurrentAddress3.Text = info.CurrentAddress3;
            cmbTransferCountry.Text = info.Country.ToString().ToUpper();
            txtTransferCity.Text = info.City.ToString().ToUpper();
            txtTransferPh.Text = info.PhOff;
            txtTransferRes.Text = info.Res;
            txtTransferMob.Text = info.Mob;
            txtTransferEmailAddress.Text = info.EmailAddress;
        }
        private void txtRegistrationNo_Leave(object sender, EventArgs e)
        {
            LoadInformation();
        }
        private void Clear()
        {
            id = 0;

            cmbApprovalStatus.Text = "Not Saved";
            txtRegistration.Text = "";
            txtProject.Text = "";
            txtBlock.Text = "";
            txtPlot.Text = "";

            txtClientID.Text = "";
            txtName.Text = "";
            cBFatherHusband.Text = "";
            txtFatherHusband.Text = "";
            txtNIDCNIC.Text = "";
            cmbNationality.Text = "";
            txtCurrentAddress1.Text = "";
            txtCurrentAddress2.Text = "";
            txtCurrentAddress3.Text = "";
            cmbCountry.Text = "";
            txtCity.Text = "";
            txtEmailAddress.Text = "";
            txtMob.Text = "";
            txtPh.Text = "";
            txtRes.Text = "";
            txtFax.Text = "";
            txtTransferID.Text = "";
            txtTransferName.Text = "";
            cmbTransferFatherHusband.Text = null;
            txtTransferFatherHusband.Text = "";
            cmbTransferNationality.Text = null;
            dTPTransferDOB.Text = "";
            txtTransferCurrentAddress1.Text = "";
            txtTransferCurrentAddress2.Text = "";
            txtTransferCurrentAddress3.Text = "";
            cmbTransferCountry.Text = null;
            txtTransferCity.Text = "";
            txtTransferPh.Text = "";
            txtTransferRes.Text = "";
            txtTransferMob.Text = "";
            txtTransferEmailAddress.Text = "";
            txtPictureName.Text = "";
            txtTransferEmailAddress.Text = "";


            pbTransferToImage.Image = null;
            txtPictureName.Text = "";

            pbTransferToCNIC.Image = null;
            txtCNICName.Text = "";

            pBMemberRegistration.Image = null;
            pBMemberCNIC.Image = null;

            infoMember = null;
            EntryApproved = ApprovalStatus.Pending;

            /////Enabling
            btnSelect.Enabled = true;

        }
        private void txtRegistration_TextChanged(object sender, EventArgs e)
        {
            #region Member Registration Table Info

            #endregion

        }
        private void LoadMemberImages()
        {
            if (!String.IsNullOrEmpty(txtRegistration.Text))
            {
                infoMember.RegistrationNo = txtRegistration.Text;
                infoMember = da.GetMemberRegistrationInfo(txtRegistration.Text);
                txtRegistration.Text = infoMember.RegistrationNo;
                txtClientID.Text = infoMember.ClientID;
                var res = da.GetMemberImage(txtRegistration.Text, txtClientID.Text);
                if (!(res == null || res.Image == null))
                    pBMemberRegistration.Image = byteArrayToImage(res.Image);

                res = da.GetMemberCnic(txtRegistration.Text, txtClientID.Text);
                if (!(res == null || res.Image == null))
                    pBMemberCNIC.Image = byteArrayToImage(res.Image);
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
        private bool ValidateFields()
        {
            if (txtRegistration.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Registration Cannot Be Empty");
                txtTransferName.Focus();
                return false;
            }
            if (txtTransferID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ClientId Cannot Be Empty");
                txtClientID.Focus();
                return false;
            }
            if (txtTransferName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name Cannot Be Empty");
                txtTransferName.Focus();
                return false;
            }

            if (txtTransferCurrentAddress1.Text.Trim() + "" + txtTransferCurrentAddress2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("CurrentAddress Cannot Be Empty");
                txtTransferCurrentAddress1.Focus();
                return false;
            }

            if (cmbCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Country Cannot Be Empty");
                cmbCountry.Focus();
                return false;
            }
            if (txtTransferCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("City Cannot Be Empty");
                txtTransferCity.Focus();
                return false;
            }
            return true;
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

            SaveTransfer(approvalStatus);

        }

        private void SaveTransfer(ApprovalStatus approvalStatus)
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
            bool result;

            var info1 = new clsTransferHistory();
            info1.intID = this.id;
            info1.strRegistrationNo = txtRegistration.Text.Trim();
            info1.strTransferFromID = txtClientID.Text;
            info1.strTransferToID = txtTransferID.Text;
            info1.dtTransferDate = dtptransferDate.Value;
            info1.strName = txtTransferName.Text;
            info1.strFatherOrHusbandType = cmbTransferFatherHusband.Text;
            info1.strFatherOrHusband = txtTransferFatherHusband.Text;
            info1.strNIDOrCNIC = txtNIDCNIC.Text;
            info1.strNationality = cmbTransferNationality.Text;
            info1.dtDOB = dTPTransferDOB.Value;
            info1.strCurrentAddress1 = txtTransferCurrentAddress1.Text.Trim();
            info1.strCurrentAddress2 = txtTransferCurrentAddress2.Text.Trim();
            info1.strCurrentAddress3 = txtTransferCurrentAddress3.Text.Trim();
            info1.strCountry = cmbTransferCountry.Text;
            info1.strCity = txtTransferCity.Text;
            info1.strPhOff = txtTransferPh.Text;
            info1.strRes = txtTransferRes.Text;
            info1.strMob = txtTransferMob.Text;
            info1.strFax = "";
            info1.strEmailAddress = txtTransferEmailAddress.Text;


            /////////////


            if (id == 0)
            {
                info1.CreatedBy = Program._userid;
                info1.CreationDate = DateTime.Now;
                info1.ApprovalStatusCode = (int)ApprovalStatus.Pending;
                info1.LastUpdateDate = new DateTime(1900, 1, 1);
                info1.LastUpdateUser = "";
                info1.ApprovalActionUser = "";
                info1.ApprovalActionDate = new DateTime(1900, 1, 1);

                info1.intPreviousStatusCode = infoMember.intStatusCode;
            }
            else if (id != 0)
            {
                info1.CreatedBy = Program._userid;
                info1.CreationDate = DateTime.Now;

                info1.LastUpdateDate = DateTime.Now;
                info1.LastUpdateUser = Program._userid;

                info1.ApprovalStatusCode = (int)approvalStatus;

                if (approvalStatus != ApprovalStatus.Pending)
                {
                    info1.ApprovalActionUser = Program._userid; ;
                    info1.ApprovalActionDate = DateTime.Now;
                }
                else
                {
                    info1.ApprovalActionUser = "";
                    info1.ApprovalActionDate = new DateTime(1900, 1, 1);
                }
            }



            int intTransID = 0;
            result = da.AddTransferHistory(info1, ref intTransID);

            if (result == false)
            {
                MessageBox.Show("An Error Occoured");
                return;
            }

            infoMember.RegistrationNo = txtRegistration.Text;
            infoMember.ClientID = txtClientID.Text;


            infoMember.ClientID = txtTransferID.Text;

            infoMember.RegistrationNo = txtRegistration.Text.Trim();
            infoMember.ClientID = txtTransferID.Text;

            infoMember.Name = txtTransferName.Text;
            infoMember.FatherOrHusbandType = cmbTransferFatherHusband.Text;
            infoMember.FatherOrHusband = txtTransferFatherHusband.Text;
            infoMember.NIDOrCNIC = txtNIDCNIC.Text;
            infoMember.Nationality = cmbTransferNationality.Text;
            infoMember.DOB = dTPTransferDOB.Value;
            infoMember.CurrentAddress1 = txtTransferCurrentAddress1.Text.Trim();
            infoMember.CurrentAddress2 = txtTransferCurrentAddress2.Text.Trim();
            infoMember.CurrentAddress3 = txtTransferCurrentAddress3.Text.Trim();
            infoMember.Country = cmbTransferCountry.Text;
            infoMember.City = txtTransferCity.Text;
            infoMember.PhOff = txtTransferPh.Text;
            infoMember.Res = txtTransferRes.Text;
            infoMember.Mob = txtTransferMob.Text;
            infoMember.Fax = "";
            infoMember.EmailAddress = txtTransferEmailAddress.Text;


            if (approvalStatus == ApprovalStatus.Approved)
            {
                infoMember.intStatusCode = (int)memberLookupCodes.Transferred;

            }
            else if (approvalStatus == ApprovalStatus.Pending)
            {
                infoMember.intStatusCode = (int)memberLookupCodes.MarkedForTransfer;

            }
            result = da.UpdateRegistrationonTransfer(infoMember, txtClientID.Text);
            if (result == false)
            {
                MessageBox.Show("An Error Occured");
                return;
            }

            if ((approvalStatus == ApprovalStatus.Pending))
            {

                if (pbTransferToImage.Image == null)
                    return;
                clsTransferImage memberImage = new clsTransferImage()
                {
                    TransferID = intTransID,
                    ClientID = txtTransferID.Text,
                    ImageId = txtPictureName.Text,
                    RegistrationNo = txtRegistration.Text

                };
                memberImage.Image = imageToByteArray(this.pbTransferToImage.Image);

                da.AddTransferImage(memberImage);

                if (pbTransferToCNIC.Image == null)
                    return;
                clsTransferCNIC memberCNIC = new clsTransferCNIC()
                {
                    TransferID = intTransID,
                    ClientID = txtTransferID.Text,
                    ImageId = txtCNICName.Text,
                    RegistrationNo = txtRegistration.Text

                };
                memberCNIC.Image = imageToByteArray(this.pbTransferToCNIC.Image);

                da.AddTransferCNIC(memberCNIC);
            }
            else if ((approvalStatus == ApprovalStatus.Approved))
            {
                da.AddMemberImageonTransfer(intTransID);
                da.AddMemberCNIConTransfer(intTransID);
            }


            Clear();
        }
        private void btnMemberRegistrationImage_Click(object sender, EventArgs e)
        {
            if (txtTransferID.Text.Trim() == "" || txtRegistration.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Person Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbTransferToImage.Image = new Bitmap(dlg.FileName);
                    pbTransferToImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtPictureName.Text = txtRegistration.Text + "-Image";
                }
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image ImageIn)
        {
            MemoryStream ms = new MemoryStream();
            ImageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMemberCNIC_Click(object sender, EventArgs e)
        {
            if (txtTransferID.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Person Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void btnMemberRegistrationCNIC_Click(object sender, EventArgs e)
        {
            if (txtTransferID.Text.Trim() == "" || txtRegistration.Text.Trim() == "")
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Person Image";
                dlg.Filter = "jpg files (*.jpg;*.png)|*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbTransferToCNIC.Image = new Bitmap(dlg.FileName);
                    pbTransferToCNIC.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtCNICName.Text = txtRegistration.Text + "-CNIC";
                }
            }
        }

        private void tsbAttach_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("To attach files, transfer must be saved.");
                return;
            }
            frmAttachmentList attachments = new frmAttachmentList();
            attachments.attachmentType = AttachmentType.Transfer;
            attachments.intTransfer = this.id;

            attachments.strRegistrationNo = txtRegistration.Text;
            attachments.strClientID = txtClientID.Text;
            attachments.ShowDialog();
        }

        private void tsbViewAttachments_Click(object sender, EventArgs e)
        {
            if (id == 0)
                return;
            frmAttachmentList attachments = new frmAttachmentList();
            attachments.attachmentType = AttachmentType.Transfer;
            attachments.intTransfer = this.id;
            attachments.strRegistrationNo = txtRegistration.Text;
            attachments.strClientID = txtClientID.Text;
            attachments.Show();
        }





    }
}
