using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class RequestAudit
    {
        public decimal Reqseqno { get; set; }
        public string Txntype { get; set; }
        public string Sealvalue { get; set; }
        public string Dealercode { get; set; }
        public string Bflreqid { get; set; }
        public string Orderno { get; set; }
        public string Reqpacket { get; set; }
        public string Reqpacketclear { get; set; }
        public DateTime? Addedon { get; set; }
        public string Sourcetype { get; set; }
        public string Cardnumber { get; set; }
        public string Mobilenumber { get; set; }
        public string Dealid { get; set; }
        public string AwlChanneltype { get; set; }
        public string FieldvalidationStatus { get; set; }
        public string AwlTxntype { get; set; }
        public string ReqPktValidFlg { get; set; }
        public string Storeid { get; set; }
    }
}
