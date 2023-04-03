using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class TreatmentChart
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public int? AdmissionId { get; set; }
        public int? Otid { get; set; }
        public int? MedicineId { get; set; }
        public DateTime? TreatmentDate { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public int? UserId { get; set; }
        public string? Ip { get; set; }
        public bool? IsActive { get; set; }
        public int? MedicineBy { get; set; }
        public bool? IsAuto { get; set; }
    }
}
