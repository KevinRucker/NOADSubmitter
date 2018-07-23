namespace NOADSubmitter.Data.Domain
{
    public class VesselTypeListEntry
    {
        public string Description { get; set; } = default(string);
        public VesselSubTypeListLookup SubTypeList { get; set; } = new VesselSubTypeListLookup();
    }
}
