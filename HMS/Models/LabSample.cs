using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class LabSample
    {
        public int CollectionId { get; set; }
        public int? ServiceId { get; set; }
        public int? PatientId { get; set; }
        public string? CollectBy { get; set; }
        public DateTime? CollectionDate { get; set; }
        public int? SpecimenType { get; set; }
        public string? Specimen { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsOk { get; set; }
        public string? Remarks { get; set; }
        public bool? ReSample { get; set; }
        public int? UserId { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
