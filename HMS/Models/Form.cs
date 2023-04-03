using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Form
    {
        public Form()
        {
            RolesDetails = new HashSet<RolesDetail>();
        }

        public int FormId { get; set; }
        public int? ParentId { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public bool? Active { get; set; }
        public string? Controller { get; set; }
        public string? Method { get; set; }

        public virtual ICollection<RolesDetail> RolesDetails { get; set; }
    }
}
