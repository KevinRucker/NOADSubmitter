using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class PortStateListLookup
    {
        public IList<PortStateListEntry> Lookup { get; set; } = new List<PortStateListEntry>();
    }
}
