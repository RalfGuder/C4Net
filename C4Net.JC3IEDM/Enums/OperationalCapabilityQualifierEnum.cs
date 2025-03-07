using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the degree to which the specific OPERATIONAL-CAPABILITY can be fulfilled.
    /// </summary>
    [DomId(100004364)]
    [DataContract]
    public enum OperationalCapabilityQualifierEnum
    {
		
        /// <summary>
        /// Can fulfil a specific mission with some restriction.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// Can fulfil a specific mission without restriction.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HIGH")]
        [EnumMember]
        High,
		
        /// <summary>
        /// Can fulfil a specific mission only under some circumstances.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LOW")]
        [EnumMember]
        Low,
		
    }
}
