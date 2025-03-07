using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the degree of safety (or risk) entailed with an ordered operation.
    /// </summary>
    [DomId(100004200)]
    [DataContract]
    public enum ActionTaskEntailedSafetyDegreeEnum
    {
		
        /// <summary>
        /// No definition provided in ATP-06(B) and ATP-24(B).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ALPHA")]
        [EnumMember]
        Alpha,
		
        /// <summary>
        /// No definition provided in ATP-06(B) and ATP-24(B).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRAVO")]
        [EnumMember]
        Bravo,
		
        /// <summary>
        /// No definition provided in ATP-06(B) and ATP-24(B).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CHARLE")]
        [EnumMember]
        Charlie,
		
    }
}
