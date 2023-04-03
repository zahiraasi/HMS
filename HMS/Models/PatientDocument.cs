using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class PatientDocument
    {
        public int Sno { get; set; }
        public string? PatientId { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? Userid { get; set; }
    }
}
