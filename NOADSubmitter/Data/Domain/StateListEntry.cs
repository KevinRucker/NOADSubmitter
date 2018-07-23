using System.Collections.Generic;

namespace NOADSubmitter.Data.Domain
{
    public class StateListEntry
    {
        public string Name { get; set; } = default(string);
        public string Abbreviation { get; set; } = default(string);
        public IList<PortListEntry> PortList { get; set; } = new List<PortListEntry>();
    }
}
