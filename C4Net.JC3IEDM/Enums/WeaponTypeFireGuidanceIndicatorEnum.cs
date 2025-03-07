using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific WEAPON-TYPE provides fire guidance.
    /// </summary>
    [DomId(100000335)]
    [DataContract]
    public enum WeaponTypeFireGuidanceIndicatorEnum
    {
		
        /// <summary>
        /// The specific WEAPON-TYPE does not provide fire-guidance.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific WEAPON-TYPE provides fire-guidance.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
