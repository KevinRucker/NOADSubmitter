using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class ShipIdTypeListDAO
    {
        public ShipIdTypeListLookup FetchLookup()
        {
            var output = new ShipIdTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Ship_ID_Type_List.xml"));
            foreach (var item in resource.Root.Descendants("ID_Type"))
            {
                output.Lookup.Add(new ShipIdTypeListEntry()
                {
                    IdType = item.Value
                });
            }

            return output;
        }
    }
}
