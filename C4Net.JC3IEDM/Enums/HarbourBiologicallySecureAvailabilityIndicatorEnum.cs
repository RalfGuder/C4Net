using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR is capable of supplying biologically secure facilities, to include quarantine facilities.
    /// </summary>
    [DomId(100004162)]
    [DataContract]
    public enum HarbourBiologicallySecureAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Biologically secure facilities are not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Biologically secure facilities are available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
