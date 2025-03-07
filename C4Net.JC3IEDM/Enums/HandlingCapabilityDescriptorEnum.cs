using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the HANDLING-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004346)]
    [DataContract]
    public enum HandlingCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The numeric value representing the maximum amount of any unpackaged liquid.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLKLIQ")]
        [EnumMember]
        BulkLiquid,
		
        /// <summary>
        /// The numeric value representing the maximum volume of any unpackaged mass.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BLKVOL")]
        [EnumMember]
        BulkVolume,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the extreme vertical distance, measured from the lowest to the highest reference point, of any object.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MCRHEI")]
        [EnumMember]
        MaximumCargoHeight,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the extreme horizontal distance, measured from side to side and perpendicular to the central axis, of any object.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MCRLEN")]
        [EnumMember]
        MaximumCargoLength,
		
        /// <summary>
        /// The numeric value representing the maximum weight of any cargo.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MCRWGT")]
        [EnumMember]
        MaximumCargoWeight,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the extreme horizontal distance, measured from side to side and parallel to the central axis, of any object.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MCRWID")]
        [EnumMember]
        MaximumCargoWidth,
		
        /// <summary>
        /// The numeric value representing the maximum item count.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MAXCNT")]
        [EnumMember]
        MaximumCount,
		
        /// <summary>
        /// The numeric value representing the Net Explosive Quantity limit equivalent to TNT (trinitrotoluene) explosive power.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NEQLMT")]
        [EnumMember]
        NeqLimit,
		
    }
}
