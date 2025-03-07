using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-TASK.
    /// </summary>
    [DomId(100000283)]
    [DataContract]
    public enum ActionTaskCategoryEnum
    {
		
        /// <summary>
        /// An ACTION-TASK that is directed to be executed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ORD")]
        [EnumMember]
        Order,
		
        /// <summary>
        /// An ACTION-TASK that represents a course of action that is foreseen or anticipated.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PLAN")]
        [EnumMember]
        Plan,
		
        /// <summary>
        /// An ACTION-TASK that states a requirement.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RQT")]
        [EnumMember]
        Request,
		
        /// <summary>
        /// An ACTION-TASK that serves as a reference in planning.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TEM")]
        [EnumMember]
        Template,
		
    }
}
