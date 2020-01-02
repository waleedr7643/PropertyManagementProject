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
    public partial class frmCommissionEntryList : Form
    {
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsCommission> lstReceipts;
        DataAccess da = new DataAccess();
        public int intId { get; set; }
        public frmCommissionEntryList()
        {
            InitializeComponent();
            dTPStartDate.Value = DateTime.Now.Date;
            dTPEndDate.Value = DateTime.Now.Date;
        }

        private void frmReceiptsList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();            
            Loadprojects();
            cmbProject.Text = "All";
            FilterList();
       
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

            frmCommissionEntry frm = new frmCommissionEntry();
            frm.EntryID = intId;
            frm.Show();
            this.Close();
            

        }
        private void FilterList()
        {
            clsDocumentFilter filter = MakeFilter();
            lstReceipts = da.GetAllCommList(filter);
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



            // filter.bForProcess = this.bForProcess;

            return Docfilter;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            FilterList();
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
