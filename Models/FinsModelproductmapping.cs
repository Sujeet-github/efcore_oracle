using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsModelproductmapping
    {
        public decimal? Modelprodseq { get; set; }
        public decimal Modelid { get; set; }
        public string Product { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modefiedby { get; set; }
        public DateTime? Modefiedon { get; set; }
        public string Ipaddress { get; set; }
        public string Uploadid { get; set; }
    }
}
