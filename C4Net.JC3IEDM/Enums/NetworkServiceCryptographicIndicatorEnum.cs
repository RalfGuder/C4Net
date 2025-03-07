using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific NETWORK-SERVICE is encrypted.
    /// </summary>
    [DomId(100004123)]
    [DataContract]
    public enum NetworkServiceCryptographicIndicatorEnum
    {
		
        /// <summary>
        /// The NETWORK-SERVICE is not encrypted.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The NETWORK-SERVICE is encrypted.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
