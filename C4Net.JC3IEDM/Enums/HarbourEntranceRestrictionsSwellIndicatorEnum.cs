using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether heavy swell is a natural factor restricting the entrance of vessels into the port.
    /// </summary>
    [DomId(100004297)]
    [DataContract]
    public enum HarbourEntranceRestrictionsSwellIndicatorEnum
    {
		
        /// <summary>
        /// Swell is not a natural factor restricting the entrance of vessels into the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Swell is a natural factor restricting the entrance of vessels into the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
