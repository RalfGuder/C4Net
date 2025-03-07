using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the relative usage of a specific ACTION-OBJECTIVE-ITEM when more than one instance of ACTION-OBJECTIVE-ITEM is designated for a specific ACTION.
    /// </summary>
    [DomId(100004317)]
    [DataContract]
    public enum ActionObjectiveItemPrimacyEnum
    {
		
        /// <summary>
        /// Denotes an alternate ACTION-OBJECTIVE-ITEM.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ALTERN")]
        [EnumMember]
        Alternate,
		
        /// <summary>
        /// Denotes a primary ACTION-OBJECTIVE-ITEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PRIME")]
        [EnumMember]
        Primary,
		
        /// <summary>
        /// Denotes a secondary ACTION-OBJECTIVE-ITEM.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SECOND")]
        [EnumMember]
        Secondary,
		
    }
}
