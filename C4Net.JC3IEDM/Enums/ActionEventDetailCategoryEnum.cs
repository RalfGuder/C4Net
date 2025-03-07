using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-EVENT-DETAIL.
    /// </summary>
    [DomId(100004427)]
    [DataContract]
    public enum ActionEventDetailCategoryEnum
    {
		
        /// <summary>
        /// An ACTION-EVENT-DETAIL that describes how an IED incident was conducted or intended to be conducted.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("IEDTC")]
        [EnumMember]
        IedTacticalCharacterization,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
