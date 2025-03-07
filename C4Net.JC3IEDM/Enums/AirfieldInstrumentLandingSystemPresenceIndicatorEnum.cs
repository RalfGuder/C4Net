using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific AIRFIELD has an instrument landing system.
    /// </summary>
    [DomId(100004112)]
    [DataContract]
    public enum AirfieldInstrumentLandingSystemPresenceIndicatorEnum
    {
		
        /// <summary>
        /// At the specific AIRFIELD there is no instrument landing system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// At the specific AIRFIELD there is an instrument landing system.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
