using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsProductlevelparammaster
    {
        public decimal? ProductLevelId { get; set; }
        public string Product { get; set; }
        public string Dueday { get; set; }
        public string Refundday { get; set; }
        public string Settelment { get; set; }
        public string Ctrallowed { get; set; }
        public string Ruralproduct { get; set; }
        public string Accounttypeid { get; set; }
        public string Status { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addon { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Modifyon { get; set; }
        public string Ipaddress { get; set; }
        public string BaseDueDateCheck { get; set; }
    }
}
