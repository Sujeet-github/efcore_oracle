using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class WsKeyconfigmultiservice
    {
        public decimal? Keyid { get; set; }
        public string Bankcode { get; set; }
        public string Encryptionkey { get; set; }
        public string Thirdparty { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Ipaddress { get; set; }
        public string Emailid { get; set; }
        public decimal? Keylength { get; set; }
        public string Modulecode { get; set; }
        public string Dealercode { get; set; }
    }
}
