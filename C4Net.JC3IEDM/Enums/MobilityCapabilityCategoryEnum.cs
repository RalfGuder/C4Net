using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MOBILITY-CAPABILITY.
    /// </summary>
    [DomId(100000329)]
    [DataContract]
    public enum MobilityCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The capability to be employed, following transport by air, in an assault debarkation either by parachuting or touchdown.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRBRN")]
        [EnumMember]
        Airborne,
		
        /// <summary>
        /// The capability to move through the air by means that combine deriving lift from fixed wings or from aerofoils that rotate.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRCMP")]
        [EnumMember]
        AirComposite,
		
        /// <summary>
        /// The capability to move through the air by deriving lift from fixed wings.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AIRFW")]
        [EnumMember]
        AirFixedWing,
		
        /// <summary>
        /// The capability of an air vehicle to remain airborne and move by displacing a weight of air greater than its own.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AIRLGT")]
        [EnumMember]
        AirLighterThanAir,
		
        /// <summary>
        /// The capability to move through the air by deriving lift from aerofoils that rotate.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AIRRW")]
        [EnumMember]
        AirRotaryWing,
		
        /// <summary>
        /// The capability of a device to operate both on land and in water.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("AMPH")]
        [EnumMember]
        Amphibious,
		
        /// <summary>
        /// The capability to move by using an animal as a carrier.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ANIMNT")]
        [EnumMember]
        AnimalMounted,
		
        /// <summary>
        /// The capability of moving on foot.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DSMNTD")]
        [EnumMember]
        Dismounted,
		
        /// <summary>
        /// The capability of a device to move along rails.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("LNDRAI")]
        [EnumMember]
        LandRailed,
		
        /// <summary>
        /// The capability of a device to move over land under its own power.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LNDSPP")]
        [EnumMember]
        LandSelfPropelled,
		
        /// <summary>
        /// The capability of a device to move by means of external propulsion (mechanical or animal).
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("LNDTWD")]
        [EnumMember]
        LandTowed,
		
        /// <summary>
        /// The capability of a device to move on caterpillar treads.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("LNDTRC")]
        [EnumMember]
        LandTracked,
		
        /// <summary>
        /// The capability of a device to move on wheels.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("LNDWHL")]
        [EnumMember]
        LandWheeled,
		
        /// <summary>
        /// The capability of a device to move on or under the water surface.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("WATSUB")]
        [EnumMember]
        WaterSubsurface,
		
        /// <summary>
        /// The capability of a device to move on the water surface.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("WATSUR")]
        [EnumMember]
        WaterSurface,
		
        /// <summary>
        /// The capability to move on or through ice.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("ARCTIC")]
        [EnumMember]
        Arctic,
		
        /// <summary>
        /// The characteristics, required for planning, of those CONTROL-FEATUREs, FACILITYs and MATERIELs or CONTROL-FEATURE-TYPEs, FACILITY-TYPEs and EQUIPMENT-TYPEs, and ORGANISATION-TYPEs that represents the standard system in which a route, bridge or raft is assigned class number(s) representing the load it can carry. Vehicles are also assigned number(s) indicating the minimum class of route, bridge or raft they are authorized to use.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MLC")]
        [EnumMember]
        MilitaryLoadClassification,
		
        /// <summary>
        /// The capability of a formation moving on a road.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("ROADMR")]
        [EnumMember]
        RoadMarch,
		
        /// <summary>
        /// The capability of a device to be brought into effective action by its own means.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SELFDP")]
        [EnumMember]
        SelfDeployable,
		
        /// <summary>
        /// The capability of a device to navigate in bays.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("WATBAY")]
        [EnumMember]
        WaterBay,
		
        /// <summary>
        /// The capability of a device to navigate canals.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("WATCNL")]
        [EnumMember]
        WaterCanal,
		
        /// <summary>
        /// The capability of a device to navigate in creeks.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WATCRK")]
        [EnumMember]
        WaterCreek,
		
        /// <summary>
        /// The capability of a device to navigate fjords.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("WATFJR")]
        [EnumMember]
        WaterFjord,
		
        /// <summary>
        /// The capability of a device to navigate lakes.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("WATLAK")]
        [EnumMember]
        WaterLake,
		
        /// <summary>
        /// The capability of a device to navigate non-tidal waters.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("WATNTD")]
        [EnumMember]
        WaterNontidal,
		
        /// <summary>
        /// The capability of a device to navigate rivers.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("WATRVR")]
        [EnumMember]
        WaterRiver,
		
        /// <summary>
        /// The capability of a device to navigate seas.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("WATSEA")]
        [EnumMember]
        WaterSea,
		
        /// <summary>
        /// The capability of a device to navigate swamps.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("WATSWM")]
        [EnumMember]
        WaterSwamp,
		
        /// <summary>
        /// The capability of a device to navigate tidal waters.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("WATTDL")]
        [EnumMember]
        WaterTidal,
		
    }
}
