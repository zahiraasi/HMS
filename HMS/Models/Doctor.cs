using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Admissions = new HashSet<Admission>();
            Appointments = new HashSet<Appointment>();
            DoctorPers = new HashSet<DoctorPer>();
            Otpatients = new HashSet<Otpatient>();
            TestEntries = new HashSet<TestEntry>();
        }

        public int DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? Education { get; set; }
        public string? MobileNo { get; set; }
        public string? Cnic { get; set; }
        public int? DepartmendId { get; set; }
        public int? Fee { get; set; }

        public virtual Department? Departmend { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<DoctorPer> DoctorPers { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
        public virtual ICollection<TestEntry> TestEntries { get; set; }
    }
}
