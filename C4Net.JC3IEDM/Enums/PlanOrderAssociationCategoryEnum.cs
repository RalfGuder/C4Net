using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between a subject PLAN-ORDER and an object PLAN-ORDER in a specific PLAN-ORDER-ASSOCIATION.
    /// </summary>
    [DomId(100004387)]
    [DataContract]
    public enum PlanOrderAssociationCategoryEnum
    {
		
        /// <summary>
        /// The provisions of subject PLAN-ORDER are altered by the provisions of the object PLAN-ORDER. Note: One of the uses for this value is to establish a relationship between an OPORDER and a FRAGO.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISAMND")]
        [EnumMember]
        IsAmendedBy,
		
        /// <summary>
        /// The relationship of the subject PLAN-ORDER with the object PLAN-ORDER is deleted.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISDTCH")]
        [EnumMember]
        IsDissociatedFrom,
		
        /// <summary>
        /// The subject PLAN-ORDER specifies additional content to make the object PLAN-ORDER into an operational order.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISORDR")]
        [EnumMember]
        IsOrderFor,
		
        /// <summary>
        /// The subject PLAN-ORDER is superseded by the object PLAN-ORDER in its entirety.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISSPRD")]
        [EnumMember]
        IsSupersededBy,
		
        /// <summary>
        /// The subject PLAN-ORDER is supported by the related object PLAN-ORDER. Note: This value is intended for a situation where an annex (such as fire support) is managed separately but is an inherent part of a plan or order.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISSUPP")]
        [EnumMember]
        IsSupportedBy,
		
    }
}
