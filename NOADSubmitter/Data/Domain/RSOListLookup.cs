using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class RSOListLookup
    {
        public IList<RSOListEntry> Lookup { get; set; } = new List<RSOListEntry>();
    }
}
