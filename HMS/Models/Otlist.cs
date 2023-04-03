using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Otlist
    {
        public Otlist()
        {
            Admissions = new HashSet<Admission>();
            Otpatients = new HashSet<Otpatient>();
        }

        public int Otid { get; set; }
        public string? Otname { get; set; }
        public int? TotalCharges { get; set; }
        public int? Anesthesia { get; set; }
        public int? Theater { get; set; }
        public int? Additional { get; set; }
        public int? Room { get; set; }
        public int? Discount { get; set; }
        public int? DoctorId { get; set; }
        public int? MedicineId { get; set; }

        public virtual Otmedicine? Otmedicine { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
    }
}
