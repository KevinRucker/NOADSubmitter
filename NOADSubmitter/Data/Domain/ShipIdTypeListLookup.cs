using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class ShipIdTypeListLookup
    {
        public IList<ShipIdTypeListEntry> Lookup { get; set; } = new List<ShipIdTypeListEntry>();
    }
}
