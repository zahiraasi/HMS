using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Otpatient
    {
        public int OperationId { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? RoomId { get; set; }
        public int? AdmissionId { get; set; }
        public DateTime? OperationDate { get; set; }
        public int? Nurse { get; set; }
        public int? Anaesthesia { get; set; }
        public int? Technician { get; set; }
        public int? Helper { get; set; }
        public string? PersonWith { get; set; }
        public string? Relationship { get; set; }
        public string? PersonCnic { get; set; }
        public bool? ConsentForm { get; set; }
        public int? Otid { get; set; }
        public string? Ipaddress { get; set; }
        public string? Remarks { get; set; }
        public int? Updatedatetime { get; set; }
        public int? Userid { get; set; }

        public virtual Admission? Admission { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public virtual Otlist? Ot { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Room? Room { get; set; }
        public virtual HrtUser? TechnicianNavigation { get; set; }
    }
}
