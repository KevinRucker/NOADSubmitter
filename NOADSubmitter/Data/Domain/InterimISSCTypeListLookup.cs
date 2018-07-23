using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class InterimISSCTypeListLookup
    {
        public IList<InterimISSCTypeListEntry> Lookup { get; set; } = new List<InterimISSCTypeListEntry>();
    }
}
