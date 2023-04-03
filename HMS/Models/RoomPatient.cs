using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class RoomPatient
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public int? AdmissionId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? RoomEntryDate { get; set; }
        public string? RoomEntryTime { get; set; }
        public int? Limit { get; set; }
        public int Otid { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public int? UserId { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? DischargeDate { get; set; }
        public bool? Available { get; set; }
        public bool? Active { get; set; }
        public string? Remarks { get; set; }

        public virtual Admission? Admission { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Room? Room { get; set; }
    }
}
