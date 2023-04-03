using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Otmedicine
    {
        public int MedicineId { get; set; }
        public string? Code { get; set; }
        public string? Barcode { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public string? Remarks { get; set; }
        public int? Otid { get; set; }

        public virtual Otlist Medicine { get; set; } = null!;
    }
}
