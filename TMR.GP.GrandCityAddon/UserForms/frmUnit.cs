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
    public partial class frmUnit : Form
    {

        int id = 0;      
        string strNumber = "", strPrefix = "";
        DataAccess da = new DataAccess();
        List<clsProjects> lstProjects;
        List<clsSizeCodes> lstSizeCodes;
        List<clsUnitType> lstUnitType;
        List<clsUnitCategory> lstUnitCategory;
        List<clsBlock> lstBlocks;

        public frmUnit()
        {
            InitializeComponent();
        }
        private void frmUnit_Load(object sender, EventArgs e)
        {
            SetUserSecurity();
            LoadGrid();
            LoadComboBoxData();
        }
        private void SetUserSecurity()
        {
            var userRights = da.GetUserRightsByUserID(Program._userid, this.GetType().Name);
            if (userRights.AllowOpen == false)
            {
                MessageBox.Show("User is not authorized to open this form.");
                this.Close();
            }

            this.tsbSave.Enabled = userRights.AllowSave;
            //this.tsbApprove.Enabled = userRights.AllowPost;

        }
        private void LoadGrid()
        {
            

            dgList.Rows.Clear();
            if (cmbProjectID.SelectedIndex == -1)
                return;

            List<clsUnit> units = da.GetAllUnitsByProjectID(cmbProjectID.Text);
            foreach (clsUnit unit in units)
            {
                int intRowIndex = dgList.Rows.Add();
                dgList.Rows[intRowIndex].Cells["ProjectID"].Value = unit.strProjectID;
                dgList.Rows[intRowIndex].Cells["BlockID"].Value = unit.strBlockNo;
                dgList.Rows[intRowIndex].Cells["UnitID"].Value = unit.strUnitID;
                dgList.Rows[intRowIndex].Cells["Street"].Value = unit.strStreetNo;
                dgList.Rows[intRowIndex].Cells["PlotNo"].Value = unit.strPlotNo;
                dgList.Rows[intRowIndex].Cells["UnitCategoryID"].Value = unit.strUnitCategoryID;
                dgList.Rows[intRowIndex].Cells["UnitTypeID"].Value = unit.strUnitTypeID;
                dgList.Rows[intRowIndex].Cells["SizeCode"].Value = unit.strSizeCode;
                dgList.Rows[intRowIndex].Cells["Area"].Value = unit.decArea.ToString("N2");
                dgList.Rows[intRowIndex].Cells["UomID"].Value = unit.strUOMID;
                dgList.Rows[intRowIndex].Cells["Width"].Value = unit.decWidth.ToString("N2");
                dgList.Rows[intRowIndex].Cells["Length"].Value = unit.decLength.ToString("N2");
                dgList.Rows[intRowIndex].Cells["Price"].Value = unit.decPrice.ToString("N2");
                dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value = unit.strRegistrationNo;
                dgList.Rows[intRowIndex].Cells["Status"].Value = unit.strStatus;
                dgList.Rows[intRowIndex].Cells["ID1"].Value = unit.ID;
            }

        }
        private void LoadComboBoxData()
        {
            lstProjects = da.GetAllProjectsInfo();
            foreach (var proj in lstProjects)
                cmbProjectID.Items.Add(proj.strProjectid);

            

            lstUnitType = da.GetAllUnitTypeInfo();
            foreach (var proj in lstUnitType)
                cmbUnitType.Items.Add(proj.strUnitTypeID);

            lstUnitCategory = da.GetAllUnitCategoryInfo();
            foreach (var proj in lstUnitCategory)
                cmbUnitCategory.Items.Add(proj.strUnitCategoryID);
        }
        private void cmbSizeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSizeCode.SelectedIndex == -1)
                return;

            var selectedRecord = lstSizeCodes.Where(x => x.strUnitSizeCode == cmbSizeCode.Text);
            if (selectedRecord != null)
            {
                txtArea.Text = selectedRecord.First().decArea.ToString();
                txtUom.Text = selectedRecord.First().UoMID;
            }

            GenerateUnitID();
        }
        private void GenerateUnitID()
        {
            if (id != 0)
                return;
            if (cmbProjectID.Text == "" || cmbSizeCode.Text == "")
                return;
            var sizeCode = da.GetSizeCodeInfoByProjectandSizeCode(cmbProjectID.Text, cmbSizeCode.Text);

            txtUnitID.Text = sizeCode.strPrefix + sizeCode.strCurrentNumber;

            strPrefix = sizeCode.strPrefix;
            strNumber = sizeCode.strCurrentNumber;

        }
        private void cmbProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBlockID.Items.Clear();
            lstBlocks = da.GetBlocksByProjectNo(cmbProjectID.Text);
            foreach (var block in lstBlocks)
                cmbBlockID.Items.Add(block.BlockNo);
            
            cmbSizeCode.Items.Clear();
            lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProjectID.Text);
            foreach (var proj in lstSizeCodes)
                cmbSizeCode.Items.Add(proj.strUnitSizeCode);

            LoadGrid();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {



            decimal outResult = 0;
            bool bResult = false;
            bResult = decimal.TryParse(txtWidth.Text, out outResult);

            if (bResult == false)
            {
                MessageBox.Show("Please specify a valid width.");
                return;
            }
            bResult = decimal.TryParse(txtArea.Text, out outResult);

            if (bResult == false)
            {
                MessageBox.Show("Please specify a valid area.");
                return;
            }
            bResult = decimal.TryParse(txtLength.Text, out outResult);

            if (bResult == false)
            {
                MessageBox.Show("Please specify a valid length.");
                return;
            }
            bResult = decimal.TryParse(txtPrice.Text, out outResult);

            if (bResult == false)
            {
                MessageBox.Show("Please specify a valid price.");
                return;
            }

            if (cmbProjectID.Text == "")
            {
                MessageBox.Show("Please select a project.");
                return;
            }
            if (cmbBlockID.Text == "")
            {
                MessageBox.Show("Please select a block.");
                return;
            }
            if (cmbUnitType.Text == "")
            {
                MessageBox.Show("Please select a valid category.");
                return;
            }
            if (cmbUnitCategory.Text == "")
            {
                MessageBox.Show("Please select a valid nature.");
                return;
            }
            if (txtUnitID.Text == "")
            {
                MessageBox.Show("Please enter a valid unit id.");
                return;
            }

            if (id == 0)
                txtStatus.Text = "Available";

            bool b = da.GetUnitIDAvailability(txtUnitID.Text);

            if (b == false)
            {
                MessageBox.Show("The unit id has already been used. Please enter a new unit id");
                return;
            }

            clsUnit unit = new clsUnit()
            {
                strUnitTypeID = cmbUnitType.Text,
                strNumber = strNumber,
                strPrefix = strPrefix,
                strRegistrationNo = txtRegistrationNo.Text,
                strBlockNo = cmbBlockID.Text,
                strProjectID = cmbProjectID.Text,
                strSizeCode = cmbSizeCode.Text,
                strStatus = txtStatus.Text,
                strStreetNo = txtStreetNo.Text,
                strPlotNo = txtPlotNo.Text,
                strUnitID = txtUnitID.Text,
                strUnitCategoryID = cmbUnitCategory.Text,
                decWidth = Convert.ToDecimal(txtWidth.Text),
                decLength = Convert.ToDecimal(txtLength.Text),
                strUOMID = txtUom.Text,
                decPrice = Convert.ToDecimal(txtPrice.Text),
                decArea = Convert.ToDecimal(txtArea.Text),
                

                ID = this.id
            };

            if (this.id == 0)
                unit.statuscode = (int)unitLookupCodes.Available;

            bool result = da.AddUnit(unit);

            LoadGrid();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {

            cmbUnitType.Text = "";
            strNumber = "";
            strPrefix = "";
            txtRegistrationNo.Text = "";
            cmbBlockID.Text = "";
            cmbProjectID.Text = "";
            cmbSizeCode.Text = "";
            txtStatus.Text = "";
            txtStreetNo.Text = "";
            txtPlotNo.Text = "";
            txtUnitID.Text = "";
            cmbUnitCategory.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            //txtUom.Text = "";
            txtPrice.Text = "0.00";
           // txtArea.Text = "";

            id = 0;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int intRowIndex = e.RowIndex;
            cmbProjectID.Text = dgList.Rows[intRowIndex].Cells["ProjectID"].Value.ToString();
            cmbBlockID.Text = dgList.Rows[intRowIndex].Cells["BlockID"].Value.ToString();
            txtUnitID.Text = dgList.Rows[intRowIndex].Cells["UnitID"].Value.ToString();
            txtStreetNo.Text = dgList.Rows[intRowIndex].Cells["Street"].Value.ToString();
            txtPlotNo.Text = dgList.Rows[intRowIndex].Cells["PlotNo"].Value.ToString();
            cmbUnitCategory.Text = dgList.Rows[intRowIndex].Cells["UnitCategoryID"].Value.ToString();
            cmbUnitType.Text = dgList.Rows[intRowIndex].Cells["UnitTypeID"].Value.ToString();
            cmbSizeCode.Text = dgList.Rows[intRowIndex].Cells["SizeCode"].Value.ToString();
            txtArea.Text = dgList.Rows[intRowIndex].Cells["Area"].Value.ToString();
            txtUom.Text = dgList.Rows[intRowIndex].Cells["UomID"].Value.ToString();
            txtWidth.Text = dgList.Rows[intRowIndex].Cells["Width"].Value.ToString();
            txtLength.Text = dgList.Rows[intRowIndex].Cells["Length"].Value.ToString();
            txtPrice.Text = dgList.Rows[intRowIndex].Cells["Price"].Value.ToString();
            txtRegistrationNo.Text = dgList.Rows[intRowIndex].Cells["RegistrationNo"].Value.ToString();
            txtStatus.Text = dgList.Rows[intRowIndex].Cells["Status"].Value.ToString();           
            id = Convert.ToInt32(dgList.Rows[intRowIndex].Cells["ID1"].Value);
        }

        private void frmUnit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string unitid = txtUnitID.Text;
            bool process = da.UnitsDeletion(txtUnitID.Text);
            if (process == true)
            {
                MessageBox.Show("Deletion Successful");
            }
            else if (process == false)
            {
                MessageBox.Show("Deletion UnSuccessful");
            }
        }

       
    }
}
