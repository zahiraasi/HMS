using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class PortalVisit
    {
        public int Sno { get; set; }
        public int? UserId { get; set; }
        public DateTime? Entrydate { get; set; }
        public string? Ip { get; set; }
    }
}
