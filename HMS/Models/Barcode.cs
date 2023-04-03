using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Barcode
    {
        public int Sno { get; set; }
        public string? Barcode1 { get; set; }
        public string? ProductName { get; set; }
        public string? Price { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Status { get; set; }
        public DateTime? Expiry { get; set; }
        public string? Batchno { get; set; }
        public bool? IsExpire { get; set; }
    }
}
