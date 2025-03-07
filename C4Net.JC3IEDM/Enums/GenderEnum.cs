using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// A code that represents the classification of a person based on reproductive physiological traits.
    /// </summary>
    [DomId(100000174)]
    [DataContract]
    public enum GenderEnum
    {
		
        /// <summary>
        /// Masculine.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MALE")]
        [EnumMember]
        Male,
		
        /// <summary>
        /// Feminine.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FEMALE")]
        [EnumMember]
        Female,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
