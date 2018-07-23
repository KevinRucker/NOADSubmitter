using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class StateListLookup
    {
        public IList<StateListEntry> Lookup { get; set; } = new List<StateListEntry>();
    }
}
