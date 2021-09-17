using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace projectMigration.Models
{
    public partial class Fins3in1apprequest
    {
        public decimal? Reqseq { get; set; }
        public string AuthRrnnumber { get; set; }
        public decimal? AuthSeqid { get; set; }
        public string Requestpacket { get; set; }
        public string Source { get; set; }
        public DateTime? Addedon { get; set; }

         [MaxLength(50)]
        public string respcode { get; set; }
    }
}
