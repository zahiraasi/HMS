using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class Smsgateway
    {
        public int Sno { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
