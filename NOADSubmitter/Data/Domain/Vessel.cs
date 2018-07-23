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
        public ShipIdType IdType { get; set; } = ShipIdType.NoSelection;
        public VesselClassificationType Class { get; set; } = VesselClassificationType.NoSelection;

    }
}
