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
    public partial class frmUnitOfM : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsUnitofMeasure> lstUom = new List<clsUnitofMeasure>();

        public frmUnitOfM()
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

            lstUom = da.GetAllUOMsInfo();

            if (lstUom != null)
            {
                foreach (var Uom in lstUom)
                {
                    int index = dgList.Rows.Add();

                    dgList.Rows[index].Cells["SRNo"].Value = SRNo;
                    dgList.Rows[index].Cells["UOMID"].Value = Uom.strUOMid;
                    dgList.Rows[index].Cells["UOMName"].Value = Uom.strUOMDesc;
                    dgList.Rows[index].Cells["ID1"].Value = Uom.id;

                    SRNo++;
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("UOM id cannot be empty.");
                txtID.Focus();
                return;

            }
            if (txtDesc.Text.Trim() == "")
            {
                MessageBox.Show("UOM description cannot be empty.");
                txtDesc.Focus();
                return;                
            }
            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["UOMID"].Value.ToString().Trim().ToUpper() == txtID.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A unit of measure with same ID already exists.");
                    return;
                }

            }

            clsUnitofMeasure uom = new clsUnitofMeasure();
            uom.strUOMid = txtID.Text.Trim();
            uom.strUOMDesc = txtDesc.Text.Trim();
            uom.id = this.id;

            bool result = da.AddUOMInfo(uom);
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
            txtID.Text = dgList.Rows[e.RowIndex].Cells["UomID"].Value.ToString();
            txtDesc.Text = dgList.Rows[e.RowIndex].Cells["UomName"].Value.ToString();

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
