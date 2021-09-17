using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsEmiFeeLogicStip
    {
        public decimal? Seqid { get; set; }
        public decimal? ConvFeeIdentifier { get; set; }
        public string CrdType { get; set; }
        public decimal? MinimumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public string TxnType { get; set; }
        public string AuthChargeAmt2 { get; set; }
        public string AuthChargeId2 { get; set; }
        public string ConvApplicable { get; set; }
        public string AuthChargeId4 { get; set; }
        public string AuthChargeAmt4 { get; set; }
        public string CtrApplicable { get; set; }
        public string AuthChargeId5 { get; set; }
        public string AuthChargeAmt5 { get; set; }
        public string SmsText { get; set; }
        public string Status { get; set; }
    }
}
