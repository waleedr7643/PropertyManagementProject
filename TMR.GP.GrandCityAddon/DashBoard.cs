using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.GrandCityAddon.UserForms;

namespace TMR.GP.GrandCityAddon
{
    public partial class DashBoard : Form
    {


        public DashBoard()
        {
            InitializeComponent();
        }

        #region public Members Initialization

        /// <summary For Processes>
        /// For Processes
        /// </summary>
        public static frmMemberRegistration _memberReg;
        public static frmAllocation _allocation;
        public static frmCancellation _cancellation;
        public static frmReactivation _reactivation;
        public static frmRefund _refund;
        public static frmTransfer _transfer;
        public static frmUnitRevaluation _unitrevaluation;
        public static frmInstallmentPlan _installmentsPlan;
        public static frmUnitSize _frmunitsize;



        /// <summary For Setup>
        /// For Setup
        /// </summary>
        public static frmProjects _projects;
        public static frmBlock _blocks;
        public static frmUnit _unit;
        public static frmUnitSize _unitsize;
        public static frmUnitType _unittype;
        public static frmUnitOfM _unitoM;
        public static frmUnitCategory _unitcatgory;
        public static frmDirectors _DirectorsSetup;


        public static frmGeneralProcessesReport _frmGPR;
        public static frmInventoryReport _frmInvRpt;
        public static frmSoldPlotsReport _frmSPRpt;
        public static frmClientWisePurchaseParm _frmCWPHRpt;
        public static frmReport _frmRptViewer;

        /// <summary For List>
        /// For Processes
        /// </summary>

        public static frmAllocationListcs _allocationlist;
        public static frmCancellationList _cancellationlist;
        public static frmReactivationList _reactivationlist;
        public static frmRefundList _refundlist;
        public static frmTransferList _transferlist;
        public static frmRevaluationList _unitrevaluationlist;



        #endregion

