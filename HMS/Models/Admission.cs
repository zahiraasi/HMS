using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Admission
    {
        public Admission()
        {
            Otpatients = new HashSet<Otpatient>();
            RoomPatients = new HashSet<RoomPatient>();
        }

        public int AdmissionId { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? PanelId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int? Otid { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public string? Remarks { get; set; }
        public int? Userid { get; set; }
        public string? Ipaddress { get; set; }

        public virtual Doctor? Doctor { get; set; }
        public virtual Otlist? Ot { get; set; }
        public virtual Panel? Panel { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Room? Room { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
        public virtual ICollection<RoomPatient> RoomPatients { get; set; }
    }
}
