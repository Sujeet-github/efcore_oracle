using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsAssetcategorymaster
    {
        public decimal Assetcatseq { get; set; }
        public string Uploadid { get; set; }
        public decimal Catgid { get; set; }
        public string Catgdesc { get; set; }
        public string CibilCheck { get; set; }
        public string RiskClassification { get; set; }
        public string DigitalFlag { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modefiedby { get; set; }
        public DateTime? Modefiedon { get; set; }
        public string Ipaddress { get; set; }
    }
}
