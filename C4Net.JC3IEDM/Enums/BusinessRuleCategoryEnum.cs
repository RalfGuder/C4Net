using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of BUSINESS-RULE as text or a formal rule.
    /// </summary>
    [DomId(100006035)]
    [DataContract]
    public enum BusinessRuleCategoryEnum
    {
		
        /// <summary>
        /// The specific value that represents a BUSINESS-RULE that is formalized in metadata content.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RULE")]
        [EnumMember]
        Rule,
		
        /// <summary>
        /// The specific value that represents a BUSINESS-RULE that is in textual form.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TEXT")]
        [EnumMember]
        Text,
		
    }
}
