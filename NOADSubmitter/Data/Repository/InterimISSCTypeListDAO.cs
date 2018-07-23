using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class InterimISSCTypeListDAO
    {
        public InterimISSCTypeListLookup FetchLookup()
        {
            var output = new InterimISSCTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Interim_ISSC_Type_List.xml"));
            foreach (var item in resource.Root.Descendants("Interim_ISSC_Type_Desc"))
            {
                output.Lookup.Add(new InterimISSCTypeListEntry()
                {
                    InterimISSCTypeDescription = item.Value
                });
            }

            return output;
        }
    }
}
