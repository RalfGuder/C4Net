using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the usage of a specific CONTROL-FEATURE, MATERIEL or FACILITY.
    /// </summary>
    [DomId(100004225)]
    [DataContract]
    public enum UsageStatusEnum
    {
		
        /// <summary>
        /// A status indicating that a CONTROL-FEATURE, MATERIEL or FACILITY is performing the function or service for which it is designed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACTIVE")]
        [EnumMember]
        Activated,
		
        /// <summary>
        /// A status indicating that a CONTROL-FEATURE, MATERIEL or FACILITY is not performing the function or service for which it is designed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DEACTV")]
        [EnumMember]
        Deactivated,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
