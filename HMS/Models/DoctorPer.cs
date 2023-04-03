using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class DoctorPer
    {
        public int Sno { get; set; }
        public int? DoctorId { get; set; }
        public int? ServiceId { get; set; }
        public int? Percentage { get; set; }

        public virtual Doctor? Doctor { get; set; }
    }
}
