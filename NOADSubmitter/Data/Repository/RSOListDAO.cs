using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class RSOListDAO
    {
        public RSOListLookup FetchLookup()
        {
            var output = new RSOListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.RSO.xml"));
            foreach (var item in resource.Root.Descendants("RSO"))
            {
                output.Lookup.Add(new RSOListEntry()
                {
                    Name = item.Element("RSO_Name").Value
                });
            }

            return output;
        }
    }
}
