using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSAddin.UserForms;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{
    public partial class frmProspect : Form
    {

        bool bEdit = false;
        DataAccess da = new DataAccess();
        List<clsProjects> lstProject;
        List<clsBlock> lstBlocks;
        List<clsSizeCodes> lstSizeCodes;


        public enum ReportCategory { ProspectReport }
        public ReportCategory Reporcategory { get; set; }

        int prosid { get; set; }

        public frmProspect()
        {
            InitializeComponent();
        }

        private void frmProspect_Load(object sender, EventArgs e)
        {
            LoadProjects();
            LoadSectors();
            LoadSizeCodes();

        }

        private void LoadProjects()
        {
            lstProject = da.GetAllProjectsInfo();
            foreach (var item in lstProject)
                cmbProjects.Items.Add(item.strProjectid);
            if (cmbProjects.Items.Count != 0)
                cmbProjects.SelectedIndex = 0;



            //Clear();
        }

        private void LoadSectors()
        {
            cmbSector.Items.Clear();
            if (cmbProjects.SelectedIndex == -1)
                return;
            lstBlocks = da.GetBlocksByProjectNo(cmbProjects.Text);
            foreach (var sizecode in lstBlocks)
                cmbSector.Items.Add(sizecode.BlockNo);

        }

        private void LoadSizeCodes()
        {
            cmbSizeCode.Items.Clear();

            lstSizeCodes = da.GetAllSizeCodeInfoByProject(cmbProjects.Text);
            foreach (var sizecode in lstSizeCodes)
                cmbSizeCode.Items.Add(sizecode.strUnitSizeCode);
        }

        bool result;

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (cmbProjects.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Project Cannot Be Empty");
                cmbProjects.Focus();
                return;
            }
            if (cmbSector.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Sector Cannot Be Empty");
                cmbSector.Focus();
                return;
            }
            if (txtUnit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unit Cannot Be Empty");
                txtName.Focus();
                return;
            }

            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prospect Name Cannot Be Empty");
                txtName.Focus();
                return;
            }

            if (txtFather.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prospect Father Name Cannot Be Empty");
                txtFather.Focus();
                return;
            }
            if (txtCNIC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("NIC Cannot Be Empty");
                txtCNIC.Focus();
                return;
            }

            if (txtContact.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Contact Cannot Be Empty");
                txtContact.Focus();
                return;
            }
            //if (cmbProspectPaymentPlan.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Prospect Payment Plan Cannot Be Empty");
            //    cmbProspectPaymentPlan.Focus();
            //    return;
            //}


            var info1 = new clsProspect();

            info1.ProjectNo = cmbProjects.Text.Trim();
            info1.Sector = cmbSector.Text;
            info1.UPlot = txtUnit.Text;
            info1.UnitType = txtUnitType.Text;
            info1.UnitAdditionalChrg = Convert.ToDecimal(txtChargesPercentage.Text);
            info1.UnitCategory = txtUnitCategory.Text;

            info1.PlotPrice = Convert.ToDecimal(txtPlotPrice.Text);
            info1.PlotAdditionalCharges = Convert.ToDecimal(txtPlotTypeCharges.Text);

            info1.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            info1.Discount = Convert.ToDecimal(txtDiscount.Text);



            info1.ProspectName = txtName.Text;
            info1.ProspectFatherName = txtFather.Text;
            info1.CNIC = txtCNIC.Text;
            info1.ContactNo = txtContact.Text;
            info1.ProspectPaymentPlan = cmbProspectPaymentPlan.Text;
            info1.SizeCode = cmbSizeCode.Text;
            info1.ProspectStartDate = dTPProspectStartDate.Value;
            info1.id = prosid;

            result = da.AddProspectPlan(info1);
            if (result == false)
            {
                MessageBox.Show("An Error Occoured.");
                return;
            }
            else Clear();


        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear();
            LoadSectors();
            LoadSizeCodes();
            if (bEdit == true)
            {
                return;
            }

            if (cmbProjects.SelectedIndex == -1)
                return;
        }

        private void Clear()
        {
            cmbProjects.SelectedIndex = -1;
            cmbSector.SelectedIndex = -1;
            txtUnit.Text = "";
            cmbSizeCode.SelectedIndex = -1;
            txtUnit.Text = "";
            txtUnitCategory.Text = "";
            txtUnitType.Text = "";
            txtPlotPrice.Text = "";
            txtPlotTypeCharges.Text = "";
            txtTotalPrice.Text = "";
            txtDiscount.Text = "";
            txtName.Text = "";
            txtFather.Text = "";
            txtContact.Text = "";
            txtCNIC.Text = "";
            dTPProspectStartDate.Text = "";
            cmbProspectPaymentPlan.SelectedIndex = -1;
            txtNetPrice.Text = "0.00";
        }

        private void btnUnitSelect_Click(object sender, EventArgs e)
        {
            frmUnitsLookUp lookup = new frmUnitsLookUp();
            lookup.strProject = cmbProjects.Text;
            lookup.strBlock = cmbSector.Text;
            lookup.strSizeCode = cmbSizeCode.Text;


            if (lookup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUnit.Text = lookup.strunitID;

                clsUnit unit = da.GetUnitByUnitID(txtUnit.Text);

                if (unit == null)
                    return;
                decimal decPlotPrice = 0, decPlotCharges = 0, decPlotChargesPerc = 0;
                decPlotPrice = unit.decPrice;


                txtPlotPrice.Text = decPlotPrice.ToString("N2");

                txtUnitType.Text = unit.strUnitTypeID;
                txtUnitCategory.Text = unit.strUnitCategoryID;

                if (unit.strUnitTypeID == "GENERAL")
                    txtChargesPercentage.Text = 0.ToString("N2");
                else if (unit.strUnitTypeID == "PARK FACE" || unit.strUnitTypeID == "WIDE ROAD" || unit.strUnitTypeID == "CORNER")
                {
                    decPlotChargesPerc = 10;
                    txtChargesPercentage.Text = 10.ToString("N2");
                }
                else if (unit.strUnitTypeID == "P. F. CORNER" || unit.strUnitTypeID == "WIDE ROAD +PARK FACE" || unit.strUnitTypeID == "WD.ROAD+CORNER")
                {
                    decPlotChargesPerc = 20;
                    txtChargesPercentage.Text = 20.ToString("N2");
                }

                txtPlotPrice.Text = decPlotPrice.ToString("N2");
                decPlotCharges = decPlotPrice * decPlotChargesPerc / 100;
                txtPlotTypeCharges.Text = decPlotCharges.ToString("N2");
                txtTotalPrice.Text = (decPlotPrice + decPlotCharges).ToString("N2");

                SetNetPrice();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProspectLookup frm = new frmProspectLookup();
            frm.strProject = cmbProjects.Text;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                prosid = frm.prosid;
                LoadInformation();
                //txtRegistrationNo.Focus();
                //btnSelect.Focus();
            }
        }

        private void LoadInformation()
        {
            var item = da.GetProspectByID(prosid);

            if (item == null)
                return;
            cmbProjects.Text = item.ProjectNo;
            cmbSector.Text = item.Sector;
            txtUnit.Text = item.UPlot;
            cmbSizeCode.Text = item.SizeCode;
            txtName.Text = item.ProspectName;
            txtFather.Text = item.ProspectFatherName;
            txtCNIC.Text = item.CNIC;
            txtContact.Text = item.ContactNo;
            cmbProspectPaymentPlan.Text = item.ProspectPaymentPlan;
            txtUnitType.Text = item.UnitType;
            txtUnitCategory.Text = item.UnitCategory;
            txtChargesPercentage.Text = Convert.ToString(item.UnitAdditionalChrg);
            txtPlotPrice.Text = Convert.ToString(item.PlotPrice);
            txtPlotTypeCharges.Text = Convert.ToString(item.PlotAdditionalCharges);
            txtTotalPrice.Text = Convert.ToString(item.TotalPrice);
            txtDiscount.Text = Convert.ToString(item.Discount);

            SetNetPrice();
        }

        private void cmbSizeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaymentPlans();
        }
        private void LoadPaymentPlans()
        {
            if (cmbProjects.SelectedIndex == -1)
                return;
            if (cmbSizeCode.SelectedIndex == -1)
                return;

            var lstPaymentPlans = da.GetInstallmentPlanByProjectSizeCode(cmbSizeCode.Text, cmbProjects.Text);

            cmbProspectPaymentPlan.Items.Clear();
            foreach (var PaymentPlan in lstPaymentPlans)
                cmbProspectPaymentPlan.Items.Add(PaymentPlan.strIntallmentPlanCode);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (prosid == 0)
                return;

            frmReport frm = new frmReport();

            if (Reporcategory == ReportCategory.ProspectReport)
            {
                frm.reportType = ReportType.ProspectReport;
            }
            frm.prosid = prosid;

            frm.Show();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            SetNetPrice();
        }
        private void SetNetPrice()
        {
            decimal decDiscount = 0, decTotalPrice = 0;
            bool b = decimal.TryParse(txtDiscount.Text, out decDiscount);
            if (b == false)
                txtDiscount.Text = "0.00";
            b = decimal.TryParse(txtTotalPrice.Text, out decTotalPrice);

            if (b == true)
            {
                txtNetPrice.Text = (decTotalPrice - decDiscount).ToString("N2");
            }
        }
    }
}
