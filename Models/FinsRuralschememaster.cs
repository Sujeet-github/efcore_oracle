using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsRuralschememaster
    {
        public decimal? Seqid { get; set; }
        public string Schemeid { get; set; }
        public string Ruralschemeid { get; set; }
        public DateTime? Createddate { get; set; }
        public string Createdby { get; set; }
        public string Ipaddress { get; set; }
        public string Createdid { get; set; }
        public string Activestatus { get; set; }
        public string Modifiedby { get; set; }
        public string Modifiedid { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string Nschemeproduct { get; set; }
        public string Rschemeproduct { get; set; }
    }
}
