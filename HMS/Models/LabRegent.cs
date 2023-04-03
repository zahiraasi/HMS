using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class LabRegent
    {
        public int RegentId { get; set; }
        public string? RegentName { get; set; }
        public int? Stock { get; set; }
        public int? Purchases { get; set; }
        public int? TotalTestValue { get; set; }
        public int? PerTest { get; set; }
        public bool? Active { get; set; }
        public string? Unit { get; set; }
        public int? ServiceId { get; set; }
    }
}
