using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class LabTestRecord
    {
        public int LabId { get; set; }
        public int? BranchId { get; set; }
        public int? ServiceId { get; set; }
        public int? PatientId { get; set; }
        public int? TransId { get; set; }
        public int? DoctorId { get; set; }
        public int? Gcode { get; set; }
        public string? Mname { get; set; }
        public string? Gname { get; set; }
        public string? Tname { get; set; }
        public string? Result { get; set; }
        public string? NormalRange { get; set; }
        public int? MinRange { get; set; }
        public int? MaxRange { get; set; }
        public string? Unit { get; set; }
        public string? Remarks { get; set; }
        public string? Heading { get; set; }
        public int? UserId { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? Updatedatetime { get; set; }
        public string? UpdateUser { get; set; }
        public int? Orderby { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual TestEntry? Trans { get; set; }
    }
}
