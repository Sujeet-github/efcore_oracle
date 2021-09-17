using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsValidaterequestid
    {
        public decimal Dealerid { get; set; }
        public string Requestid { get; set; }
        public string Awlchanneltype { get; set; }
        public DateTime? Addedon { get; set; }
    }
}
