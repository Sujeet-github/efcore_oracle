using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsGetdealerkey
    {
        public decimal Keyseq { get; set; }
        public decimal Dealerid { get; set; }
        public string Securitykey { get; set; }
        public decimal? Addedon { get; set; }
        public DateTime? Addedondate { get; set; }
        public DateTime? Addedontime { get; set; }
        public string Status { get; set; }
        public string Keytype { get; set; }
        public string Modulename { get; set; }
    }
}
