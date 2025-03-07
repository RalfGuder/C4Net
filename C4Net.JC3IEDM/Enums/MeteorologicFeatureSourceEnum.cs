using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the basis for the estimate of a condition for a specific METEOROLOGIC-FEATURE.
    /// </summary>
    [DomId(100000169)]
    [DataContract]
    public enum MeteorologicFeatureSourceEnum
    {
		
        /// <summary>
        /// A statement of anticipated (meteorological) conditions for a specified place (or area, route, etc.) and period of time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FOR")]
        [EnumMember]
        Forecast,
		
        /// <summary>
        /// Reported based on observation, in meteorological context, a record of measurement or assessment of one or more meteorological elements - e.g. temperature pressure, cloud type and amount - at a particular time and place.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OBSRVD")]
        [EnumMember]
        Observed,
		
    }
}
