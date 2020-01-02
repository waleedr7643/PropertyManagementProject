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
    public partial class frmAllocationListcs : Form
    {
        int id1 = 0;
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsAllocation> lstAllocations;
        DataAccess da = new DataAccess();
        public frmAllocationListcs()
        {
            InitializeComponent();
            dTPStartDate.Value = DateTime.Now.Date;
            dTPEndDate.Value = DateTime.Now.Date;
        }
        public void DataGridRefresh(List<clsAllocation> list)
        {
            dgList.Rows.Clear();

            int SRNo = 1;

            if (list != null)
            {
                foreach (clsAllocation mem in list)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[intRowIndex].Cells["AllocationDate"].Value = mem.dtAllocationDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationOrBookingNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.strClientID;
                    dgList.Rows[intRowIndex].Cells["ProjectID"].Value = mem.strProjectid;
                    dgList.Rows[intRowIndex].Cells["Block"].Value = mem.strBlock;
                    dgList.Rows[intRowIndex].Cells["UnitID"].Value = mem.strUnitID;
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.strRemarks;
                    dgList.Rows[intRowIndex].Cells["StatusCode"].Value = mem.intPreviousStatusCode;
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = mem.ApprovalStatusDescription;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;

                    SRNo++;
                }
            }
               

        }
        private void frmAllocationListcs_Load(object sender, EventArgs e)
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

        }
        private void Loadprojects()
        {
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            id1 = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);

            frmAllocation frmAloc = DashBoard._allocation;

            foreach (var form in Application.OpenForms)
            {
                if (((Form)form).GetType().Name == "frmAllocation")
                {
                    frmAloc.Close();
                    break;
                }
            }
            if (frmAloc == null || frmAloc.IsDisposed == true)
            {
                frmAloc = new frmAllocation();
                frmAloc.id = id1;
                frmAloc.Show();
            }
            frmAloc.BringToFront();

            //this.Close();
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



            // filter.bForProcess = this.bForProcess;

            return Docfilter;
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }
        private void FilterList()
        {
            clsDocumentFilter filter = MakeFilter();
            lstAllocations = da.GetAllAllocationList(filter);
            DataGridRefresh(lstAllocations);
        }

    }
}
