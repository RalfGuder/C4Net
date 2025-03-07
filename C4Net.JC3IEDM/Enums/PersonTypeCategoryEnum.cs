using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of PERSON-TYPE.
    /// </summary>
    [DomId(100000204)]
    [DataContract]
    public enum PersonTypeCategoryEnum
    {
		
        /// <summary>
        /// A PERSON-TYPE who is not a uniformed member of a regular armed force.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CIV")]
        [EnumMember]
        Civilian,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A PERSON-TYPE who is a uniformed member of a regular armed force.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MILTRY")]
        [EnumMember]
        Military,
		
        /// <summary>
        /// A PERSON-TYPE who is a member of an irregular armed force.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PAR")]
        [EnumMember]
        Paramilitary,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
