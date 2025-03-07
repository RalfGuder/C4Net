using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of acknowledgement of the distribution for a specific PLAN-ORDER and a specific recipient.
    /// </summary>
    [DomId(100004391)]
    [DataContract]
    public enum PlanOrderDistributionAcknowledgementEnum
    {
		
        /// <summary>
        /// The recipient has understood the content of a specific PLAN-ORDER.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACK")]
        [EnumMember]
        Acknowledged,
		
        /// <summary>
        /// The recipient has read the content of the specific PLAN-ORDER.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("READ")]
        [EnumMember]
        Read,
		
        /// <summary>
        /// The recipient has taken delivery of the specific PLAN-ORDER.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RCVD")]
        [EnumMember]
        Received,
		
    }
}
