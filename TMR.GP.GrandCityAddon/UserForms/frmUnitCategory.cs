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
    public partial class frmUnitCategory : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsUnitCategory> lstUnitNature = new List<clsUnitCategory>();

        public frmUnitCategory()
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

            lstUnitNature = da.GetAllUnitCategoryInfo();

            if (lstUnitNature != null)
            {
                foreach (var nature in lstUnitNature)
                {
                    int index = dgList.Rows.Add();
                    dgList.Rows[index].Cells["UnitCategoryID"].Value = nature.strUnitCategoryID;
                    dgList.Rows[index].Cells["Description"].Value = nature.strDesc;
                    dgList.Rows[index].Cells["ID1"].Value = nature.id;
                    
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unit Category id cannot be empty.");
                txtID.Focus();
                return;

            }
            if (txtDesc.Text.Trim() == "")
            {
                MessageBox.Show("Description cannot be empty.");
                txtDesc.Focus();
                return;                
            }

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["UnitCategoryID"].Value.ToString().Trim().ToUpper() == txtID.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A unit category with same ID already exists.");
                    return;
                }

            }

            clsUnitCategory nature = new clsUnitCategory();
            nature.strUnitCategoryID = txtID.Text.Trim();
            nature.strDesc = txtDesc.Text.Trim();
            nature.id = this.id;

            bool result = da.AddUnitCategory(nature);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadProjects();

            Clear();
        }
        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            id = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells["ID1"].Value);
            txtID.Text = dgList.Rows[e.RowIndex].Cells["UnitCategoryID"].Value.ToString();
            txtDesc.Text = dgList.Rows[e.RowIndex].Cells["Description"].Value.ToString();

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
            txtDesc.Text = "";
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string SizeCode = txtID.Text;
            bool process = da.UnitCategoriesDeletion(SizeCode);
            if (process == true)
            {
                MessageBox.Show("Deletion Successful");
            }
            else if (process == false)
            {
                MessageBox.Show("Deletion UnSuccessful");
            }
        }

    }
}
