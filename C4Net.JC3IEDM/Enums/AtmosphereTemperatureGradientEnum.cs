using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents heat change with respect to the ground and 100 m in elevation in a certain area. Acts as an indication of vertical air movement between the ground and higher elevations.
    /// </summary>
    [DomId(100000171)]
    [DataContract]
    public enum AtmosphereTemperatureGradientEnum
    {
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// More than one degree Kelvin positive temperature gradient between the ground and 100 metres above ground level. (colder lower layers)
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("STABLE")]
        [EnumMember]
        Stable,
		
        /// <summary>
        /// More than one degree Kelvin negative temperature gradient between the ground and 100 metres above ground level. (hotter lower layers)
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("UNSTAB")]
        [EnumMember]
        Unstable,
		
        /// <summary>
        /// A one degree Kelvin, or less, temperature gradient between the ground and 100 metres above ground level.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NEUTRL")]
        [EnumMember]
        Neutral,
		
    }
}
