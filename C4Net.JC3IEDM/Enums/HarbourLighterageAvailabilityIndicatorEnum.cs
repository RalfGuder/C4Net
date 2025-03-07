using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the possibility for transferring goods from a ship to a wharf or another ship using a boat, usu. flat-bottomed at a specific maritime port.
    /// </summary>
    [DomId(100004301)]
    [DataContract]
    public enum HarbourLighterageAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Lighters are not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Lighters are available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
