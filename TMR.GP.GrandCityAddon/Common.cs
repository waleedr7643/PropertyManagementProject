using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMR.GP.GrandCityAddon.UserForms;

namespace TMR.GP.GrandCityAddon
{
    
    public enum memberLookupCodes
    {
        All = 0, Unallocated = 1, New = 2, Allocated = 3, MarkedForCancellation = 4, Cancelled = 5, MarkedForRefund = 6, Refunded = 7,
        MarkedForReactivation = 8, Reactivate = 9, MarkedForDeallocation = 10, Deallocte = 11, MarkedForAllocation = 12,
        MarkedForTransfer = 13, Transferred = 14
    }
    public enum unitLookupCodes { All = 0, Available = 1, Allocated = 2, MarkedForAllocation = 3}
    public enum ApprovalStatus { Pending = 1, Approved = 2, Rejected = 3 }
    public enum AttachmentType { MemberRegistration = 1, Transfer = 2}
}