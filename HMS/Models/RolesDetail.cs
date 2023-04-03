using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class RolesDetail
    {
        public int Sno { get; set; }
        public int? FormId { get; set; }
        public int? RollId { get; set; }
        public DateTime? Updatatedatetime { get; set; }
        public int? UpdateUser { get; set; }

        public virtual Form? Form { get; set; }
        public virtual Role? Roll { get; set; }
    }
}
