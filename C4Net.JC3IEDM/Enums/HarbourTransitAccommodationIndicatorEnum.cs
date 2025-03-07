using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR is capable of supplying transit accommodation facilities.
    /// </summary>
    [DomId(100004173)]
    [DataContract]
    public enum HarbourTransitAccommodationIndicatorEnum
    {
		
        /// <summary>
        /// Transit accommodation is not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Transit accommodation is available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
