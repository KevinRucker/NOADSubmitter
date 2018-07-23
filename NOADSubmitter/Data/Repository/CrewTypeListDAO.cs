using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class CrewTypeListDAO
    {
        public CrewTypeListLookup FetchLookup()
        {
            var output = new CrewTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Crew_Type_List.xml"));
            foreach (var item in resource.Root.Descendants("Crew_Type"))
            {
                output.Lookup.Add(new CrewTypeListEntry()
                {
                    Value = item.Value
                });
            }

            return output;
        }
    }
}
