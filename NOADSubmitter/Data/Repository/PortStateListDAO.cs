using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class PortStateListDAO
    {
        public PortStateListLookup FetchLookup()
        {
            var output = new PortStateListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Port_State_List.xml"));
            foreach (var item in resource.Root.Descendants("Port"))
            {
                output.Lookup.Add(new PortStateListEntry()
                {
                    StateName = item.Element("State_Name").Value,
                    PortName = item.Element("Port_Name").Value
                });
            }

            return output;
        }
    }
}
