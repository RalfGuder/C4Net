using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether an ATTRIBUTE plays the role of part of the primary key in the ENTITY to which it belongs.
    /// </summary>
    [DomId(100006002)]
    [DataContract]
    public enum AttributePrimaryKeyIndicatorEnum
    {
		
        /// <summary>
        /// An ATTRIBUTE used to provide a descriptive data element of instances of the ENTITY to which the ATTRIBUTE belongs and that is not a member of the primary key of that ENTITY.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NK")]
        [EnumMember]
        NonKeyAttribute,
		
        /// <summary>
        /// An ATTRIBUTE used to provide the unique identifier(s) of an instance of the ENTITY to which the attributes belong.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PK")]
        [EnumMember]
        PrimaryKeyAttribute,
		
    }
}
