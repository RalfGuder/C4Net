using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ADDRESS.
    /// </summary>
    [DomId(100004138)]
    [DataContract]
    public enum AddressCategoryEnum
    {
		
        /// <summary>
        /// An ADDRESS that is reached by using the specified NETWORK-SERVICE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ELCADR")]
        [EnumMember]
        ElectronicAddress,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// An ADDRESS that represents a physical location that is reachable by use of transportation, to include the use of postal services.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PHYADR")]
        [EnumMember]
        PhysicalAddress,
		
    }
}
