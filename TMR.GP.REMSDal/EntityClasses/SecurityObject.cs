using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMR.GP.REMSDal.EntityClasses
{
    public class clsSecurityObject
    {
        public string ObjectName { get; set; }
        public string ObjectArea { get; set; }
        public bool AllowOpen { get; set; }
        public bool AllowSave { get; set; }
        public bool AllowPost { get; set; }
        public bool AllowPrint { get; set; }
        public int id { get; set; }
    }

    public class clsUserSecurity
    {
        public string UserId{ get; set; }
  
    }
}
