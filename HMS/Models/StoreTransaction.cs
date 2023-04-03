using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class StoreTransaction
    {
        public int StoreId { get; set; }
        public int? TransId { get; set; }
        public int? PatientId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public int? Discount { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }

        public virtual Itemfox? Item { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
