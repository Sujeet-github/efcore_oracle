using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsInactcardmaster
    {
        public string CrdNo { get; set; }
        public string CrdCustId { get; set; }
        public string CrdAccountId { get; set; }
        public string CrdBankCode { get; set; }
        public string CrdType { get; set; }
        public DateTime? CrdCreaDt { get; set; }
        public string CrdExpDt { get; set; }
        public string CrdDealerCd { get; set; }
        public string CrdGrpDealerCd { get; set; }
        public string CrdGrpDealerName { get; set; }
        public string CrdSrcType { get; set; }
        public string CrdPrimaryAddOnInd { get; set; }
        public string CrdPin { get; set; }
        public long? CrdEmiCharges { get; set; }
        public DateTime? CrdActivationDt { get; set; }
        public string CrdLatestStatus { get; set; }
        public DateTime? CrdReissueDt { get; set; }
        public string CrdReplNewCard { get; set; }
        public string CrdReplOldCard { get; set; }
        public string CrdWecareRefNo { get; set; }
        public DateTime? CrdLastAuthDt { get; set; }
        public DateTime? CrdLastModifyDt { get; set; }
        public string CrdUserName { get; set; }
        public byte? CrdWrngPinAttmpt { get; set; }
        public string CrdNameOnCard { get; set; }
        public string CrdAddonmobile { get; set; }
        public string CrdAddonresidenceEmail { get; set; }
        public string CrdAddonrelationshipPrim { get; set; }
        public DateTime? CrdAddondob { get; set; }
        public string CrdAddondocsFlag { get; set; }
        public DateTime? CrdAddonlastModifyDt { get; set; }
        public DateTime? CrdAddonmobChangeDt { get; set; }
        public string CrdAddonoldMobilNo { get; set; }
        public decimal? CrdDesign { get; set; }
        public string CrdTypeIdentifier { get; set; }
        public string CrdSourceInd { get; set; }
        public string CrdSystemBlockCode { get; set; }
        public DateTime? CrdSystemBlockDate { get; set; }
        public DateTime? CrdSystemUnblockDate { get; set; }
        public string CrdManualBlockCode { get; set; }
        public DateTime? CrdManualBlockDate { get; set; }
        public DateTime? CrdManualUnblockDate { get; set; }
        public string CrdChargedRrn { get; set; }
        public string CrdWrngOtpAttmpt { get; set; }
        public DateTime? CrdLastModifyDtWl { get; set; }
        public DateTime? CrdLastModifyDtBfl { get; set; }
        public string CrdFundedNonfunded { get; set; }
        public string CrdManualUnblockReason { get; set; }
        public string CrdSystemUnblockReason { get; set; }
        public DateTime? CrdIvrUpd { get; set; }
        public byte? CrdActivationMob { get; set; }
        public string CrdAddonParentConsentFlag { get; set; }
    }
}
