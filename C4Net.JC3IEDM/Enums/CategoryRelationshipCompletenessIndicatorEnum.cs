using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether all the possible subtypes of the Super ENTITY explicitly occur in the data model.
    /// </summary>
    [DomId(100006008)]
    [DataContract]
    public enum CategoryRelationshipCompletenessIndicatorEnum
    {
		
        /// <summary>
        /// The subtyping for this entity is complete.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CC")]
        [EnumMember]
        CompleteCategory,
		
        /// <summary>
        /// The subtyping for this entity is incomplete.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("IC")]
        [EnumMember]
        IncompleteCategory,
		
    }
}
