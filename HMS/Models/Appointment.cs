using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int? TokenNo { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? VisitTime { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public int? UserId { get; set; }
        public int? Active { get; set; }

        public virtual Doctor? Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
