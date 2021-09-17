using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsApiwiselog
    {
        public decimal? Auditseq { get; set; }
        public string Application { get; set; }
        public string Packagename { get; set; }
        public string Procedurename { get; set; }
        public string Errortext { get; set; }
        public DateTime? Addedon { get; set; }
        public string Fieldname { get; set; }
        public string Fieldvalue { get; set; }
    }
}
