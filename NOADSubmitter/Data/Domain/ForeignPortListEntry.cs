namespace NOADSubmitter.Data.Domain
{
    public class ForeignPortListEntry
    {
        public string ISOCode { get; set; } = default(string);
        public string PortName { get; set; } = default(string);
        public string UNLocationCode { get; set; } = default(string);
    }
}
