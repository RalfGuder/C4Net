using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-OBJECTIVE with respect to item or type.
    /// </summary>
    [DomId(100000115)]
    [DataContract]
    public enum ActionObjectiveCategoryEnum
    {
		
        /// <summary>
        /// A battlespace object (FACILITY, FEATURE, MATERIEL, ORGANISATION or PERSON) which is the focus of a specific ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("OI")]
        [EnumMember]
        ActionObjectiveItem,
		
        /// <summary>
        /// A class of battlespace object (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE or PERSON-TYPE) which is the focus of a specific ACTION.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OT")]
        [EnumMember]
        ActionObjectiveType,
		
        /// <summary>
        /// The objective of the specific ACTION is the operation identified as the specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OTASK")]
        [EnumMember]
        ActionObjectiveTask,
		
    }
}
