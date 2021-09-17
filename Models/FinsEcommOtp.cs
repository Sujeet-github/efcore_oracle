using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsEcommOtp
    {
        public decimal Otpid { get; set; }
        public string Cardnumber { get; set; }
        public string Mobileno { get; set; }
        public string Dealerid { get; set; }
        public string Otpvalue { get; set; }
        public DateTime? Adddatetime { get; set; }
        public string Otprrn { get; set; }
        public string Responseid { get; set; }
        public string OtpStatus { get; set; }
        public decimal? AttemptCounter { get; set; }
        public string CardStatus { get; set; }
        public DateTime? Finaldatetime { get; set; }
        public string Nooftransaction { get; set; }
        public string Utilizecount { get; set; }
        public string Servicetype { get; set; }
        public DateTime? Utilizedatetime { get; set; }
        public decimal? GenerateCounter { get; set; }
        public string Trantype { get; set; }
        public string Cardtype { get; set; }
        public string Authcode { get; set; }
        public DateTime? OtpReqdatetime { get; set; }
    }
}
