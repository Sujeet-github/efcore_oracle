using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsValidateorderid
    {
        public decimal Dealerid { get; set; }
        public string Orderid { get; set; }
        public string Awlchanneltype { get; set; }
        public DateTime? Addedon { get; set; }
    }
}
