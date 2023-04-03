using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Treatment
    {
        public Treatment()
        {
            PatientTreatments = new HashSet<PatientTreatment>();
        }

        public int TreatmentId { get; set; }
        public string? TreatmentName { get; set; }

        public virtual ICollection<PatientTreatment> PatientTreatments { get; set; }
    }
}
