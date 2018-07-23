using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class VesselClassificationListDAO
    {
        public VesselClassificationListLookup FetchLookup()
        {
            var output = new VesselClassificationListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Vessel_Classification_List.xml"));
            var vesselTypeDAO = new VesselTypeListDAO();
            foreach(var item in resource.Root.Descendants("Classification"))
            {
                var temp = new VesselClassificationListEntry { Description = item.Element("Description").Value };
                temp.VesselTypeList = vesselTypeDAO.FetchLookup(temp);
                output.Lookup.Add(temp);
            }

            return output;
        }
    }
}
