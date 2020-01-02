using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;


namespace TMR.GP.GrandCityAddon
{
    public partial class frmMemberRegistration : Form
    {
        int id = 0;
        bool bEdit = false;
        string strPrefix = "";
        string strNumber = "";

        DataAccess da = new DataAccess();
        clsMemberRegistration info = new clsMemberRegistration();
        clsNominee info1 = new clsNominee();
        clsPartner infoP = new clsPartner();
        List<clsProjects> lstProject;
        List<clsSizeCodes> lstSizeCodes;
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
            this.tsbAttach.Enabled = userRights.AllowSave;
            this.tsbViewAttachments.Enabled = userRights.AllowSave;
            this.btnAddNominee.Enabled = userRights.AllowSave;
            this.btnAddPartner.Enabled = userRights.AllowSave;
        }
        private void cmbSizeCode_SelectedIndexChanged(object sender, EventArgs e)
        {


            //if (cmbSizeCode.SelectedIndex == -1)
            //    return;
            //var selectedSizeCode = lstSizeCodes.Where(x => x.strUnitSizeCode == cmbSizeCode.Text).First();
            //int sizeCodeID = selectedSizeCode.ID;

            //var Size = da.GetSizeCodeInfoByID(sizeCodeID);

            //txtRegistrationNo.Text = Size.strPrefix + Size.strCurrentNumber;        
        }
        private void LoadProjects()
        {
            lstProject = da.GetAllProjectsInfo();
            foreach (var item in lstProject)
                cmbProjects.Items.Add(item.strProjectid);
            if (cmbProjects.Items.Count != 0)
                cmbProjects.SelectedIndex = 0;
            Clear();
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

            dTPBooking.Value = info.Booking;
            cmbProjects.Text = info.strProjectid;
            cmbSizeCode.Text = info.Plan;
            txtBlock.Text = info.Block;
            txtPlot.Text = info.Plot;
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
            LoadNomineeGrid();
            LoadPartnerGrid();
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
            //info.RegistrationOrBookingNo = cmbRegistrationNo.Text;
            //if (txtRegistrationNo.Text.Trim() == "")
            //    return;

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
            txtBlock.Text = "";
            txtPlot.Text = "";
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
            //pbNomineeImage
            //pbNomineeCNIC
            //txtNomineePictureName
            //txtNomineeCNICName
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
            if (chkSoleProprieter.Checked == true)
            {
                MessageBox.Show("Client is marked as sole owner. Partners cannot be added.");
                return;
            }
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
        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            LoadSizeCodes();
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
        private void LoadSizeCodes()
        {
            cmbSizeCode.Items.Clear();

            lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProjects.Text);
            foreach (var sizecode in lstSizeCodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
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

            if (txtCurrentAddress1.Text.Trim() + "" + txtCurrentAddress2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("CurrentAddress Cannot Be Empty");
                txtCurrentAddress1.Focus();
                return;
            }

            if (cmbCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Country Cannot Be Empty");
                cmbCountry.Focus();
                return;
            }
            if (txtCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("City Cannot Be Empty");
                txtCity.Focus();
                return;
            }


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
            info.Booking = dTPBooking.Value;
            info.Block = txtBlock.Text;
            info.Plot = txtPlot.Text;
            info.UnitRate = Convert.ToDecimal(txtUnitRate.Text);
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
            //Saving Mameber CNIC
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

            MessageBox.Show("Member Information saved.");
            LoadInformation();

            //MemberRegistrationClear();
            //NomineeClear();
            //PartnerClear();
            //dgNominee.Rows.Clear();
            //dgPartner.Rows.Clear();


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
                return;
            }
            result = decimal.TryParse(txtRebatAmt.Text, out rebateAmount);
            txtRebatAmt.Text = rebateAmount.ToString("N2");
            if (result == false)
            {
                MessageBox.Show("Please enter a valid rebate amount.");
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
                txtCustomerNumber.Text = da.GenerateCustomerNumber(txtClientID.Text);
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

    }
}