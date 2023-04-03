using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class AdmissionService
    {
        public int Sno { get; set; }
        public int? AdmissionId { get; set; }
        public int? PatientId { get; set; }
        public int? ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? Charges { get; set; }
        public string? Discount { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int? Userid { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? Updatedatetime { get; set; }

        public virtual Admission? Admission { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
