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
    public partial class frmSizeCodePriceList : Form
    {
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks;
        List<clsSizeCodes> lstSizecodes = new List<clsSizeCodes>();
        List<clsSizeCodePriceList> lstSizecodespl = new List<clsSizeCodePriceList>();
       

        public frmSizeCodePriceList()
        {
            InitializeComponent();
        }

        private void frmSizeCodePriceList_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            LoadProjects();
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
        public void LoadProjects()
        {
            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlock.Items.Clear();
            lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);

            cmbSizeCode.Items.Clear();
            lstSizecodes = da.GetAllSizeCodeInfoByProject(cmbProject.Text);
            foreach (var proj in lstSizecodes)
                cmbSizeCode.Items.Add(proj.strUnitSizeCode);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

           
            
            dgList.Rows.Clear();
            clsSizeCodePriceList cls = new clsSizeCodePriceList();
            cls.strProjectID = cmbProject.Text;
            cls.strBlockID = cmbBlock.Text;
            cls.strSizeCode = cmbSizeCode.Text;
            
                foreach (var sizeCodeP in lstSizecodespl)
                {
                    int index = dgList.Rows.Add();
                    //dgList.Rows[index].Cells["ProjectID"].Value = sizeCodeP.strProjectID;
                    //dgList.Rows[index].Cells["BlockID"].Value = sizeCodeP.strBlockID;
                    //dgList.Rows[index].Cells["SizeCode"].Value = sizeCodeP.strSizeCode;
                   
                    //dgList.Rows[index].Cells["Price"].Value = sizeCodeP.dPrice;
                   
                }
        }
    }
}
