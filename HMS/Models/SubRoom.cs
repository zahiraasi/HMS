using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class SubRoom
    {
        public int Sno { get; set; }
        public string? RoomId { get; set; }
        public string? Name { get; set; }
        public int? Charges { get; set; }
        public bool? IsActive { get; set; }
    }
}
