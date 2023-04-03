using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class UltraSoundRecord
    {
        public int Sno { get; set; }
        public int? BranchId { get; set; }
        public int? PatientId { get; set; }
        public int? TransId { get; set; }
        public int? ServiceId { get; set; }
        public string? Type { get; set; }
        public string? Heading { get; set; }
        public string? Detail { get; set; }
        public string? Value { get; set; }
        public string? Impression { get; set; }
        public string? Advise { get; set; }
        public string? Remarks { get; set; }
        public bool? IsProcess { get; set; }
        public string? Logo { get; set; }
    }
}
