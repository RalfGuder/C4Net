using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value assigned to represent the state of preparation for a specific PLAN.
    /// </summary>
    [DomId(100004393)]
    [DataContract]
    public enum PlanStatusDevelopmentStatusEnum
    {
		
        /// <summary>
        /// The preparation of the specific PLAN has been completed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMPL")]
        [EnumMember]
        Complete,
		
        /// <summary>
        /// The preparation of the specific PLAN has not been completed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NCOMPL")]
        [EnumMember]
        NotComplete,
		
    }
}
