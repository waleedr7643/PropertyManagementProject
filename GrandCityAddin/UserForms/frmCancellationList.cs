using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon
{
    public partial class frmCancellationList : Form
    {
        List<clsProjects> lstProjects = new List<clsProjects>();
        List<clsCancellation> lstCancellations;
        DataAccess da = new DataAccess();
        public int intId { get; set; }
        public frmCancellationList()
        {
            InitializeComponent();
        }

        private void frmCancellationList_Load(object sender, EventArgs e)
        {

            cmbStatus.Text = "Pending";
            Loadprojects();
            cmbProject.Text = "All";
            FilterList();
       
        }
        public void DataGridRefresh(List<clsCancellation> list)
        {

            dgList.Rows.Clear();

            if (list != null)
            {
                foreach (clsCancellation mem in list)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationOrBookingNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.ClientID;
                    dgList.Rows[intRowIndex].Cells["CancellationDate"].Value = mem.CancellationDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["Approve"].Value = mem.Approved;
                   
                    dgList.Rows[intRowIndex].Cells["ProjectID"].Value = mem.strProjectid;
                    dgList.Rows[intRowIndex].Cells["Block"].Value = mem.strBlock;
                    dgList.Rows[intRowIndex].Cells["UnitID"].Value = mem.strUnitID;
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.Remarks;
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = mem.ApprovalStatusDescription;
                    
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;


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

            frmCancellation frm = new frmCancellation();
            frm.id = intId;
            frm.Show();
            this.Close();
            

        }
        private void FilterList()
        {
            clsDocumentFilter filter = MakeFilter();
            lstCancellations = da.GetAllCancellationList(filter);
            DataGridRefresh(lstCancellations);
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
    }
}
