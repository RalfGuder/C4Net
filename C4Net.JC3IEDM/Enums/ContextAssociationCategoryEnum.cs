using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between the subject CONTEXT and the object CONTEXT in a specific CONTEXT-ASSOCIATION.
    /// </summary>
    [DomId(100004243)]
    [DataContract]
    public enum ContextAssociationCategoryEnum
    {
		
        /// <summary>
        /// The subject CONTEXT follows the object CONTEXT sequentially without negating it. The value is to be used to establish a time-ordered sequence of CONTEXTs.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISNEXT")]
        [EnumMember]
        IsNextAfter,
		
        /// <summary>
        /// The subject CONTEXT is included in the object CONTEXT.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISPART")]
        [EnumMember]
        IsPartOfIsSubContextOf,
		
        /// <summary>
        /// The subject CONTEXT negates the object CONTEXT by replacing it.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SPRCDS")]
        [EnumMember]
        Supersedes,
		
        /// <summary>
        /// The subject CONTEXT provides amplifying information with respect to the object CONTEXT.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SPPLMN")]
        [EnumMember]
        Supplements,
		
    }
}
