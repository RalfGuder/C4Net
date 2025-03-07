using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the SURVEILLANCE-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004361)]
    [DataContract]
    public enum SurveillanceCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The longest distance that can be achieved.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MRANGE")]
        [EnumMember]
        MaximumRange,
		
        /// <summary>
        /// The shortest distance that can be achieved.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NRANGE")]
        [EnumMember]
        MinimumRange,
		
    }
}
