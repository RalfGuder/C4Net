using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the phase of the moon for a specific LIGHT.
    /// </summary>
    [DomId(100000194)]
    [DataContract]
    public enum LightMoonPhaseEnum
    {
		
        /// <summary>
        /// The moon is increasing in phase.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("WAX")]
        [EnumMember]
        WaxingMoon,
		
        /// <summary>
        /// The moon with its entire disc illuminated.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FUL")]
        [EnumMember]
        FullMoon,
		
        /// <summary>
        /// The moon is decreasing in phase.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("WAN")]
        [EnumMember]
        WaningMoon,
		
        /// <summary>
        /// The moon when first seen as a slender crescent shortly after its conjunction with the sun.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NEW")]
        [EnumMember]
        NewMoon,
		
    }
}
