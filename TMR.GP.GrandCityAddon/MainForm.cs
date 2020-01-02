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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        #region public Members Initialization

        /// <summary For Processes>
        /// For Processes
        /// </summary>
        public static frmMemberRegistration _memberReg;
        public static frmAllocation _allocation;
        public static frmCancellation  _cancellation;
        public static frmReactivation _reactivation;
        public static frmRefund _refund;
        public static frmTransfer _transfer;
        public static frmUnitRevaluation _unitrevaluation;



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

        /// <summary For Reports>
        /// For Reports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public static frmGeneralProcessesReport _frmGPR;
        public static frmInventoryReport _frmInvRpt;
        public static frmSoldPlotsReport _frmSPRpt;
        public static frmClientWisePurchaseParm _frmCWPHRpt;
       
        #endregion
      
        #region Processes Forms
        private void LnkLblMemberReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_memberReg == null || _memberReg.IsDisposed == true)
            {
                _memberReg = new frmMemberRegistration();
                _memberReg.Show();
            }
            _memberReg.BringToFront();
        }
        private void LnkLbAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_allocation == null || _allocation.IsDisposed == true)
            {
                _allocation = new frmAllocation();
                _allocation.Show();
            }
            _allocation.BringToFront();
        }
        private void LnkLbCancellation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cancellation == null || _cancellation.IsDisposed == true)
            {
                _cancellation = new frmCancellation();
                _cancellation.Show();
            }
            _cancellation.BringToFront();
        }
        private void LnkLbReactivation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_reactivation == null || _reactivation.IsDisposed == true)
            {
                _reactivation = new frmReactivation();
                _reactivation.Show();
            }
            _reactivation.BringToFront();
        }
        private void LnkLbRefund_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_refund == null || _refund.IsDisposed == true)
            {
                _refund = new frmRefund();
                _refund.Show();
            }
            _refund.BringToFront();
        }
        private void LnkLbTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_transfer == null || _transfer.IsDisposed == true)
            {
                _transfer = new frmTransfer();
                _transfer.Show();
            }
            _transfer.BringToFront();
        }
        private void lnkLabelRevalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unitrevaluation == null || _unitrevaluation.IsDisposed == true)
            {
                _unitrevaluation = new frmUnitRevaluation();
                _unitrevaluation.Show();
            }
            _unitrevaluation.BringToFront();
        }
        #endregion
        
        #region Setup Forms
        
        private void LnkLbProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_projects == null || _projects.IsDisposed == true)
            {
                _projects = new frmProjects();
                _projects.Show();
            }
            _projects.BringToFront();
        }
        private void LnkLbBlock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_blocks == null || _blocks.IsDisposed == true)
            {
                _blocks = new frmBlock();
                _blocks.Show();
            }
            _blocks.BringToFront();
        }
        private void LnklbUnits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unit == null || _unit.IsDisposed == true)
            {
                _unit = new frmUnit();
                _unit.Show();
            }
            _unit.BringToFront();
        }
        private void LnkLbSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unitsize == null || _unitsize.IsDisposed == true)
            {
                _unitsize = new frmUnitSize();
                _unitsize.Show();
            }
            _unitsize.BringToFront();
           
        }
        private void LnkLbCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unittype == null || _unittype.IsDisposed == true)
            {
                _unittype = new frmUnitType();
                _unittype.Show();
            }
            _unittype.BringToFront();
        }
        private void LnkLbUOM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unitoM == null || _unitoM.IsDisposed == true)
            {
                _unitoM = new frmUnitOfM();
                _unitoM.Show();
            }
            _unitoM.BringToFront();
        }
        private void LnkLbNature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_unitcatgory == null || _unitcatgory.IsDisposed == true)
            {
                _unitcatgory = new frmUnitCategory();
                _unitcatgory.Show();
            }
            _unitcatgory.BringToFront();    
        }       
        #endregion
       
        #region Lists Forms
        private void llAllocList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAllocationListcs frm = new frmAllocationListcs();
            frm.Show();
        }

        private void llDeallocList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDealloctionList frm = new frmDealloctionList();
            frm.Show();
        }

        private void llCancelList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCancellationList frm = new frmCancellationList();
            frm.Show();
        }

        private void llReacList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReactivationList frm = new frmReactivationList();
            frm.Show();
        }
        private void llRefundList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRefundList frm = new frmRefundList();
            frm.Show();
        }
        private void llTransferList_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransferList frm = new frmTransferList();
            frm.Show();
        }
        private void llTransferPendingList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransferPendingList frm = new frmTransferPendingList();
            frm.Show();
        }
        private void llunsentToGPList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnsentToGPList frm = new frmUnsentToGPList();
            frm.Show();
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRevaluationList frm = new frmRevaluationList();
            frm.Show();
        }
        private void llSizeCodePriceList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSizeCodePriceList frm = new frmSizeCodePriceList();
            frm.Show();
        }     
        #endregion
       
        #region Reports Forms
        /// <summary>
        /// General Reports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblAllocationReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnklblCancellatonReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnklblReactivationReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnklblRefundReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnklblTransferReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        /// <Advance Reports>
        /// Advance Reports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkInventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_frmInvRpt == null || _frmInvRpt.IsDisposed == true)
            {
                _frmInvRpt = new frmInventoryReport();
                _frmInvRpt.Show();
            }
            _frmInvRpt.BringToFront();
        }
        private void lnklblSoldPlotsReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_frmSPRpt == null || _frmSPRpt.IsDisposed == true)
            {
                _frmSPRpt = new frmSoldPlotsReport();
                _frmSPRpt.Show();
            }
            _frmSPRpt.BringToFront();
        }
        private void lnklblClientWisePurchaseHistoryReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnklbl_ClientWisePurchaseHistory(object sender, LinkLabelLinkClickedEventArgs e)
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

        #endregion


        /// <summary>
        /// addOn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region FormLoad Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            frmUserLogin frm = new frmUserLogin();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program._userid = frm.strUserID;
            }
            else
            {
                this.Close();
            }
        }
        #endregion

        #region Pending Decision Forms
        private void lnkInstallmentPlanSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInstallmentPlanSetup frm = new frmInstallmentPlanSetup();
            frm.Show();
        }
        private void LnkLbDeallocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeAllocation frm = new frmDeAllocation();
            frm.Show();
        }
        private void lnkDirectors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDirectors frm = new frmDirectors();
            frm.Show();
        }

        private void lnkInstallmentPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInstallmentPlan frm = new frmInstallmentPlan();
            frm.Show();
        }
        #endregion
    
    }
}
