using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.REMSDal
{
    public class clsRecoveryType
    {
        public string strCode { get; set; }
        public string strDescription { get; set; }
        public bool bDueMonthly { get; set; }
        public bool bIncludeTotal { get; set; }
        public int intId { get; set; }
    }
    public class clsOtherRecoveryPlan
    {
        public string strSizeCode { get; set; }
        public string strPlan { get; set; }
        public string strProject { get; set; }
        public int intInstallmentNo { get; set; }
        public string strRecoveryType { get; set; }
        public int intRecoveryTypeid { get; set; }
        public decimal decAmountDue { get; set; }
        public int intDueAfterMonths { get; set; }
        public int intId { get; set; }

    }
    public class clsMemberRecoveryPlan
    {
        public string strRegistrationNo { get; set; }
        public string strClientID { get; set; }
        public int intMembershipid { get; set; }
        public int intInstallmentNo { get; set; }
        public string strRecoveryType { get; set; }
        public decimal decAmountDue { get; set; }
        public DateTime dateDue { get; set; }
        public decimal decAmountWaived { get; set; }
        public decimal decAmountApplied { get; set; }
        public decimal decOutStandingAmount { get; set; }
        public decimal decTotalAmountWaived { get; set; }
        public decimal decTotalAmountReceived { get; set; }
        public bool Applied { get; set; }
        public bool Delete { get; set; }
        public bool bIncludeInTotal { get; set; }
        public int intId { get; set; }
    }
    public class clsReceiptEntry
    {
        public string Project { get; set; }
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string ClientName { get; set; }
        public string FatherName { get; set; }
        public string PlotSize { get; set; }
        public string OnAccountOf { get; set; }
        public string ClearStatus { get; set; }
        public int Membership_id { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal ReceiptAmount { get; set; }
        public decimal AppliedAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public string ReceiptMode { get; set; }
        public string InstrumentNumber { get; set; }
        public DateTime InstrumentDate { get; set; }
        public string DraweeBank { get; set; }
        public string DraweeBranch { get; set; }
        public string DepositBank { get; set; }
        public string DepositAccount { get; set; }
        public string DepositBy { get; set; }
        public DateTime DepositDate { get; set; }
        public bool Cleared { get; set; }
        public DateTime ClearanceDate { get; set; }
        public string Remarks { get; set; }
        public bool SentToGP { get; set; }
        public int intId { get; set; }

    }
    public class clsReceiptAttachment
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string ReceiptNumber { get; set; }
        public string FileName { get; set; }
        public string Remarks { get; set; }
        public DateTime FileDate { get; set; }
        public byte[] FileContents { get; set; }


    }
    public class clsReceiptApply
    {
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string Receiptnumber { get; set; }
        public decimal decAppliedAmount { get; set; }
        public decimal decWaivedAmount { get; set; }
        public int RecoveryPlanid { get; set; }
        public int intId { get; set; }
    }
    public class clsCheckBook
    {
        public string strCheckbookid { get; set; }
        public string strCheckbookDesc { get; set; }
        public int intAccountid { get; set; }
        public string strBank { get; set; }
    }
}