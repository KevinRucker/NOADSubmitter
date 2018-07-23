using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class AgencyListLookup
    {
        public IList<AgencyListEntry> Lookup { get; set; } = new List<AgencyListEntry>();
    }
}
