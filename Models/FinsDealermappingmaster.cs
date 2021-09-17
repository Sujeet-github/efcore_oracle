using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsDealermappingmaster
    {
        public decimal Delmapseq { get; set; }
        public string Uploadid { get; set; }
        public decimal Supplierid { get; set; }
        public string Code { get; set; }
        public string RecordType { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modefiedby { get; set; }
        public DateTime? Modefiedon { get; set; }
        public string Ipaddress { get; set; }
    }
}
