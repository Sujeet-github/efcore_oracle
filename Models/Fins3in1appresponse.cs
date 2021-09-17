using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class Fins3in1appresponse
    {
        public decimal? Resseq { get; set; }
        public decimal? Reqseq { get; set; }
        public string Responsepacket { get; set; }
        public string Responsecode { get; set; }
        public string Responsedesc { get; set; }
        public DateTime? Addedon { get; set; }
        public string Alertsmsflag { get; set; }
    }
}
