using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsTid
    {
        public string Bflprofileid { get; set; }
        public string Tid { get; set; }
        public string Addedon { get; set; }
        public decimal? Addedby { get; set; }
        public string PosType { get; set; }
        public string AcqChnl { get; set; }
        public string Acqchncode { get; set; }
        public string Tidstatus { get; set; }
        public DateTime? AcqchangeDate { get; set; }
        public DateTime? Tidcreationdate { get; set; }
    }
}
