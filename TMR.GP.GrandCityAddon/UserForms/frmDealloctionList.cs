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
    public partial class frmDealloctionList : Form
    {
        DataAccess da = new DataAccess();
        public frmDealloctionList()
        {
            InitializeComponent();
        }

        private void frmDealloctionList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            DataGridRefresh();
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Program._userid, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            // this.tsbSave.Enabled = userRights.AllowSave;
            // this.tsbApprove.Enabled = userRights.AllowPost;

        }
        public void DataGridRefresh()
        {

            bool approval = false;


            if (txtStatus.Text == "Approved" || txtStatus.Text == "approved")
            {
                approval = true;
            }
            if (txtStatus.Text == "unpproved" || txtStatus.Text == "Unpproved")
            {
                approval = false;
            }

            dgList.Rows.Clear();
            List<clsDeAllocation> canmem = da.GetAllDeallocationList();


            if (canmem != null)
            {
                foreach (clsDeAllocation mem in canmem)
                {
                    int intRowIndex = dgList.Rows.Add();
                    dgList.Rows[intRowIndex].Cells["Remarks"].Value = mem.Remarks;
                    dgList.Rows[intRowIndex].Cells["Approve"].Value = mem.Approved;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.ClientID;
                    dgList.Rows[intRowIndex].Cells["DeallocationDate"].Value = Convert.ToDateTime(mem.DeAllocationDate.ToShortDateString());
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationOrBookingNo;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;


                }
            }

            if (canmem == null)
            {
                MessageBox.Show("No Record for approval");
            }

        }

    }
}
