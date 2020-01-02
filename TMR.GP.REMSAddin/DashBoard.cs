using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSAddin;
using TMR.GP.REMSAddin.UserForms;

namespace TMR.GP.REMSAddin
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
        public static frmReceiptEntry _frmrecEntry;
        public static frmUnsentReceiptsList _frmusReceipts;
        public static frmCommissionEntry _frmDealerComm;
        //public static frmReport _frmReport;

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
        public static frmRecoveryTypes _recoveryTypes;

        public static frmInstallmentPlanSetup _InstallmentPlanSetup;
        public static frmOtherRecoveryPlan _RecoveryPlanSetup;
        public static frmDirectors _DirectorsSetup;

        public static frmGeneralProcessesReport _frmGPR;
        public static frmInventoryReport _frmInvRpt;
        public static frmSoldPlotsReport _frmSPRpt;
        public static frmClientWisePurchaseParm _frmCWPHRpt;
        public static frmGeneralAccountingProcessReport _frmGAccRpt;
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
        public static frmUnsentToGPList _unsentToGP;
        public static frmSizeCodePriceList _SizeCodePriceList;
        public static frmReceiptsList _ReceiptList;
        public static frmReceiptsList _NotClearedReceiptList;
        public static frmCommissionEntryList _CommList;
        public static frmUnsentCommList _UnsentCommList;
        public static frmProspect _frmProspect;
        public static frmMasterSalesReport _frmMasterSales;
        public static frmUnit _frmUnit;
        public static frmUnitListReport _frmUnitList;

        public static frmRecoveryDueReport _recoveryDueReport;
        public static frmDuesOutstandingReport _outstandingDuesReport;
        public static frmReceiptDetailReport _receiptDetailReport;
        public static frmNotClearedReceiptReport _notClearedReceiptDetailReport;


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
        private void tsbProcessmenuReceiptEntry_Click(object sender, EventArgs e)
        {

            if (_frmrecEntry == null || _frmrecEntry.IsDisposed == true)
            {
                _frmrecEntry = new frmReceiptEntry();
                _frmrecEntry.Show();
            }
            _frmrecEntry.BringToFront();
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
            if (_InstallmentPlanSetup == null || _InstallmentPlanSetup.IsDisposed == true)
            {
                _InstallmentPlanSetup = new frmInstallmentPlanSetup();
                _InstallmentPlanSetup.Show();
            }
            _InstallmentPlanSetup.BringToFront();
        }
        private void tsmbRecoveryPlan_Click(object sender, EventArgs e)
        {
            if (_RecoveryPlanSetup == null || _RecoveryPlanSetup.IsDisposed == true)
            {
                _RecoveryPlanSetup = new frmOtherRecoveryPlan();
                _RecoveryPlanSetup.Show();
            }
            _RecoveryPlanSetup.BringToFront();
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
            _cancellationlist.BringToFront();
        }
        private void tsbLSTReactivation_Click(object sender, EventArgs e)
        {
            if (_reactivationlist == null || _reactivationlist.IsDisposed == true)
            {
                _reactivationlist = new frmReactivationList();
                _reactivationlist.Show();
            }
            _reactivationlist.BringToFront();
        }
        private void tsbRefundList_Click(object sender, EventArgs e)
        {
            if (_refundlist == null || _refundlist.IsDisposed == true)
            {
                _refundlist = new frmRefundList();
                _refundlist.Show();
            }
            _refundlist.BringToFront();
        }
        private void tsbUnitRevaluationList_Click(object sender, EventArgs e)
        {
            if (_unitrevaluationlist == null || _unitrevaluationlist.IsDisposed == true)
            {
                _unitrevaluationlist = new frmRevaluationList();
                _unitrevaluationlist.Show();
            }
            _unitrevaluationlist.BringToFront();
        }
        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {


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
        private void sizeCodeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (_SizeCodePriceList == null || _SizeCodePriceList.IsDisposed == true)
            {
                _SizeCodePriceList = new frmSizeCodePriceList();
                _SizeCodePriceList.Show();
            }
            _SizeCodePriceList.BringToFront();
        }
        private void receiptsListToolStripMenu_Click(object sender, EventArgs e)
        {
            if (_ReceiptList == null || _ReceiptList.IsDisposed == true)
            {
                _ReceiptList = new frmReceiptsList();
                _ReceiptList.strStatus = "All";
                _ReceiptList.Show();
            }
            _ReceiptList.BringToFront();
        }
        private void createCashReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        #endregion

        #region Reports Forms
        /// <summary>
        /// General Reports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbReportAlloc(object sender, EventArgs e)
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
        private void tsbReportCancellation(object sender, EventArgs e)
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
        private void tsbReportReactivations(object sender, EventArgs e)
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
        private void tsbReportRefund(object sender, EventArgs e)
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
        private void tsbReportTransfer(object sender, EventArgs e)
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
        private void tsbReportInventoryReport(object sender, EventArgs e)
        {
            if (_frmInvRpt == null || _frmInvRpt.IsDisposed == true)
            {
                _frmInvRpt = new frmInventoryReport();
                _frmInvRpt.Show();
            }
            _frmInvRpt.BringToFront();
        }
        private void tsbReportSoldPlotsReport(object sender, EventArgs e)
        {
            if (_frmSPRpt == null || _frmSPRpt.IsDisposed == true)
            {
                _frmSPRpt = new frmSoldPlotsReport();
                _frmSPRpt.Show();
            }
            _frmSPRpt.BringToFront();
        }

        private void tsbReportClientWiseMemberProfile(object sender, EventArgs e)
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
        private void tsbReportClientWisePurchaseHistory(object sender, EventArgs e)
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
        private void accountStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmGAccRpt == null || _frmGAccRpt.IsDisposed == true)
            {
                _frmGAccRpt = new frmGeneralAccountingProcessReport();
                _frmGAccRpt.Reporcategory = frmGeneralAccountingProcessReport.ReportCategory.AccountStatement;
                _frmGAccRpt.Show();
            }
            _frmGAccRpt.Reporcategory = frmGeneralAccountingProcessReport.ReportCategory.AccountStatement;
            _frmGAccRpt.BringToFront();
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

        private void recoveryTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_recoveryTypes == null || _recoveryTypes.IsDisposed == true)
            {
                _recoveryTypes = new frmRecoveryTypes();
                _recoveryTypes.Show();
            }
            _recoveryTypes.BringToFront();
        }

        private void dealerCommissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDealerComm == null || _frmDealerComm.IsDisposed == true)
            {
                _frmDealerComm = new frmCommissionEntry();
                _frmDealerComm.EntryType = 1;
                _frmDealerComm.Show();
            }
            _frmDealerComm.BringToFront();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (_CommList == null || _CommList.IsDisposed == true)
            {
                _CommList = new frmCommissionEntryList();

                _CommList.Show();
            }
            _CommList.BringToFront();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            //_UnsentCommList

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void inventoryReportSizeWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.InventoryReportSizeWise;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void inventoryReportSectorWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.InventoryReportSectorWise;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void sizeWiseQuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.SizeWiseQuota;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void sectorWiseQuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.SectorWiseQuota;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void quotaWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.QuotaWiseReport;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void prospectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProspect == null || _frmProspect.IsDisposed == true)
            {
                _frmProspect = new frmProspect();
                _frmProspect.Show();
            }
            _frmProspect.BringToFront();
        }

        private void prospectReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmRptViewer == null || _frmRptViewer.IsDisposed == true)
            {
                _frmRptViewer = new frmReport();
                _frmRptViewer.reportType = ReportType.ProspectReport;
                _frmRptViewer.Show();
            }
            _frmRptViewer.BringToFront();
        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_transfer == null || _transfer.IsDisposed == true)
            {
                _transfer = new frmTransfer();
                _transfer.Show();
            }
            _transfer.BringToFront();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (_transferlist == null || _transferlist.IsDisposed == true)
            {
                _transferlist = new frmTransferList();
                _transferlist.Show();
            }
            _transferlist.BringToFront();
        }

        private void masterSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmMasterSales == null || _frmMasterSales.IsDisposed == true)
            {
                _frmMasterSales = new frmMasterSalesReport();
                _frmMasterSales.Show();
            }
            _frmMasterSales.BringToFront();
        }

        private void unitListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmUnitList == null || _frmUnitList.IsDisposed == true)
            {
                _frmUnitList = new frmUnitListReport();
                _frmUnitList.Show();
            }
            _frmUnitList.BringToFront();
        }

        private void gPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createGPCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_unsentToGP == null || _unsentToGP.IsDisposed == true)
            {
                _unsentToGP = new frmUnsentToGPList();
                _unsentToGP.Show();
            }
            _unsentToGP.BringToFront();
        }

        private void createCashReceiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_frmusReceipts == null || _frmusReceipts.IsDisposed == true)
            {
                _frmusReceipts = new frmUnsentReceiptsList();
                _frmusReceipts.Show();
            }
            _frmusReceipts.BringToFront();
        }

        private void createCommissionEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_UnsentCommList == null || _UnsentCommList.IsDisposed == true)
            {
                _UnsentCommList = new frmUnsentCommList();

                _UnsentCommList.Show();
            }
            _UnsentCommList.BringToFront();
        }

        private void notClearedReceipts_Click(object sender, EventArgs e)
        {
            if (_NotClearedReceiptList == null || _NotClearedReceiptList.IsDisposed == true)
            {

                _NotClearedReceiptList = new frmReceiptsList();
                _NotClearedReceiptList.strStatus = "Not Cleared";
                _NotClearedReceiptList.Show();
            }
            _NotClearedReceiptList.BringToFront();

        }

        private void recoveryDueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_recoveryDueReport == null || _recoveryDueReport.IsDisposed == true)
            {

                _recoveryDueReport = new frmRecoveryDueReport();
                _recoveryDueReport.Show();
            }
            _recoveryDueReport.BringToFront();
        }

        private void outstandingDuesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_outstandingDuesReport == null || _outstandingDuesReport.IsDisposed == true)
            {

                _outstandingDuesReport = new frmDuesOutstandingReport();
                _outstandingDuesReport.Show();
            }
            _outstandingDuesReport.BringToFront();
        }

        private void receiptDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_receiptDetailReport == null || _receiptDetailReport.IsDisposed == true)
            {
                _receiptDetailReport = new frmReceiptDetailReport();
                _receiptDetailReport.Show();
            }
            _receiptDetailReport.BringToFront();
        }

        private void toolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
            if (_notClearedReceiptDetailReport == null || _notClearedReceiptDetailReport.IsDisposed == true)
            {
                _notClearedReceiptDetailReport = new frmNotClearedReceiptReport();
                _notClearedReceiptDetailReport.Show();
            }
            _notClearedReceiptDetailReport.BringToFront();
        }
    }
}
