using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Tlist
    {
        public int Tcode { get; set; }
        public int? Mcode { get; set; }
        public int? Gcode { get; set; }
        public string? Tname { get; set; }
        public string? NormalRange { get; set; }
        public string? Unit { get; set; }
        public string? Value { get; set; }
        public string? Heading { get; set; }
        public int? Orderby { get; set; }
        public bool? PositiveNegative { get; set; }
        public int? MinRange { get; set; }
        public int? MaxInt { get; set; }
    }
}
