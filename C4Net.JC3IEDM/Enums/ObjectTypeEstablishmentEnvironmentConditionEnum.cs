using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the environmental conditions for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
    /// </summary>
    [DomId(100004191)]
    [DataContract]
    public enum ObjectTypeEstablishmentEnvironmentConditionEnum
    {
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in arctic conditions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARC")]
        [EnumMember]
        Arctic,
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in desert conditions.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DES")]
        [EnumMember]
        Desert,
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in jungle conditions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("JUN")]
        [EnumMember]
        Jungle,
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in mountain conditions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MOUNTN")]
        [EnumMember]
        Mountain,
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in temperate conditions.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("TMP")]
        [EnumMember]
        Temperate,
		
        /// <summary>
        /// An indication that the specified establishment is authorised for use in tropical conditions.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("TRP")]
        [EnumMember]
        Tropical,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
