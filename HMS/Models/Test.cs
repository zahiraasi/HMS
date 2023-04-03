using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Test
    {
        public int ServiceId { get; set; }
        public string? TestName { get; set; }
        public string? Price { get; set; }
        public string? Sample { get; set; }
        public string? Duration { get; set; }
        public int? CaseId { get; set; }
        public string? PerType { get; set; }
        public int? Mcode { get; set; }
        public int? Gcode { get; set; }
        public string Oldid { get; set; } = null!;
        public int? RegendId { get; set; }
        public bool? IsDynamicRate { get; set; }
    }
}
