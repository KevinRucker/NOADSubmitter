using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class CrewTypeListLookup
    {
        public IList<CrewTypeListEntry> Lookup { get; set; } = new List<CrewTypeListEntry>();
    }
}
