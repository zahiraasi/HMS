using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Covid19
    {
        public int Sno { get; set; }
        public string? Mrno { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? Ward { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? Cnic { get; set; }
        public string? Refer { get; set; }
        public DateTime? Sampledate { get; set; }
        public string? SampleTime { get; set; }
        public DateTime? Reportindate { get; set; }
        public DateTime? Entrydate { get; set; }
        public string? Remarks { get; set; }
        public string? Userid { get; set; }
    }
}
