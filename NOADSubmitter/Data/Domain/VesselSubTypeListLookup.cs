using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class VesselSubTypeListLookup
    {
        public IList<VesselSubTypeListEntry> Lookup { get; set; } = new List<VesselSubTypeListEntry>();
    }
}
