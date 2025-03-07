using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between a specific CONTEXT and a specific OBJECT-ITEM in a specific CONTEXT-OBJECT-ITEM-ASSOCIATION.
    /// </summary>
    [DomId(100004246)]
    [DataContract]
    public enum ContextObjectItemAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific CONTEXT includes the OBJECT-ITEM as part of the information encompassed by the CONTEXT.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INCLDE")]
        [EnumMember]
        Includes,
		
        /// <summary>
        /// The specific CONTEXT has significance with respect to a specific OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISRELV")]
        [EnumMember]
        IsRelevantTo,
		
    }
}
