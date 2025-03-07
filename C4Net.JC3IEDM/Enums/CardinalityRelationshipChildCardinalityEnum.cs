using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the range in the number of occurrences associated with the child entity in the CARDINALITY-RELATIONSHIP represented.
    /// </summary>
    [DomId(100006007)]
    [DataContract]
    public enum CardinalityRelationshipChildCardinalityEnum
    {
		
        /// <summary>
        /// The child cardinality relationship is represented by exactly one expression.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EX")]
        [EnumMember]
        Exactly,
		
        /// <summary>
        /// The child cardinality relationship is represented by one or more expressions.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PO")]
        [EnumMember]
        PositiveOneOrMore,
		
        /// <summary>
        /// The child cardinality relationship is represented as a range.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RA")]
        [EnumMember]
        Range,
		
        /// <summary>
        /// The child cardinality relationship is represented as a special expression.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SP")]
        [EnumMember]
        Special,
		
        /// <summary>
        /// The child cardinality relationship is represented by zero, one or more expressions.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ZM")]
        [EnumMember]
        ZeroOneOrMore,
		
        /// <summary>
        /// The child cardinality relationship is represented by zero or one expressions.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ZO")]
        [EnumMember]
        ZeroOrOne,
		
    }
}
