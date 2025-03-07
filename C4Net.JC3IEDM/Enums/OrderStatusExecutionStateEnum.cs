using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value assigned to represent the state of execution for a specific ORDER.
    /// </summary>
    [DomId(100004383)]
    [DataContract]
    public enum OrderStatusExecutionStateEnum
    {
		
        /// <summary>
        /// The specific ORDER has been distributed to be executed according to order provisions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISSUED")]
        [EnumMember]
        Issued,
		
        /// <summary>
        /// The execution of a specific ORDER has been paused, aborted, or completed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("STOPPD")]
        [EnumMember]
        Stopped,
		
    }
}
