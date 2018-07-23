using System;
using System.Linq;
using System.Xml.Linq;
using NOADSubmitter.Framework;

namespace NOADSubmitter.Data.Domain
{
    public class Source : PersistentEntityBase
    {
        private string _organizationName = default(String);
        private string _softwareApplicationName = default(string);
        private string _contact = default(String);

        public string OrganizationName { get { return _organizationName; } set { ChangeTracker.ChangePropertyValue("OrganizationName", value); _organizationName = value; } }
        public string SoftwareApplicationName { get { return _softwareApplicationName; } set { ChangeTracker.ChangePropertyValue("SoftwareApplicationName", value); _softwareApplicationName = value; } }
        public Version SoftwareApplicationVersion { get; } = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
        public string Contact { get { return _contact; } set { ChangeTracker.ChangePropertyValue("Contact", value); _contact = value; } }
        public bool HasChanges { get { return ChangeTracker.HasChanges; } }

        public static explicit operator XElement(Source origin)
        {
            var output = new XElement("Source");
            output.Add(new XElement("Organization_Name", origin.OrganizationName));
            output.Add(new XElement("Software_Application_Name", origin.SoftwareApplicationName));
            output.Add(new XElement("Software_Application_Version", origin.SoftwareApplicationVersion.ToString()));
            output.Add(new XElement("Contact", origin.Contact));

            return output;
        }

        public static explicit operator Source(XElement origin)
        {
            var output = new Source();
            output.OrganizationName = origin.Descendants().Single(x => x.Name == "Orgainzation_Name").Value;
            output.SoftwareApplicationName = origin.Descendants().Single(x => x.Name == "Software_Application_Name").Value;
            output.Contact = origin.Descendants().Single(x => x.Name == "Contact").Value;

            return output;
        }
    }
}
