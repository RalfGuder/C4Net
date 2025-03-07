using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes request or requirement to modify the timing associated with a specific ACTION-TASK.
    /// </summary>
    [DomId(100000290)]
    [DataContract]
    public enum ActionTaskStatusAmendTimingEnum
    {
		
        /// <summary>
        /// The times entered into this entity represent the reporting organisation’s requested alterations to the ACTION-TASK timings.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RQSEAT")]
        [EnumMember]
        RequestEndAmendTime,
		
        /// <summary>
        /// The timings entered into this entity represent the new timings the reporting organisation requires to achieve its part of the ACTION-TASK.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RQEEAT")]
        [EnumMember]
        RequireEndAmendTime,
		
        /// <summary>
        /// The times entered into this entity represent the reporting organisation’s requested alterations to the ACTION-TASK timings.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RQSSAT")]
        [EnumMember]
        RequestStartAmendTime,
		
        /// <summary>
        /// The timings entered into this entity represent the new timings the reporting organisation requires to achieve its part of the ACTION-TASK.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RQESAT")]
        [EnumMember]
        RequireStartAmendTime,
		
    }
}
