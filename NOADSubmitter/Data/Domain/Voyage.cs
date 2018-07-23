using System.Linq;
using System.Xml.Linq;
using NOADSubmitter.Framework;
using NOADSubmitter.Utility;

namespace NOADSubmitter.Data.Domain
{
    public class Voyage : PersistentEntityBase
    {
        public string VoyageType { get; set; } = default(string);
        public string VoyageNumber { get; set; } = default(string);
        public BiStateYN ClosedLoopVoyage { get; set; } = BiStateYN.NoSelection;
        public BiStateYN LessThan24Hour { get; set; } = BiStateYN.NoSelection;

        public static explicit operator XElement(Voyage origin)
        {
            var output = new XElement("VOYAGE");
            output.Add(new XElement("VOYAGE_TYPE", origin.VoyageType));
            output.Add(new XElement("VOYAGE_NUMBER", origin.VoyageNumber));
            output.Add(new XElement("CLOSED_LOOP_VOYAGE", origin.ClosedLoopVoyage));
            output.Add(new XElement("LESS_THAN_24HR", origin.LessThan24Hour));

            return output;
        }

        public static explicit operator Voyage(XElement origin)
        {
            var output = new Voyage();
            output.VoyageType = origin.Descendants().Single(x => x.Name == "VOYAGE_TYPE").Value;
            output.VoyageNumber = origin.Descendants().Single(x => x.Name == "VOYAGE_NUMBER").Value;
            output.ClosedLoopVoyage = Common.ConvertToYN(origin.Descendants().Single(x => x.Name == "CLOSED_LOOP_VOYAGE").Value);
            output.LessThan24Hour = Common.ConvertToYN(origin.Descendants().Single(x => x.Name == "LESS_THAN_24HR").Value);

            return output;
        }
    }
}
