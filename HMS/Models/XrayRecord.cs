using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class XrayRecord
    {
        public int Sno { get; set; }
        public string? BranchId { get; set; }
        public string? ServiceId { get; set; }
        public string? PatientId { get; set; }
        public string? Mcode { get; set; }
        public string? Gcode { get; set; }
        public string? TestName { get; set; }
        public string? TestValue { get; set; }
        public string? TestHeading { get; set; }
        public string? TestDetail { get; set; }
        public string? TestConclusion { get; set; }
        public string? TestAdvise { get; set; }
        public string? TestConclusion1 { get; set; }
        public string? TestConclusion2 { get; set; }
        public string? TestConclusion3 { get; set; }
        public string? TestConclusion4 { get; set; }
    }
}
