using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Discharge
    {
        public int Did { get; set; }
        public int? PatientId { get; set; }
        public int? AdmissionId { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string? DischargeTime { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public int? StayDays { get; set; }
        public DateTime? Upcomingdate { get; set; }
        public bool? Active { get; set; }
        public int? UserId { get; set; }
    }
}
