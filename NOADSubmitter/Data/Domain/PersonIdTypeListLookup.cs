using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class PersonIdTypeListLookup
    {
        public IList<PersonIdTypeListEntry> Lookup { get; set; } = new List<PersonIdTypeListEntry>();
    }
}
