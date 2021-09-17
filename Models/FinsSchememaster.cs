using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsSchememaster
    {
        public decimal? Smid { get; set; }
        public string UploadId { get; set; }
        public decimal Schemeid { get; set; }
        public string Bankcode { get; set; }
        public string Schemedesc { get; set; }
        public short? Tenure { get; set; }
        public string ProcessingFees { get; set; }
        public string Product { get; set; }
        public decimal? AdvanceEmi { get; set; }
        public string Dbd { get; set; }
        public string Mbd { get; set; }
        public decimal? Intrate { get; set; }
        public DateTime? SchemeStartDate { get; set; }
        public DateTime? SchemeExpiryDate { get; set; }
        public string PortalDescription { get; set; }
        public long? Maxamount { get; set; }
        public long? Minamount { get; set; }
        public string GenSch { get; set; }
        public string SplSch { get; set; }
        public string DealerMapping { get; set; }
        public string ModelMapping { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Ipaddress { get; set; }
        public decimal? MaxEmiAmountPer { get; set; }
    }
}
