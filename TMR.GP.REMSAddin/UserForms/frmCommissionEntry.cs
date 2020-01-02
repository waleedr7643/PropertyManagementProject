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
    public partial class frmCommissionEntry : Form
    {

        DataAccess da = new DataAccess();
        clsMemberRegistration memberInfo = new clsMemberRegistration();
        public int EntryID { get; set; }
        public int EntryType { get; set; }//1 for dealer. 2 fro sales person

        public frmCommissionEntry()
        {
            InitializeComponent();
        }

        private void btnSelectRegistration_Click(object sender, EventArgs e)
        {
            frmMemberLookup frm = new frmMemberLookup();
            frm.strProject = cmbProjects.Text;
            //LoadSizeCodes();
            frm.memberlookupCode = memberLookupCodes.Allocated;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                LoadInformation();
                txtRegistrationNo.Focus();
                btnSelectRegistration.Focus();
            }
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
        private void frmCommissionEntry_Load(object sender, EventArgs e)
        {
            LoadProjects();

            if (EntryID == 0)
            {
                var number = da.GetNextCommissionNumber();
                txtEntryNumber.Text = number;
            }
            else
            {
                LoadEntry();
            }
        }
        private void LoadEntry()
        {
            clsCommission comm = da.GetCommissionEntry(this.EntryID);

            this.EntryType = comm.intEntryType;
            txtAmount.Text = comm.decAmount.ToString("N2");
            txtNetPrice.Text = comm.decNetPrice.ToString("N2");
            txtPercentage.Text = comm.decPercentage.ToString("N2");
            dtpEntryDate.Value = comm.DocumentDate.Date;
            cmbProjects.Text = comm.strProject;
            txtRemarks.Text = comm.strRemarks;
            txtClientID.Text = comm.strClientID;
            txtName.Text = comm.strClientName;
            txtDealerName.Text = comm.strDealer;
            txtEntryNumber.Text = comm.strEntryNumber;
            txtRegistrationNo.Text = comm.strRegistration;


        }
        private void LoadInformation()
        {
            if (txtRegistrationNo.Text.Trim() == "")
                return;

            memberInfo = da.GetMemberRegistrationInfo(txtRegistrationNo.Text);

            if (memberInfo == null || memberInfo.id == 0)
                return;

            if (memberInfo.bSendToGP == false)
            {
                MessageBox.Show("A corresponding customer entry does not exist in Dynamics GP. \n A receipt entry cannot be created.");
                return;
            }

            txtClientID.Enabled = false;
            txtRegistrationNo.Enabled = false;
            txtRegistrationNo.Text = memberInfo.RegistrationNo;
            txtClientID.Text = memberInfo.ClientID;
            txtName.Text = memberInfo.Name;
            txtDealerName.Text = memberInfo.strDealer;
            txtNetPrice.Text = memberInfo.NetOrRetailPrice.ToString("N2");
            txtPercentage.Text = memberInfo.decDealerPercentage.ToString("N2");
            txtAmount.Text = (memberInfo.NetOrRetailPrice / 100 * memberInfo.decDealerPercentage).ToString("N2");



        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            //PMPurchaseDocument document = new PMPurchaseDocument();
            //document.AccountAmount = Convert.ToDecimal(txtAmount.Text);

            //document.BatchNumber = "BATCH";
            //document.BatchSource = "PM_Trxent";
            //document.CurrencyId = "PKR";
            //document.DocumentNumber = "10000";
            //document.DocumentType = 1;
            //document.PostingStatus = 20;
            //document.VendNumber = "DEALER-001";
            //document.DocumentNumber = "10000";            
            //document.TaxEngineCalled = true;

            //da.AddPMTransHeader(document, "10000");

            clsCommission comm = new clsCommission();
            comm.intID = this.EntryID;
            comm.intEntryType = this.EntryType;
            comm.bSentToGP = false;
            comm.decAmount = Convert.ToDecimal(txtAmount.Text);
            comm.decNetPrice = Convert.ToDecimal(txtNetPrice.Text);
            comm.decPercentage = Convert.ToDecimal(txtPercentage.Text);
            comm.DocumentDate = dtpEntryDate.Value.Date;
            comm.strProject = cmbProjects.Text;
            comm.strRemarks = txtRemarks.Text;
            comm.strClientID = txtClientID.Text;
            comm.strClientName = txtName.Text;
            comm.strDealer = txtDealerName.Text;
            comm.strEntryNumber = txtEntryNumber.Text;
            comm.strRegistration = txtRegistrationNo.Text;

            bool result = da.AddCommissionEntry(comm);
            if (result == true)
                Clear();
            else
            {
                MessageBox.Show("Could not create commission entry.");
                return;
            }

        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {

            txtAmount.Text = "0";
            txtNetPrice.Text = "0";
            txtPercentage.Text = "0";


            txtRemarks.Text = "";
            txtClientID.Text = "";
            txtName.Text = "";
            txtDealerName.Text = "";
            txtEntryNumber.Text = "";
            txtRegistrationNo.Text = "";
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}