using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes at the reporting time whether an ACTION-TASK is approved for execution.
    /// </summary>
    [DomId(100004314)]
    [DataContract]
    public enum ActionTaskStatusApprovalIndicatorEnum
    {
		
        /// <summary>
        /// The associated ACTION-TASK is disapproved.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The associated ACTION-TASK is approved for execution.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
