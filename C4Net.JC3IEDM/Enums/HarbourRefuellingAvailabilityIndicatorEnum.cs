using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR has refuelling facilities.
    /// </summary>
    [DomId(100004171)]
    [DataContract]
    public enum HarbourRefuellingAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Refuelling facilities are not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Refuelling facilities are available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
