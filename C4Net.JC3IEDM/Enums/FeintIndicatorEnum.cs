using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether the ACTION is a feint.
    /// </summary>
    [DomId(100004336)]
    [DataContract]
    public enum FeintIndicatorEnum
    {
		
        /// <summary>
        /// The activity is not a feint.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The activity is intended to draw an enemy’s attention from the true attack.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
