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
    public partial class frmUnsentCommList : Form
    {
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsCommission> lstReceipts;
        DataAccess da = new DataAccess();
        public int intId { get; set; }
        public frmUnsentCommList()
        {
            InitializeComponent();
        }

        private void frmReceiptsList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            Loadprojects();
            cmbProject.Text = "All";
            FilterList();
            LoadBatches();

        }
        private void SetUserSecurity()
        {
            //var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            //if (userRights.AllowOpen == false)
            //{
            //    MessageBox.Show("User is not authorized to open this form.");
            //    this.Close();
            //}

            // this.tsbSave.Enabled = userRights.AllowSave;
            // this.tsbApprove.Enabled = userRights.AllowPost;

        }
        private void LoadBatches()
        {
            var lst = da.GetVendorInvoiceBatches();
            foreach (var batch in lst)
                cmbBatches.Items.Add(batch);
        }
        public void DataGridRefresh(List<clsCommission> list)
        {

            dgList.Rows.Clear();

            int SRNo = 1;

            if (list != null)
            {
                foreach (clsCommission mem in list)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;

                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.strRegistration;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.strClientID;
                    dgList.Rows[intRowIndex].Cells["ClientName"].Value = mem.strClientName;
                    dgList.Rows[intRowIndex].Cells["EntryNumber"].Value = mem.strEntryNumber;
                    dgList.Rows[intRowIndex].Cells["PartyID"].Value = mem.strDealer;
                    dgList.Rows[intRowIndex].Cells["ReceiptAmount"].Value = mem.decAmount.ToString("N2");
                    dgList.Rows[intRowIndex].Cells["ReceiptDate"].Value = mem.DocumentDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.strRemarks;

                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.intID;

                    SRNo++;
                }
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            intId = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);

            frmReceiptEntry frm = new frmReceiptEntry();
            frm.receiptId = intId;
            frm.Show();
            this.Close();


        }
        private void FilterList()
        {
            //clsDocumentFilter filter = MakeFilter();
            //lstReceipts = da.GetAllReceiptsList(filter);
            lstReceipts = da.GetUnsentCommissionList();

            DataGridRefresh(lstReceipts);
        }

        private void Loadprojects()
        {
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }

        private clsDocumentFilter MakeFilter()
        {
            clsDocumentFilter Docfilter = new clsDocumentFilter();

            Docfilter.strProjectID = cmbProject.Text;
            if (cmbSearchBy.Text == "Membership ID")
                Docfilter.strRegistrationNo = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Client ID")
                Docfilter.strClientID = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Project ID")
                Docfilter.strProjectID = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Entry Number")
                Docfilter.strDocNumber = txtSearchValue.Text.Trim();

            Docfilter.dateStartDate = dTPStartDate.Value.Date;
            Docfilter.dateEndDate = dTPEndDate.Value.Date;

            return Docfilter;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (cmbBatches.Text == "")
            {
                MessageBox.Show("Please select a batch.");
                return;
            }

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["Select"].Value) == false)
                    continue;

                int id = Convert.ToInt32(dgr.Cells["id"].Value);
                var receiptEntry = da.GetCommissionEntry(id);


                PMPurchaseDocument pm = new PMPurchaseDocument();
                pm.VoucherNumber = receiptEntry.strEntryNumber;
                pm.DocumentNumber = receiptEntry.strEntryNumber;
                pm.TransactionDescription = "Commission Entry";
                pm.VendNumber = receiptEntry.strDealer;
                pm.CurrencyId = "PKR";
                pm.BatchNumber = cmbBatches.Text;
                pm.TaxEngineCalled = true;
                pm.BatchSource = "PM_Trxent";
                pm.DocumentType = 1;
                pm.AccountAmount = receiptEntry.decAmount;
                pm.PostingStatus = 20;

                var result = da.AddPMTransHeader(pm, pm.VoucherNumber);
                if (result == false)
                {
                    MessageBox.Show("An error occurred. Contact your system administrator.");
                    return;
                }

                result = da.AddPMNumberSequence(pm.VoucherNumber, pm.DocumentNumber, pm.VendNumber);
                if (result == false)
                {
                    MessageBox.Show("An error occurred. Contact your system administrator.");
                    return;
                }

                List<PMPurchaseDistribution> distributions = new List<PMPurchaseDistribution>();

                distributions.Add(new PMPurchaseDistribution()
                {
                    PostingStatus = 0,
                    DistributionType = 6,
                    SequenceNumber = 16384,
                    VendorNumber = pm.VendNumber,
                    DistributionAccountIndex = 71,
                    DebitAmount = pm.AccountAmount,
                    CreditAmount = 0,
                    CurrencyId = "PKR",
                    CurrencyIndex = 1000,
                    DistributionReference = ""
                });
                distributions.Add(new PMPurchaseDistribution()
                {
                    PostingStatus = 0,
                    DistributionType = 2,
                    SequenceNumber = 32768,
                    VendorNumber = pm.VendNumber,
                    DistributionAccountIndex = 15,
                    DebitAmount = 0,
                    CreditAmount = pm.AccountAmount,
                    CurrencyId = "PKR",
                    CurrencyIndex = 1000,
                    DistributionReference = ""
                });

                pm.Distributions = distributions;
                result = da.AddPMTransDistributions(pm, pm.VoucherNumber);

                if (result == false)
                {
                    MessageBox.Show("An error occurred. Contact your system administrator.");
                    return;
                }

                if (result == true)
                {
                    bool sendToGp = da.UpdateCommissionSendToGPStatus(id);

                    if (sendToGp == false)
                    {
                        MessageBox.Show("An error occurred. Contact your system administrator.");
                        return;
                    }
                }
                FilterList();
            }
        }

        private void dgList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgList.IsCurrentCellDirty)
            {
                dgList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
