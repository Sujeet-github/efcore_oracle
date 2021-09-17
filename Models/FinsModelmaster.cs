using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsModelmaster
    {
        public decimal? ModelSeq { get; set; }
        public decimal Modelid { get; set; }
        public string Modelno { get; set; }
        public int? Categoryid { get; set; }
        public int? Manufacturerid { get; set; }
        public decimal? SellingPrice { get; set; }
        public DateTime? ModelExpiryDate { get; set; }
        public int? SizeId { get; set; }
        public string Make { get; set; }
        public string ProductCode { get; set; }
        public DateTime? AddedDate { get; set; }
        public string Uploadid { get; set; }
        public string SerialNoValidFlag { get; set; }
        public string SfdcModelId { get; set; }
        public decimal? ModelMinPrice { get; set; }
        public string SfdcModelCode { get; set; }
    }
}
