using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific CONTEXT-ELEMENT-STATUS refers to the addition or removal of the CONTEXT-ELEMENT from the CONTEXT.
    /// </summary>
    [DomId(100004245)]
    [DataContract]
    public enum ContextElementStatusCategoryEnum
    {
		
        /// <summary>
        /// The specific CONTEXT-ELEMENT is added to the CONTEXT.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADDITN")]
        [EnumMember]
        Addition,
		
        /// <summary>
        /// The specific CONTEXT-ELEMENT is removed from the CONTEXT.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("REMOVL")]
        [EnumMember]
        Removal,
		
    }
}
