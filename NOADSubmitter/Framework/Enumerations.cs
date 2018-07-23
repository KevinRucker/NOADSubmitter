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

    public enum ShipIdType
    {
        NoSelection,
        IMO_Number,
        Official_Number
    }

    public enum VesselClassificationType
    {
        NoSelection,
        Barge,
        Bulk_Carrier,
        Fishing_Vessel,
        General_Dry_Cargo_Ship,
        Miscellaneous_Vessel,
        Offshore,
        Passenger_Ship,
        Recreational,
        Refrigerated_Cargo__Ship,
        Research_Ship,
        Ro__Ro_Cargo_Ship,
        School_Ship,
        Tank_Ship,
        Towing_Vessel,
        Warship
    }
}
