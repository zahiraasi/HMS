using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Audit
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Amount { get; set; }
        public bool? Active { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public string? Userid { get; set; }
        public string? Remarks { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
