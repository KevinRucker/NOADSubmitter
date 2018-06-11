using System.Xml.Linq;

namespace NOADSubmitter.Framework
{
    public class Notice
    {
        public Source Source { get; set; }

        public static explicit operator XDocument(Notice origin)
        {
            var returnValue = new XDocument(new XDeclaration("1.0", "UTF-8", "true"));
            returnValue.Add(new XElement("NOTICE"));
            returnValue.Root.Add((XElement)origin.Source);
            return returnValue;
        }

        public static explicit operator Notice(XDocument origin)
        {
            return new Notice();
        }
    }
}
