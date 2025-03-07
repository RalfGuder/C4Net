using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the FIRE-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004357)]
    [DataContract]
    public enum FireCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The numeric value that denotes the rate at which projectiles can be fired in a short but rapid burst.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BRTFIR")]
        [EnumMember]
        BurstFireRate,
		
        /// <summary>
        /// The numeric value that denotes the highest rate at which projectiles can be fired for a limited period of time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MRATFR")]
        [EnumMember]
        MaximumFireRate,
		
        /// <summary>
        /// The longest distance that can be achieved.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MRANGE")]
        [EnumMember]
        MaximumRange,
		
        /// <summary>
        /// The shortest distance that can be achieved.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NRANGE")]
        [EnumMember]
        MinimumRange,
		
        /// <summary>
        /// The numeric value that denotes the minimum distance to be maintained between own troops and the intended target.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SFTDST")]
        [EnumMember]
        SafetyDistanceFactor,
		
        /// <summary>
        /// The numeric value that denotes the rate at which projectiles can be fired repeatedly for a prolonged period of time.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SSTRTF")]
        [EnumMember]
        SustainedFireRate,
		
    }
}
