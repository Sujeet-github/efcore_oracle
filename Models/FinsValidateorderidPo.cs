using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsValidateorderidPo
    {
        public decimal? Dealerid { get; set; }
        public string Orderid { get; set; }
        public string Awlchanneltype { get; set; }
        public decimal? RequestAuditSeqno { get; set; }
        public string Respcode { get; set; }
        public string Resdescription { get; set; }
        public DateTime? Addedon { get; set; }
    }
}
