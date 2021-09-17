using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsProfilekeyconfig
    {
        public decimal? Keyid { get; set; }
        public string Bankcode { get; set; }
        public string Profilekey { get; set; }
        public string Thirdparty { get; set; }
        public DateTime? Addedon { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Ipaddress { get; set; }
        public decimal? Keylength { get; set; }
        public string Modulecode { get; set; }
        public string ProfileId { get; set; }
    }
}
