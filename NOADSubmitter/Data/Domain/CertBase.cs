using System;

namespace NOADSubmitter.Data.Domain
{
    public abstract class CertBase
    {
        public DateTime? Issued { get; set; } = default(DateTime?);
        public DateTime? Expiration { get; set; } = default(DateTime?);
        public AgencyListEntry Agency { get; set; } = new AgencyListEntry();
    }
}
