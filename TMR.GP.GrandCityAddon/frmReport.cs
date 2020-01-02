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



namespace TMR.GP.GrandCityAddon
{
   
    public enum ReportType { InventoryReport, SoldPlotsByMemberShip, GeneralCancellationReport, Allocations, Cancellations, Reactivations, Transfer, Refund,
                               ClientWiseMemberProfile, ClientWisePurchaseHistory}

    public partial class frmReport : Form
    {
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
        public DateTime dtToDate { get; set; }
        public DateTime dtFromDate { get; set; }
        public ReportType reportType { get; set; }
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
                else  if (this.reportType == ReportType.Cancellations)
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
                { s = Application.StartupPath + @"\Reports\GraanaClientWiseProfile.rpt"; }//  Application.StartupPath +
                else if (this.reportType == ReportType.ClientWisePurchaseHistory)
                { s = Application.StartupPath + @"\Reports\GraanaClientWisePurchaseHistory.rpt"; }

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
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
                }
                else if (this.reportType == ReportType.Allocations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Cancellations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Reactivations)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Transfer)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
                    cryRpt.SetParameterValue("@ApprovalStatusCode", intStatusCode);
                }
                else if (this.reportType == ReportType.Refund)
                {
                    cryRpt.SetParameterValue("@ProjectID", strProjectID);
                    cryRpt.SetParameterValue("@StartDate", dtFromDate);
                    cryRpt.SetParameterValue("@EndDate", dtToDate);
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

