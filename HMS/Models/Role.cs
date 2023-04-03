using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Role
    {
        public Role()
        {
            HrtUsers = new HashSet<HrtUser>();
            RolesDetails = new HashSet<RolesDetail>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<HrtUser> HrtUsers { get; set; }
        public virtual ICollection<RolesDetail> RolesDetails { get; set; }
    }
}
