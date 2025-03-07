using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the SUPPORT-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004351)]
    [DataContract]
    public enum SupportCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The numeric value denoting the number of hospital beds, fully outfitted with the necessary equipment and nursing personnel, available.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BEDCNT")]
        [EnumMember]
        BedCount,
		
        /// <summary>
        /// The numeric value representing the maximum amount of any unpackaged liquid.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BLKLIQ")]
        [EnumMember]
        BulkLiquid,
		
        /// <summary>
        /// The numeric value representing the maximum volume of any unpackaged mass.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BLKVOL")]
        [EnumMember]
        BulkVolume,
		
        /// <summary>
        /// The numeric value representing the maximum item count.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MAXCNT")]
        [EnumMember]
        MaximumCount,
		
        /// <summary>
        /// The numeric value denoting the number of operational operating rooms, fully outfitted with the necessary equipment and surgical personnel, available to treat injuries and illness.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("OPRCNT")]
        [EnumMember]
        OperatingTableCount,
		
    }
}
