using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class CertificateDate
    {
        public int Sno { get; set; }
        public int? PatientId { get; set; }
        public int? CertificateId { get; set; }
        public DateTime? CertificateDate1 { get; set; }
        public string? Issuedto { get; set; }
        public string? Requested { get; set; }
        public string? Remarks { get; set; }

        public virtual CertificateType? Certificate { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
