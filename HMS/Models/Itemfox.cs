using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Itemfox
    {
        public Itemfox()
        {
            StoreTransactions = new HashSet<StoreTransaction>();
        }

        public int ItemId { get; set; }
        public string BarCode { get; set; } = null!;
        public string? Name { get; set; }
        public string? TrackNo { get; set; }
        public string? Pkng { get; set; }
        public string? Mqty { get; set; }
        public double? Pkqty { get; set; }
        public double? Trp { get; set; }
        public double? Unit { get; set; }
        public double? Retail { get; set; }
        public double? Stock { get; set; }
        public string? Company { get; set; }
        public int? Required { get; set; }
        public int? MinQuantityAlert { get; set; }
        public string? Distributor { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<StoreTransaction> StoreTransactions { get; set; }
    }
}
