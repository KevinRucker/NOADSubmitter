using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class INAExemptionsListLookup
    {
        public IList<INAExemptionsListEntry> Lookup { get; set; } = new List<INAExemptionsListEntry>();
    }
}
