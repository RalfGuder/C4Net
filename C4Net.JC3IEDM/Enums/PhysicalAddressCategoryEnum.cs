using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of the PHYSICAL-ADDRESS.
    /// </summary>
    [DomId(100000383)]
    [DataContract]
    public enum PhysicalAddressCategoryEnum
    {
		
        /// <summary>
        /// An address to which a specific piece of mail is sent.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MLADDR")]
        [EnumMember]
        MailingAddress,
		
        /// <summary>
        /// An address to which a specific piece of mail should be returned to if not delivered.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RTADDR")]
        [EnumMember]
        ReturnAddress,
		
        /// <summary>
        /// The mark affixed to a mailed item by the post office.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PSTMRK")]
        [EnumMember]
        Postmark,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The actual address of a facility, organisation or person.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PHADDR")]
        [EnumMember]
        PhysicalAddress,
		
    }
}
