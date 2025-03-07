using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of LIGHT.
    /// </summary>
    [DomId(100000215)]
    [DataContract]
    public enum LightCategoryEnum
    {
		
        /// <summary>
        /// Ambient atmospheric light resulting from the sun.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DAY")]
        [EnumMember]
        Daylight,
		
        /// <summary>
        /// The periods of incomplete darkness following sunset and preceding sunrise. The darker limit occurs when the centre of the sun is 6 degrees below the celestial horizon.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CIVIL")]
        [EnumMember]
        CivilTwilight,
		
        /// <summary>
        /// The periods of incomplete darkness following sunset and preceding sunrise. The darker limit occurs when the centre of the sun is 12 degrees below the celestial horizon.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NAUTIC")]
        [EnumMember]
        NauticalTwilight,
		
        /// <summary>
        /// Ambient atmospheric light resulting from the moon.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MOON")]
        [EnumMember]
        Moonlight,
		
        /// <summary>
        /// The absence of light.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DARK")]
        [EnumMember]
        Darkness,
		
    }
}
