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

namespace TMR.GP.REMSAddin.UserForms
{
    public partial class frmGeneralAccountingProcessReport : Form
    {
        public enum ReportCategory { AccountStatement }
        public ReportCategory Reporcategory { get; set; }
        public frmGeneralAccountingProcessReport()
        {
            InitializeComponent();
        }

        private void frmGeneralAccountsReport_Load(object sender, EventArgs e)
        {
            if (Reporcategory == ReportCategory.AccountStatement)
            {
                this.Text = "Account Statement";
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text == " ")
                return;
            
            frmReport frm = new frmReport();

            if (Reporcategory == ReportCategory.AccountStatement)
            {
                frm.reportType = ReportType.AccountStatement;
            }
            frm.strRegistrationNo = txtRegistrationNo.Text;
           
            frm.Show();
        
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            frmMemberLookup frm = new frmMemberLookup();
            frm.memberlookupCode = memberLookupCodes.All;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtRegistrationNo.Text = frm.strMemberShipID;
                txtRegistrationNo.Focus();                
            }
        }
       
       
    }
}
