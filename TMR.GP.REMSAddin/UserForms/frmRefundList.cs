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

namespace TMR.GP.REMSAddin.UserForms
{
    public partial class frmRefundList : Form
    {
        public int intid { get; set; }
        DataAccess da = new DataAccess();
        List<clsProjects> lstProjects = new List<clsProjects>();
        public frmRefundList()
        {
            InitializeComponent();
            dTPStartDate.Value = DateTime.Now.Date;
            dTPEndDate.Value = DateTime.Now.Date;
        }

        private void frmRefundList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            cmbStatus.Text = "Pending";
            Loadprojects();
            cmbProject.Text = "All";
                        
            FilterList();
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            // this.tsbSave.Enabled = userRights.AllowSave;
            // this.tsbApprove.Enabled = userRights.AllowPost;

        }

        private void Loadprojects()
        {
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }
        public void DataGridRefresh(List<clsRefund> lstRefund)
        {


            dgList.Rows.Clear();

            int SRNo = 1;

            if (lstRefund != null)
            {
                foreach (clsRefund mem in lstRefund)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationOrBookingNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.ClientID;
                    dgList.Rows[intRowIndex].Cells["RefundDate"].Value = mem.RefundDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = mem.ApprovalStatusDescription;
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.Remarks;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;

                    SRNo++;

                }
            }

        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;

            intid = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);

            frmRefund frmAloc = new frmRefund();
            frmAloc.id = intid;
            frmAloc.Show();
            this.Close();
        }
        private void FilterList()
        {
            clsDocumentFilter filter = MakeFilter();
            var lstRefund = da.GetAllRefundList(filter);
            DataGridRefresh(lstRefund);

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
                Docfilter.strRegistrationNo = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Client ID")
                Docfilter.strClientID = txtSearchValue.Text.Trim();
            else if (cmbSearchBy.Text == "Project ID")
                Docfilter.strProjectID = txtSearchValue.Text.Trim();

            Docfilter.dateStartDate = dTPStartDate.Value.Date;
            Docfilter.dateEndDate = dTPEndDate.Value.Date;

            return Docfilter;
        }
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }
        private void clear()
        {


        }
    
    }
}
