using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMR.GP.GrandCityAddon.UserForms
{
    public partial class frmUnsentToGPList : Form
    {

        public int intid { get; set; }
        DataAccess da = new DataAccess();
        public frmUnsentToGPList()
        {
            InitializeComponent();
        }

        private void frmUnsentToGPList_Load(object sender, EventArgs e)
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

            dgList.Rows.Clear();
            List<clsMemberRegistration> canmem = da.GetAllUnSentToGP();


            if (canmem != null)
            {
                foreach (clsMemberRegistration mem in canmem)
                {
                    int intRowIndex = dgList.Rows.Add();

                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.RegistrationNo;
                    dgList.Rows[intRowIndex].Cells["ClientID"].Value = mem.ClientID;
                    dgList.Rows[intRowIndex].Cells["CName"].Value = mem.Name;
                    dgList.Rows[intRowIndex].Cells["Booking"].Value = mem.Booking.ToShortDateString();
                    dgList.Rows[intRowIndex].Cells["ProjectID"].Value = mem.strProjectid;
                    dgList.Rows[intRowIndex].Cells["Plan"].Value = mem.Plan;
                    dgList.Rows[intRowIndex].Cells["id"].Value = mem.id;

                }
            }

            if (canmem == null)
            {
                MessageBox.Show("No Record for approval");
            }

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgList.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["Select"].Value) == false)
                    continue;

                int id = Convert.ToInt32(dgr.Cells["id"].Value);
                var member = da.GetMemberRegistrationInfoById(id);

                var result = da.CreateGPCustomer(member);
               
                if (result == false)
                {
                    MessageBox.Show("Record could not be created.");
                    return;
                }

                if (result == true)
                {
                    bool sendToGp = da.UpdateSendToGPStatus(id);

                    if (sendToGp == false)
                    {
                        MessageBox.Show("Faild to Update.");
                        return;
                    }
                }
                MessageBox.Show("Record successfully created in Customer Database.");


            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
           // this.Close();
        }
    }
}
