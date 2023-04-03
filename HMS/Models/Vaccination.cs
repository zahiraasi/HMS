using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Vaccination
    {
        public int Sno { get; set; }
        public int? Cno { get; set; }
        public int? PatientId { get; set; }
        public DateTime? VaccineDate { get; set; }
        public DateTime? ProposeDate { get; set; }
        public DateTime? InjectionDate { get; set; }
        public string? Remarks { get; set; }
        public bool? Active { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
