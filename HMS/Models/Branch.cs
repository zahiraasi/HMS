using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Branch
    {
        public Branch()
        {
            HrtUsers = new HashSet<HrtUser>();
            LabTestRecords = new HashSet<LabTestRecord>();
            Patients = new HashSet<Patient>();
        }

        public int BranchId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<HrtUser> HrtUsers { get; set; }
        public virtual ICollection<LabTestRecord> LabTestRecords { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
