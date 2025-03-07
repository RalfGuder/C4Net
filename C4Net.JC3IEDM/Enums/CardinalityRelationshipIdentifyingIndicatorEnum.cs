using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CARDINALITY-RELATIONSHIP represented.
    /// </summary>
    [DomId(100006005)]
    [DataContract]
    public enum CardinalityRelationshipIdentifyingIndicatorEnum
    {
		
        /// <summary>
        /// The cardinality relationship is identifying.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ID")]
        [EnumMember]
        Identifying,
		
        /// <summary>
        /// The cardinality relationship is nonidentifying.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NI")]
        [EnumMember]
        Nonidentifying,
		
    }
}
