using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsAcqproductparammaster
    {
        public decimal? Seq { get; set; }
        public string Acqchannel { get; set; }
        public string Productid { get; set; }
        public string Productname { get; set; }
        public string Otpbypass { get; set; }
        public string Settlement { get; set; }
        public string Cancelotpbypass { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Status { get; set; }
    }
}
