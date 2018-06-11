using System.Linq;
using System.Xml.Linq;

namespace NOADSubmitter.Data.Domain
{
    public class Notice
    {
        public Source Source { get; set; } = new Source();
        public NoticeDetails NoticeDetails { get; set; } = new NoticeDetails();
        public bool HasChanges
        {
            get
            {
                return Source.HasChanges;
            }
        }

        public static explicit operator XDocument(Notice origin)
        {
            var output = new XDocument(new XDeclaration("1.0", "UTF-8", "true"));
            output.Add(new XElement("NOTICE"));
            output.Root.Add((XElement)origin.Source);
            output.Root.Add((XElement)origin.NoticeDetails);
            return output;
        }

        public static explicit operator Notice(XDocument origin)
        {
            var output = new Notice();
            output.Source = (Source)origin.Descendants("Source").Single();
            output.NoticeDetails = (NoticeDetails)origin.Descendants("NOTICE_DETAILS").Single();
            return output;
        }
    }
}
