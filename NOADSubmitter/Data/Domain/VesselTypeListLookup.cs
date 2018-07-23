using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class VesselTypeListLookup
    {
        public IList<VesselTypeListEntry> Lookup { get; set; } = new List<VesselTypeListEntry>();
    }
}
