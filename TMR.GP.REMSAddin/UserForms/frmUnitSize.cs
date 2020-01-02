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
    public partial class frmUnitSize : Form
    {
        int id = 0;
        DataAccess da = new DataAccess();
        List<clsSizeCodes> lstSizeCodes = new List<clsSizeCodes>();
        List<clsUnitofMeasure> lstUnits = new List<clsUnitofMeasure>();
        List<clsProjects> lstProjects = new List<clsProjects>();

        public frmUnitSize()
        {
            InitializeComponent();
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            lstUnits = da.GetAllUOMsInfo();

            foreach (var unit in lstUnits)
                cmbUoM.Items.Add(unit.strUOMid);

            lstProjects = da.GetAllProjectsInfo();
            foreach (var proj in lstProjects)
                cmbProjectID.Items.Add(proj.strProjectid);

            LoadSizeCodes();
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            this.tsbSave.Enabled = userRights.AllowSave;
            //this.tsbApprove.Enabled = userRights.AllowPost;

        }

        private void LoadSizeCodes()
        {
            dgList.Rows.Clear();

            int SRNo = 1;

            lstSizeCodes = da.GetAllSizeCodeInfo();

            if (lstSizeCodes != null)
            {
                foreach (var project in lstSizeCodes)
                {
                    int index = dgList.Rows.Add();

                    dgList.Rows[index].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[index].Cells["UnitSizeCode"].Value = project.strUnitSizeCode;
                    dgList.Rows[index].Cells["Description"].Value = project.strUnitSizeDescription;
                    dgList.Rows[index].Cells["Area"].Value = project.decArea.ToString("N2");
                    dgList.Rows[index].Cells["UoM"].Value = project.UoMID;
                    dgList.Rows[index].Cells["Prefix"].Value = project.strPrefix;
                    dgList.Rows[index].Cells["CurrentNumber"].Value = project.strCurrentNumber;
                    dgList.Rows[index].Cells["Project"].Value = project.strProject;
                    dgList.Rows[index].Cells["ID1"].Value = project.ID;

                    SRNo++;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal decArea = 0;
            bool b = decimal.TryParse(txtArea.Text, out decArea);

            if(b== false)
            {
                MessageBox.Show("Please enter a valid area.");
                txtArea.Focus();
                return;
            }
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Code cannot be empty.");
                txtID.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Description cannot be empty.");
                txtName.Focus();
                return;                
            }
            if (txtArea.Text.Trim() == "")
            {
                MessageBox.Show("Area cannot be empty.");
                txtArea.Focus();
                return;
            }
            if (cmbUoM.Text.Trim() == "")
            {
                MessageBox.Show("Please select a unit of measure.");
                cmbUoM.Focus();
                return;
            }
            if (txtPrefix.Text.Trim() == "")
            {
                MessageBox.Show("Prefix cannot be empty.");
                txtPrefix.Focus();
                return;
            }
            if (txtCurrentNumber.Text.Trim() == "")
            {
                MessageBox.Show("Current number cannot be empty.");
                txtCurrentNumber.Focus();
                return;
            }
            if (cmbProjectID.Text.Trim() == "")
            {
                MessageBox.Show("A project must be selected.");
                cmbProjectID.Focus();
                return;
            }

            foreach (DataGridViewRow dgr in dgList .Rows)
            {
                if (dgr.Cells["Project"].Value.ToString().Trim().ToUpper() == cmbProjectID.Text.Trim().ToUpper()
                    && dgr.Cells["UnitSizeCode"].Value.ToString().Trim().ToUpper() == txtID.Text.Trim().ToUpper()
                    && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A size code with same ID already exists.");
                    return;
                }
                if (dgr.Cells["Project"].Value.ToString().Trim().ToUpper() == cmbProjectID.Text.Trim().ToUpper()
                   && dgr.Cells["Prefix"].Value.ToString().Trim().ToUpper() == txtPrefix.Text.Trim().ToUpper()
                   && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A prefix code with same ID already exists.");
                    return;
                }

            }

            clsSizeCodes project = new clsSizeCodes();

            project.strProject = cmbProjectID.Text;
            project.strUnitSizeCode = txtID.Text.Trim();
            project.strUnitSizeDescription = txtName.Text.Trim();
            project.strPrefix = txtPrefix.Text.Trim();
            project.strCurrentNumber = txtCurrentNumber.Text.Trim();
            project.UoMID = cmbUoM.Text.Trim();
            project.decArea = decArea;
            project.UoMDescription = "";
            project.ID = this.id;

            bool result = da.AddSizeCode(project);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadSizeCodes();

            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            id = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells["ID1"].Value);
            txtID.Text = dgList.Rows[e.RowIndex].Cells["UnitSizeCode"].Value.ToString();
            txtName.Text = dgList.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            txtArea.Text = dgList.Rows[e.RowIndex].Cells["Area"].Value.ToString();
            cmbUoM.Text = dgList.Rows[e.RowIndex].Cells["UoM"].Value.ToString();
            txtPrefix.Text = dgList.Rows[e.RowIndex].Cells["Prefix"].Value.ToString();
            txtCurrentNumber.Text = dgList.Rows[e.RowIndex].Cells["CurrentNumber"].Value.ToString();
            cmbProjectID.Text = dgList.Rows[e.RowIndex].Cells["Project"].Value.ToString();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            id = 0;
            txtID.Text = "";
            txtName.Text = "";
            txtPrefix.Text = "";
            txtCurrentNumber.Text = "";
            txtArea.Text = "";
        }
    }
}
