using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the availability of tugs at a specific HARBOUR.
    /// </summary>
    [DomId(100004306)]
    [DataContract]
    public enum HarbourTugAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Tugs are not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Tugs are available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
