using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsDealermanfmapping
    {
        public decimal? DlrMnfmapid { get; set; }
        public decimal Supplierid { get; set; }
        public decimal ManufacturerId { get; set; }
        public decimal? Bankpk { get; set; }
        public string Uploadid { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? Processeddate { get; set; }
        public string RecordStatusFlag { get; set; }
    }
}
