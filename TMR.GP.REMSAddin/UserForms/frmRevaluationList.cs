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
    public partial class frmRevaluationList : Form
    {
        public int intid { get; set; }
        DataAccess da = new DataAccess();
        public frmRevaluationList()
        {
            InitializeComponent();
        }

        public void DataGridRefresh()
        {
            dgList.Rows.Clear();
            int SRNo = 1;
            List<clsUnitRevaluation> REAVLst = da.GetRevaluationList();


            if (REAVLst != null)
            {
                foreach (clsUnitRevaluation Reav in REAVLst)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["SRNo"].Value = SRNo;

                    dgList.Rows[intRowIndex].Cells["ProjectID"].Value = Reav.strProject;
                    dgList.Rows[intRowIndex].Cells["BlockID"].Value = Reav.strBlock;
                    dgList.Rows[intRowIndex].Cells["ReavaluationDate"].Value = Reav.dateRevaluationDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = Reav.ApprovalStatusDescription;
                    dgList.Rows[intRowIndex].Cells["id"].Value = Reav.id;

                    SRNo++;

                }
            }

            if (REAVLst == null)
            {
                MessageBox.Show("No Record for approval");
            }

        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            intid = Convert.ToInt32(dgList.SelectedRows[0].Cells["id"].Value);

            frmUnitRevaluation revaluation = new frmUnitRevaluation();
            revaluation.id = intid;
            revaluation.Show();
            this.Close();
        }

        private void frmReavaluationList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            DataGridRefresh();
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Microsoft.Dexterity.Applications.Dynamics.Globals.UserId, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            // this.tsbSave.Enabled = userRights.AllowSave;
            // this.tsbApprove.Enabled = userRights.AllowPost;

        }
        private void tsbClear_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
