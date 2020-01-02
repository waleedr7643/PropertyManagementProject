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
    public partial class frmInstallmentPlanLookup : Form
    {

        public int strPlanId { get; set; }
        DataAccess da = new DataAccess();

        public frmInstallmentPlanLookup()
        {
            InitializeComponent();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dgList.Rows.Clear();

            int SRNo = 1;
            //clsUnitsFilter filter = new clsUnitsFilter();



            var list = da.GetInstallmentPlans();

            foreach (var item in list)
            {
                int rowIndex = dgList.Rows.Add();

                dgList.Rows[rowIndex].Cells["SRNo"].Value = SRNo;
                dgList.Rows[rowIndex].Cells["InstallmentPlanCode"].Value = item.strIntallmentPlanCode;
                dgList.Rows[rowIndex].Cells["InstallmentPlanName"].Value = item.strInstallmentPlanName;
                dgList.Rows[rowIndex].Cells["InstallmentPlanId"].Value = item.intId;

                SRNo++;
            }
        }
        private void frmUnitsLookUp_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            strPlanId = Convert.ToInt32(dgList.SelectedRows[0].Cells["InstallmentPlanId"].Value);
            this.DialogResult = DialogResult.OK;
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
