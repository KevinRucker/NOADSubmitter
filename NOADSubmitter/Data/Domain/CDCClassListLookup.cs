using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class CDCClassListLookup
    {
        public IList<CDCClassListEntry> Lookup { get; set; } = new List<CDCClassListEntry>();
    }
}
