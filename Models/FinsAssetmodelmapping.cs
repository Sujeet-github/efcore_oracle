using System;
using System.Collections.Generic;

#nullable disable

namespace projectMigration.Models
{
    public partial class FinsAssetmodelmapping
    {
        public decimal Bflprofileid { get; set; }
        public string Assetid { get; set; }
        public string Modelid { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addedon { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Status { get; set; }
    }
}
