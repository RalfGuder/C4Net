using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether the surface will recirculate as a result of rotor downwash.
    /// </summary>
    [DomId(100000309)]
    [DataContract]
    public enum GeographicFeatureStatusSurfaceRecirculationIndicatorEnum
    {
		
        /// <summary>
        /// The specific GEOGRAPHIC-FEATURE will not recirculate as a result of rotor downwash.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific GEOGRAPHIC-FEATURE will recirculate as a result of rotor downwash.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
