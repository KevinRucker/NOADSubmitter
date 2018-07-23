using System.Xml.Linq;
using NOADSubmitter.Data.Domain;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Repository
{
    public class PersonIdTypeDAO
    {
        public PersonIdTypeListLookup FetchLookup()
        {
            var output = new PersonIdTypeListLookup();
            var resource = XDocument.Load(Common.GetEmbeddedResource("NOADSubmitter.Data.Lookups.Person_ID_Type_List.xml"));
            foreach (var item in resource.Root.Descendants("ID_Type"))
            {
                output.Lookup.Add(new PersonIdTypeListEntry()
                {
                    IdType = item.Value
                });
            }

            return output;
        }
    }
}
