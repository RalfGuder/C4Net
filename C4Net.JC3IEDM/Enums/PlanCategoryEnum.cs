using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of PLAN.
    /// </summary>
    [DomId(100004385)]
    [DataContract]
    public enum PlanCategoryEnum
    {
		
        /// <summary>
        /// A mechanism which a command uses to plan/prepare to conduct military operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("OPLAN")]
        [EnumMember]
        OperationsPlan,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
