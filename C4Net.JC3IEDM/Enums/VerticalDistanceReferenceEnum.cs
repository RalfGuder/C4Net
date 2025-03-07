using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the reference system for a specific VERTICAL-DISTANCE.
    /// </summary>
    [DomId(100004211)]
    [DataContract]
    public enum VerticalDistanceReferenceEnum
    {
		
        /// <summary>
        /// The vertical reference established as the lowest observed or theoretical sea level possible for the area, such as Mean Lower Low Water (MLLW) or Lowest Astronomical Tide (LAT).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CHADAT")]
        [EnumMember]
        ChartDatum,
		
        /// <summary>
        /// The vertical reference for a level, a point or an object considered as a point measured from a specific datum.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LOCDAT")]
        [EnumMember]
        LocalDatum,
		
        /// <summary>
        /// The vertical reference established as the average level of the ocean surface measured over a full metonic tidal cycle of 18.6 years.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MNSLVL")]
        [EnumMember]
        MeanSeaLevel,
		
        /// <summary>
        /// The VERTICAL-DISTANCE reference in terms of atmospheric pressure indicated by a pressure altimeter that is calibrated to read 0 at airfield runway ground level.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PDQFE")]
        [EnumMember]
        PressureDatumQfe,
		
        /// <summary>
        /// The VERTICAL-DISTANCE reference in terms of atmospheric pressure indicated by a pressure altimeter that is calibrated to read 0 at Mean Sea Level (MSL).
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PDQNH")]
        [EnumMember]
        PressureDatumQnh,
		
        /// <summary>
        /// The VERTICAL-DISTANCE reference in terms of atmospheric pressure indicated by a pressure altimeter that is calibrated to read 0 at standard atmosphere pressure of 1013.2 millibars.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PDSTDT")]
        [EnumMember]
        PressureDatumStandardAtmosphere,
		
        /// <summary>
        /// The datum for VERTICAL-DISTANCE provided by the submerged surface at a point or area.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("WATBOT")]
        [EnumMember]
        WaterBottom,
		
        /// <summary>
        /// The vertical reference is the actual visible surface. This includes both terrain and water surfaces.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("TOPOSR")]
        [EnumMember]
        TopographicSurface,
		
        /// <summary>
        /// The vertical reference established as the surface of the WGS84 geoid.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("WGS84G")]
        [EnumMember]
        Wgs84Geoid,
		
        /// <summary>
        /// The vertical reference established as the surface of the WGS84 ellipsoid.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("WGS84R")]
        [EnumMember]
        Wgs84ReferenceEllipsoid,
		
    }
}
