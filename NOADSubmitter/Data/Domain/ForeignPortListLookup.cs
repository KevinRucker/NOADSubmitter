using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class ForeignPortListLookup
    {
        public IList<ForeignPortListEntry> Lookup { get; set; } = new List<ForeignPortListEntry>();
    }
}
