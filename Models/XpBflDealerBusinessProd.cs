using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class XpBflDealerBusinessProd
    {
        public decimal Dealerbusiprodid { get; set; }
        public decimal Dealerid { get; set; }
        public string Businessproddesc { get; set; }
        public DateTime? Modifiedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public string ModifedIp { get; set; }
        public string BusiProdCode { get; set; }
    }
}
