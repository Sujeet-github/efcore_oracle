using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsSmsalertmaster
    {
        public string Servicename { get; set; }
        public string SmsFlag { get; set; }
        public string SendsmsTo { get; set; }
        public string SmsText { get; set; }
        public DateTime? Addedon { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Fromemailid { get; set; }
        public string Toemailid { get; set; }
        public string Ccemailid { get; set; }
        public string OtpRestime { get; set; }
        public string AuthRestime { get; set; }
        public string ExtToemail { get; set; }
        public string ExtCcemail { get; set; }
    }
}
