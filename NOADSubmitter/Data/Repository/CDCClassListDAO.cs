using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class CDCClassListDAO
    {
        public CDCClassListLookup FetchLookup()
        {
            var output = new CDCClassListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.CDC_Class_List.xml"));
            foreach (var item in resource.Root.Descendants("CDC_Class"))
            {
                output.Lookup.Add(new CDCClassListEntry()
                {
                    Description = item.Element("Description").Value,
                    Code = item.Element("Code").Value
                });
            }

            return output;
        }
    }
}
