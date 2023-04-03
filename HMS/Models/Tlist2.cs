using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Tlist2
    {
        public string? Mcode { get; set; }
        public string Tcode { get; set; } = null!;
        public string? Gcode { get; set; }
        public string? Tname { get; set; }
        public string? NRange { get; set; }
        public string? Unit { get; set; }
        public string? Value { get; set; }
        public string? Hcode { get; set; }
        public int? Orderby { get; set; }
        public int Sno { get; set; }
    }
}
