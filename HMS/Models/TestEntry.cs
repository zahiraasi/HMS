using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class TestEntry
    {
        public TestEntry()
        {
            LabTestRecords = new HashSet<LabTestRecord>();
        }

        public int TransId { get; set; }
        public int? PatientId { get; set; }
        public int? ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceType { get; set; }
        public int? ServicePrice { get; set; }
        public int? Paid { get; set; }
        public int? Discount { get; set; }
        public int? Due { get; set; }
        public int? DuePaid { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? UserId { get; set; }
        public int? UpdateCount { get; set; }
        public string? Ipaddress { get; set; }
        public int? BranchId { get; set; }
        public int? DoctorId { get; set; }
        public bool? Active { get; set; }
        public bool? IsEntered { get; set; }
        public bool? IsProcess { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsFinish { get; set; }
        public bool? IsCancel { get; set; }
        public string? Isreported { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ReportingDate { get; set; }
        public string? ReportingTime { get; set; }

        public virtual Doctor? Doctor { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual ICollection<LabTestRecord> LabTestRecords { get; set; }
    }
}
