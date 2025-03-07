using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether the specific NETWORK-SERVICE is active.
    /// </summary>
    [DomId(100004253)]
    [DataContract]
    public enum NetworkServiceStatusIndicatorEnum
    {
		
        /// <summary>
        /// The specific NETWORK-SERVICE is not activated.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific NETWORK-SERVICE is activated.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
