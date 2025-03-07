using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of GEOGRAPHIC-FEATURE-TYPE.
    /// </summary>
    [DomId(100004327)]
    [DataContract]
    public enum GeographicFeatureTypeSubcategoryEnum
    {
		
        /// <summary>
        /// Area between the normal limit of wave action above either Mean High Water Springs (MHWS) or Mean High High Water (MHHW) as defined by the National Authority and the maximum limit of wave action.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BCKSHR")]
        [EnumMember]
        Backshore,
		
        /// <summary>
        /// The shore of the sea or lake, sandy or pebbly, brought up by the waves (including the foreshore area).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BEACH")]
        [EnumMember]
        Beach,
		
        /// <summary>
        /// A steep, vertical, or overhanging face of rock or earth.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BLUFF")]
        [EnumMember]
        BluffCliffEscarpment,
		
        /// <summary>
        /// A poorly drained or periodically flooded area, excluding tidal waters, with soil rich in plant residue.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BOG")]
        [EnumMember]
        Bog,
		
        /// <summary>
        /// A natural subterranean chamber or series of chambers open to the Earth’s surface.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CAVE")]
        [EnumMember]
        Cave,
		
        /// <summary>
        /// A small insular feature, which may contain scant vegetation; usually composed of sand or coral. Often applied to smaller coral shoals.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CAY")]
        [EnumMember]
        Cay,
		
        /// <summary>
        /// That part of a body of water, sometimes dredged, deep enough for navigation through an area otherwise not navigable. It is usually marked by a single or double line of navigational aids.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CHANEL")]
        [EnumMember]
        Channel,
		
        /// <summary>
        /// A line generally following the contact between a land mass and a body of water, based on the low water line, and used as a reference for measuring international boundaries such as Territorial Limits or Exclusive Economic Zone (EEZ).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CSTLNE")]
        [EnumMember]
        Coastline,
		
        /// <summary>
        /// A narrow fissure, crack, or rift in the Earth’s surface, snow or ice.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CRVCEC")]
        [EnumMember]
        CreviceCrevasse,
		
        /// <summary>
        /// An excavation of the Earth’s surface to provide passage for a road, railroad, canal, etc.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CUT")]
        [EnumMember]
        Cut,
		
        /// <summary>
        /// A low area surrounded by higher ground.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("DPRSSN")]
        [EnumMember]
        Depression,
		
        /// <summary>
        /// A waterless ravine or mountain pass.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DRYGAP")]
        [EnumMember]
        DryGap,
		
        /// <summary>
        /// A raised long mound of earth or other material.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("EMBANK")]
        [EnumMember]
        EmbankmentFill,
		
        /// <summary>
        /// A long, narrow ridge of sand and gravel deposited by a glacial stream.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ESKER")]
        [EnumMember]
        Esker,
		
        /// <summary>
        /// A gently sloping fan shaped feature usually found near the lower termination of a canyon.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("FAN")]
        [EnumMember]
        Fan,
		
        /// <summary>
        /// A fracture in the Earth’s crust with displacement on one side of the fracture relative to the other.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("FAULT")]
        [EnumMember]
        Fault,
		
        /// <summary>
        /// Land subject to controlled inundation (i.e. flooded by the regulation of the level of water impounded by a dam or beaver dam), and is normally associated with permanently flooded areas in which trees are still standing. Also known as inundated land.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("FLDDAR")]
        [EnumMember]
        FloodedArea,
		
        /// <summary>
        /// An open, inclined channel which carries water for use in such operations as mining or logging.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("FLUME")]
        [EnumMember]
        Flume,
		
        /// <summary>
        /// A shallow part of a body of water that can be crossed without bridging, boats, or rafts. A location in a water barrier where the physical characteristics of current, bottom, and approaches permit the passage of personnel and/or vehicles and other equipment that remain in contact with the bottom.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("FORD")]
        [EnumMember]
        Ford,
		
        /// <summary>
        /// Area between the low water line defined by Mean Low Water Springs (MLWS) or Mean Low Low Water (MLLW) as appropriate and the normal limit of wave action above Mean High Water Springs (MHWS) or Mean High High Water (MHHW) as appropriate.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("FRESHR")]
        [EnumMember]
        Foreshore,
		
        /// <summary>
        /// A terrain surface feature controlled by or derived from the heat of the Earth’s interior.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("GEOTHR")]
        [EnumMember]
        GeothermalFeature,
		
        /// <summary>
        /// A large mass of snow and ice moving slowly down a slope or valley from above the snowline.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("GLACER")]
        [EnumMember]
        Glacier,
		
        /// <summary>
        /// A long, narrow, deep erosion with steep banks.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("GULLY")]
        [EnumMember]
        GullyGorge,
		
        /// <summary>
        /// A place of shelter for ships; where they may lie close to and sheltered by the shore or by works extended from it.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("HRBRNT")]
        [EnumMember]
        HarbourNatural,
		
        /// <summary>
        /// A small, isolated elevation, smaller than a mountain.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("HILL")]
        [EnumMember]
        Hill,
		
        /// <summary>
        /// An area of higher elevation within a swamp, bog, or marsh.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("HUMOCK")]
        [EnumMember]
        Hummock,
		
        /// <summary>
        /// The vertical face of a glacier or ice shelf.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("ICECLF")]
        [EnumMember]
        IceCliff,
		
        /// <summary>
        /// A rocky peak projecting above a surrounding ice field that may be perpetually covered with ice.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("ICEPKN")]
        [EnumMember]
        IcePeakNunatak,
		
        /// <summary>
        /// A sheet of thick ice, with level or undulating surface, attached to the land but mostly afloat which is bounded on the seaward side by an Ice Cliff.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("ICESHL")]
        [EnumMember]
        IceShelf,
		
        /// <summary>
        /// The land-water boundary for all inland hydrographic features having shorelines, Lake /Pond, or Island.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("INLNDS")]
        [EnumMember]
        InlandShoreline,
		
        /// <summary>
        /// A land mass smaller than a continent and surrounded by water.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("ISLAND")]
        [EnumMember]
        Island,
		
        /// <summary>
        /// Open body of water separated from the sea by a sand bank or coral reef.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("LAGOON")]
        [EnumMember]
        LagoonReefPool,
		
        /// <summary>
        /// A body of water surrounded by land.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("LKEPND")]
        [EnumMember]
        LakePond,
		
        /// <summary>
        /// An area periodically covered by flood water, excluding tidal waters.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("LNDSBJ")]
        [EnumMember]
        LandSubjectToInundation,
		
        /// <summary>
        /// A mass of land, with a high potential of slipping down from a mountain, hill, etc.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("LNDSLD")]
        [EnumMember]
        LandslideScree,
		
        /// <summary>
        /// A conspicuous isolated rocky formation or single large stone existing in its entirety above the high water mark. From offshore it would appear to a mariner as a single point on land and would be appropriate for use in navigation.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("LRGRCK")]
        [EnumMember]
        LargeIsolatedRockBoulderOrRockyFormation,
		
        /// <summary>
        /// A narrow, flat surface or shelf, especially one that projects, as from a wall of rock.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("LEDGE")]
        [EnumMember]
        Ledge,
		
        /// <summary>
        /// An area of wet, often spongy ground that is subject to frequent or tidal inundations, but not considered to be continually under water.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("MARSH")]
        [EnumMember]
        Marsh,
		
        /// <summary>
        /// An accumulation of soil and stone debris deposited by a glacier.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("MORANE")]
        [EnumMember]
        Moraine,
		
        /// <summary>
        /// A natural elevation of the earth's surface rising more or less abruptly from the surrounding level, and attaining an altitude which, relatively to adjacent elevations, is impressive or notable.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("MOUNTN")]
        [EnumMember]
        Mountain,
		
        /// <summary>
        /// A natural route through a low place in a mountain range.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("MNTPSS")]
        [EnumMember]
        MountainPass,
		
        /// <summary>
        /// Area between the 10 meter depth curve and the low water line defined by either Mean Low Water Springs (MLWS) or Mean Low Low Water (MLLW) as defined by the National Authority and the International Hydrographic Organisation.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("NRSHRE")]
        [EnumMember]
        Nearshore,
		
        /// <summary>
        /// An area of ice formed by the drifting and crushing together of floating pieces of ice.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("PCKICE")]
        [EnumMember]
        PackIce,
		
        /// <summary>
        /// A cone or dome shaped mound or hill of peat or soil, usually with a core of ice. It is found in tundra regions and is produced by the pressure of water or ice accumulating underground and pushing upward.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("PINGO")]
        [EnumMember]
        Pingo,
		
        /// <summary>
        /// The heaviest, thickest form of ice over land or water.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("PLRICE")]
        [EnumMember]
        PolarIce,
		
        /// <summary>
        /// A place in a stream or river where the current is swift and the surface is usually broken by boulders and rocks.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("RAPIDS")]
        [EnumMember]
        Rapids,
		
        /// <summary>
        /// A rocky or coral elevation at or near enough to the surface of the sea to be a danger to surface navigation.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("REEF")]
        [EnumMember]
        Reef,
		
        /// <summary>
        /// The limit line between the water area of a river and the area of land.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("RVRBNK")]
        [EnumMember]
        RiverBank,
		
        /// <summary>
        /// A natural flowing watercourse.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("RVRSTR")]
        [EnumMember]
        RiverStream,
		
        /// <summary>
        /// Point at which a river or stream passes into the ground.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("RVRSTV")]
        [EnumMember]
        RiverStreamVanishingPoint,
		
        /// <summary>
        /// An isolated rocky formation or a single large stone above or below the water surface.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("ROCK")]
        [EnumMember]
        Rock,
		
        /// <summary>
        /// A visual topographic outcrop, layers or beds of rock.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("RCKSTR")]
        [EnumMember]
        RockStrataRockFormation,
		
        /// <summary>
        /// A flat area of natural surface salt deposits.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("SLTPAN")]
        [EnumMember]
        SaltPan,
		
        /// <summary>
        /// Ridges or hills of sand.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("SNDDUN")]
        [EnumMember]
        SandDuneSandHill,
		
        /// <summary>
        /// A natural depression in arid or semi-arid regions whose bed is covered with salt encrusted clayey soil.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("SEBKHA")]
        [EnumMember]
        Sebkha,
		
        /// <summary>
        /// A line drawn along the normal limit of wave action above either Mean High Water Springs (MHWS) or Mean High High Water (MHHW) as defined by the National Authority.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("SHRLNE")]
        [EnumMember]
        Shoreline,
		
        /// <summary>
        /// A stem or a trunk of a tree below the surface of water.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("SNGSSS")]
        [EnumMember]
        SnagsSubmergedStumps,
		
        /// <summary>
        /// A large area permanently covered by snow or ice over land or water.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("SNWICE")]
        [EnumMember]
        SnowFieldIceField,
		
        /// <summary>
        /// A natural outflow of water from below the ground surface.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("SPRING")]
        [EnumMember]
        SpringWaterHole,
		
        /// <summary>
        /// A low lying saturated area covered with water all or most of the year, where accumulating dead vegetation does not rapidly decay. It can exist on flat-lying areas created by certain geomorphic environments.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("SWAMP")]
        [EnumMember]
        Swamp,
		
        /// <summary>
        /// A prairie-like region in the Arctic and Subarctic zones in which the subsoil is permanently frozen.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("TUNDRA")]
        [EnumMember]
        Tundra,
		
        /// <summary>
        /// Water situated underground but reachable by wells.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("UNDRGW")]
        [EnumMember]
        UndergroundWaterPhreaticWater,
		
        /// <summary>
        /// Area undermined through mining activities that has already partly subsided or that is in the process of subsiding.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("UNDRML")]
        [EnumMember]
        UnderminedLand,
		
        /// <summary>
        /// Sand on the sea floor having steeper sides and less regular topography than a rise.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("UNDRSR")]
        [EnumMember]
        UnderwaterSandRidge,
		
        /// <summary>
        /// A stretched-out groove in the land, usually formed by streams or rivers. A valley begins with high ground on three sides, and usually has a course of running water through it.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("VALLEY")]
        [EnumMember]
        Valley,
		
        /// <summary>
        /// A mountain or hill, often conical, formed around a vent in the earth's crust through which molten rock, ash, or gases are or have been expelled.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("VOLCNO")]
        [EnumMember]
        Volcano,
		
        /// <summary>
        /// A steep ridge of igneous rock.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("VLCNOD")]
        [EnumMember]
        VolcanoDike,
		
        /// <summary>
        /// An area of water that normally has tidal fluctuations.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("WATER")]
        [EnumMember]
        WaterExceptInland,
		
        /// <summary>
        /// A vertical or nearly vertical descent of water.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("WATRFL")]
        [EnumMember]
        Waterfall,
		
    }
}
