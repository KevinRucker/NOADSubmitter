using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class INAExemptionsListDAO
    {
        public INAExemptionsListLookup FetchLookup()
        {
            var output = new INAExemptionsListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.INA_Exemptions_List.xml"));
            foreach (var item in resource.Root.Descendants("INA_Exemption"))
            {
                output.Lookup.Add(new INAExemptionsListEntry()
                {
                    Code = item.Element("Code").Value,
                    Description = item.Element("Description").Value
                });
            }

            return output;
        }
    }
}
