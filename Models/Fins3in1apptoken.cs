using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class Fins3in1apptoken
    {
        public decimal? Seqno { get; set; }
        public string Token { get; set; }
        public decimal? Expiresin { get; set; }
        public string Source { get; set; }
        public string Response { get; set; }
        public DateTime? Addedon { get; set; }
    }
}
