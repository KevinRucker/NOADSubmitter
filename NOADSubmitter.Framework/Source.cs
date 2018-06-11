using System;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace NOADSubmitter.Framework
{
    public class Source
    {
        public string OrganizationName { get; } = "United States Coast Guard";
        public string SoftwareApplicationName { get; } = "NOAD Submitter";
        public Version SoftwareApplicationVersion { get; } = Assembly.GetEntryAssembly().GetName().Version;
        public string Contact { get; set; }

        public static explicit operator XElement(Source origin)
        {
            var returnValue = new XElement("Source");
            returnValue.Add(new XElement("Organization_Name", origin.OrganizationName));
            returnValue.Add(new XElement("Software_Application_Name", origin.SoftwareApplicationName));
            returnValue.Add(new XElement("Software_Application_Version", origin.SoftwareApplicationVersion.ToString()));
            returnValue.Add(new XElement("Contact", origin.Contact));
            return returnValue;
        }

        public static explicit operator Source(XElement origin)
        {
            var returnValue = new Source();
            returnValue.Contact = origin.Descendants("Contact").Single().Value;
            return new Source();
        }
    }
}