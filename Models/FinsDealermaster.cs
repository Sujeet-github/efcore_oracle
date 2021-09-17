using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsDealermaster
    {
        public decimal Bflprofileid { get; set; }
        public int Supplierid { get; set; }
        public string Supplierdesc { get; set; }
        public string SupplierDealerFlag { get; set; }
        public int? DealerGrpId { get; set; }
        public string DealerGrpDesc { get; set; }
        public string Pan { get; set; }
        public string ContactPerson { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Stdisd { get; set; }
        public string Phone1 { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string DealerEmail { get; set; }
        public string Classification { get; set; }
        public string LoyalityProgApplicable { get; set; }
        public string Status { get; set; }
        public string Suppliertype { get; set; }
        public int? SupplierBranch { get; set; }
        public string RecordType { get; set; }
        public int? AssetCatgId { get; set; }
        public string ProcessType { get; set; }
        public string PreferredLimitFlag { get; set; }
        public string StoreId { get; set; }
        public string CoBrandLimitFlag { get; set; }
        public string CoBrandCardCode { get; set; }
        public string RewardRedemptionApplicable { get; set; }
        public decimal? RewardRedemptionFee { get; set; }
        public string DummyLanno { get; set; }
        public string AcquringChannel { get; set; }
        public string FinancingType { get; set; }
        public string MerchantCategory { get; set; }
        public string ExistingBank { get; set; }
        public string ExistingMid { get; set; }
        public string ExistingTid { get; set; }
        public string AssetModel { get; set; }
        public byte? NoOfTerminal { get; set; }
        public string Typeofrequest { get; set; }
        public string Remarks { get; set; }
        public string RejectionReason { get; set; }
        public string RecordStatus { get; set; }
        public string Addedon { get; set; }
        public decimal? Addedby { get; set; }
        public string Modifiedon { get; set; }
        public decimal? Modifiedby { get; set; }
        public string AddedIp { get; set; }
        public string ModifedIp { get; set; }
        public string RemiFlag { get; set; }
        public string RemiRejections { get; set; }
        public string DealerUploadFlag { get; set; }
        public string DealerUploadRejections { get; set; }
        public string ChkmakStatus { get; set; }
        public string Mid { get; set; }
        public string State { get; set; }
        public int? Zipcode { get; set; }
        public string ServingCities { get; set; }
        public decimal? AssetSrNo { get; set; }
        public int? Location { get; set; }
        public string Tid { get; set; }
        public string Financingtypecode { get; set; }
        public string RiskIndicator { get; set; }
        public string DealerSupergroup { get; set; }
        public string CashFunding { get; set; }
        public string DiyFlag { get; set; }
        public DateTime? DiyFlagDate { get; set; }
        public string DiyAmount { get; set; }
        public byte? ConvFeeIdentifier { get; set; }
    }
}
