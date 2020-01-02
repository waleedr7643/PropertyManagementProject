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

       
        private void LnkLblMemberReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberRegistration frminfo = new frmMemberRegistration();
            frminfo.Show();
        }

        private void LnklbReactivations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReactivationss FRAc = new frmReactivationss();
            FRAc.Show();
        }

        private void LnkLbAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAllocation frminfo = new frmAllocation();
            frminfo.Show();
        }

        private void LnkLbDeallocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeAllocation frm = new frmDeAllocation();
            frm.Show();
        }

        private void LnkLbCancellation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCancellation frm = new frmCancellation();
            frm.Show();
        }

        private void LnkLbReactivation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReactivation frm = new frmReactivation();
            frm.Show();
        }

        private void LnkLbRefund_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRefund frm = new frmRefund();
            frm.Show();
        }

        private void LnkLbTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.Show();
        }

        private void LnkLbBlock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBlock block = new frmBlock();
            block.Show();
        }

        private void LnkLbProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProjects project = new frmProjects();
            project.Show();
        }

        private void LnkLbCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnitType cat = new frmUnitType();
            cat.Show();
        }

        private void LnkLbSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnitSize size = new frmUnitSize();
            size.Show();
        }

        private void LnkLbUOM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnitOfM uom = new frmUnitOfM();
            uom.Show();
        }

        private void LnkLbNature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnitCategory nature = new frmUnitCategory();
            nature.Show();
        }

        private void LnkLbMembership_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberLookup me = new frmMemberLookup();
            me.Show();
        }

        private void LnklbUnits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnit unit = new frmUnit();
            unit.Show();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
        }

        private void lnkLabelRevalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnitRevaluation frm = new frmUnitRevaluation();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmUserLogin frm = new frmUserLogin();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Program._userid = frm.strUserID;
            }
            else
            {
                this.Close();
            }
        }

       

        private void llTransferList_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransferList frm = new frmTransferList();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTransferList frm = new frmTransferList();
            frm.Show();
        }

        private void lnkInstallmentPlanSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInstallmentPlanSetup frm = new frmInstallmentPlanSetup();
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
    }
}
