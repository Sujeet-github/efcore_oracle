using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsCreditprogrammapping
    {
        public string Processtype { get; set; }
        public string Creditprogram { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Status { get; set; }
        public decimal? SrNo { get; set; }
        public string Customertype { get; set; }
        public string Carddesign { get; set; }
    }
}
