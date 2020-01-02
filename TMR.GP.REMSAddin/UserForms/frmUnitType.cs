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
    public partial class frmUnitType : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsUnitType> lstUnitCategory = new List<clsUnitType>();

        public frmUnitType()
        {
            InitializeComponent();
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
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
            dgList.Rows.Clear();

            int SRNo = 1;

            lstUnitCategory = da.GetAllUnitTypeInfo();

            if (lstUnitCategory != null)
            {
                foreach (var nature in lstUnitCategory)
                {
                    int index = dgList.Rows.Add();
                    dgList.Rows[index].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[index].Cells["UnitTypeID"].Value = nature.strUnitTypeID;
                    dgList.Rows[index].Cells["Description"].Value = nature.strDesc;
                    dgList.Rows[index].Cells["ID1"].Value = nature.id;

                    SRNo++;
                    
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
                if (dgr.Cells["UnitTypeID"].Value.ToString().Trim().ToUpper() == txtID.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A unit type with same ID already exists.");
                    return;
                }

            }

            clsUnitType cat = new clsUnitType();
            cat.strUnitTypeID = txtID.Text.Trim();
            cat.strDesc = txtDesc.Text.Trim();
            cat.id = this.id;

            bool result = da.AddUnitType(cat);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadProjects();

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
            txtID.Text = dgList.Rows[e.RowIndex].Cells["UnitTypeID"].Value.ToString();
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


    }
}
