using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific OBJECT-ITEM has been booby-trapped.
    /// </summary>
    [DomId(100000385)]
    [DataContract]
    public enum ObjectItemStatusBoobyTrapPresenceEnum
    {
		
        /// <summary>
        /// The specific OBJECT-ITEM has not been booby-trapped.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// It is unknown if the specific OBJECT-ITEM has been booby-trapped.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
        /// <summary>
        /// The specific OBJECT-ITEM has been booby-trapped.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
