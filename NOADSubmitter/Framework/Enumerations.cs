namespace NOADSubmitter.Framework
{
    public enum NoticeTransactionType
    {
        NoSelection,
        Initial,
        Update
    }

    public enum NoticeType
    {
        NoSelection,
        Arrival,
        Departure
    }

    public enum ArrivalVoyageType
    {
        NoSelection,
        US_To_US,
        Foreign_To_US,
        US_To_CARICOM,
        Foreign_To_CARICOM,
        CARICON_To_CARICOM,
        Foreign_To_Saint_Lawrence_Seaway
    }

    public enum DepartureVoyageType
    {
        NoSelection,
        US_To_Foreign,
        CARICON_To_CARICOM,
        CARICOM_To_Foreign,
        CARICOM_To_US
    }

    public enum BiStateYN
    {
        NoSelection,
        Yes,
        No
    }

    public enum BiStateTF
    {
        NoSelection,
        True,
        False
    }

    public enum ISMCodeType
    {
        No_Selection,
        In_Compliance,
        NOT_In_Compliance,
        Not_Required_To_Comply
    }
}
