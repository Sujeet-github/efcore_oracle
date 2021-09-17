using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsDealershortname
    {
        public decimal? Dshortseq { get; set; }
        public string Dealercode { get; set; }
        public string Dealershortname { get; set; }
        public DateTime? Addedon { get; set; }
        public DateTime? Modifiedon { get; set; }
    }
}
