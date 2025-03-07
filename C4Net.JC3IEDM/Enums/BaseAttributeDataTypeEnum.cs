using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the technical form (datatype or syntax) for the attribute.
    /// </summary>
    [DomId(100006037)]
    [DataContract]
    public enum BaseAttributeDataTypeEnum
    {
		
        /// <summary>
        /// The datatype of the attribute is BLOB.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLOB")]
        [EnumMember]
        Blob,
		
        /// <summary>
        /// The datatype of the attribute is space padded character.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CHAR")]
        [EnumMember]
        Character,
		
        /// <summary>
        /// The datatype of the attribute is a number.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NUMBER")]
        [EnumMember]
        Numeric,
		
        /// <summary>
        /// The datatype of the attribute is variable character not space padded.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("VARCHAR")]
        [EnumMember]
        VaryingCharacter,
		
    }
}
