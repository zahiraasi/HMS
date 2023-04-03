using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class RoomsType
    {
        public RoomsType()
        {
            Rooms = new HashSet<Room>();
        }

        public int RoomTypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string IsPrivate { get; set; } = null!;
        public string IsAc { get; set; } = null!;
        public string IsBed { get; set; } = null!;

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
