using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class CaseCategory
    {
        public int CaseId { get; set; }
        public string? CaseName { get; set; }
        public bool? Active { get; set; }
    }
}
