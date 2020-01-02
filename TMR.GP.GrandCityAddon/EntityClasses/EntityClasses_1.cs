using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.GrandCityAddon
{
    public class clsApprovalCreate
    {
        public int ApprovalStatusCode { get; set; }
        public string ApprovalStatusDescription { get; set; }
        public string ApprovalActionUser { get; set; }
        public DateTime ApprovalActionDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }

    
    public class clsProjects
    {
        public int id { get; set; }
        public string strPrefix { get; set; }
        public string strNumber { get; set; }
        public string strProjectid { get; set; }
        public string strProjectName { get; set; }
        public string strLocation { get; set; }
        public bool bSubProject { get; set; }
        public string strMainProjecID { get; set; }

    }
    public class clsStatusCodes
    {
        public int intStatusID { get; set; }
        public string strStatusTag { get; set; }
        public string strDescription { get; set; }
        public int intStatusCode { get; set; }
    }

    public class clsSizeCodePriceList
    {
            public int id { get; set; }
            public string strProjectID { get; set; }
            public string strBlockID { get; set; }
            public string strSizeCode { get; set; }
            public decimal dPrice { get; set; }
           
            public int Fk_RevaluationID { get; set; }
    }
    public class clsTransferHistory :  clsApprovalCreate
    {
        public int intID { get; set; }
        public int intPreviousStatusCode { get; set; }
        public string strRegistrationNo { get; set; }
        public string strTransferFromID { get; set; }
        public string strTransferToID { get; set; }
        public DateTime dtTransferDate { get; set; }
        public string strName { get; set; }
        public string strFatherOrHusbandType { get; set; }
        public string strFatherOrHusband { get; set; }
        public string strNIDOrCNIC { get; set; }
        public string strNationality { get; set; }
        public DateTime dtDOB { get; set; }
        public string strCurrentAddress1 { get; set; }
        public string strCurrentAddress2 { get; set; }
        public string strCurrentAddress3 { get; set; }
        public string strCountry { get; set; }
        public string strCity { get; set; }
        public string strPhOff { get; set; }
        public string strRes { get; set; }
        public string strMob { get; set; }
        public string strFax { get; set; }
        public string strEmailAddress { get; set; }
        public string strLocation { get; set; }
        public bool bSubProject { get; set; }
        public string strMainProjecID { get; set; }

    }
    public class clsBlock
    {
        public int id { get; set; }
        public string BlockNo { get; set; }
        public string BlockName { get; set; }
        public string ProjectID { get; set; }
        public string strUOMid { get; set; }
        public decimal decTotalArea { get; set; }
        public decimal decDevelopedArea { get; set; }

    }
    public class clsMemberRegistration
    {
        public int id { get; set; }
        public int intPercentage { get; set; }
        public string RegistrationNo { get; set; }
        public string strPrefix { get; set; }
        public string strNumber { get; set; }
        public string ClientID { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public string FatherOrHusbandType { get; set; }
        public string FatherOrHusband { get; set; }
        public string NIDOrCNIC { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string CurrentAddress1 { get; set; }
        public string CurrentAddress2 { get; set; }
        public string CurrentAddress3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhOff { get; set; }
        public string Res { get; set; }
        public string Mob { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Plan { get; set; }
        public DateTime Booking { get; set; }
        public string Block { get; set; }
        public string Plot { get; set; }
        public decimal UnitRate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal FinanceAmt { get; set; }
        public decimal RebatAmt { get; set; }
        public decimal NetOrRetailPrice { get; set; }
        public decimal BookingPrice { get; set; }
        public string strProjectid { get; set; }
        public bool bitAllocated { get; set; }
        public string strStatus { get; set; }
        public int intStatusCode { get; set; }
        public bool bActive { get; set; }
        public memberLookupCodes MembershipStatus { get; set; }
        public string strDirectorName { get; set; }
        public string BankName { get; set; }
        public string AccountTitle { get; set; }
        public string AccountNumber { get; set; }
        public bool bSoleOwner { get; set; }
        public bool bTransferPending { get; set; }
        public bool bSendToGP { get; set; }
        public string strSalesRep { get; set; }

    }
    public class clsMemberAttachment
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string FileName { get; set; }
        public string Remarks { get; set; }
        public DateTime FileDate { get; set; }
        public byte[] FileContents { get; set; }


    }
    public class clsTransferAttachment
    {
        public int id { get; set; }
        public int TransferId { get; set; }
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string FileName { get; set; }
        public string Remarks { get; set; }
        public DateTime FileDate { get; set; }
        public byte[] FileContents { get; set; }


    }
    public class clsMemberImage
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }

    }

    public class clsTransferImage
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }
        public int TransferID { get; set; }

    }
    public class clsTransferCNIC
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }
        public int TransferID { get; set; }

    }
    public class clsNomineeImage
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string NomineeID { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }

    }
    /// <summary>
    /// Class for Nominee CNIC
    /// </summary>
    public class clsNomineeCNIC
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string NomineeID { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }

    }
    /// <summary>
    /// Class for Partner Image
    /// </summary>
    public class clsPartnerImage
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string PartnerID { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }

    }
    /// <summary>
    /// Class for Partner CNIC
    /// </summary>
    public class clsPartnerCNIC
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public string PartnerID { get; set; }
        public string ClientID { get; set; }
        public string ImageId { get; set; }
        public byte[] Image { get; set; }

    }
    /// <summary>
    /// Class for Nominee Details
    /// </summary>
    public class clsNominee
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string NomineeID { get; set; }
        public string ClientID { get; set; }
        public string Name { get; set; }
        public string FatherOrHusband { get; set; }
        public string NIDOrCNIC { get; set; }
        public string CurrentAddress1 { get; set; }
        public string CurrentAddress2 { get; set; }
        public string CurrentAddress3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Relation { get; set; }
        public int Percentage { get; set; }

    }
    /// <summary>
    /// Class for Partner Details
    /// </summary>
    public class clsPartner
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string PartnerID { get; set; }
        public string ClientID { get; set; }
        public string Name { get; set; }
        public string FatherOrHusband { get; set; }
        public string NIDOrCNIC { get; set; }
        public string CurrentAddress1 { get; set; }
        public string CurrentAddress2 { get; set; }
        public string CurrentAddress3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Relation { get; set; }
        public int Percentage { get; set; }
        public string BankName { get; set; }
        public string AccountTitle { get; set; }
        public string AccountNumber { get; set; }

    }
    public class clsAllocation : clsApprovalCreate
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string strProjectid { get; set; }
        public string strBlock { get; set; }
        public string strClientID { get; set; }
        public string strUnitID { get; set; }
        public DateTime dtAllocationDate { get; set; }
        public bool bitApprove { get; set; }
        public string strRemarks { get; set; }
        public string strDirector { get; set; }
        public int intPreviousStatusCode { get; set; }
        public string StatusDescription { get; set; }
       
    }
    public class clsTransfer
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string TransferID { get; set; }
        public string Name { get; set; }
        public string FatherOrHusbandType { get; set; }
        public string FatherOrHusband { get; set; }
        public string NIDOrCNIC { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public string CurrentAddress1 { get; set; }
        public string CurrentAddress2 { get; set; }
        public string CurrentAddress3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhOff { get; set; }
        public string Res { get; set; }
        public string Mob { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
    }
    public class clsCancellation : clsApprovalCreate
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string strProjectid { get; set; }
        public string strBlock { get; set; }
        public string ClientID { get; set; }
        public string strUnitID { get; set; }
        public bool Approved { get; set; }
        public string Remarks { get; set; }
        public DateTime CancellationDate { get; set; }
        public int intPreviousStatusCode { get; set; }
        public string StatusDescription { get; set; }

    }
    public class clsDeAllocation
    {
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string ClientID { get; set; }
        public bool Approved { get; set; }
        public string Remarks { get; set; }
        public DateTime DeAllocationDate { get; set; }
    }
    public class clsReactivation : clsApprovalCreate
    {
   
        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string ClientID { get; set; }

        public string strProjectid { get; set; }
        public bool Approved { get; set; }
        public string Remarks { get; set; }
        public DateTime ReActivationDate { get; set; }
        public int intPreviousStatusCode { get; set; }
        public string StatusDescription { get; set; }


    }
    public class clsRefund : clsApprovalCreate
    {

        public int id { get; set; }
        public string RegistrationOrBookingNo { get; set; }
        public string ClientID { get; set; }
        public string strProjectid { get; set; }
        public bool Approved { get; set; }
        public string Remarks { get; set; }
        public DateTime RefundDate { get; set; }
        public int intPreviousStatusCode { get; set; }
        public string StatusDescription { get; set; }
        public decimal decProfit { get; set; }
        public decimal decDeduction { get; set; }
        public decimal decTax { get; set; }
        public decimal decNet { get; set; }
    }

}
