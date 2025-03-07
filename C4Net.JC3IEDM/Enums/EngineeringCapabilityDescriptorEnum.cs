using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a specific ENGINEERING-CAPABILITY in terms of a measurable quantity.
    /// </summary>
    [DomId(100004355)]
    [DataContract]
    public enum EngineeringCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The numeric value that denotes the rate at which an ENGINEERING-CAPABILITY of an object can be accomplished.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RATE")]
        [EnumMember]
        Rate,
		
        /// <summary>
        /// The time normally required for an ENGINEERING-CAPABILITY of an object to be executed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TIME")]
        [EnumMember]
        Time,
		
    }
}
