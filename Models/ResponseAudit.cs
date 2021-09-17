using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class ResponseAudit
    {
        public decimal Resseqno { get; set; }
        public decimal? Reqseqno { get; set; }
        public string Respcode { get; set; }
        public string Respacket { get; set; }
        public string Respacketclear { get; set; }
        public DateTime? Addedon { get; set; }
        public string Dealid { get; set; }
        public string Resdescription { get; set; }
    }
}
