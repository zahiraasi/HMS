using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Supplier
    {
        public int Sno { get; set; }
        public string? Supplier1 { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }
        public byte[]? Company { get; set; }
        public bool? Active { get; set; }
    }
}
