using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the perceived class of a specific ACTION-TASK at a given time.
    /// </summary>
    [DomId(100000287)]
    [DataContract]
    public enum ActionTaskStatusCategoryEnum
    {
		
        /// <summary>
        /// An ACTION-TASK-STATUS indicating that the ACTION-TASK has been directed to be executed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ORD")]
        [EnumMember]
        Order,
		
        /// <summary>
        /// An ACTION-TASK-STATUS indicating that the ACTION-TASK is a plan.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PLAN")]
        [EnumMember]
        Plan,
		
    }
}
