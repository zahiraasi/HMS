using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class LabCovid19
    {
        public int Sno { get; set; }
        public string? Sample { get; set; }
        public string? Technology { get; set; }
        public string? Remarks { get; set; }
    }
}
