using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the prevailing class of a specific PRECIPITATION.
    /// </summary>
    [DomId(100000170)]
    [DataContract]
    public enum PrecipitationCategoryEnum
    {
		
        /// <summary>
        /// No measurable precipitation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NPR")]
        [EnumMember]
        NoPrecipitation,
		
        /// <summary>
        /// Precipitation in the form of small balls or other pieces of ice falling separately or frozen together in irregular lumps. Hailstones consist of alternate opaque and clear layers of ice in most cases. Hail is normally associated with thunderstorms and surface temperatures above freezing.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HAIL")]
        [EnumMember]
        Hail,
		
        /// <summary>
        /// Precipitation, either in the form of drops larger than 0.5 mm, or smaller drops, which in contrast to drizzle, are widely separated.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RAIN")]
        [EnumMember]
        Rain,
		
        /// <summary>
        /// A condition with precipitation of rain and snow.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SLEET")]
        [EnumMember]
        Sleet,
		
        /// <summary>
        /// Frozen precipitation in the form of white or translucent hexagonal ice crystals that fall in soft, white flakes.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SNOW")]
        [EnumMember]
        Snow,
		
        /// <summary>
        /// Fairly uniform precipitation composed exclusively of fine drops (diameter less than 0.5 mm) very close together. Drizzle appears to float while following air currents although, unlike fog droplets, it falls to the ground. It usually falls from low stratus clouds and is frequently accompanied by low visibility and fog.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DRZLE")]
        [EnumMember]
        Drizzle,
		
        /// <summary>
        /// Drizzle which freezes upon impact with the ground, with objects in flight, or with objects on the ground. Produces glaze (clear) ice.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("FDRZLE")]
        [EnumMember]
        FreezingDrizzle,
		
        /// <summary>
        /// Rain that freezes on impact with the ground, with objects in flight, or with objects on the ground. Produces glaze (clear) ice.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FRAIN")]
        [EnumMember]
        FreezingRain,
		
        /// <summary>
        /// A fall of unbranched (snow crystals are branched) ice crystals in the form of needles, columns, or plates. They are termed "ice prisms" in synoptic observations. Ice crystals are often so tiny they seem to be suspended in air. They may fall from a cloud or from clear air. The crystals are visible mainly when they glitter in the sunshine or other bright light (diamond dust), thus producing a luminous pillar or other optical phenomena. This hydrometer (rarely more than the lightest precipitation), which is frequent in polar regions, occurs only at very low temperatures in stable air masses.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ICECRY")]
        [EnumMember]
        IceCrystals,
		
        /// <summary>
        /// Precipitation of transparent or translucent pellets of ice, which are round or irregular, rarely conical, and have a diameter of 5 mm or less. The pellets usually rebound when striking hard ground and make a sound on impact. There are two main types: hard grains of ice consisting of frozen raindrops or melted and refrozen snowflakes and pellets of snow encased in a thin layer of ice formed from the freezing, either of droplets intercepted by the pellets, or of water resulting from the partial melting of the pellets.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ICEPLT")]
        [EnumMember]
        IcePellets,
		
        /// <summary>
        /// The rain changes intensity or starts and stops abruptly. These showers fall exclusively from cumuliform clouds.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("RAINSR")]
        [EnumMember]
        RainShower,
		
        /// <summary>
        /// Precipitation of very small, white, opaque particles of ice; the solid equivalent of drizzle. The grains are fairly flat or elongated. Diameters are generally less than 1 mm. When the grains hit hard ground, they do not bounce or shatter. They usually fall in very small quantities from stratus clouds (or occasionally from fog).
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SNWGRN")]
        [EnumMember]
        SnowGrains,
		
        /// <summary>
        /// Snow changes intensity or starts and stops abruptly. These showers fall exclusively from cumuliform clouds.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SNWSHR")]
        [EnumMember]
        SnowShower,
		
    }
}
