using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsBulkdealerdetail
    {
        public decimal BulkId { get; set; }
        public decimal? Uploadid { get; set; }
        public string DealerId { get; set; }
        public string DealerDescription { get; set; }
        public string DealershortName { get; set; }
        public string Ipaddress { get; set; }
        public string Userid { get; set; }
        public string Flag { get; set; }
        public string Description { get; set; }
        public string StatusFlag { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Actionflag { get; set; }
        public decimal? ProcessingFee { get; set; }
        public string Ranking { get; set; }
        public DateTime? Createddate { get; set; }
        public string Createdby { get; set; }
    }
}
