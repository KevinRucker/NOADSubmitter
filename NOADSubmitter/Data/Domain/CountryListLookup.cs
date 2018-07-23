using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class CountryListLookup
    {
        public IList<CountryListEntry> Lookup { get; set; } = new List<CountryListEntry>();
    }
}
