using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.REMSDal
{
    public class PMPurchaseDocument
    {
        public string DocumentNumber { get; set; }
        public string TransactionDescription { get; set; }
        public string ReturnBatch { get; set; }
        public string VendNumber { get; set; }
        public string VendorName { get; set; }
        public string CurrencyId { get; set; }
        public string BatchNumber { get; set; }
        public string BatchSource { get; set; }
        public short DocumentType { get; set; }
        public short PmDocumentTypeAll { get; set; }
        public short PostingStatus { get; set; }
        public bool TaxEngineCalled { get; set; }
        public decimal AccountAmount { get; set; }        
        public int PayActIndx { get; set; }
        public List<PMPurchaseDistribution> Distributions { get; set; }
        public string Status { get; set; }//Can have values New, Old, Deleted
        public string VoucherNumber { get; set; }
    }
    public class PMPurchaseDistribution
    {
        public short PostingStatus { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentStatus { get; set; }
        public short DistributionType { get; set; }
        public short PmDocumentTypeAll { get; set; }
        public int SequenceNumber { get; set; }
        public string VendorNumber { get; set; }
        public int DistributionAccountIndex { get; set; }
        public decimal ManualPaymentAmount { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public string CurrencyId { get; set; }
        public short CurrencyIndex { get; set; }
        public string DistributionReference { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxType { get; set; }
    }
}
