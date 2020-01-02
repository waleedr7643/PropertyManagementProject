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
    public partial class frmProspectLookup : Form
    {

        public string strProject { get; set; }
        public memberLookupCodes prospectlookupCode { get; set; }
        DataAccess da = new DataAccess();
        List<clsProspect> lstinfo = new List<clsProspect>();
        List<clsProjects> lstProjects = new List<clsProjects>();
        public frmProspectLookup()
        {
            InitializeComponent();
            dTPStartDate.Value = DateTime.Now.Date;
            dTPEndDate.Value = DateTime.Now.Date;
        }

        private void frmProspectLookup_Load(object sender, EventArgs e)
        {
            Loadprojects();

            if (strProject == "" || strProject == null)
            {
                cmbProject.Text = "All";
            }
            else
                cmbProject.Text = strProject;

            lstinfo = da.GetAllProspects(cmbProject.Text,dTPStartDate.Value.Date,dTPEndDate.Value.Date);
            PopulateGrid(lstinfo);

        }

        private void Loadprojects()
        {
            cmbProject.Items.Clear();
            cmbProject.Items.Add("All");
            lstProjects = da.GetAllProjectsInfo();
            foreach (var project in lstProjects)
                cmbProject.Items.Add(project.strProjectid);
        }

        public int prosid { get; set; }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;


            prosid = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);
            this.DialogResult = DialogResult.OK;
           
        }
          
        private void PopulateGrid(List<clsProspect> list)
        {

            dgList.Rows.Clear();

            int SRNo = 1;

            foreach (var mem in list)
            {
                int intRowIndex = dgList.Rows.Add();

                dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;
                dgList.Rows[intRowIndex].Cells["ProjectNo"].Value = mem.ProjectNo;
                dgList.Rows[intRowIndex].Cells["Sector"].Value = mem.Sector;

                dgList.Rows[intRowIndex].Cells["UPlot"].Value = mem.UPlot;
                dgList.Rows[intRowIndex].Cells["SizeCode"].Value = mem.SizeCode;
                dgList.Rows[intRowIndex].Cells["ProspectName"].Value = mem.ProspectName;
                dgList.Rows[intRowIndex].Cells["ProspectFatherName"].Value = mem.ProspectFatherName;
                dgList.Rows[intRowIndex].Cells["CNIC"].Value = mem.CNIC;

                dgList.Rows[intRowIndex].Cells["ContactNo"].Value = mem.ContactNo;
                dgList.Rows[intRowIndex].Cells["ProspectStartDate"].Value = mem.ProspectStartDate.ToString("dd/MM/yyy");
                dgList.Rows[intRowIndex].Cells["ProspectPaymentPlan"].Value = mem.ProspectPaymentPlan;
                dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;

                SRNo++;

            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            cmbProject.Text = "";
            
            dgList.Rows.Clear();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Loadprojects();

            if (strProject == "" || strProject == null)
            {
                cmbProject.Text = "All";
            }
            else
                cmbProject.Text = strProject;

            lstinfo = da.GetAllProspects(cmbProject.Text, dTPStartDate.Value.Date, dTPEndDate.Value.Date);
            PopulateGrid(lstinfo);
        }
    }
}
