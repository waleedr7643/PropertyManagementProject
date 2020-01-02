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
    public partial class frmBlock : Form
    {
        int id = 0;

        DataAccess da = new DataAccess();
        List<clsBlock> LstBlock = new List<clsBlock>();
        List<clsUnitofMeasure> lstUnits = new List<clsUnitofMeasure>();
 
        public frmBlock()
        {
            InitializeComponent();
        }

        private void frmBlock_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            lstUnits = da.GetAllUOMsInfo();

            foreach (var unit in lstUnits)
                cmbUoM.Items.Add(unit.strUOMid);
            LoadProjects();
           
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
        private void LoadProjects()
        {
            List<clsProjects> lstProject = new List<clsProjects>();
            lstProject = da.GetAllProjectsInfo();

            foreach (var item in lstProject)
                cmbProjectID.Items.Add(item.strProjectid);
        }
        private void LoadBlocks()
        {            
            

            if (cmbProjectID.SelectedIndex == -1)
                return;

            dgBlockList.Rows.Clear();

            int SRNo = 1;

            LstBlock = da.GetBlocksByProjectNo(cmbProjectID.Text);

            if (LstBlock != null)
            {
                foreach (var item in LstBlock)
                {
                    int index = dgBlockList.Rows.Add();

                    dgBlockList.Rows[index].Cells["SRNo"].Value = SRNo;
                    dgBlockList.Rows[index].Cells["BlockNo"].Value = item.BlockNo;
                    dgBlockList.Rows[index].Cells["BlockName"].Value = item.BlockName;
                    dgBlockList.Rows[index].Cells["ProjectNo"].Value = item.ProjectID;

                    dgBlockList.Rows[index].Cells["UOMid"].Value = item.strUOMid;
                    dgBlockList.Rows[index].Cells["TotalArea"].Value = item.decTotalArea.ToString("N2");
                    dgBlockList.Rows[index].Cells["DecArea"].Value = item.decDevelopedArea.ToString("N2");

                    dgBlockList.Rows[index].Cells["ID1"].Value = item.id;

                    SRNo++;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBlockno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Block No Cannot Be Empty");
                txtBlockno.Focus();
                return;
            }

            if (txtBlockname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Block Name Cannot Be Empty");
                txtBlockname.Focus();
                return;
            }

            if (cmbProjectID.Text.Trim() == "")
            {
                MessageBox.Show("Project ID Cannot Be Empty");
                cmbProjectID.Focus();
                return;
            }

            if(cmbUoM.SelectedIndex == -1)
            {
                MessageBox.Show("An area unit must be selected");
                cmbUoM.Focus();
                return;
            }

           



            if (txtTotalArea.Text.Trim() == "")
            {
                MessageBox.Show("Total area must be enetered.");
                txtTotalArea.Focus();
                return;
            }
            if (txtDevArea.Text.Trim() == "")
            {
                MessageBox.Show("Developed area must be selected.");
                txtTotalArea.Focus();
                return;
            }

            foreach (DataGridViewRow dgr in dgBlockList.Rows)
            {
                if (dgr.Cells["ProjectNo"].Value.ToString().Trim().ToUpper() == cmbProjectID.Text.Trim().ToUpper()
                    && dgr.Cells["BlockNo"].Value.ToString().Trim().ToUpper() == txtBlockno.Text.Trim().ToUpper()
                    && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A block no with same ID already exists.");
                    return;
                }

            }

            clsBlock info = new clsBlock();
            decimal decResult = 0;
            
            bool b = decimal.TryParse(txtTotalArea.Text, out decResult);
            if (b == false)
            {
                MessageBox.Show("Total area is invalid.");
                txtTotalArea.Focus();
                return;
            }

            info.decTotalArea = decResult;

            b = decimal.TryParse(txtDevArea.Text, out decResult);
            if (b == false)
            {
                MessageBox.Show("Developed area is invalid.");
                txtDevArea.Focus();
                return;
            }

            info.decDevelopedArea = decResult;

            info.BlockNo = txtBlockno.Text;
            info.BlockName = txtBlockname.Text;
            info.ProjectID = cmbProjectID.Text;
            info.strUOMid = cmbUoM.Text;
            info.id = this.id;

            bool result = da.AddBlockInfo(info);
            if (result == false)
            {
                MessageBox.Show("An Error Occoured");
            }

            LoadBlocks();

            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
         private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void Clear()
        {
            txtBlockno.Text = "";
            txtBlockname.Text = "";
            txtDevArea.Text = "";
            txtTotalArea.Text = "";
            id = 0;
        }
        private void dgBlockList_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            txtBlockno.Text = dgBlockList.Rows[e.RowIndex].Cells["BlockNo"].Value.ToString();
            txtBlockname.Text = dgBlockList.Rows[e.RowIndex].Cells["BlockName"].Value.ToString();
            cmbProjectID.Text = dgBlockList.Rows[e.RowIndex].Cells["ProjectNo"].Value.ToString();
            cmbUoM.Text = dgBlockList.Rows[e.RowIndex].Cells["UOMid"].Value.ToString();
            txtTotalArea .Text = dgBlockList.Rows[e.RowIndex].Cells["TotalArea"].Value.ToString();
            txtDevArea.Text = dgBlockList.Rows[e.RowIndex].Cells["DecArea"].Value.ToString();


            id = Convert.ToInt32(dgBlockList.Rows[e.RowIndex].Cells["ID1"].Value);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBlocks();
        }
    }
}
