using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between a subject PLAN-ORDER-COMPONENT and an object PLAN-ORDER-COMPONENT in a specific PLAN-ORDER-COMPONENT-STRUCTURE.
    /// </summary>
    [DomId(100004389)]
    [DataContract]
    public enum PlanOrderComponentStructureCategoryEnum
    {
		
        /// <summary>
        /// The relationship of the subject PLAN-ORDER-COMPONENT to the object PLAN-ORDER-COMPONENT is deleted.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISDISS")]
        [EnumMember]
        IsDissociatedFrom,
		
        /// <summary>
        /// The subject PLAN-ORDER-COMPONENT is the general topic for which the object PLAN-ORDER-COMPONENT is a sub-topic.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISPRNT")]
        [EnumMember]
        IsParentOf,
		
        /// <summary>
        /// The subject PLAN-ORDER-COMPONENT is replaced in its entirety by the object PLAN-ORDER-COMPONENT. The replacement removes all subordinate components of the subject PLAN-ORDER-COMPONENT.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISREPL")]
        [EnumMember]
        IsReplacedBy,
		
    }
}
