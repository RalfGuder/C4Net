using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of obscurant that governs a particular VISIBILITY.
    /// </summary>
    [DomId(100000305)]
    [DataContract]
    public enum VisibilityCategoryEnum
    {
		
        /// <summary>
        /// Dust or sand raised by the wind to a height of 1.8 metres or more.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSTSND")]
        [EnumMember]
        BlowingDustOrSand,
		
        /// <summary>
        /// Snow particles raised and stirred violently by the wind to moderate or great heights. Prevailing visibility is reduced to less than 11,260 metres and the sky may become obscured when the particles are raised to great heights.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BLWSNW")]
        [EnumMember]
        BlowingSnow,
		
        /// <summary>
        /// Well-developed dust/sand whirls (PO). An ensemble of particles of dust or sand, sometimes accompanied by small litter, raised from the ground in the form of a whirling column of varying height with a small diameter and an approximately vertical axis. Reported regardless of the visibility.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DSTDVL")]
        [EnumMember]
        DustDevil,
		
        /// <summary>
        /// An unusual, frequently severe weather condition characterised by strong winds and dust-filled air over an extensive area. Report a dust storm if the prevailing visibility is reduced to less than 1,000 meters, but not less than 500 metres. Report a heavy (severe) dust storm (+DS) if the visibility is reduced to less than 500 metres.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DSTSTR")]
        [EnumMember]
        DustStorm,
		
        /// <summary>
        /// A visible aggregate of minute water particles (droplets), which are based on the Earth’s surface, extends vertically, and reduces horizontal visibility to less than 1,000 metres. When fog is further described by the descriptors BC, MI, or PR, the prevailing visibility may be equal to or greater than 1,000 metres. Unlike drizzle, Fog does not fall to the ground.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FOG")]
        [EnumMember]
        FogMist,
		
        /// <summary>
        /// A suspension of numerous minute ice crystals in the air, or water droplets at temperatures below 0 degrees Celsius, based at the Earth’s surface and extending vertically to greater than 1.8 metres. FZFG reduces prevailing visibility to less than 1000 metres and, unlike drizzle, does not fall to the ground. The water droplets may freeze upon contact with exposed objects to form a coating of rime or glaze and it can occur even though the air temperature is above freezing. Also called Ice Fog.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FRZFOG")]
        [EnumMember]
        FreezingFog,
		
        /// <summary>
        /// A suspension in the air of extremely small, dry particles invisible to the naked eye and sufficiently numerous to give the air an opalescent appearance. This phenomenon resembles a uniform veil over the landscape and subdues all colours. Dark objects viewed through this veil tend to have a bluish tinge while bright objects, such as the sun or distant lights, tend to have a dirty yellow or reddish hue. When haze is present and the sun is well above the horizon, its light may have a peculiar silvery tinge. Haze particles may be composed of a variety of substances; e.g., dust, salt, residue from distant fires or volcanoes, pollen, etc., which generally are well diffused through the atmosphere.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HAZE")]
        [EnumMember]
        Haze,
		
        /// <summary>
        /// Particles of sand ranging in diameter from 0.2 millimetres to 1 millimetre carried aloft by a strong wind. A sandstorm is reported if the prevailing visibility is reduced to less than 1,000 metres, but not less than 500 metres. Report a heavy (severe) sandstorm (+SS) if the visibility is reduced to less than 500 metres.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SNDSTR")]
        [EnumMember]
        Sandstorm,
		
        /// <summary>
        /// A suspension in the air of small particles produced by combustion. A transition to haze may occur when smoke particles have travelled great distances (40 to 160 kilometres or more) and when the larger particles have settled out and the remaining particles have become widely scattered through the atmosphere. When viewed through smoke, the disk of the sun at sunrise and sunset appears very red. The disk may have an orange tinge when the sun is above the horizon. Evenly distributed smoke from distant sources generally has a light greyish or bluish appearance.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SMOKE")]
        [EnumMember]
        Smoke,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
