using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the speed of the object relative to its normal speed.
    /// </summary>
    [DomId(100004337)]
    [DataContract]
    public enum ObjectItemLocationRelativeSpeedEnum
    {
		
        /// <summary>
        /// Faster than the normal speed of the object reported.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FAST")]
        [EnumMember]
        Fast,
		
        /// <summary>
        /// The normal speed of the object reported.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// Self explanatory.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ZERO")]
        [EnumMember]
        NoSpeed,
		
        /// <summary>
        /// Slower than the normal speed of the object reported.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SLOW")]
        [EnumMember]
        Slow,
		
    }
}