        #region Processes Forms
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_memberReg == null || _memberReg.IsDisposed == true)
            {
                _memberReg = new frmMemberRegistration();
                _memberReg.Show();
            }
            _memberReg.BringToFront();
        }

        private void allocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_allocation == null || _allocation.IsDisposed == true)
            {
                _allocation = new frmAllocation();
                _allocation.Show();
            }
            _allocation.BringToFront();
        }

        private void cancellationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cancellation == null || _cancellation.IsDisposed == true)
            {
                _cancellation = new frmCancellation();
                _cancellation.Show();
            }
            _cancellation.BringToFront();
        }

        private void reactivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_reactivation == null || _reactivation.IsDisposed == true)
            {
                _reactivation = new frmReactivation();
                _reactivation.Show();
            }
            _reactivation.BringToFront();
        }

        private void refundBuyBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_refund == null || _refund.IsDisposed == true)
            {
                _refund = new frmRefund();
                _refund.Show();
            }
            _refund.BringToFront();
        }

        private void revaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unitrevaluation == null || _unitrevaluation.IsDisposed == true)
            {
                _unitrevaluation = new frmUnitRevaluation();
                _unitrevaluation.Show();
            }
            _unitrevaluation.BringToFront();
        }

        private void installmentPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_installmentsPlan == null || _installmentsPlan.IsDisposed == true)
            {
                _installmentsPlan = new frmInstallmentPlan();
                _installmentsPlan.Show();
            }
            _installmentsPlan.BringToFront();
        }

        private void sizeCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmunitsize == null || _frmunitsize.IsDisposed == true)
            {
                _frmunitsize = new frmUnitSize();
                _frmunitsize.Show();
            }
            _frmunitsize.BringToFront();
        }

        #endregion

        #region Setup Forms
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_blocks == null || _blocks.IsDisposed == true)
            {
                _blocks = new frmBlock();
                _blocks.Show();
            }
            _blocks.BringToFront();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unit == null || _unit.IsDisposed == true)
            {
                _unit = new frmUnit();
                _unit.Show();
            }
            _unit.BringToFront();
        }

        private void unitTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unittype == null || _unittype.IsDisposed == true)
            {
                _unittype = new frmUnitType();
                _unittype.Show();
            }
            _unittype.BringToFront();
        }

        private void unitOfMeasuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unitoM == null || _unitoM.IsDisposed == true)
            {
                _unitoM = new frmUnitOfM();
                _unitoM.Show();
            }
            _unitoM.BringToFront();
        }

        private void unitCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unitcatgory == null || _unitcatgory.IsDisposed == true)
            {
                _unitcatgory = new frmUnitCategory();
                _unitcatgory.Show();
            }
            _unitcatgory.BringToFront();
        }

        private void installmentsPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    if (_InstallmentPlanSetup == null || _InstallmentPlanSetup.IsDisposed == true)
            //    {
            //        _InstallmentPlanSetup = new frmInstallmentPlanSetup();
            //        _InstallmentPlanSetup.Show();
            //    }
            //    _InstallmentPlanSetup.BringToFront();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_floorPrice == null || _floorPrice.IsDisposed == true)
            //{
            //    _floorPrice = new frmFloorPrice();
            //    _floorPrice.Show();
            //}
            //_floorPrice.BringToFront();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_floorRent == null || _floorRent.IsDisposed == true)
            //{
            //    _floorRent = new frmFloorRent();
            //    _floorRent.Show();
            //}
            //_floorRent.BringToFront();
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_bank == null || _bank.IsDisposed == true)
            //{
            //    _bank = new frmBank();
            //    _bank.Show();
            //}
            //_bank.BringToFront();
        }
        private void officeBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_branchOffice == null || _branchOffice.IsDisposed == true)
            //{
            //    _branchOffice = new frmBranchOffice();
            //    _branchOffice.Show();
            //}
            //_branchOffice.BringToFront();

        }
        #endregion

        #region Lists Forms
        private void tsbLSTAllocation_Click(object sender, EventArgs e)
        {
        
            if (_allocationlist == null || _allocationlist.IsDisposed == true)
            {
                _allocationlist = new frmAllocationListcs();
                _allocationlist.Show();
            }
            _allocationlist.BringToFront();
        }

        private void tsbLSTCancellation_Click(object sender, EventArgs e)
        {
          
            if (_cancellationlist == null || _cancellationlist.IsDisposed == true)
            {
                _cancellationlist = new frmCancellationList();
                _cancellationlist.Show();
            }
            _projects.BringToFront();
        }
        private void tsbLSTReactivation_Click(object sender, EventArgs e)
        { 
            
            if (_reactivationlist == null || _reactivationlist.IsDisposed == true)
            {
                _reactivationlist = new frmReactivationList();
                _reactivationlist.Show();
            }
            _projects.BringToFront();
        }
        private void tsbRefundList_Click(object sender, EventArgs e)
        {
            if (_transferlist == null || _transferlist.IsDisposed == true)
            {
                _transferlist = new frmTransferList();
                _transferlist.Show();
            }
            _projects.BringToFront();
        }
        private void tsbUnitRevaluationList_Click(object sender, EventArgs e)
        {
           if (_unitrevaluationlist == null || _unitrevaluationlist.IsDisposed == true)
            {
                _unitrevaluationlist = new frmRevaluationList();
                _unitrevaluationlist.Show();
            }
            _projects.BringToFront();
        }
        private void floorPriceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }
        private void floorRentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }

        private void floorCurrentPriceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }

        private void floorCurrentRentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }
      
        #endregion

        #region Reports Forms
        /// <summary>
        /// General Reports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //if (_frmGPR == null || _frmGPR.IsDisposed == true)
            //{
            //    _frmGPR = new frmGeneralProcessesReport();
            //    _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Allocations;
            //    //__frmGPR.lable = "Allocation Report";
            //    _frmGPR.Show();
            //}
            //_frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Allocations;

            //_frmGPR.BringToFront();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //if (_frmGPR == null || _frmGPR.IsDisposed == true)
            //{
            //    _frmGPR = new frmGeneralProcessesReport();
            //    _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Cancellations;
            //    _frmGPR.Show();
            //}
            //_frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Cancellations;
            //_frmGPR.BringToFront();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            //if (_frmGPR == null || _frmGPR.IsDisposed == true)
            //{
            //    _frmGPR = new frmGeneralProcessesReport();
            //    _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Reactivations;
            //    _frmGPR.Show();
            //}
            //_frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Reactivations;
            //_frmGPR.BringToFront();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            //if (_frmGPR == null || _frmGPR.IsDisposed == true)
            //{
            //    _frmGPR = new frmGeneralProcessesReport();
            //    _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Refund;
            //    _frmGPR.Show();
            //}
            //_frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Refund;
            //_frmGPR.BringToFront();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            //if (_frmGPR == null || _frmGPR.IsDisposed == true)
            //{
            //    _frmGPR = new frmGeneralProcessesReport();
            //    _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Transfer;
            //    _frmGPR.Show();
            //}
            //_frmGPR.BringToFront();
            //_frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Transfer;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmInvRpt == null || _frmInvRpt.IsDisposed == true)
            //{
            //    _frmInvRpt = new frmInventoryReport();
            //    _frmInvRpt.Show();
            //}
            //_frmInvRpt.BringToFront();
        }

        private void soldPlotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmSPRpt == null || _frmSPRpt.IsDisposed == true)
            //{
            //    _frmSPRpt = new frmSoldPlotsReport();
            //    _frmSPRpt.Show();
            //}
            //_frmSPRpt.BringToFront();
        }

        private void clientProfileWithPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmCWPHRpt == null || _frmCWPHRpt.IsDisposed == true)
            //{
            //    _frmCWPHRpt = new frmClientWisePurchaseParm();
            //    _frmCWPHRpt.reportType = ReportType.ClientWiseMemberProfile;
            //    _frmCWPHRpt.Show();
            //}
            //else if (_frmCWPHRpt != null || _frmCWPHRpt.IsDisposed == true)
            //{
            //    _frmCWPHRpt.reportType = ReportType.ClientWiseMemberProfile;
            //    _frmCWPHRpt.BringToFront();
            //}
        }

        private void clientWisePurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmCWPHRpt == null || _frmCWPHRpt.IsDisposed == true)
            //{
            //    _frmCWPHRpt = new frmClientWisePurchaseParm();
            //    _frmCWPHRpt.reportType = ReportType.ClientWisePurchaseHistory;
            //    _frmCWPHRpt.Show();
            //}
            //else if (_frmCWPHRpt != null || _frmCWPHRpt.IsDisposed == true)
            //{
            //    _frmCWPHRpt.reportType = ReportType.ClientWisePurchaseHistory;
            //    _frmCWPHRpt.BringToFront();
            //}
        }

        #endregion

        #region FormLoad Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            //frmUserLogin frm = new frmUserLogin();
            //frm.ShowInTaskbar = false;
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Microsoft.Dexterity.Applications.Dynamics.Globals.UserId = frm.strUserID;
            //}
            //else
            //{
            //    this.Close();
            //}
        }
        #endregion

    
        private void priceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void rentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void createCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUnsentToGPList frm = new frmUnsentToGPList();
            frm.Show();
        }

        private void sizeCodeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmSizeCodePriceList frm = new frmSizeCodePriceList();
            frm.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            if (_frmGPR == null || _frmGPR.IsDisposed == true)
            {
                _frmGPR = new frmGeneralProcessesReport();
                _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Allocations;
                //__frmGPR.lable = "Allocation Report";
                _frmGPR.Show();
            }
            _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Allocations;

            _frmGPR.BringToFront();
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            if (_frmGPR == null || _frmGPR.IsDisposed == true)
            {
                _frmGPR = new frmGeneralProcessesReport();
                _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Cancellations;
                _frmGPR.Show();
            }
            _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Cancellations;
            _frmGPR.BringToFront();
        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            if (_frmGPR == null || _frmGPR.IsDisposed == true)
            {
                _frmGPR = new frmGeneralProcessesReport();
                _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Reactivations;
                _frmGPR.Show();
            }
            _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Reactivations;
            _frmGPR.BringToFront();
        }

        private void toolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            if (_frmGPR == null || _frmGPR.IsDisposed == true)
            {
                _frmGPR = new frmGeneralProcessesReport();
                _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Refund;
                _frmGPR.Show();
            }
            _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Refund;
            _frmGPR.BringToFront();
        }

        private void transferToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmGPR == null || _frmGPR.IsDisposed == true)
            {
                _frmGPR = new frmGeneralProcessesReport();
                _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Transfer;
                _frmGPR.Show();
            }
            _frmGPR.BringToFront();
            _frmGPR.processtype = frmGeneralProcessesReport.ProcessType.Transfer;
        }

        private void inventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmInvRpt == null || _frmInvRpt.IsDisposed == true)
            {
                _frmInvRpt = new frmInventoryReport();
                _frmInvRpt.Show();
            }
            _frmInvRpt.BringToFront();
        }

        private void soldPlotsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmSPRpt == null || _frmSPRpt.IsDisposed == true)
            {
                _frmSPRpt = new frmSoldPlotsReport();
                _frmSPRpt.Show();
            }
            _frmSPRpt.BringToFront();
        }

        private void clientProfileWithPaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmCWPHRpt == null || _frmCWPHRpt.IsDisposed == true)
            {
                _frmCWPHRpt = new frmClientWisePurchaseParm();
                _frmCWPHRpt.reportType = ReportType.ClientWiseMemberProfile;
                _frmCWPHRpt.Show();
            }
            else if (_frmCWPHRpt != null || _frmCWPHRpt.IsDisposed == true)
            {
                _frmCWPHRpt.reportType = ReportType.ClientWiseMemberProfile;
                _frmCWPHRpt.BringToFront();
            }
        }

        private void clientWisePurchaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_frmCWPHRpt == null || _frmCWPHRpt.IsDisposed == true)
            {
                _frmCWPHRpt = new frmClientWisePurchaseParm();
                _frmCWPHRpt.reportType = ReportType.ClientWisePurchaseHistory;
                _frmCWPHRpt.Show();
            }
            else if (_frmCWPHRpt != null || _frmCWPHRpt.IsDisposed == true)
            {
                _frmCWPHRpt.reportType = ReportType.ClientWisePurchaseHistory;
                _frmCWPHRpt.BringToFront();
            }
        }

    }
}
