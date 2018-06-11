using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using NOADSubmitter.Framework;

namespace NOADSubmitter.Data.Domain
{
    public class NoticeDetails : PersistentEntityBase
    {
        private Guid? _noticeId = default(Guid?);
        private NoticeTransactionType _noticeTransactionType = NoticeTransactionType.Initial;
        private NoticeType _noticeType = NoticeType.Arrival;

        public Guid? NoticeId { get { return _noticeId; } set { ChangeTracker.ChangePropertyValue("NoticeId", value); _noticeId = value; } }
        public NoticeTransactionType NoticeTransactionType { get { return _noticeTransactionType; } set { ChangeTracker.ChangePropertyValue("NoticeTransactionType", value); _noticeTransactionType = value; } }
        public NoticeType NoticeType { get { return _noticeType; } set { ChangeTracker.ChangePropertyValue("NoticeType", value); _noticeType = value; } }
        public string Version { get; } = "3.5";

        public static explicit operator XElement(NoticeDetails origin)
        {
            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
            var output = new XElement("NOTICE_DETAILS");
            if(origin.NoticeId.HasValue)
            {
                output.Add(new XElement("NOTICE_ID", origin.NoticeId.Value.ToString()));
            }
            else
            {
                var nilElement = new XElement("NOTICE_ID");
                nilElement.Add(new XAttribute(xsi + "nil", true));
                output.Add(nilElement);
            }
            output.Add(new XElement("NOTICE_TRANSACTION_TYPE", origin.NoticeTransactionType));
            output.Add(new XElement("NOTICE_TYPE", origin.NoticeType));
            output.Add(new XElement("Version", origin.Version));
            return output;
        }

        public static explicit operator NoticeDetails(XElement origin)
        {
            var output = new NoticeDetails();
            var tempId = new Guid();
            if (Guid.TryParse(origin.Descendants().Single(x => x.Name == "NOTICE_ID").Value, out tempId))
            {
                output.NoticeId = Guid.Parse(origin.Descendants().Single(x => x.Name == "NOTICE_ID").Value);
            }

            return output;
        }
    }
}
