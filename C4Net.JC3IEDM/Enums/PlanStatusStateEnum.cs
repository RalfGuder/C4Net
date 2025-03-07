using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value assigned to represent the condition for a specific PLAN.
    /// </summary>
    [DomId(100004394)]
    [DataContract]
    public enum PlanStatusStateEnum
    {
		
        /// <summary>
        /// A state of a specific PLAN that allows sub-units to initiate their own planning processes.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APPRVD")]
        [EnumMember]
        Approved,
		
        /// <summary>
        /// A state of a specific PLAN to indicate that the PLAN will not be used or further developed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CANCEL")]
        [EnumMember]
        Cancelled,
		
        /// <summary>
        /// A state of a specific PLAN that permits the PLAN to be edited.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("WTHDRN")]
        [EnumMember]
        Withdrawn,
		
    }
}
