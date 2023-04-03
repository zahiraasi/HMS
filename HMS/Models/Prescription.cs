using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Prescription
    {
        public int Sno { get; set; }
        public int? AppointmentId { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string? Prescriptions { get; set; }
        public string? Dosage { get; set; }
        public string? Potency { get; set; }
        public string? Remarks { get; set; }
        public DateTime? NextAppointment { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? UserId { get; set; }
    }
}
