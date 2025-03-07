using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the priority that a specific ADDRESS has with respect to a specific OBJECT-ITEM.
    /// </summary>
    [DomId(100004236)]
    [DataContract]
    public enum ObjectItemAddressPrimacyEnum
    {
		
        /// <summary>
        /// Denotes the primary ADDRESS.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PRIME")]
        [EnumMember]
        Primary,
		
        /// <summary>
        /// Denotes the secondary ADDRESS.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SCNDRY")]
        [EnumMember]
        Secondary,
		
        /// <summary>
        /// Denotes the tertiary ADDRESS.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("THIRD")]
        [EnumMember]
        Tertiary,
		
    }
}
