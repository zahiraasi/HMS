using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class TestList
    {
        public int ServiceId { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int? Price { get; set; }
        public string? Duration { get; set; }
        public string? Technology { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int? UserId { get; set; }
        public int? Mcode { get; set; }
        public int? Gcode { get; set; }
    }
}
