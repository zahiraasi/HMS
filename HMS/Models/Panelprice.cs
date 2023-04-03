using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Panelprice
    {
        public int Sno { get; set; }
        public int? ServiceId { get; set; }
        public int? PanelId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
    }
}
