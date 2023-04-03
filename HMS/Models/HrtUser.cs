using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class HrtUser
    {
        public HrtUser()
        {
            Otpatients = new HashSet<Otpatient>();
        }

        public int Sno { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastActive { get; set; }
        public string? Ip { get; set; }
        public int? RoleId { get; set; }
        public int? BranchId { get; set; }
        public bool? MasterId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
    }
}
