using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Panel
    {
        public Panel()
        {
            Admissions = new HashSet<Admission>();
            Patients = new HashSet<Patient>();
        }

        public int PanelId { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Address { get; set; }
        public string? ContactPerson { get; set; }

        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
