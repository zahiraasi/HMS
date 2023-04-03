using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            CertificateDates = new HashSet<CertificateDate>();
        }

        public int CertificateId { get; set; }
        public string? CertificateName { get; set; }
        public string? Title { get; set; }
        public string? Remarks { get; set; }

        public virtual ICollection<CertificateDate> CertificateDates { get; set; }
    }
}
