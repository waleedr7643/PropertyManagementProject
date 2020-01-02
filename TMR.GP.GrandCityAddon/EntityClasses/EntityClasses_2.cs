using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.GrandCityAddon
{
    public class clsUnitofMeasure
    {
        public int id { get; set; }
        public string strUOMid { get; set; }
        public string strUOMDesc { get; set; }
    }
    public class clsUnitCategory
    {
        public int id { get; set; }
        public string strUnitCategoryID { get; set; }
        public string strDesc { get; set; }
    }

    public class clsunitStatus
    {
        public string strStatus { get; set; }
    }

    public class clsUnitsFilter
    {
        public clsUnitsFilter()
        {
            strUnitID = ""; strProjectID = ""; strBlockNo = ""; strStreetNo = "";
            strSizeCode = ""; strPlotNo = ""; strUnitNatureID = ""; strUnitCategoryID = "";
            strUnitCategoryID = ""; strStatus = ""; decPrice = 0; decArea = 0; strUOMID = "";
            decWidth = 0; decLength = 0; strRegistrationNo = ""; ID = 0;


        }
        public string strUnitID { get; set; }
        public string strProjectID { get; set; }
        public string strBlockNo { get; set; }
        public string strStreetNo { get; set; }
        public string strSizeCode { get; set; }
        public string strPlotNo { get; set; }
        public string strUnitNatureID { get; set; }
        public string strUnitCategoryID { get; set; }
        public string strStatus { get; set; }
        public decimal decPrice { get; set; }
        public decimal decArea { get; set; }
        public string strUOMID { get; set; }
        public decimal decWidth { get; set; }
        public decimal decLength { get; set; }
        public string strRegistrationNo { get; set; }
        public int ID { get; set; }
    }

    public class clsUnitType
    {
        public int id { get; set; }
        public string strUnitTypeID { get; set; }
        public string strDesc { get; set; }
    }
    public class clsSizeCodes
    {
        public string strProject { get; set; }
        public string strUnitSizeCode { get; set; }
        public string strUnitSizeDescription { get; set; }
        public decimal decArea { get; set; }
        public string UoMID { get; set; }
        public string UoMDescription { get; set; }
        public string strPrefix { get; set; }
        public string strCurrentNumber { get; set; }
        public int ID { get; set; }
    }
    public class clsUnit
    {
        public string strUnitID { get; set; }
        public string strPrefix { get; set; }
        public string strNumber { get; set; }
        public string strProjectID { get; set; }
        public string strBlockNo { get; set; }
        public string strStreetNo { get; set; }
        public string strSizeCode { get; set; }
        public string strPlotNo { get; set; }
        public string strUnitCategoryID { get; set; }
        public string strUnitTypeID { get; set; }
        public string strStatus { get; set; }
        public decimal decPrice { get; set; }
        public decimal decArea { get; set; }
        public string strUOMID { get; set; }
        public decimal decWidth { get; set; }
        public decimal decLength { get; set; }
        public decimal decSquareFeet { get; set; }
        public string strRegistrationNo { get; set; }
        public int ID { get; set; }

        public int statuscode { get; set; }

    }
    public class clsMemberShipFilter
    {
        public clsMemberShipFilter()
        {
            strUnitID = ""; strProjectID = "All"; strBlockNo = "All"; strName = "";
            strMobileNumber = ""; strMemberShipID = ""; strClientID = "";
            membershipStatus = memberLookupCodes.All;
            bFilterAllocated = true; bAllocated = false;
            bForProcess = false;
        }

        public memberLookupCodes membershipStatus { get; set; }
        public string strUnitID { get; set; }
        public string strProjectID { get; set; }
        public string strBlockNo { get; set; }
        public string strName { get; set; }
        public string strMobileNumber { get; set; }
        public string strMemberShipID { get; set; }//RegistrationNumber
        public string strClientID { get; set; }
        public bool bFilterAllocated { get; set; }//If this flag is true then Allocated filter will be applied
        public bool bAllocated { get; set; }
        public bool bForProcess { get; set; }
    }

    public class clsDocumentFilter
    {
        public clsDocumentFilter()
        {
            strRegistrationNo = "";
            strClientID = "";
            strProjectID = "";
            strToClientID = "";
            dateStartDate = System.DateTime.Now;
            dateEndDate = System.DateTime.Now;
            intApprovalStatusCode = 0;

        }

        public string strRegistrationNo { get; set; }
        public string strClientID { get; set; }//To be used as From client in transfer. To be used as client in other process filters.
        public string strToClientID { get; set; }//To be used only on transfer entry as To Client. Not to be used in any other process filter
        public string strProjectID { get; set; }
        public DateTime dateStartDate { get; set; }
        public DateTime dateEndDate { get; set; }
        public int intApprovalStatusCode { get; set; }

    }
    public class clsMemberStatusFilter
    {
        public clsMemberStatusFilter()
        {
            strRegistrationNo = ""; strClientID = ""; dtCancellationDate = System.DateTime.Now; boolApprove = false;
            strRemarks = ""; id = "";

        }
        public string strRegistrationNo { get; set; }
        public string strClientID { get; set; }
        public DateTime dtCancellationDate { get; set; }
        public bool boolApprove { get; set; }
        public string strRemarks { get; set; }
        public string id { get; set; }
    }

    public class clsUnitRevaluation : clsApprovalCreate
    {
        public string strProject { get; set; }
        public string strBlock { get; set; }
        public DateTime dateRevaluationDate { get; set; }
        public int id { get; set; }
    }
    public class clsUnitRevaluationListItem
    {
        public int id { get; set; }
        public int Revaluationid { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public string SizeCode { get; set; }
        public string BlockID { get; set; }
    }
    public class clsDirector
    {
        public string strName { get; set; }
        public string strCNIC { get; set; }
        public int id { get; set; }
    }
    public class clsUser
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
        public bool inactive { get; set; }
        public int id { get; set; }

    }
    public class clsInstallmentPlan
    {
        public string strIntallmentPlanCode { get; set; }
        public string strInstallmentPlanName { get; set; }
        public bool bInactive { get; set; }
        public int intId { get; set; }

    }
    public class clsInstallmentPlanDetails
    {
        public string strInstallmentPlanCode { get; set; }
        public int intInstallmentPlanID { get; set; }
        public int intInstallmentType { get; set; }
        public string strInstallmentTypeName { get; set; }
        public int intInstallmentDueAfterMonths { get; set; }
        public int intInstallmentPercentage { get; set; }
        public int intInstallmentNumber { get; set; }
        public int intId { get; set; }

    }
}