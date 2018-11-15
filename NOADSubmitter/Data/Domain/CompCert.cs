using System;
using System.Linq;
using System.Xml.Linq;

namespace NOADSubmitter.Data.Domain
{
    public class CompCert : CertBase
    {
        public static explicit operator XElement(CompCert origin)
        {
            if (!origin.Issued.HasValue || !origin.Expiration.HasValue)
            {
                return null;
            }

            var output = new XElement("COMP_CERT");
            output.Add(new XElement("ISSUED_DT", origin.Issued.Value.ToString("yyyy-MM-dd")));
            output.Add(new XElement("EXPIRATION_DT", origin.Issued.Value.ToString("yyyy-MM-dd")));
            output.Add(new XElement("AGENCY", origin.Agency.Value));

            return output;
        }

        public static explicit operator CompCert(XElement origin)
        {
            var output = new CompCert();

            output.Issued = DateTime.Parse(origin.Descendants("ISSUED_DT").Single().Value);
            output.Issued = DateTime.Parse(origin.Descendants("EXPIRATION_DT").Single().Value);
            output.Agency = new AgencyListEntry { Value = origin.Descendants("AGENCY").Single().Value };

            return output;
        }
    }
}
