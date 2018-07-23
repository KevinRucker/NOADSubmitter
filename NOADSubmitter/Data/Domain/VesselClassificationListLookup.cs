using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class VesselClassificationListLookup
    {
        public IList<VesselClassificationListEntry> Lookup { get; set; } = new List<VesselClassificationListEntry>();
    }
}
