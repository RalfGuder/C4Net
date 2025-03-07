using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies the age group in a specific GROUP-CHARACTERISTIC.
    /// </summary>
    [DomId(100004153)]
    [DataContract]
    public enum GroupCharacteristicAgeGroupEnum
    {
		
        /// <summary>
        /// The group includes ages from 13 through 60 years.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADULT")]
        [EnumMember]
        Adult,
		
        /// <summary>
        /// The group includes ages less than 13 years.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CHILD")]
        [EnumMember]
        Child,
		
        /// <summary>
        /// The group includes ages over 60 years.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ELDRLY")]
        [EnumMember]
        Elderly,
		
        /// <summary>
        /// The group includes a mixture of ages.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
