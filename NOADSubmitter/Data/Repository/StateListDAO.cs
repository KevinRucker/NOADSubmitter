using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class StateListDAO
    {
        public StateListLookup FetchLookup()
        {
            var output = new StateListLookup();
            var StateResource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.State_List.xml"));
            var PortResource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Port_State_List.xml"));
            foreach(var item in StateResource.Root.Descendants("State"))
            {
                var tempPorts = PortResource.Root.Descendants("Port")
                    .Where(x => x.Element("State_Name").Value == item.Element("State_Name").Value);
                var Ports = new List<PortListEntry>();
                foreach(var temp in tempPorts)
                {
                    Ports.Add(new PortListEntry()
                    {
                        Name = temp.Element("Port_Name").Value
                    });
                }

                output.Lookup.Add(new StateListEntry
                {
                    Name = item.Element("State_Name").Value,
                    Abbreviation = item.Element("State_Abbr").Value,
                    PortList = Ports
                });
            }

            return output;
        }
    }
}
