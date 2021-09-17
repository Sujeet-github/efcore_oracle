using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsSchememodelmapping
    {
        public decimal? SchidMdl { get; set; }
        public decimal? SchemeId { get; set; }
        public string ModelId { get; set; }
        public string ManufacturerId { get; set; }
        public string Categoryid { get; set; }
        public decimal? Bankpk { get; set; }
        public string Uploadid { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? Processeddate { get; set; }
    }
}
