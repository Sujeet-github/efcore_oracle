using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsAccprodmapping
    {
        public decimal? Id { get; set; }
        public string Accounttype { get; set; }
        public string Product { get; set; }
        public decimal? Priority { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modifyby { get; set; }
        public DateTime? Modifyon { get; set; }
        public string Ipaddress { get; set; }
        public string Status { get; set; }
    }
}
