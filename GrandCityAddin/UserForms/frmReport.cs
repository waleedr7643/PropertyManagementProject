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



namespace TMR.GP.GrandCityAddon.UserForms
{


    public partial class frmReport : Form
    {
        public string ProjectID { get; set; }
        public string BlockNo { get; set; }
        public int StatusCode { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public ReportType reportType { get; set; }
        public frmReport()
        {
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            //interID = Dynamics.Globals.IntercompanyId.Value;
            LoadReport();
        }
        void LoadReport()
        {
            ProjectID = "All";
            BlockNo = "All";
            StatusCode = -1;
            Type = "All";
            Category = "All";

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

                if (this.reportType == ReportType.UnitStatus)
                { s = Application.StartupPath + @"\Reports\UnitStatus.rpt"; }
                else if (this.reportType == ReportType.UnitStatusCount)
                { s = Application.StartupPath + @"\Reports\UnitStatusCount.rpt"; }
                //else if (this.reportType == ReportType.GRN)
                //{ s = Application.StartupPath + @"\Reports\GRNMainReport.rpt"; }
                //else if (this.reportType == ReportType.GIN)
                //{ s = Application.StartupPath + @"\Reports\GINMainReport.rpt"; }

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

                if (this.reportType == ReportType.UnitStatus)
                {
                    cryRpt.SetParameterValue("@ProjectID", this.ProjectID);
                    cryRpt.SetParameterValue("@BlockNo", this.BlockNo);
                    cryRpt.SetParameterValue("@StatusCode", this.StatusCode);
                    cryRpt.SetParameterValue("@Category", this.Category);
                    cryRpt.SetParameterValue("@Type", this.Type);
                }
                else if (this.reportType == ReportType.UnitStatusCount)
                {
                    cryRpt.SetParameterValue("@ProjectID", this.ProjectID);
                }
                //else if (this.reportType == ReportType.GIN)
                //{
                //    cryRpt.SetParameterValue("@docnmbr", this.strDocumentNumber);
                //}


                rptViewer.ReportSource = cryRpt;
                rptViewer.Refresh();
            }
            catch { }
            this.Cursor = Cursors.Arrow;
        }


    }
}
