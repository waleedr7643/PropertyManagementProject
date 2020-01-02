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
    public partial class frmRecoveryTypes : Form
    {

        int id = 0;

        DataAccess da = new DataAccess();
        List<clsRecoveryType> lstRecoveryTypes = new List<clsRecoveryType>();

        public frmRecoveryTypes()
        {
            InitializeComponent();
        }
        private void frmRecoveryTypes_Load(object sender, EventArgs e)
        {
            LoadRecoveryTypes();
        }

        private void LoadRecoveryTypes()
        {
            dgList.Rows.Clear();

            int SRNo = 1;

            lstRecoveryTypes = da.GetRecoveryTypes();

            if (lstRecoveryTypes != null)
            {
                foreach (var recoveryType in lstRecoveryTypes)
                {
                    int index = dgList.Rows.Add();

                    dgList.Rows[index].Cells["SRNo"].Value = SRNo;

                    dgList.Rows[index].Cells["Code"].Value = recoveryType.strCode;
                    dgList.Rows[index].Cells["Desc"].Value = recoveryType.strDescription;
                    dgList.Rows[index].Cells["DueMonthly"].Value = recoveryType.bDueMonthly;
                    dgList.Rows[index].Cells["IncludeInTotal"].Value = recoveryType.bIncludeTotal;
                    dgList.Rows[index].Cells["ID1"].Value = recoveryType.intId;

                    SRNo++;
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a recovery type code.");
                txtName.Focus();
                return;

            }
            if (txtCNIC.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a recovery type name.");
                txtCNIC.Focus();
                return;                
            }

            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (dgr.Cells["Code"].Value.ToString().Trim().ToUpper() == txtName.Text.Trim().ToUpper() && this.id != Convert.ToInt32(dgr.Cells["ID1"].Value))
                {
                    MessageBox.Show("A recovery code with same name already exists.");
                    return;
                }
            }

            clsRecoveryType cat = new clsRecoveryType();
            cat.strCode = txtName.Text.Trim();
            cat.strDescription = txtCNIC.Text.Trim();
            cat.bDueMonthly = chkDueMonthly.Checked;
            cat.bIncludeTotal = chkIncludeTotal.Checked;
            cat.intId = this.id;

            bool result = da.AddRecoveryType(cat);
            if (result == false)
            {
                MessageBox.Show("An error occurred.");
                return;
            }

            LoadRecoveryTypes();

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
            txtName.Text = dgList.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            txtCNIC.Text = dgList.Rows[e.RowIndex].Cells["Desc"].Value.ToString();
            chkDueMonthly.Checked = Convert.ToBoolean(dgList.Rows[e.RowIndex].Cells["DueMonthly"].Value);
            chkIncludeTotal.Checked = Convert.ToBoolean(dgList.Rows[e.RowIndex].Cells["IncludeInTotal"].Value);

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
            txtName.Text = "";
            txtCNIC.Text = "";
            chkDueMonthly.Checked = false;
            chkIncludeTotal.Checked = false;
        }


    }
}
