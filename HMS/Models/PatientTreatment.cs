using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class PatientTreatment
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public int? TreatmentId { get; set; }
        public string? Name { get; set; }
        public string? Descrption { get; set; }
        public DateTime? TreatedDate { get; set; }
        public int? UserId { get; set; }
        public string? Ipaddress { get; set; }
        public int? DoctorId { get; set; }
        public int? AppointmentId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Remarks { get; set; }

        public virtual Treatment? Treatment { get; set; }
    }
}
