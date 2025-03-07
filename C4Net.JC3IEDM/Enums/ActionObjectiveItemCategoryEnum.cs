using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-OBJECTIVE-ITEM.
    /// </summary>
    [DomId(100000206)]
    [DataContract]
    public enum ActionObjectiveItemCategoryEnum
    {
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// An ACTION-OBJECTIVE-ITEM that is subject to capture, destruction or intelligence operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TARGET")]
        [EnumMember]
        Target,
		
    }
}
