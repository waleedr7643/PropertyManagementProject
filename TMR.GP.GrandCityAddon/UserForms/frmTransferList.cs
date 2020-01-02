using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon.UserForms
{
    public partial class frmTransferList : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstProjects = new List<clsProjects>();
        public int intId { get; set; }
        public frmTransferList()
        {
            InitializeComponent();
        }

        private void frmTransferList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            cmbStatus.Text = "Pending";
            Loadprojects();
            cmbProject.Text = "All";

            //DataGridRefresh();

        }
        private void Loadprojects()
        {
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }
        private void FilterList()
        {
            clsDocumentFilter filter = MakeFilter();
            var lstTransfer = da.GetAllTransferHistoryList(filter);
            DataGridRefresh(lstTransfer);

        }
        private clsDocumentFilter MakeFilter()
        {
            clsDocumentFilter Docfilter = new clsDocumentFilter();

            Docfilter.strProjectID = cmbProject.Text;

            if (cmbStatus.Text == "All")
                Docfilter.intApprovalStatusCode = 0;
            else if (cmbStatus.Text == "Approved")
                Docfilter.intApprovalStatusCode = (int)ApprovalStatus.Approved;
            else if (cmbStatus.Text == "Pending")
                Docfilter.intApprovalStatusCode = (int)ApprovalStatus.Pending;
            else if (cmbStatus.Text == "Rejected")
                Docfilter.intApprovalStatusCode = (int)ApprovalStatus.Rejected;

            if (cmbSearchBy.Text == "Membership ID")
            {
                if (!String.IsNullOrEmpty(txtSearchValue.Text))
                {
                    Docfilter.strRegistrationNo = txtSearchValue.Text.Trim();
                }
                else
                {
                    Docfilter.strRegistrationNo = "";
                }

                //if (!String.IsNullOrEmpty(txtTransferFromID.Text))
                //{
                //    Docfilter.strClientID = txtTransferFromID.Text.Trim();
                //}
                //else
                //{
                //    Docfilter.strClientID = "";
                //}
                //if (!String.IsNullOrEmpty(txtTransferToID.Text))
                //{
                //    Docfilter.strClientID = txtTransferToID.Text.Trim();
                //}
                //else
                //{
                //    Docfilter.strToClientID = "";
                //}

            }
            else if (cmbSearchBy.Text == "Client ID")
            {

                if (!String.IsNullOrEmpty(txtSearchValue.Text))
                {
                    Docfilter.strRegistrationNo = txtSearchValue.Text.Trim();
                }
                else
                {
                    Docfilter.strRegistrationNo = "";
                }

                //if (!String.IsNullOrEmpty(txtTransferFromID.Text))
                //{
                //    Docfilter.strClientID = txtTransferFromID.Text.Trim();
                //}
                //else
                //{
                //    Docfilter.strClientID = "";
                //}
                //if (!String.IsNullOrEmpty(txtTransferToID.Text))
                //{
                //    Docfilter.strClientID = txtTransferToID.Text.Trim();
                //}
                //else
                //{
                //    Docfilter.strToClientID = "";
                //}

            }
            else if (cmbSearchBy.Text == "Project ID")
                Docfilter.strProjectID = txtSearchValue.Text.Trim();



            Docfilter.dateStartDate = dTPStartDate.Value.Date;
            Docfilter.dateEndDate = dTPEndDate.Value.Date;

            return Docfilter;
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Program._userid, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            // this.tsbSave.Enabled = userRights.AllowSave;
            // this.tsbApprove.Enabled = userRights.AllowPost;

        }
        public void DataGridRefresh(List<clsTransferHistory> lstTrans)
        {

            dgList.Rows.Clear();
            if (lstTrans != null)
            {
                foreach (clsTransferHistory mem in lstTrans)
                {
                    int intRowIndex = dgList.Rows.Add();


                    dgList.Rows[intRowIndex].Cells["ID"].Value = mem.intID;
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.strRegistrationNo;
                    dgList.Rows[intRowIndex].Cells["TransferFromID"].Value = mem.strTransferFromID;
                    dgList.Rows[intRowIndex].Cells["TransferToID"].Value = mem.strTransferToID;
                    dgList.Rows[intRowIndex].Cells["TransferDate"].Value = mem.dtTransferDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = mem.ApprovalStatusDescription;
                }
            }
        }

        private void tsbtnLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;

            intId = Convert.ToInt32(dgList.SelectedRows[0].Cells["ID"].Value);

            frmTransfer frm = new frmTransfer();
            frm.id = intId;
           
            frm.Show();
            this.Close();

        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }



    }
}
