using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsInactaccountmaster
    {
        public string AccBankcode { get; set; }
        public string AccId { get; set; }
        public string AccCustId { get; set; }
        public string AccType { get; set; }
        public long? AccCreditLimit { get; set; }
        public long? AccTotalAuthBlocked { get; set; }
        public long? AccTotalLoanBlocked { get; set; }
        public long? AccAdjLimit { get; set; }
        public DateTime? AccAdjLimitDate { get; set; }
        public long? AccTempLimit { get; set; }
        public DateTime? AccTempLimitStartDt { get; set; }
        public DateTime? AccTempLimitEndDt { get; set; }
        public string AccSystemBlockCode { get; set; }
        public DateTime? AccSystemBlockDate { get; set; }
        public DateTime? AccSystemUnblockDate { get; set; }
        public string AccManualBlockCode { get; set; }
        public DateTime? AccManualBlockDate { get; set; }
        public DateTime? AccManualUnblockDate { get; set; }
        public string AccVipNonvipFlag { get; set; }
        public DateTime? AccLastAuthDate { get; set; }
        public DateTime? AccCreationDate { get; set; }
        public string AccOldestActPriCard { get; set; }
        public string AccProcDevFlag { get; set; }
        public DateTime? AccProcDevEndDate { get; set; }
        public string AccNameChmpChllg { get; set; }
        public string AccNoOfAddonCards { get; set; }
        public string AccTotalNoOfCards { get; set; }
        public DateTime? AccLastModifyDtWl { get; set; }
        public DateTime? AccLastModifyDtBfl { get; set; }
        public string AccBlockClassification { get; set; }
        public DateTime? AccBlockClassModifyDt { get; set; }
        public string AccSystemUnblockReason { get; set; }
        public string AccManualUnblockReason { get; set; }
        public long? AccBestLimit { get; set; }
        public DateTime? AccIvrUpd { get; set; }
        public DateTime? AccStartDate { get; set; }
        public DateTime? AccEndDate { get; set; }
        public DateTime? AccCreditLimtChgDt { get; set; }
        public string AccCreditLimUpdSrc { get; set; }
        public long? AccFirstTxnLimit { get; set; }
        public string AccFirstTxnRrn { get; set; }
        public DateTime? AccFirstTxnDate { get; set; }
    }
}
