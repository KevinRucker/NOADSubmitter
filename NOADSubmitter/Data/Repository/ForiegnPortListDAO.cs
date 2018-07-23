using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class ForiegnPortListDAO
    {
        public ForeignPortListLookup FetchLookup()
        {
            var output = new ForeignPortListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Foreign_Port_List.xml"));
            foreach (var item in resource.Root.Descendants("Foreign_Port"))
            {
                output.Lookup.Add(new ForeignPortListEntry()
            {
                ISOCode = item.Element("ISO_Code").Value,
                PortName = item.Element("Port_Name").Value,
                UNLocationCode = item.Element("UNLocation_Code").Value
                });
            }

            return output;
        }
    }
}
