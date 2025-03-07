using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of METEOROLOGIC-FEATURE.
    /// </summary>
    [DomId(100000195)]
    [DataContract]
    public enum MeteorologicFeatureCategoryEnum
    {
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the type of particulate matter in the Earth's atmosphere and the rate of its accumulation on the Earth's surface.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PRECIP")]
        [EnumMember]
        Precipitation,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the characteristics of clouds above Earth's surface.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COVER")]
        [EnumMember]
        CloudCover,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the velocity and directional characteristics of atmospheric movement.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("WIND")]
        [EnumMember]
        Wind,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies humidity, pressure, and temperature characteristics of Earth's atmosphere.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ATMOS")]
        [EnumMember]
        Atmosphere,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the availability of natural illumination by type and time.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LIGHT")]
        [EnumMember]
        Light,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the distance at which an object illuminated by light in the visual spectrum can be detected.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("VISIB")]
        [EnumMember]
        Visibility,
		
        /// <summary>
        /// The atmospheric pressure distribution in which there is a low central pressure relative to the surroundings. Cyclonic circulation is anticlockwise round the centre in the northern hemisphere and clockwise in the southern hemisphere; in either case the sense of rotation about the vertical is the same as that of the earth's rotation.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CYCL")]
        [EnumMember]
        Cyclone,
		
        /// <summary>
        /// A tropical cyclone, especially in the West Indies, in which wind velocity equals or exceeds 64 knots (118.5 km/hr).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HURR")]
        [EnumMember]
        Hurricane,
		
        /// <summary>
        /// An atmospheric disturbance manifested in strong winds with precipitation.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("STORM")]
        [EnumMember]
        Storm,
		
        /// <summary>
        /// A local storm produced by a cumulonimbus cloud accompanied by strong gusty winds, vertical currents at higher levels, and heavy precipitation with lightning and/or thunder. It is usually a few miles in both horizontal and vertical dimensions, extending from the ground up to 6,000, 12,000 or even 18,000 metres in the most vigorous examples.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("THST")]
        [EnumMember]
        Thunderstorm,
		
        /// <summary>
        /// A violent, rotating column of air touching the ground; funnel cloud touching the ground. A tornado nearly always starts as a funnel cloud and is accompanied by a loud, roaring noise.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("TORN")]
        [EnumMember]
        Tornado,
		
        /// <summary>
        /// A tropical cyclone having winds ranging from approximately 48 to 121 kilometres per hour.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("TRST")]
        [EnumMember]
        TropicalStorm,
		
        /// <summary>
        /// A severe tropical hurricane.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("TYPH")]
        [EnumMember]
        Typhoon,
		
        /// <summary>
        /// A small revolving storm of wind in which the air whirls around a core of low pressure. Whirlwinds sometimes extend upwards to a height of many hundreds of metres and cause dust whirls formed over a desert.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("WHIR")]
        [EnumMember]
        Whirlwind,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A violent, rotating column of air that does not touch the ground, usually appended to a cumulonimbus cloud. Also called a tuba.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("FNLCLD")]
        [EnumMember]
        FunnelCloud,
		
        /// <summary>
        /// A luminous manifestation accompanying a sudden electrical discharge, which takes place from or inside a cloud or, less often, from high structures on the ground, or from mountains.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("LGTNNG")]
        [EnumMember]
        Lightning,
		
        /// <summary>
        /// A local storm produced by a cumulonimbus cloud accompanied by lightning and/or thunder and precipitation, either in the form of drops larger than 0.5 mm, or smaller drops, which in contrast to drizzle, are widely separated.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("THSTRN")]
        [EnumMember]
        ThunderstormsAndRain,
		
        /// <summary>
        /// A violent, rotating column of air that forms over a body of water, such as a bay, gulf, or lake, and touches the water surface; a tornado or funnel cloud that touches a body of water.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("WTRSPT")]
        [EnumMember]
        Waterspout,
		
        /// <summary>
        /// A METEOROLOGIC-FEATURE that specifies the accumulation of frozen water on stationary or moving surfaces.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("ICING")]
        [EnumMember]
        Icing,
		
        /// <summary>
        /// A narrow belt of strong winds, with speeds of 50 to 200 knots (92.6 to 370.4 km/hr), in the upper troposphere.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("JTSTRM")]
        [EnumMember]
        JetStream,
		
    }
}
