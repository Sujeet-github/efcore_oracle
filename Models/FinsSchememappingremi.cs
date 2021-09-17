using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsSchememappingremi
    {
        public decimal? Schid { get; set; }
        public string Parentschemeid { get; set; }
        public string Mappedschemeid { get; set; }
        public string Mappedproduct { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string Status { get; set; }
    }
}
