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
    public partial class frmTransferList : Form
    {
        DataAccess da = new DataAccess();
        public int intId { get; set; }
        public frmTransferList()
        {
            InitializeComponent();
        }

        private void frmTransferList_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
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
            List<clsTransferHistory> canmem = da.GetAllTransferHistoryList(null);


            if (canmem != null)
            {
                foreach (clsTransferHistory mem in canmem)
                {
                    int intRowIndex = dgList.Rows.Add();


                    dgList.Rows[intRowIndex].Cells["ID"].Value = mem.intID;
                    dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = mem.strRegistrationNo;
                    dgList.Rows[intRowIndex].Cells["TransferFromID"].Value = mem.strTransferFromID;
                    dgList.Rows[intRowIndex].Cells["TransferToID"].Value = mem.strTransferToID;
                    dgList.Rows[intRowIndex].Cells["TransferDate"].Value = mem.dtTransferDate.ToString("dd/MM/yyy");
                    dgList.Rows[intRowIndex].Cells["StatusDescription"].Value = mem.ApprovalStatusDescription;

                    //dgList.Rows[intRowIndex].Cells["strName"].Value = mem.strName;
                    //dgList.Rows[intRowIndex].Cells["FatherOrHusbandType"].Value = mem.strFatherOrHusbandType;
                    //dgList.Rows[intRowIndex].Cells["FatherOrHusbandName"].Value = mem.strFatherOrHusband;
                    //dgList.Rows[intRowIndex].Cells["CNIC"].Value = mem.strNIDOrCNIC;
                    //dgList.Rows[intRowIndex].Cells["Nationality"].Value = mem.strNationality;
                    //dgList.Rows[intRowIndex].Cells["DOB"].Value = mem.dtDOB.ToShortDateString();
                    //dgList.Rows[intRowIndex].Cells["CurrentAddress1"].Value = mem.strCurrentAddress1;
                    //dgList.Rows[intRowIndex].Cells["CurrentAddress2"].Value = mem.strCurrentAddress2;
                    //dgList.Rows[intRowIndex].Cells["CurrentAddress3"].Value = mem.strCurrentAddress3;
                    //dgList.Rows[intRowIndex].Cells["Country"].Value = mem.strCountry;
                    //dgList.Rows[intRowIndex].Cells["City"].Value = mem.strCity;
                    //dgList.Rows[intRowIndex].Cells["PhOff"].Value = mem.strPhOff;
                    //dgList.Rows[intRowIndex].Cells["Res"].Value = mem.strRes;
                    //dgList.Rows[intRowIndex].Cells["Mob"].Value = mem.strMob;
                    //dgList.Rows[intRowIndex].Cells["EmailAddress"].Value = mem.strEmailAddress;
                    //dgList.Rows[intRowIndex].Cells["ApprovalStatusCode"].Value = mem.ApprovalStatusCode;
                    //dgList.Rows[intRowIndex].Cells["ApprovalActionUser"].Value = mem.ApprovalActionUser;
                    //dgList.Rows[intRowIndex].Cells["ApprovalActionDate"].Value = mem.ApprovalActionDate.ToShortDateString();
                    //dgList.Rows[intRowIndex].Cells["CreatedBy"].Value = mem.CreatedBy;
                    //dgList.Rows[intRowIndex].Cells["CreationDate"].Value = mem.CreationDate.ToShortDateString();
                    //dgList.Rows[intRowIndex].Cells["LastUpdateUser"].Value = mem.LastUpdateUser;
                    //dgList.Rows[intRowIndex].Cells["LastUpdateDate"].Value = mem.LastUpdateDate.ToShortDateString();
                    
                }
            }

            if (canmem == null)
            {
                MessageBox.Show("No Record for approval");
            }

        }

        private void tsbtnLoad_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            intId = Convert.ToInt32(dgList.SelectedRows[0].Cells["ID"].Value);

            frmTransfer frm = new frmTransfer();
            frm.id = intId;
            frm.Show();
            this.Close();
            
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
