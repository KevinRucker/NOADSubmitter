namespace NOADSubmitter.Data.Domain
{
    public class VesselClassificationListEntry
    {
        public string Description { get; set; } = default(string);
        public VesselTypeListLookup VesselTypeList { get; set; } = new VesselTypeListLookup();
    }
}
