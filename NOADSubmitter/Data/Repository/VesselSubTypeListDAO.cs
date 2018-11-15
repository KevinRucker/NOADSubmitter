using System.Linq;
using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class VesselSubTypeListDAO
    {
        public VesselSubTypeListLookup FetchLookup(VesselClassificationListEntry vesselClassification, VesselTypeListEntry vesselType)
        {
            var output = new VesselSubTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Vessel_Subtype_List.xml"));
            var temp = resource.Root.Descendants("Vessel_Subtype")
                .Where(x => x.Element("VesselClassification").Value.ToLower() == vesselClassification.Description.ToLower() 
                    && x.Element("VesselType").Value.ToLower() == vesselType.Description.ToLower());
            foreach(var item in temp)
            {
                output.Lookup.Add(new VesselSubTypeListEntry()
                {
                    Description = item.Element("Description").Value
                });
            }

            return output;
        }
    }
}
