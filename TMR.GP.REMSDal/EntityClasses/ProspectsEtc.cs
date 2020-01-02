using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.REMSDal
{
    public class clsProspect
    {
        
        public string ProjectNo { get; set; }
        public string Sector { get; set; }
        public string UPlot { get; set; }
        public string UnitType { get; set; }
        public string UnitCategory { get; set; }
        public decimal UnitAdditionalChrg { get; set; }
        public decimal PlotPrice { get; set; }
        public decimal PlotAdditionalCharges { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public string ProspectName { get; set; }
        public string ProspectFatherName { get; set; }
        public string CNIC { get; set; }
        public string ContactNo { get; set; }
        public string ProspectPaymentPlan { get; set; }
        public string SizeCode { get; set; }
        public DateTime ProspectStartDate { get; set; } 
        public int id { get; set; }
    }
}