using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the optionality of the CARDINALITY-RELATIONSHIP.
    /// </summary>
    [DomId(100006006)]
    [DataContract]
    public enum CardinalityRelationshipParentCardinalityEnum
    {
		
        /// <summary>
        /// The parent cardinality relationship must occur at least one time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MA")]
        [EnumMember]
        Mandatory,
		
        /// <summary>
        /// The parent cardinality relationship may or may not occur (zero or one).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OP")]
        [EnumMember]
        Optional,
		
    }
}
