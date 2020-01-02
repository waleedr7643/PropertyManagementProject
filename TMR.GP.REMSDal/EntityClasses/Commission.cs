using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.REMSDal
{
    public class clsCommission
    {
        public string strRegistration { get; set; }
        public string strProject { get; set; }
        public string strClientID { get; set; }
        public string strClientName { get; set; }
        public string strDealer { get; set; }
        public string strEntryNumber { get; set; }
        public int intEntryType { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal decNetPrice { get; set; }
        public decimal decPercentage { get; set; }
        public decimal decAmount { get; set; }
        public string strRemarks { get; set; }
        public bool bSentToGP { get; set; }
        public int intID { get; set; }
    }
}