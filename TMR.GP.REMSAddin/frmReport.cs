using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.REMSDal;

namespace TMR.GP.REMSAddin
{

    public enum ReportType
    {
        InventoryReport, SoldPlotsByMemberShip, GeneralCancellationReport, Allocations, Cancellations, Reactivations, Transfer, Refund, ClientWiseMemberProfile, ClientWisePurchaseHistory, MemberInfo, AccountStatement, InventoryReportSizeWise, InventoryReportSectorWise, SizeWiseQuota, SectorWiseQuota, QuotaWiseReport, ProspectReport,
        Receipt, MasterSales, UnitList, Membership, RecoveryDueReport, DuesOutstanding, ReceiptDetail, NotCleared
    }
    public partial class frmReport : Form
    {
        public string strRegistrationNo { get; set; }
        public string strDocumentNumber { get; set; }
        public bool IncludeTax { get; set; }
        public bool IncludeFullInvoice { get; set; }
        public decimal InvoicePercentage { get; set; }
        public decimal TaxPercentage { get; set; }
        private string interID;
        public string strProjectID { get; set; }
        public string strBlockNo { get; set; }
        public string strSizeCode { get; set; }
        public int intStatusCode { get; set; }
        public string strStatusCode { get; set; }
        public DateTime dtToDate { get; set; }
        public DateTime dtFromDate { get; set; }
        public ReportType reportType { get; set; }
        public int prosid { get; set; }
        public clsReceiptEntry receipt { get; set; }

        public frmReport()
        {
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadInventoryReport();
        }
        void LoadInventoryReport()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ReportDocument cryRpt = new ReportDocument();
                ReportObjects crReportObjects;
                SubreportObject crSubreportObject;
                ReportDocument crSubreportDocument;
                Database crDatabase;
                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                string s = "";

                if (this.reportType == ReportType.Allocations)
                { s = Application.StartupPath + @"\Reports\GCKAllocationsReport.rpt"; }// Application.StartupPath +
                else if (this.reportType == ReportType.Cancellations)
                { s = Application.StartupPath + @"\Reports\GCKCancellationsReport.rpt"; }// Application.StartupPath +
                else if (this.reportType == ReportType.Reactivations)
                { s = Application.StartupPath + @"\Reports\GCKReactivationsReport.rpt"; }// Application.StartupPath +
                else if (this.reportType == ReportType.Refund)
                { s = Application.StartupPath + @"\Reports\GCKRefundReport.rpt"; }// Application.StartupPath +
                else if (this.reportType == ReportType.Transfer)
                { s = Application.StartupPath + @"\Reports\GCKTransferReport.rpt"; }// Application.StartupPath +
                else if (this.reportType == ReportType.InventoryReport)
                { s = Application.StartupPath + @"\Reports\GCKInventory.rpt"; } // Application.StartupPath +
                else if (this.reportType == ReportType.SoldPlotsByMemberShip)
                { s = Application.StartupPath + @"\Reports\GCKSoldPlots.rpt"; }//  Application.StartupPath +
                else if (this.reportType == ReportType.ClientWiseMemberProfile)
                { s = Application.StartupPath + @"\Reports\GCKClientWiseProfile.rpt"; }//  Application.StartupPath +
                else if (this.reportType == ReportType.ClientWisePurchaseHistory)
                { s = Application.StartupPath + @"\Reports\GCKClientWisePurchaseHistory.rpt"; }
                else if (this.reportType == ReportType.AccountStatement)
                { s = Application.StartupPath + @"\Reports\GCKMemberInfo.rpt"; }
                else if (this.reportType == ReportType.InventoryReportSizeWise)
                { s = Application.StartupPath + @"\Reports\01-InventoryReportSizeWise.rpt"; }
                else if (this.reportType == ReportType.InventoryReportSectorWise)
                { s = Application.StartupPath + @"\Reports\02-InventoryReportSectorWise.rpt"; }
                else if (this.reportType == ReportType.SizeWiseQuota)
                { s = Application.StartupPath + @"\Reports\03-SizeWiseQuota.rpt"; }
                else if (this.reportType == ReportType.SectorWiseQuota)
                { s = Application.StartupPath + @"\Reports\04-SectorWiseQuota.rpt"; }
                else if (this.reportType == ReportType.QuotaWiseReport)
                { s = Application.StartupPath + @"\Reports\05-QuotaWiseReport.rpt"; }
                else if (this.reportType == ReportType.ProspectReport)
                { s = Application.StartupPath + @"\Reports\06-ProspectReport.rpt"; }
                else if (this.reportType == ReportType.Receipt)
                { s = Application.StartupPath + @"\Reports\07-ReceiptPrintContainer.rpt"; }
                else if (this.reportType == ReportType.Membership)
                { s = Application.StartupPath + @"\Reports\08-MemberRegistration.rpt"; }
                else if (this.reportType == ReportType.MasterSales)
                { s = Application.StartupPath + @"\Reports\09-MasterSalesReport.rpt"; }
                else if (this.reportType == ReportType.UnitList)
                { s = Application.StartupPath + @"\Reports\10-UnitsList.rpt"; }
                else if (this.reportType == ReportType.RecoveryDueReport)
                { s = Application.StartupPath + @"\Reports\11-RecoveryDueReport.rpt"; }
                else if (this.reportType == ReportType.DuesOutstanding)
                { s = Application.StartupPath + @"\Reports\12-DuesOutstandingReport.rpt"; }
                else if (this.reportType == ReportType.ReceiptDetail)
                { s = Application.StartupPath + @"\Reports\13-ReceiptDetailReport.rpt"; }
                else if (this.reportType == ReportType.NotCleared)
                { s = Application.StartupPath + @"\Reports\14-NotClearedReceiptsReport.rpt"; }

