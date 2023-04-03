using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class PatientMedicine
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? AppointmentId { get; set; }
        public int? MedicineId { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Duration { get; set; }
        public string? Power { get; set; }
        public string? Remarks { get; set; }
        public string? Histroy { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
