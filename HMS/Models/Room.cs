using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Room
    {
        public Room()
        {
            Admissions = new HashSet<Admission>();
            Otpatients = new HashSet<Otpatient>();
            RoomPatients = new HashSet<RoomPatient>();
        }

        public int RoomId { get; set; }
        public string? Name { get; set; }
        public string? Floor { get; set; }
        public int? RoomTypeId { get; set; }
        public int? Charges { get; set; }
        public bool? Active { get; set; }
        public string? Remarks { get; set; }

        public virtual RoomsType? RoomType { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Otpatient> Otpatients { get; set; }
        public virtual ICollection<RoomPatient> RoomPatients { get; set; }
    }
}
