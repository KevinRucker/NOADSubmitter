using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class CountryListDAO
    {
        public CountryListLookup FetchLookup()
        {
            var output = new CountryListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.country_List.xml"));
            foreach (var item in resource.Root.Descendants("Country"))
            {
                output.Lookup.Add(new CountryListEntry()
                {
                    CountryName = item.Element("Country_Name").Value,
                    ISOCode = item.Element("ISO_Code").Value
                });
            }

            return output;
        }
    }
}
