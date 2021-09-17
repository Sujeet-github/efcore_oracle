using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsManufacturermaster
    {
        public decimal Mmid { get; set; }
        public string UploadId { get; set; }
        public decimal ManufactureId { get; set; }
        public string Bankcode { get; set; }
        public string ManufactureDesc { get; set; }
        public decimal? Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Ipaddress { get; set; }
    }
}
