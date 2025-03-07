using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value assigned to represent the type of PLAN-ORDER-DISTRIBUTION with respect to the reason for its dissemination.
    /// </summary>
    [DomId(100004390)]
    [DataContract]
    public enum PlanOrderDistributionCategoryEnum
    {
		
        /// <summary>
        /// The PLAN-ORDER is to be distributed to the specific ORGANISATION for execution.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSTEXE")]
        [EnumMember]
        DistributedForExecution,
		
        /// <summary>
        /// The PLAN-ORDER is to be distributed to the specific ORGANISATION for information only.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DSTINF")]
        [EnumMember]
        DistributedForInformation,
		
    }
}
