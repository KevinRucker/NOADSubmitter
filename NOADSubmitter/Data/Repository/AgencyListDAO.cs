using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class AgencyListLookupDAO
    {
        public AgencyListLookup FetchLookup()
        {
            var output = new AgencyListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Agency_List.xml"));
            foreach(var item in resource.Root.Descendants("Agency"))
            {
                output.Lookup.Add(new AgencyListEntry() { Value = item.Value });
            }

            return output;
        }
    }
}
