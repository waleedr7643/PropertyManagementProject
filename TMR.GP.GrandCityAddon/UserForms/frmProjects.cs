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
    public partial class frmProjects : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsProjects> lstProject = new List<clsProjects>();
        List<clsBlock> lstblocks = new List<clsBlock>();

        public frmProjects()
        {
            InitializeComponent();
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            if (SetUserSecurity() == true)
            {
                LoadProjects();
            }
        }
        private bool SetUserSecurity()
        {
            bool access = false;
            var userRights = da.GetUserRightsByUserID(Program._userid, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                access = false;
                this.Close();

            }
            else
            {
                this.tsbSave.Enabled = userRights.AllowSave;
                //this.tsbApprove.Enabled = userRights.AllowPost;
                access = true;
            }
                return access;
        }
        private void LoadProjects()
        {
            dgList.Rows.Clear();

            lstProject = da.GetAllProjectsInfo();

            if (lstProject != null)
            {
                foreach (var project in lstProject)
                {
                    int index = dgList.Rows.Add();
                    dgList.Rows[index].Cells["ProjectID"].Value = project.strProjectid;
                    dgList.Rows[index].Cells["ProjectName"].Value = project.strProjectName;
                    dgList.Rows[index].Cells["SubProject"].Value = project.bSubProject;
                    dgList.Rows[index].Cells["MainProjectID"].Value = project.strMainProjecID;
                    dgList.Rows[index].Cells["Location"].Value = project.strLocation;
                    dgList.Rows[index].Cells["Prefix"].Value = project.strPrefix;
                    dgList.Rows[index].Cells["CurrentNumber"].Value = project.strNumber;

                    dgList.Rows[index].Cells["ID1"].Value = project.id;

                }
            }
        }
        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            id = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells["ID1"].Value);
            txtID.Text = dgList.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString();
            txtName.Text = dgList.Rows[e.RowIndex].Cells["ProjectName"].Value.ToString();

            txtCurrentNumber.Text = dgList.Rows[e.RowIndex].Cells["CurrentNumber"].Value.ToString();
            txtPrefix.Text = dgList.Rows[e.RowIndex].Cells["Prefix"].Value.ToString();

            chkBoxSubProject.Checked = Convert.ToBoolean(dgList.Rows[e.RowIndex].Cells["SubProject"].Value);
            cmbMainProject.Text = dgList.Rows[e.RowIndex].Cells["MainProjectID"].Value.ToString();
            cmbBlock.Text = dgList.Rows[e.RowIndex].Cells["Location"].Value.ToString();

        }
        private void Clear()
        {
            id = 0;
            txtID.Text = "";
            txtName.Text = "";
            chkBoxSubProject.Checked = false;
            cmbMainProject.Text = "";
            cmbBlock.Text = "";
            txtCurrentNumber.Clear();
            txtPrefix.Clear();
        }
        private void chkBoxSubProject_Click(object sender, EventArgs e)
        {

        }
        private void cmbMainProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            if (chkBoxSubProject.Checked == false)
                return;

            cmbBlock.Enabled = true;
            lstblocks = da.GetBlocksByProjectNo(cmbMainProject.Text);
            foreach (var block in lstblocks)
                cmbBlock.Items.Add(block.BlockNo);
        }
        private void chkBoxSubProject_CheckedChanged(object sender, EventArgs e)
        {
            cmbMainProject.Items.Clear();

            if (chkBoxSubProject.Checked == true)
            {
                cmbMainProject.Enabled = true;
                lstProject = da.GetMainProjects(false);

                foreach (var project in lstProject)
                    cmbMainProject.Items.Add(project.strProjectid);

            }
            else if (chkBoxSubProject.Checked == false)
            {
                cmbMainProject.Enabled = false;
                cmbMainProject.Text = "";
                cmbBlock.Text = "";
                cmbMainProject.Items.Clear();
                cmbMainProject.Enabled = false;
                cmbBlock.Items.Clear();
                cmbBlock.Enabled = false;
                id = 0;

            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Project id cannot be empty.");
                txtID.Focus();
                return;

            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Project name cannot be empty.");
                txtName.Focus();
                return;
            }

            if (txtCurrentNumber.Text == "")
            {
                MessageBox.Show("Current number cannot be empty.");
                txtCurrentNumber.Focus();
                return;
            }

            if (txtPrefix.Text == "")
            {
                MessageBox.Show("Prefix cannot be empty.");
                txtPrefix.Focus();
                return;
            }

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["ProjectID"].Value.ToString().Trim().ToUpper() == txtID.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A project with same ID already exists.");
                    return;
                }

            }

            clsProjects project = new clsProjects();
            project.strProjectid = txtID.Text.Trim();
            project.strProjectName = txtName.Text.Trim();
            project.strPrefix = txtPrefix.Text.Trim();
            project.strNumber = txtCurrentNumber.Text.Trim();
            project.id = this.id;


            project.bSubProject = chkBoxSubProject.Checked;


            if (chkBoxSubProject.Checked == true)
            {
                if (cmbMainProject.Text == "")
                {
                    MessageBox.Show("Select Main Project.");
                    return;
                }

                if (cmbBlock.Text == "")
                {
                    MessageBox.Show("Select Location.");
                    cmbBlock.Focus();
                    return;
                }
            }

            project.strMainProjecID = cmbMainProject.Text;
            project.strLocation = cmbBlock.Text;


            bool result = da.AddProjectInfo(project);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadProjects();

            Clear();
        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string projectid = txtID.Text;
            bool process = da.ProjectsDeletion(projectid);

            if (process == true)
            {
                MessageBox.Show("Deletion Successful");
            }
            else if (process == false)
            {
                MessageBox.Show("Deletion Unsuccessfull");
            }
        }

    }
}
