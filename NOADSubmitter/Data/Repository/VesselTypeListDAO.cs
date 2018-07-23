using System.Linq;
using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class VesselTypeListDAO
    {
        public VesselTypeListLookup FetchLookup(VesselClassificationListEntry vesselClassification)
        {
            var output = new VesselTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Vessel_Type_List.xml"));
            var subTypeDAO = new VesselSubTypeListDAO();
            var temp = resource.Root.Descendants("Vessel_Type")
                .Where(x => x.Element("VesselClassification").Value == vesselClassification.Description);
            foreach(var item in temp)
            {
                var thisEntry = new VesselTypeListEntry { Description = item.Element("Description").Value };
                thisEntry.SubTypeList = subTypeDAO.FetchLookup(vesselClassification, thisEntry);
                output.Lookup.Add(thisEntry);
            }

            return output;
        }
    }
}
