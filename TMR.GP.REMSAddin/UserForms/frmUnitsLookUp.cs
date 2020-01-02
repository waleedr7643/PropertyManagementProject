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
    public partial class frmUnitsLookUp : Form
    {

        public string strProject { get; set; }
        public string strBlock { get; set; }
        public string strSizeCode { get; set; }

        public string strunitID { get; set; }


        public unitLookupCodes unitLookupCode { get; set; }
        DataAccess da = new DataAccess();
        List<clsProjects> lstprojects = new List<clsProjects>();
        List<clsBlock> lstBlocks = new List<clsBlock>();
        List<clsSizeCodes> lstSizecodes = new List<clsSizeCodes>();
        List<clsUnit> units = new List<clsUnit>();



        public frmUnitsLookUp()
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
            
            string strProjectID = cmbProject.Text.Trim();
            string strBlockNo = cmbBlock.Text.Trim();


            string strStreet = "", strPlot = "";
            if (cmbSearchBy.Text == "Street")
                strStreet = txtSearchby.Text;
            else if (cmbSearchBy.Text == "Plot")
                strPlot = txtSearchby.Text;


            LoadCombobox();

            string strSizeCode = cmbSizeCode.Text.Trim();

            cmbSizeCode.Text = strSizeCode;

            var list = da.GetAvailableUnitsByProjectBlockSizeCode(strProjectID, strBlockNo, strSizeCode, strStreet, strPlot);

            foreach (var item in list)
            {
                int rowIndex = dgList.Rows.Add();
                dgList.Rows[rowIndex].Cells["SRNo"].Value = SRNo;
                dgList.Rows[rowIndex].Cells["Status"].Value = item.strStatus;
                dgList.Rows[rowIndex].Cells["UnitID"].Value = item.strUnitID;
                dgList.Rows[rowIndex].Cells["StreetNo"].Value = item.strStreetNo;
                dgList.Rows[rowIndex].Cells["PlotNo"].Value = item.strPlotNo;
                dgList.Rows[rowIndex].Cells["SizeCode"].Value = item.strSizeCode;
                dgList.Rows[rowIndex].Cells["UnitCategoryID"].Value = item.strUnitCategoryID;
                dgList.Rows[rowIndex].Cells["UnitTypeID"].Value = item.strUnitTypeID;
                dgList.Rows[rowIndex].Cells["Price"].Value = item.decPrice.ToString();
                dgList.Rows[rowIndex].Cells["Area"].Value = item.decArea.ToString();

                SRNo++;

            }
        }

        public void LoadCombobox()
        {
            units = da.GetAvailableUnits(cmbProject.Text, cmbBlock.Text);
            if (units == null)
            {
                return;
            }
            foreach (var unit in units)
                cmbSizeCode.Items.Add(unit.strSizeCode);
        }
        /// <summary>
        /// /Get Availabale Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            //units = da.GetAvailableUnits(cmbProject.Text, cmbBlock.Text);
            //if (units == null)
            //{
            //    return;
            //}
            //foreach (var unit in units)
            //    cmbSizeCode.Items.Add(unit.strSizeCode);

        }

        private void frmUnitsLookUp_Load(object sender, EventArgs e)
        {
            LoadFunction();
            PopulateGrid();
        }

        private void LoadFunction()
        {


            lstprojects = da.GetAllProjectsInfo();
            foreach (var project in lstprojects)
                cmbProject.Items.Add(project.strProjectid);
            cmbProject.Text = strProject;

            lstBlocks = da.GetBlocksByProjectNo(strProject);
            foreach (var block in lstBlocks)
                cmbBlock.Items.Add(block.BlockNo);
            cmbBlock.Text = strBlock;

            lstSizecodes = da.GetAllSizeCodes();
            foreach (var sizecode in lstSizecodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);

            cmbSizeCode.Text = strSizeCode;





        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbBlock.Text = "";
            //cmbBlock.Items.Clear();
            //lstBlocks = da.GetBlocksByProjectNo(cmbProject.Text);
            //foreach (var block in lstBlocks)
            //    cmbBlock.Items.Add(block.BlockNo);
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (dgList.SelectedRows.Count == 0)
                return;
            strunitID = dgList.SelectedRows[0].Cells["UnitID"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
