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
using TMR.GP.REMSDal.EntityClasses;


namespace TMR.GP.REMSAddin
{
    public partial class frmSecurityObject : Form
    {

        List<clsSecurityObject> lstSec;
        List<clsUserSecurity> lst;
        
        DataAccess da = new DataAccess();
        public frmSecurityObject()
        {
            InitializeComponent();
        }

        private void frmSecurityObject_Load(object sender, EventArgs e)
        {
            LoadObjects();
            GetUserId();
        }

        private void LoadObjects()
        {
            cmbCategory.Items.Add("All");
            lstSec = da.GetObjectNameandObjectAreaFromObjectSecurity();
            foreach (var Object in lstSec)
                cmbCategory.Items.Add(Object.ObjectArea);
        }

        private void GetUserId()
        {
            lst = da.GetUserIdList();
            foreach(var item in lst)
            {
                cmbUserid.Items.Add(item.UserId);
            }
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmbUserid.Focus();
           dgList.Rows.Clear();
        }

        private void cmbUserid_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateGrid(cmbCategory.SelectedItem.ToString(), cmbUserid.SelectedItem.ToString());
        }

        private void PopulateGrid(string value,string userid)
        {
            dgList.Rows.Clear();

            var list = da.GetObjectSecurityByObjectNameAndUserID(value, userid);

            foreach (var item in list)
            {
                int rowIndex = dgList.Rows.Add();
                dgList.Rows[rowIndex].Cells["TaskName"].Value = item.ObjectName;
                dgList.Rows[rowIndex].Cells["AllowOpen"].Value = item.AllowOpen;
                dgList.Rows[rowIndex].Cells["AllowSave"].Value = item.AllowSave;
                dgList.Rows[rowIndex].Cells["AllowApprove"].Value = item.AllowPost;
                dgList.Rows[rowIndex].Cells["AllowPrint"].Value = item.AllowPrint;
            }
        }

        
    }
}
