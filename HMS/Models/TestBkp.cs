using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class TestBkp
    {
        public string TestSno { get; set; } = null!;
        public string? TestName { get; set; }
        public string? Price { get; set; }
        public string? TestSample { get; set; }
        public string? Duration { get; set; }
        public int? RefPer { get; set; }
        public string? CaseType { get; set; }
        public string? Mcode { get; set; }
        public string? Gcode { get; set; }
        public string? Tcode { get; set; }
    }
}
