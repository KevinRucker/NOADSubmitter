using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOADSubmitter.Framework;

namespace NOADSubmitter.Data.Domain
{
    public class Vessel : PersistentEntityBase
    {
        public string Name { get; set; } = default(string);
        public string CallSign { get; set; } = default(string);
        public string IdNumber { get; set; } = default(string);
        public ShipIdTypeListEntry IdType { get; set; } = new ShipIdTypeListEntry();
        public VesselClassificationListEntry Class { get; set; } = new VesselClassificationListEntry();
        public VesselTypeListEntry Type { get; set; } = new VesselTypeListEntry();
        public VesselSubTypeListEntry SubType { get; set; } = new VesselSubTypeListEntry();
        public CountryListEntry Flag { get; set; } = new CountryListEntry();
        public string Owner { get; set; } = default(string);
        public string Operator { get; set; } = default(string);
        public string COFROperator { get; set; } = default(string);
        public AgencyListEntry ClassSociety { get; set; } = new AgencyListEntry();
        public ISMCodeType ISMCode { get; set; } = ISMCodeType.No_Selection;
        public string Charterer { get; set; } = default(string);
        public CompCert CompCert { get; set; } = new CompCert();
        public SftyMgmtCert SftyMgmntCert { get; set; } = new SftyMgmtCert();
    }
}
