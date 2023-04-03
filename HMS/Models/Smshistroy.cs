using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Smshistroy
    {
        public int Smsid { get; set; }
        public string? PatientId { get; set; }
        public string? Mobileno { get; set; }
        public string? Message { get; set; }
        public DateTime? Smsdate { get; set; }
        public int? Userid { get; set; }
    }
}
