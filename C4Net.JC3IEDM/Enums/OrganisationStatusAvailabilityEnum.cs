using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that gives the availability status of an ORGANISATION without regard to readiness.
    /// </summary>
    [DomId(100004115)]
    [DataContract]
    public enum OrganisationStatusAvailabilityEnum
    {
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION can be available for use after 30 days.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFT30D")]
        [EnumMember]
        After30Days,
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION can be available for use in between 48 hours and 4 days.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BTW484")]
        [EnumMember]
        Between48HoursAnd4Days,
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION can be available for use in between 5 and 15 days.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BTW515")]
        [EnumMember]
        Between5And15Days,
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION can be available for use in between 16 and 30 days.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BTW163")]
        [EnumMember]
        Between16And30Days,
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION can be available for use within 48 hours.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WTN48H")]
        [EnumMember]
        Within48Hours,
		
        /// <summary>
        /// An availability status of an ORGANISATION indicating that the ORGANISATION is not available.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NA")]
        [EnumMember]
        NotAvailable,
		
    }
}
