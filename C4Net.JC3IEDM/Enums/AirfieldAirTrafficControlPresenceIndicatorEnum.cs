using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific AIRFIELD provides air traffic control.
    /// </summary>
    [DomId(100004111)]
    [DataContract]
    public enum AirfieldAirTrafficControlPresenceIndicatorEnum
    {
		
        /// <summary>
        /// The specific AIRFIELD does not provide air traffic control.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific AIRFIELD provides air traffic control.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
