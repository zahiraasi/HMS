using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Purchase
    {
        public int Sno { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public double? Retail { get; set; }
        public int? PurchaseItem { get; set; }
        public int? Qty { get; set; }
        public double? PurchasePrice { get; set; }
        public bool? IsPurchase { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? Distributor { get; set; }
        public bool? IsUpdated { get; set; }
        public int? Per { get; set; }
        public int? PoNo { get; set; }
    }
}
