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
    public partial class frmUnsentReceiptsList : Form
    {
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsReceiptEntry> lstReceipts;
        DataAccess da = new DataAccess();
        public int intId { get; set; }
        public frmUnsentReceiptsList()
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
            var lst = da.GetCashReceiptBatches();
            foreach (var batch in lst)
                cmbBatches.Items.Add(batch);
        }
        public void DataGridRefresh(List<clsReceiptEntry> list)
        {

            dgList.Rows.Clear();
            int SRNo = 1;

            if (list != null)
            {
                foreach (clsReceiptEntry mem in list)
                {
                    int intRowIndex = dgList.Rows.Add();
                    dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.ClientID;
                    dgList.Rows[intRowIndex].Cells["ClientName"].Value = mem.ClientName;
                    dgList.Rows[intRowIndex].Cells["ReceiptNumber"].Value = mem.ReceiptNumber;

                    dgList.Rows[intRowIndex].Cells["ReceiptAmount"].Value = mem.ReceiptAmount.ToString("N2");
                    dgList.Rows[intRowIndex].Cells["ReceiptDate"].Value = mem.ReceiptDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.Remarks;
                    dgList.Rows[intRowIndex].Cells["ClearanceDate"].Value = mem.ClearanceDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["DepositBank"].Value = mem.DepositBank;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.intId;

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
            lstReceipts = da.GetUnsentReceiptsList();

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
            else if (cmbSearchBy.Text == "Receipt Number")
                Docfilter.strDocNumber = txtSearchValue.Text.Trim();

            Docfilter.dateStartDate = dTPStartDate.Value.Date;
            Docfilter.dateEndDate = dTPEndDate.Value.Date;



            // filter.bForProcess = this.bForProcess;

            return Docfilter;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["Select"].Value) == false)
                    continue;

                int id = Convert.ToInt32(dgr.Cells["id"].Value);
                var receiptEntry = da.GetReceiptEntry(id);

                var result = da.CreateCashReceipt(receiptEntry, cmbBatches.Text);

                if (result == false)
                {
                    MessageBox.Show("Record could not be created.");
                    return;
                }
                if (result == true)
                {
                    bool sendToGp = da.UpdateCashReceiptSendToGPStatus(id);

                    if (sendToGp == false)
                    {
                        MessageBox.Show("Failed to Update.");
                        return;
                    }
                }
                MessageBox.Show("Record successfully created in Customer Database.");
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
