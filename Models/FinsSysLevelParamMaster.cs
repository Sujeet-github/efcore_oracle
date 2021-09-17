using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsSysLevelParamMaster
    {
        public decimal? SysLevelId { get; set; }
        public string SysLevelParameter { get; set; }
        public string Paramatervalues { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addon { get; set; }
        public string Modifyby { get; set; }
        public DateTime? Modifyon { get; set; }
        public string Ipaddress { get; set; }
        public string Status { get; set; }
    }
}
