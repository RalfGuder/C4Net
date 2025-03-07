using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes at the reporting time whether an ACTION-TASK is completed in the planning process.
    /// </summary>
    [DomId(100000288)]
    [DataContract]
    public enum ActionTaskStatusPlanningIndicatorEnum
    {
		
        /// <summary>
        /// Additional ACTION-TASKs are expected to be added or linked to this or an associated ACTION-TASK or further refinement of the specific ACTION-TASK is intended.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The associated ACTION-TASK specification is complete.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
