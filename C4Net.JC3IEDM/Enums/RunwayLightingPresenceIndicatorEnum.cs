using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific RUNWAY has runway lighting.
    /// </summary>
    [DomId(100004113)]
    [DataContract]
    public enum RunwayLightingPresenceIndicatorEnum
    {
		
        /// <summary>
        /// At the specific RUNWAY there is no lighting.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// At the specific RUNWAY there is lighting.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
