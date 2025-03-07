using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the availability of railroad transportation capability at a specific BERTH.
    /// </summary>
    [DomId(100004289)]
    [DataContract]
    public enum BerthRailAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Railroad transportation is not available at the berth.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Railroad transportation is available at the berth.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
