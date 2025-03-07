using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of PLAN-ORDER.
    /// </summary>
    [DomId(100004386)]
    [DataContract]
    public enum PlanOrderCategoryEnum
    {
		
        /// <summary>
        /// A communication that conveys instructions from a superior to a subordinate.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ORDER")]
        [EnumMember]
        Order,
		
        /// <summary>
        /// A proposal for putting into effect a command decision or project; it represents the preparation for future or anticipated operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PLAN")]
        [EnumMember]
        Plan,
		
    }
}
