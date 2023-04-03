using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class NormalRange
    {
        public int RangeId { get; set; }
        public string? RangeName { get; set; }
        public bool? PostiveNegative { get; set; }
        public int? MinRange { get; set; }
        public int? MaxRange { get; set; }
        public string? Unit { get; set; }
        public string? Remarks { get; set; }
    }
}