                cryRpt.Load(s);

                ConnectionInfo connInfo = new ConnectionInfo();
                SqlConnectionStringBuilder builder = new DataAccess().GetCredentials();
                crConnectionInfo.ServerName = builder.DataSource;
                crConnectionInfo.DatabaseName = builder.InitialCatalog;
                crConnectionInfo.UserID = builder.UserID;
                crConnectionInfo.Password = builder.Password;
                Sections ReportSections = cryRpt.ReportDefinition.Sections;
                foreach (Section section in ReportSections)
                {
                    crReportObjects = section.ReportObjects;

                    foreach (ReportObject crReportObject in crReportObjects)
                    {
                        if (crReportObject.Kind != ReportObjectKind.SubreportObject)
                            continue;

                        crSubreportObject = (SubreportObject)crReportObject;
                        crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName);
                        crDatabase = crSubreportDocument.Database;

                        CrTables = crDatabase.Tables;

                        foreach (Table CrTable in CrTables)
                        {
                            TableLogOnInfo crTableLogOnInfo = CrTable.LogOnInfo;
                            crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                            CrTable.ApplyLogOnInfo(crTableLogOnInfo);
                        }
                    }
                }

                CrTables = cryRpt.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                if (this.reportType == ReportType.InventoryReport)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@SizeCode", strSizeCode);
                    cryRpt.SetParameterValue("@Sector", strBlockNo);
                    cryRpt.SetParameterValue("@StatusCode", intStatusCode);
                }

                else if (this.reportType == ReportType.SoldPlotsByMemberShip)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@Sector", strBlockNo);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                }
                else if (this.reportType == ReportType.Allocations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Cancellations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Reactivations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Transfer)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Refund)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.ClientWiseMemberProfile)
                {
                    cryRpt.SetParameterValue("@ClientID", strDocumentNumber);
                }
                else if (this.reportType == ReportType.ClientWisePurchaseHistory)
                {
                    cryRpt.SetParameterValue("@ClientID", strDocumentNumber);
                }
                else if (this.reportType == ReportType.AccountStatement)
                {
                    cryRpt.SetParameterValue("@reg", strRegistrationNo);
                }
                else if (this.reportType == ReportType.ProspectReport)
                {
                    cryRpt.SetParameterValue("@id", prosid);
                }
                else if (this.reportType == ReportType.Membership)
                {
                    cryRpt.SetParameterValue("@RegNo", strRegistrationNo);
                }
                else if (this.reportType == ReportType.Receipt)
                {
                    cryRpt.SetParameterValue("ReceiptNumber", receipt.ReceiptNumber);
                    cryRpt.SetParameterValue("RegNo", receipt.RegistrationNo);
                    cryRpt.SetParameterValue("ReceiptDate", receipt.ReceiptDate.Date);
                    cryRpt.SetParameterValue("Amount", receipt.ReceiptAmount);

                    cryRpt.SetParameterValue("PlotSize", receipt.PlotSize);
                    cryRpt.SetParameterValue("PaymentMode", receipt.ReceiptMode);
                    cryRpt.SetParameterValue("InstrumentNo", receipt.InstrumentNumber);
                    cryRpt.SetParameterValue("BankAndBranch", receipt.DraweeBank + " " + receipt.DraweeBranch);

                    cryRpt.SetParameterValue("InstrumentDate", receipt.InstrumentDate);
                    cryRpt.SetParameterValue("From", receipt.ClientName);
                    cryRpt.SetParameterValue("FatherName", receipt.FatherName);
                    cryRpt.SetParameterValue("Remarks", receipt.Remarks);

                    cryRpt.SetParameterValue("OnAccountOf", receipt.OnAccountOf);
                    cryRpt.SetParameterValue("Deposit By", receipt.DepositBy);
                }
                else if (this.reportType == ReportType.MasterSales)
                {
                    cryRpt.SetParameterValue("@project", strProjectID);
                    cryRpt.SetParameterValue("@Block", strBlockNo);
                    cryRpt.SetParameterValue("@StartBookingDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndBookingDate", dtToDate.Date);
                }
                else if (this.reportType == ReportType.UnitList)
                {
                    cryRpt.SetParameterValue("@project", strProjectID);
                    cryRpt.SetParameterValue("@Block", strBlockNo);
                    cryRpt.SetParameterValue("@Status", strStatusCode);
                    cryRpt.SetParameterValue("@SizeCode", strSizeCode);
                }
                else if (this.reportType == ReportType.RecoveryDueReport)
                {
                    cryRpt.SetParameterValue("@project", strProjectID);
                    cryRpt.SetParameterValue("@Block", strBlockNo);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                }
                else if (this.reportType == ReportType.DuesOutstanding)
                {                   
                    cryRpt.SetParameterValue("@Block", strBlockNo);
                    cryRpt.SetParameterValue("@StartRegNo", strRegistrationNo);
                    cryRpt.SetParameterValue("@EndRegNo", strDocumentNumber);
                    cryRpt.SetParameterValue("@TillDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@StatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.ReceiptDetail)
                {
                    cryRpt.SetParameterValue("@SizeCode", strSizeCode);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@StatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.NotCleared)
                {
                    cryRpt.SetParameterValue("@SizeCode", strSizeCode);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate.Date);
                    cryRpt.SetParameterValue("@EndDate", dtToDate.Date);
                    cryRpt.SetParameterValue("@StatusCode", intStatusCode);
                }

                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return;
            }
            this.Cursor = Cursors.Arrow;
        }

    }
}

