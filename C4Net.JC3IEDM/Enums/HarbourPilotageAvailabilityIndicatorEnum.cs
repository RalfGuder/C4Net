using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a pilot is available at the port.
    /// </summary>
    [DomId(100004303)]
    [DataContract]
    public enum HarbourPilotageAvailabilityIndicatorEnum
    {
		
        /// <summary>
        /// Pilotage is not available at the port.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Pilotage is available at the port.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
