using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Admissions = new HashSet<Admission>();
            Appointments = new HashSet<Appointment>();
            Audits = new HashSet<Audit>();
            CertificateDates = new HashSet<CertificateDate>();
            LabSamples = new HashSet<LabSample>();
            LabTestRecords = new HashSet<LabTestRecord>();
            Otpatients = new HashSet<Otpatient>();
            RoomPatients = new HashSet<RoomPatient>();
            StoreTransactions = new HashSet<StoreTransaction>();
            TestEntries = new HashSet<TestEntry>();
            Vaccinations = new HashSet<Vaccination>();
        }

        [Required]
        public int PatientId { get; set; }
        [Required]
        public string Mrno { get; set; } = null!;
        public string? PatientName { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public string? Cnic { get; set; }
        public int? Panelid { get; set; }
        public int? DepartmentId { get; set; }
        public int? BranchId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? UserId { get; set; }
        public string? Ip { get; set; }
        public string? ReferBy { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Panel? Panel { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<CertificateDate> CertificateDates { get; set; }
        public virtual ICollection<LabSample> LabSamples { get; set; }
        public virtual ICollection<LabTestRecord> LabTestRecords { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
        public virtual ICollection<RoomPatient> RoomPatients { get; set; }
        public virtual ICollection<StoreTransaction> StoreTransactions { get; set; }
        public virtual ICollection<TestEntry> TestEntries { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
