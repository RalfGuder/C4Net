using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FACILITY-TYPE.
    /// </summary>
    [DomId(100000133)]
    [DataContract]
    public enum FacilityTypeCategoryEnum
    {
		
        /// <summary>
        /// An amount of living space distinct and separate. (Intended for humanitarian aid scenario to enable general indication of accommodation requirements).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACCOM")]
        [EnumMember]
        UnitOfAccommodation,
		
        /// <summary>
        /// A facility that carries out Electronic Warfare.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SITEEW")]
        [EnumMember]
        SiteElectronicWarfare,
		
        /// <summary>
        /// An accommodation based upon a number of tents or huts.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CAMP")]
        [EnumMember]
        Camp,
		
        /// <summary>
        /// A facility where personnel and/or materiel (incl. vehicles) can be cleaned after (potential) contamination of radioactive, biological, or chemical material.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DECONP")]
        [EnumMember]
        DecontaminationFacility,
		
        /// <summary>
        /// An area used for the storage of petroleum, oil and/or lubricants.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DEPPOL")]
        [EnumMember]
        DepotPol,
		
        /// <summary>
        /// A temporary facility that is organised, equipped, and deployed by an aviation commander and normally located in the main battle area closer to the area of operations than the aviation unit's combat service support (CSS) area. It provides fuel and ammunition necessary for the employment of aviation manoeuvre units in combat. It permits combat aircraft to rapidly refuel and rearm simultaneously.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("FARP")]
        [EnumMember]
        ForwardArmingAndRefuellingPoint,
		
        /// <summary>
        /// A facility for refuelling of POL products.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FHPT")]
        [EnumMember]
        FuelHandlingPoint,
		
        /// <summary>
        /// A facility for the storage, maintenance, research, or disposal of material.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SITLOG")]
        [EnumMember]
        SiteLogistic,
		
        /// <summary>
        /// A facility containing the resources and infrastructure to enable it to be used for the repair and servicing of equipment.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MAINTF")]
        [EnumMember]
        MaintenanceFacility,
		
        /// <summary>
        /// A facility from which military observations are made or fires directed and adjusted and which possesses appropriate communications; it may be airborne.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("OBSP")]
        [EnumMember]
        ObservationPost,
		
        /// <summary>
        /// A facility for the distribution of petroleum and associated products.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("POLPT")]
        [EnumMember]
        PolPoint,
		
        /// <summary>
        /// A facility containing radar that may be employed for the tracking and identification of battlespace objects.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SITRAD")]
        [EnumMember]
        SiteRadar,
		
        /// <summary>
        /// An installation on a railway where loads may be transferred between trains and other means of transport.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("RAIL")]
        [EnumMember]
        RailFacilities,
		
        /// <summary>
        /// An installation organised, equipped, and located for the purpose of extending the coverage of electronic communications and detection.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("RELAY")]
        [EnumMember]
        RelayFacility,
		
        /// <summary>
        /// A fortified chamber, mostly below ground, often built with reinforced concrete and provided with embrasures.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("BUNKER")]
        [EnumMember]
        Bunker,
		
        /// <summary>
        /// An area used for the storage of engineer equipment.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("DEPENG")]
        [EnumMember]
        DepotEngineer,
		
        /// <summary>
        /// A temporary storage area, usually in the open, for bombs, ammunition, equipment, or supplies.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SUPDMP")]
        [EnumMember]
        SupplyDump,
		
        /// <summary>
        /// Enables transfer of materiel from one mode of transportation to another or between the same modes of transportation.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("TRANSF")]
        [EnumMember]
        TransloadingFacility,
		
        /// <summary>
        /// An area used for the storage of nuclear weapons.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("DEPNUC")]
        [EnumMember]
        DepotNuclearStorage,
		
        /// <summary>
        /// A relatively permanent structure, roofed and usually walled and designed for some particular use.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("BLD")]
        [EnumMember]
        Building,
		
        /// <summary>
        /// A facility that is an area of land for burying the dead.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("CEM")]
        [EnumMember]
        CemeteryGraveyardBurialGround,
		
        /// <summary>
        /// A prepared position for one or more weapons or pieces of equipment for protection against hostile fire or bombardment, and from which they can execute their tasks.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("EMPLAC")]
        [EnumMember]
        Emplacement,
		
        /// <summary>
        /// A building in which communications signals are processed or controlled.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("COB")]
        [EnumMember]
        CommunicationsBuilding,
		
        /// <summary>
        /// A relatively tall structure used for transmitting and/or receiving electronic communications signals.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("COT")]
        [EnumMember]
        CommunicationsTower,
		
        /// <summary>
        /// A tower-like structure that houses the persons and equipment used to control the flow of air, rail, or marine traffic.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("CTT")]
        [EnumMember]
        ControlTower,
		
        /// <summary>
        /// A facility containing radar employed for air-defence purposes.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("SITADR")]
        [EnumMember]
        SiteAirDefenceRadar,
		
        /// <summary>
        /// An area used for the storage of products or supplies. A facility for the receipt, classification, storage, accounting, issue, maintenance, procurement, manufacture, assembly, research, salvage or disposal of material.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("DEPOT")]
        [EnumMember]
        DepotNotOtherwiseSpecified,
		
        /// <summary>
        /// A man-made barrier of relatively light structure used as an enclosure or boundary.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("FENCE")]
        [EnumMember]
        Fence,
		
        /// <summary>
        /// A barrier that controls passage to a road, railway, tunnel or bridge.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("GAT")]
        [EnumMember]
        Gate,
		
        /// <summary>
        /// An improved area used for takeoff, and landing, by helicopters and other vertical takeoff and landing aircraft.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("HPD")]
        [EnumMember]
        HelicopterLandingPad,
		
        /// <summary>
        /// A place designated for the landing and takeoff of helicopters, including its buildings and facilities.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("HPT")]
        [EnumMember]
        Heliport,
		
        /// <summary>
        /// A connection designed to provide traffic access from one road to another.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("JCT")]
        [EnumMember]
        InterchangeComplexJunction,
		
        /// <summary>
        /// An area with related facilities for storing and launching missiles.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("MSS")]
        [EnumMember]
        MissileSite,
		
        /// <summary>
        /// An open, broad way, often with shoulders and barriers, maintained for vehicular use.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("MWY")]
        [EnumMember]
        Motorway,
		
        /// <summary>
        /// A facility containing radar employed for ground surveillance purposes.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("SITGSR")]
        [EnumMember]
        SiteGroundSurveillanceRadar,
		
        /// <summary>
        /// An open way maintained for vehicular use.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("ROAD")]
        [EnumMember]
        Road,
		
        /// <summary>
        /// A rail or set of parallel rails on which a train or tram runs.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("RAILWY")]
        [EnumMember]
        Railway,
		
        /// <summary>
        /// A storage facility usually characterised by one or more open sides, support pillars and a roof.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("SHD")]
        [EnumMember]
        Shed,
		
        /// <summary>
        /// A stopping place for the transfer of passengers and/or freight.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("STN")]
        [EnumMember]
        StationGeneral,
		
        /// <summary>
        /// An embankment to provide shelter (as against bomb splinters or strafing).
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("REVETM")]
        [EnumMember]
        Revetment,
		
        /// <summary>
        /// A linear excavation dug for defensive purposes.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("TCH")]
        [EnumMember]
        Trench,
		
        /// <summary>
        /// An underground or underwater passage, open at both ends, and usually containing a road or railway.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("TUN")]
        [EnumMember]
        Tunnel,
		
        /// <summary>
        /// An open land area used for storing or parking vehicles or vessels. (Including Recreational Vehicles).
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("VST")]
        [EnumMember]
        VehicleStorageParkingArea,
		
        /// <summary>
        /// A fortified structure built on the surface, used to house personnel and/or equipment.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("SHLSUR")]
        [EnumMember]
        ShelterSurface,
		
        /// <summary>
        /// An elevated container and its supporting structure used to hold water.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("WTW")]
        [EnumMember]
        WaterTower,
		
        /// <summary>
        /// A fortified structure built underground, used to house personnel and/or equipment.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("SHLUND")]
        [EnumMember]
        ShelterUnderground,
		
        /// <summary>
        /// A facility containing equipment employed for locating artillery.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("SITART")]
        [EnumMember]
        SiteArtilleryLocating,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// An area used for the storage of chemicals.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("DEPCHM")]
        [EnumMember]
        DepotChemicals,
		
        /// <summary>
        /// An area used for the storage of ammunition.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("DEPMUN")]
        [EnumMember]
        DepotAmmunition,
		
        /// <summary>
        /// A continuous, vertical structure, such as a concrete or rock wall serving to enclose, divide, support or protect an area of land. Includes sea walls.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("WALL")]
        [EnumMember]
        Wall,
		
        /// <summary>
        /// A camp of semi-permanent nature established for the internment of prisoners of war (POW).
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("POWCMP")]
        [EnumMember]
        PowCamp,
		
        /// <summary>
        /// A facility where railway track crosses a highway or street, or where a river can be crossed.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("XRR")]
        [EnumMember]
        CrossingRailwayRiver,
		
        /// <summary>
        /// A facility for washing personnel and/or equipment.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("WSHFAC")]
        [EnumMember]
        WashingFacility,
		
        /// <summary>
        /// A facility that is a point where two or more line features intersect or cross at the same level.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("XLC")]
        [EnumMember]
        CrossingLevelCrossing,
		
        /// <summary>
        /// An area used for the storage of missile ammunition.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("DEPMIS")]
        [EnumMember]
        DepotMissileAmmunition,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A small simple or crude house or shelter.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("HUT")]
        [EnumMember]
        Hut,
		
        /// <summary>
        /// An area used for the storage of medical supplies.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("DEPMED")]
        [EnumMember]
        DepotMedical,
		
        /// <summary>
        /// A movable facility for the initial treatment of casualties.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("DRSTAT")]
        [EnumMember]
        DressingStation,
		
        /// <summary>
        /// A building or group of buildings used to house soldiers.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("BARRCK")]
        [EnumMember]
        Barracks,
		
        /// <summary>
        /// An artificial ridge or embankment.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("BERM")]
        [EnumMember]
        Berm,
		
        /// <summary>
        /// A facility whose essential function is based on the use of electronic equipment.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("ELCINS")]
        [EnumMember]
        ElectronicInstallation,
		
        /// <summary>
        /// A facility (including the terminals and the water craft) to enable moving equipment and personnel across a body of water.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("FERINS")]
        [EnumMember]
        FerryInstallation,
		
        /// <summary>
        /// A facility containing factories and/or productive installations.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("INDINS")]
        [EnumMember]
        IndustrialInstallation,
		
        /// <summary>
        /// A facility containing a concentration of buildings and other structures.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("BUA")]
        [EnumMember]
        BuiltUpArea,
		
        /// <summary>
        /// A man-made or improved natural waterway used for transportation.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("CAN")]
        [EnumMember]
        Canal,
		
        /// <summary>
        /// A vertical structure containing a passage or flue for discharging smoke and gases of combustion.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("CHM")]
        [EnumMember]
        ChimneySmokestack,
		
        /// <summary>
        /// A man-made clearing in a cultural area or through a stand of trees, designed to provide access for a road, railroad, pipeline or power transmission line, or to impede the progress of forest fires.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("CWY")]
        [EnumMember]
        ClearedWayFirebreak,
		
        /// <summary>
        /// An area that has been tilled for the planting of crops.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("CRP")]
        [EnumMember]
        Cropland,
		
        /// <summary>
        /// An excavation of the earth's surface to provide passage for a road, railway, canal, etc.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("CUT")]
        [EnumMember]
        Cut,
		
        /// <summary>
        /// A permanent barrier across a watercourse used to impound water or to control its flow.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("DAM")]
        [EnumMember]
        DamWeir,
		
        /// <summary>
        /// A channel constructed for the purpose of irrigation or drainage.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("DCH")]
        [EnumMember]
        Ditch,
		
        /// <summary>
        /// An area covered by systematic plantings of trees that yield fruits, nuts or other products.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("ORD")]
        [EnumMember]
        OrchardPlantation,
		
        /// <summary>
        /// A system of above ground wires including their supports, which transmit electricity over distance.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("PTL")]
        [EnumMember]
        PowerTransmissionLine,
		
        /// <summary>
        /// A man-made open enclosure or area formed for the storage of water.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("RES")]
        [EnumMember]
        Reservoir,
		
        /// <summary>
        /// A site or location where remains of ancient civilisations or human activity have been discovered.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("RUI")]
        [EnumMember]
        Ruins,
		
        /// <summary>
        /// In architecture, a steeply pointed pyramidal or conical structure usually attached to an ecclesiastical or public building.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("STP")]
        [EnumMember]
        SteepleSpire,
		
        /// <summary>
        /// A relatively tall structure which may be used for observation, support, or storage etc.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("TOW")]
        [EnumMember]
        TowerNonCommunications,
		
        /// <summary>
        /// A wind-driven system of vanes attached to a tower-like structure (excluding wind-generated power plants).
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("WML")]
        [EnumMember]
        Windmill,
		
        /// <summary>
        /// The debris left over from the demolition of an object.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("DMDBRS")]
        [EnumMember]
        DemolitionDebris,
		
        /// <summary>
        /// A decontamination facility designated as the alternate to the primary decontamination facility that can be used in place of the where personnel and/or materiel (incl. vehicles) can be cleaned after (potential) contamination of radioactive, biological, or chemical material.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("ALTDCN")]
        [EnumMember]
        AlternateDecontaminationFacility,
		
        /// <summary>
        /// A facility where casualties are assembled to be transported to a medical treatment facility for example a company aid post.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("CSCLPT")]
        [EnumMember]
        CasualtyCollectionPoint,
		
        /// <summary>
        /// A facility where civilians are assembled for classification, sorting or further movement to other facilities or installations.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("CVCLPT")]
        [EnumMember]
        CivilianCollectionPoint,
		
        /// <summary>
        /// A reinforced observation post capable of conducting limited combat operations.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("CBTPST")]
        [EnumMember]
        CombatOutpost,
		
        /// <summary>
        /// A facility where detainees are assembled for classification, sorting or further movement to other facilities or installations.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("DTCLPT")]
        [EnumMember]
        DetaineeCollectionPoint,
		
        /// <summary>
        /// A facility where detainees are provided custodial care pending further disposition.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("DTHARE")]
        [EnumMember]
        DetaineeHoldingArea,
		
        /// <summary>
        /// A fortified place garrisoned with troops.
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("FORT")]
        [EnumMember]
        Fort,
		
        /// <summary>
        /// A facility from which military observations are made or fires directed and adjusted by the occupants and which possesses appropriate communications; it may be airborne.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("FOBSPS")]
        [EnumMember]
        ForwardObserverPosition,
		
        /// <summary>
        /// The facility along the supply route where the supported unit meets the supporting unit to transfer supplies.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("LGRLPT")]
        [EnumMember]
        LogisticsReleasePoint,
		
        /// <summary>
        /// A facility established to collect equipment awaiting repair, controlled exchange, cannibalisation or evacuation. May be operated by the user or by intermediate maintenance units.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("MNTCPT")]
        [EnumMember]
        MaintenanceCollectionPoint,
		
        /// <summary>
        /// A facility from which chemical, biological, radiological, or nuclear observations are made and which possesses appropriate communications; it is dismounted.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("CBRNPS")]
        [EnumMember]
        NbcObservationPostDismounted,
		
        /// <summary>
        /// A facility where Prisoners of war are assembled for classification, sorting or further movement to other facilities or installations.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("POWCPT")]
        [EnumMember]
        PrisonerOfWarCollectionPoint,
		
        /// <summary>
        /// A facility where Prisoners of war are provided custodial care pending further disposition.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("POWARE")]
        [EnumMember]
        PrisonerOfWarHoldingArea,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("SITRFT")]
        [EnumMember]
        SiteRaft,
		
        /// <summary>
        /// A designated facility through which a unit passes where it receives fuel, ammunition, and other necessary supplies to continue combat operations.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("RRRSPT")]
        [EnumMember]
        RearmRefuelAndResupplyPoint,
		
        /// <summary>
        /// A facility where vehicles receive a prescribed (timed) amount of fuel and then continue their movement.
        /// </summary>
        [DomValIx(1000149)]
        [StringValue("ROMPT")]
        [EnumMember]
        RefuelOnTheMovePoint,
		
        /// <summary>
        /// A facility where refugees are assembled for classification, sorting or further movement to other facilities or installations.
        /// </summary>
        [DomValIx(1000150)]
        [StringValue("REFARE")]
        [EnumMember]
        RefugeeHoldingArea,
		
        /// <summary>
        /// A facility from which military observations are made or fires directed and adjusted and which possesses appropriate communications; it may be airborne. This is an unmanned Observation Post with electronic or other devices to detect activity within the sensors’ range.
        /// </summary>
        [DomValIx(1000151)]
        [StringValue("SENPST")]
        [EnumMember]
        SensorOutpostListeningPost,
		
        /// <summary>
        /// A facility in which combat services support (CSS) elements and some staff elements locate to support a unit.
        /// </summary>
        [DomValIx(1000152)]
        [StringValue("SPTARE")]
        [EnumMember]
        SupportArea,
		
        /// <summary>
        /// A facility at which traffic is controlled either by police or by mechanical means.
        /// </summary>
        [DomValIx(1000154)]
        [StringValue("TRFPST")]
        [EnumMember]
        TrafficControlPost,
		
        /// <summary>
        /// A facility at which ammunition, obtained from supporting supply points by a division or other unit, are broken down for distribution to other units.
        /// </summary>
        [DomValIx(1000165)]
        [StringValue("ASP")]
        [EnumMember]
        AmmunitionSupplyPoint,
		
        /// <summary>
        /// A facility for physical transfer of ammunition from one means of transport to another or to the final receiving unit.
        /// </summary>
        [DomValIx(1000166)]
        [StringValue("ATP")]
        [EnumMember]
        AmmunitionTransferPoint,
		
        /// <summary>
        /// A town or place possessing a harbour where vessels load and unload, or begin or end their voyage.
        /// </summary>
        [DomValIx(1000168)]
        [StringValue("PORT")]
        [EnumMember]
        Port,
		
        /// <summary>
        /// A grouping of facilities, located in the same vicinity, which support particular functions. Installations may be elements of a base.
        /// </summary>
        [DomValIx(1000169)]
        [StringValue("INSTAL")]
        [EnumMember]
        Installation,
		
        /// <summary>
        /// An area used for the storage of chemical, biological, radiological, or nuclear materiel.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("DPCBRN")]
        [EnumMember]
        DepotNbc,
		
        /// <summary>
        /// An area used for the storage of biological agents.
        /// </summary>
        [DomValIx(1000171)]
        [StringValue("DEPBIO")]
        [EnumMember]
        DepotBiological,
		
        /// <summary>
        /// A facility generally used to support a particular method of operation in any manufacture or to support a series of actions or events.
        /// </summary>
        [DomValIx(1000172)]
        [StringValue("FACPRO")]
        [EnumMember]
        ProcessingFacility,
		
        /// <summary>
        /// A facility generally used specifically to support the manufacture of equipment.
        /// </summary>
        [DomValIx(1000173)]
        [StringValue("EQIMFT")]
        [EnumMember]
        EquipmentManufacture,
		
        /// <summary>
        /// A facility generally used to support service, research or utility functions.
        /// </summary>
        [DomValIx(1000174)]
        [StringValue("FACSRU")]
        [EnumMember]
        ServiceResearchUtilityFacility,
		
        /// <summary>
        /// A facility generally used to support service, research or utility functions in support of technological research.
        /// </summary>
        [DomValIx(1000175)]
        [StringValue("FACTEC")]
        [EnumMember]
        ServiceResearchUtilityFacilityTechnologicalResearchFacility,
		
        /// <summary>
        /// A facility generally used to support service, research or utility functions in support of telecommunications.
        /// </summary>
        [DomValIx(1000176)]
        [StringValue("FACTEL")]
        [EnumMember]
        ServiceResearchUtilityFacilityTelecommunicationsFacility,
		
        /// <summary>
        /// A facility generally used to support service, research or utility functions in support of electric power.
        /// </summary>
        [DomValIx(1000177)]
        [StringValue("FACPOW")]
        [EnumMember]
        ServiceResearchUtilityFacilityElectricPowerFacility,
		
        /// <summary>
        /// A facility generally used to support service, research or utility functions in support of public water services.
        /// </summary>
        [DomValIx(1000178)]
        [StringValue("FACWAT")]
        [EnumMember]
        ServiceResearchUtilityFacilityPublicWaterService,
		
        /// <summary>
        /// A facility used as an atomic energy reactor.
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("FACATR")]
        [EnumMember]
        MilitaryMaterielFacilityAtomicEnergyReactor,
		
        /// <summary>
        /// A facility used as for aircraft production and assembly.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("FACARP")]
        [EnumMember]
        MilitaryMaterielFacilityAircraftProductionAndAssembly,
		
        /// <summary>
        /// A facility used as for munitions and explosives production.
        /// </summary>
        [DomValIx(1000181)]
        [StringValue("FACAMM")]
        [EnumMember]
        MilitaryMaterielFacilityAmmunitionAndExplosivesProduction,
		
        /// <summary>
        /// A facility used as for armament production.
        /// </summary>
        [DomValIx(1000182)]
        [StringValue("FACARM")]
        [EnumMember]
        MilitaryMaterielFacilityArmamentProduction,
		
        /// <summary>
        /// A facility used as for vehicle production.
        /// </summary>
        [DomValIx(1000183)]
        [StringValue("FACVEH")]
        [EnumMember]
        MilitaryMaterielFacilityVehicleProduction,
		
        /// <summary>
        /// A facility used as for engineering equipment production.
        /// </summary>
        [DomValIx(1000184)]
        [StringValue("FACENG")]
        [EnumMember]
        MilitaryMaterielFacilityEngineeringEquipmentProduction,
		
        /// <summary>
        /// A facility used as for engineering equipment production, bridge.
        /// </summary>
        [DomValIx(1000185)]
        [StringValue("FACBRG")]
        [EnumMember]
        MilitaryMaterielFacilityEngineeringEquipmentProductionBridge,
		
        /// <summary>
        /// A facility used as for chemical and biological warfare production.
        /// </summary>
        [DomValIx(1000186)]
        [StringValue("FACCHB")]
        [EnumMember]
        MilitaryMaterielFacilityChemicalAndBiologicalWarfareProduction,
		
        /// <summary>
        /// A facility used as for ship construction.
        /// </summary>
        [DomValIx(1000187)]
        [StringValue("FACSHP")]
        [EnumMember]
        MilitaryMaterielFacilityShipConstruction,
		
        /// <summary>
        /// A facility used as for missile and space system production.
        /// </summary>
        [DomValIx(1000188)]
        [StringValue("FACMSL")]
        [EnumMember]
        MilitaryMaterielFacilityMissileAndSpaceSystemProduction,
		
        /// <summary>
        /// A facility used to support governmental leadership functions.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("FACGOV")]
        [EnumMember]
        GovernmentalLeadership,
		
        /// <summary>
        /// A facility that is used as a military base.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("FACMIL")]
        [EnumMember]
        MilitaryBaseFacility,
		
        /// <summary>
        /// A facility that is used as a military base prepared for the accommodation, landing and takeoff of aircraft.
        /// </summary>
        [DomValIx(1000191)]
        [StringValue("FACAIR")]
        [EnumMember]
        MilitaryBaseFacilityAirportAirbase,
		
        /// <summary>
        /// A facility that is used as a naval base and where ships may receive or discharge their cargoes.
        /// </summary>
        [DomValIx(1000192)]
        [StringValue("FACNAV")]
        [EnumMember]
        MilitaryBaseFacilitySeaportNavalBase,
		
        /// <summary>
        /// A facility that is used to support transport functions.
        /// </summary>
        [DomValIx(1000193)]
        [StringValue("FACTRN")]
        [EnumMember]
        TransportFacility,
		
        /// <summary>
        /// A fixed medical treatment facility capable of providing inpatient care.
        /// </summary>
        [DomValIx(1000194)]
        [StringValue("HSP")]
        [EnumMember]
        MedicalFacilityHospital,
		
        /// <summary>
        /// A movable medical treatment facility capable of providing inpatient care.
        /// </summary>
        [DomValIx(1000195)]
        [StringValue("HSPFLD")]
        [EnumMember]
        MedicalFacilityHospitalField,
		
        /// <summary>
        /// A facility established for the purpose of furnishing medical and/or dental care to eligible individuals.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("HSPNOS")]
        [EnumMember]
        MedicalFacilityHospitalNotOtherwiseSpecified,
		
        /// <summary>
        /// Unusable or unwanted material, which may include hazardous materiel.
        /// </summary>
        [DomValIx(1000197)]
        [StringValue("WSTPLE")]
        [EnumMember]
        WastePile,
		
        /// <summary>
        /// A FACILITY-TYPE used for the burial of multiple bodies.
        /// </summary>
        [DomValIx(1000198)]
        [StringValue("MSSGRV")]
        [EnumMember]
        MassGrave,
		
        /// <summary>
        /// A facility containing the equipment used for the storage and/or distribution of water.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("WATSPL")]
        [EnumMember]
        WaterSupply,
		
        /// <summary>
        /// A facility used for personal cleanliness.
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("BATH")]
        [EnumMember]
        Bath,
		
        /// <summary>
        /// A facility used for emptying of liquid and channelling sewage to get rid of waste, dirty water and drain water.
        /// </summary>
        [DomValIx(1000201)]
        [StringValue("DRNSEW")]
        [EnumMember]
        DrainageSewage,
		
        /// <summary>
        /// A facility containing the equipment used for the production and/or distribution of electricity.
        /// </summary>
        [DomValIx(1000202)]
        [StringValue("ELCSPL")]
        [EnumMember]
        ElectricalSupply,
		
        /// <summary>
        /// A facility that hosts medical personnel who carry out treatment of sick or wounded persons.
        /// </summary>
        [DomValIx(1000203)]
        [StringValue("MEDSPT")]
        [EnumMember]
        MedicalSupport,
		
        /// <summary>
        /// An establishment where money is stored for saving or commercial purposes.
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("BANK")]
        [EnumMember]
        Bank,
		
        /// <summary>
        /// Land devoted to agricultural production, raising and breeding of animals or an area of water devoted to the raising and breeding of aquatic animals.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("FARM")]
        [EnumMember]
        Farm,
		
        /// <summary>
        /// A detached household used as a dwelling for one or more persons.
        /// </summary>
        [DomValIx(1000206)]
        [StringValue("HOUSE")]
        [EnumMember]
        House,
		
        /// <summary>
        /// A place in which business, professional or clerical activities are conducted.
        /// </summary>
        [DomValIx(1000207)]
        [StringValue("OFFICE")]
        [EnumMember]
        Office,
		
        /// <summary>
        /// A small retail store or a speciality department in a large store.
        /// </summary>
        [DomValIx(1000208)]
        [StringValue("SHOP")]
        [EnumMember]
        Shop,
		
        /// <summary>
        /// A facility containing fuel containers, pipe work and dispensing equipment connected together to form a temporary fuel installation within a tactical field location.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("BFIFLD")]
        [EnumMember]
        BulkFuelInstallationField,
		
        /// <summary>
        /// A facility with a group of field storage sites containing a max of 5000 tonnes gross weight of ammunition and explosives.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("FSAAMM")]
        [EnumMember]
        FieldStorageAreaAmmunition,
		
        /// <summary>
        /// A facility that is a site containing approximately 10 tonnes gross weight of ammunition and explosives.
        /// </summary>
        [DomValIx(1000211)]
        [StringValue("FSMAMM")]
        [EnumMember]
        FieldStorageModuleAmmunition,
		
        /// <summary>
        /// A facility with a group of field storage modules containing a max of 200 tonnes gross weight of ammunition and explosives.
        /// </summary>
        [DomValIx(1000212)]
        [StringValue("FSSAMM")]
        [EnumMember]
        FieldStorageSiteAmmunition,
		
        /// <summary>
        /// A facility where approximately 1 tonne gross weight of ammunition and explosives stored under tactical field conditions.
        /// </summary>
        [DomValIx(1000213)]
        [StringValue("FSSTAM")]
        [EnumMember]
        FieldStorageStackAmmunition,
		
        /// <summary>
        /// The point on a railway from which branch-line or road transport of supplies begins.
        /// </summary>
        [DomValIx(1000214)]
        [StringValue("RAILHD")]
        [EnumMember]
        Railhead,
		
        /// <summary>
        /// A FACILITY-TYPE that is a class of structures (including overpasses and viaducts), fixed or moveable, spanning and/or providing passage over an object.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("BRGTYP")]
        [EnumMember]
        BridgeType,
		
        /// <summary>
        /// A facility that is used as a basis for military bridging.
        /// </summary>
        [DomValIx(1000216)]
        [StringValue("SITMLB")]
        [EnumMember]
        SiteMilitaryBridging,
		
        /// <summary>
        /// A FACILITY-TYPE that provides communication and information services.
        /// </summary>
        [DomValIx(1000217)]
        [StringValue("NETWRK")]
        [EnumMember]
        Network,
		
        /// <summary>
        /// A covered space, shed or shelter for the accommodation of aircraft or spacecraft.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("HANGAR")]
        [EnumMember]
        Hangar,
		
        /// <summary>
        /// A facility where police check vehicular or pedestrian traffic in order to enforce circulation control measures and other laws, orders, and regulations.
        /// </summary>
        [DomValIx(1000219)]
        [StringValue("CKPPOL")]
        [EnumMember]
        CheckPointPolice,
		
        /// <summary>
        /// A facility where supply services are provided.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("SUPPT")]
        [EnumMember]
        SupplyPoint,
		
        /// <summary>
        /// A facility used as a medical facility.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("MF")]
        [EnumMember]
        MedicalFacility,
		
        /// <summary>
        /// A facility used as a first level care medical facility for a unit.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("MFUMS")]
        [EnumMember]
        MedicalFacilityUnitMedicalStation,
		
        /// <summary>
        /// An emplacement or shelter of a temporary or permanent nature constructed for defence by forces for protection of forces.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("FRTFCN")]
        [EnumMember]
        Fortification,
		
        /// <summary>
        /// An ecclesiastical facility established for the purpose of worship and prayer.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("RELFAC")]
        [EnumMember]
        ReligiousFacility,
		
        /// <summary>
        /// A building housing fire-fighters and their equipment.
        /// </summary>
        [DomValIx(1000227)]
        [StringValue("FFBRKS")]
        [EnumMember]
        FireFightersBarracks,
		
        /// <summary>
        /// A building for the administration of local, regional, or national government.
        /// </summary>
        [DomValIx(1000228)]
        [StringValue("GVTBLD")]
        [EnumMember]
        GovernmentBuilding,
		
        /// <summary>
        /// A facility where materials are extracted from the ground.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("MINE")]
        [EnumMember]
        Mine,
		
        /// <summary>
        /// A facility where materials are extracted from the ground directly, without using tunnels.
        /// </summary>
        [DomValIx(1000230)]
        [StringValue("MNINOS")]
        [EnumMember]
        MiningInstallationOpenSky,
		
        /// <summary>
        /// A facility where materials are extracted from the ground using underground tunnels and shafts.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("MNINUG")]
        [EnumMember]
        MiningInstallationUnderground,
		
        /// <summary>
        /// A facility where materials are extracted from the bottom of a lake, river or sea.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("MNINUW")]
        [EnumMember]
        MiningInstallationUnderwater,
		
        /// <summary>
        /// The office of a local police force.
        /// </summary>
        [DomValIx(1000233)]
        [StringValue("POLSTA")]
        [EnumMember]
        PoliceStation,
		
        /// <summary>
        /// A building for the administration of local government, having public meeting rooms, etc.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("TWNHAL")]
        [EnumMember]
        TownHall,
		
        /// <summary>
        /// A developed area, constituting, forming, or including a city, town, or burgh, or part of such.
        /// </summary>
        [DomValIx(1000239)]
        [StringValue("URBANA")]
        [EnumMember]
        UrbanArea,
		
        /// <summary>
        /// A building or open space where people assemble for religious purpose.
        /// </summary>
        [DomValIx(1000240)]
        [StringValue("WRSHPL")]
        [EnumMember]
        WorshipPlace,
		
        /// <summary>
        /// A FACILITY-TYPE that is a class of man-made devices or passive defence works that are designed to stop, impede, or divert movement of amphibious or ground forces.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("MILOBS")]
        [EnumMember]
        MilitaryObstacleType,
		
        /// <summary>
        /// A facility that supports the study of or the science of, the motions and phenomena of the atmosphere, with a view to forecasting the weather.
        /// </summary>
        [DomValIx(1000242)]
        [StringValue("METFAC")]
        [EnumMember]
        MeteorologicalFacility,
		
        /// <summary>
        /// A system of pipes above or under ground including their supports, which transports liquids or gas over distance.
        /// </summary>
        [DomValIx(1000243)]
        [StringValue("PIPLIN")]
        [EnumMember]
        Pipeline,
		
        /// <summary>
        /// A facility that supports the movement of gases or liquids.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("PMPSTN")]
        [EnumMember]
        PumpingStation,
		
        /// <summary>
        /// A facility used for the handling and treatment of sewage.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("SWGFAC")]
        [EnumMember]
        SewageTreatmentFacility,
		
        /// <summary>
        /// A facility used for the handling and treatment of water.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("WTRFAC")]
        [EnumMember]
        WaterTreatmentFacility,
		
        /// <summary>
        /// A FACILITY-TYPE that is a restricted body of water, an anchorage, or other limited coastal water area and its water approaches from which and in which shipping operations are projected or supported.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("HARBOR")]
        [EnumMember]
        HarbourType,
		
        /// <summary>
        /// A facility from which a commander directs operations or controls forces.
        /// </summary>
        [DomValIx(1000248)]
        [StringValue("CP")]
        [EnumMember]
        CommandPostFacility,
		
        /// <summary>
        /// A facility from which administrative and/or command functions are performed.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("HQ")]
        [EnumMember]
        HeadquartersFacility,
		
        /// <summary>
        /// A residential unit consisting of a block of flats.
        /// </summary>
        [DomValIx(1000250)]
        [StringValue("APRTBD")]
        [EnumMember]
        ApartmentBuilding,
		
        /// <summary>
        /// A large town. In most cases a town created a city by charter.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("CITY")]
        [EnumMember]
        City,
		
        /// <summary>
        /// A small village, especially one without a church.
        /// </summary>
        [DomValIx(1000252)]
        [StringValue("HAMLET")]
        [EnumMember]
        Hamlet,
		
        /// <summary>
        /// Facilities of a type that represent individual houses sharing at least one wall.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("ROWHSE")]
        [EnumMember]
        RowHouse,
		
        /// <summary>
        /// An urban area with a name, defined boundaries and local government, being larger than a village and generally smaller than a city.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("TOWN")]
        [EnumMember]
        Town,
		
        /// <summary>
        /// A group of houses and associated buildings, larger than a hamlet and smaller than a town, especially in a rural area.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("VLLAGE")]
        [EnumMember]
        Village,
		
        /// <summary>
        /// A facility for the receipt, classification, storage, accounting, issue, maintenance, procurement, manufacture, assembly, research, salvage or disposal of material.
        /// </summary>
        [DomValIx(1000256)]
        [StringValue("WAREHS")]
        [EnumMember]
        Warehouse,
		
        /// <summary>
        /// A FACILITY-TYPE that is a place where vessels anchor.
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("ANCHOR")]
        [EnumMember]
        Anchorage,
		
        /// <summary>
        /// A FACILITY-TYPE that is an open area of water, usually artificial and enclosed by dock gates lined with wharves, warehouses and berths to enable vessels to load and unload.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("BASIN")]
        [EnumMember]
        Basin,
		
        /// <summary>
        /// A FACILITY-TYPE that is a space or length in the water at a harbour allocated to or reserved for a vessel to dock and moor for loading or unloading.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("BERTH")]
        [EnumMember]
        Berth,
		
        /// <summary>
        /// A FACILITY-TYPE that provides an enclosure for maintenance, building or repairing ships, from which water can be pumped out.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("DRYDCK")]
        [EnumMember]
        DryDock,
		
        /// <summary>
        /// A FACILITY-TYPE that is a platform that may be fixed or floating extending from a shore, normally attached to a wharf or the shore, and which allows access to a vessel lying alongside, used to secure, protect and provide landing and docking for vessels.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("JETTY")]
        [EnumMember]
        Jetty,
		
        /// <summary>
        /// A FACILITY-TYPE that is a solidly constructed platform, usually parallel to the shoreline of navigable water, alongside which a vessel can be docked or berthed and, on which, the vessel can be accessed and cargo can be loaded or unloaded on one side of the vessel only.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("QUAY")]
        [EnumMember]
        Quay,
		
        /// <summary>
        /// A FACILITY-TYPE that provides a sloping surface or inclined structure leading down to the water.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("SLPWAY")]
        [EnumMember]
        Slipway,
		
        /// <summary>
        /// A temporary encampment, under canvas, of troops in the field.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("BIVOUC")]
        [EnumMember]
        Bivouac,
		
        /// <summary>
        /// A confined section of a canal or river where the level can be changed for raising and lowering boats between adjacent sections by the use of gates and sluices.
        /// </summary>
        [DomValIx(1000265)]
        [StringValue("CHPLCK")]
        [EnumMember]
        ChannelPassLock,
		
        /// <summary>
        /// A facility whose essential function is jamming to prevent or reduce the enemy's effective use of the electromagnetic spectrum for surface surveillance.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("ELISSJ")]
        [EnumMember]
        ElectronicInstallationSurfaceSurveillanceJammer,
		
        /// <summary>
        /// A cover usually intended for protecting radar from the effects of its physical environment without degrading significantly its electrical performance.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("ELIRDD")]
        [EnumMember]
        ElectronicInstallationRadarDome,
		
        /// <summary>
        /// A facility whose essential function is to exploit the electromagnetic spectrum encompassing: the search for, interception and identification of electromagnetic emissions, the employment of electromagnetic energy, including directed energy, to reduce or prevent hostile use of the electromagnetic spectrum, and actions to ensure its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000268)]
        [StringValue("ELIWAR")]
        [EnumMember]
        ElectronicInstallationWarfare,
		
        /// <summary>
        /// A shallow place in a river or other water marked with a concrete-lined bed that can be crossed without bridging, boats, or rafts.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("FCRLBD")]
        [EnumMember]
        FordConcreteLinedBed,
		
        /// <summary>
        /// A shallow place in a river or other water marked with a stone-lined bed that can be crossed without bridging, boats, or rafts.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("FCRSLB")]
        [EnumMember]
        FordStoneLinedBed,
		
        /// <summary>
        /// A facility processing 'goods' in transit or being transferred from one transportation means to another.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("FRGTER")]
        [EnumMember]
        FreightTerminal,
		
        /// <summary>
        /// Installations for processing and purification of natural gas or separating natural gas from crude oil.
        /// </summary>
        [DomValIx(1000272)]
        [StringValue("GASPFA")]
        [EnumMember]
        GasProcessingFacility,
		
        /// <summary>
        /// A tower or other structure, with a powerful light or lights at the top, erected at some important or dangerous point on or near the seacoast for the guidance of mariners.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("LGTHSE")]
        [EnumMember]
        Lighthouse,
		
        /// <summary>
        /// A facility constructed for loading goods/equipment.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("LOADPL")]
        [EnumMember]
        LoadingPlatform,
		
        /// <summary>
        /// A facility constructed for loading military goods/equipment.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("LOADPM")]
        [EnumMember]
        LoadingPlatformMilitary,
		
        /// <summary>
        /// A facility containing the resources and infrastructure to enable it to be used for the repair and servicing of aircraft.
        /// </summary>
        [DomValIx(1000276)]
        [StringValue("MTFAIR")]
        [EnumMember]
        MaintenanceFacilityAircraft,
		
        /// <summary>
        /// A facility containing the resources and infrastructure to enable it to be used for the repair and servicing of armour/artillery equipment.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("MTFAAR")]
        [EnumMember]
        MaintenanceFacilityArmourArtillery,
		
        /// <summary>
        /// A facility containing the resources and infrastructure to enable it to be used for the repair and servicing of motor vehicles.
        /// </summary>
        [DomValIx(1000278)]
        [StringValue("MTFMVH")]
        [EnumMember]
        MaintenanceFacilityMotorVehicle,
		
        /// <summary>
        /// A facility that is used as a naval base and where submarines may receive or discharge their cargoes or receive maintenance.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("MBFSUB")]
        [EnumMember]
        MilitaryBaseFacilitySubmarine,
		
        /// <summary>
        /// A facility that could be used for munitions and explosives production or storage.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("MNCPLX")]
        [EnumMember]
        MunitionsComplex,
		
        /// <summary>
        /// An installation with associated buildings capable of handling civilian or military nuclear material.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("NCLFAC")]
        [EnumMember]
        NuclearFacility,
		
        /// <summary>
        /// A facility that provides transportation services for passengers.
        /// </summary>
        [DomValIx(1000282)]
        [StringValue("PASTRM")]
        [EnumMember]
        PassengerTerminal,
		
        /// <summary>
        /// Installations for refining crude oil and/or intermediate petroleum products or for refining synthetic petroleum.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("PCHREF")]
        [EnumMember]
        PetrochemicalRefinery,
		
        /// <summary>
        /// A solid structure of stone, or of earth faced with piles, extending into the sea or a tidal river to protect or partially enclose a harbour and form a landing place for vessels, or a breakwater.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("PIER")]
        [EnumMember]
        Pier,
		
        /// <summary>
        /// A facility that provides power produced from fossil fuels.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("PWPLFF")]
        [EnumMember]
        PowerPlantFossilFuel,
		
        /// <summary>
        /// A facility that provides power produced from hydroelectric processes.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("PWPLHL")]
        [EnumMember]
        PowerPlantHydroelectric,
		
        /// <summary>
        /// A facility that provides power produced from nuclear energy.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("PWPLNC")]
        [EnumMember]
        PowerPlantNuclear,
		
        /// <summary>
        /// A facility that provides power produced from thermal processes.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("PWPLTH")]
        [EnumMember]
        PowerPlantThermal,
		
        /// <summary>
        /// A facility used for petroleum based products production.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("PRCXPT")]
        [EnumMember]
        ProductionComplexPetroleum,
		
        /// <summary>
        /// An installation on a railway where railway equipment may be repaired.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("RFAREP")]
        [EnumMember]
        RailFacilityRepair,
		
        /// <summary>
        /// A predefined place at which a railway may be crossed at the same level by a road.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("RWCRSS")]
        [EnumMember]
        RailwayCrossing,
		
        /// <summary>
        /// A site where two or more railway tracks join or form a connection.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("RWJNCT")]
        [EnumMember]
        RailwayJunction,
		
        /// <summary>
        /// A facility whose essential function is instruction and education.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("SCHOOL")]
        [EnumMember]
        School,
		
        /// <summary>
        /// A large enclosure, adjoining the sea or a river, in which ships are built, repaired or maintained.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("SHYARD")]
        [EnumMember]
        Shipyard,
		
        /// <summary>
        /// A facility containing radar employed for navigation purposes.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("SNVRDR")]
        [EnumMember]
        SiteNavigationRadar,
		
        /// <summary>
        /// An installation dedicated to the storage and launch of surface-to-surface missiles.
        /// </summary>
        [DomValIx(1000296)]
        [StringValue("STSSML")]
        [EnumMember]
        SiteSurfaceToSurfaceMissile,
		
        /// <summary>
        /// A relatively tall structure mounted with an anti-aircraft gun.
        /// </summary>
        [DomValIx(1000297)]
        [StringValue("TWFLAK")]
        [EnumMember]
        TowerFlak,
		
        /// <summary>
        /// A relatively tall structure mounted with a television transmitter.
        /// </summary>
        [DomValIx(1000298)]
        [StringValue("TWTLTM")]
        [EnumMember]
        TowerTelevisionTransmitter,
		
        /// <summary>
        /// A beaten path, especially through a wild region.
        /// </summary>
        [DomValIx(1000299)]
        [StringValue("TRAIL")]
        [EnumMember]
        Trail,
		
        /// <summary>
        /// A site where two or more roads join or form a connection.
        /// </summary>
        [DomValIx(1000301)]
        [StringValue("RDJNCT")]
        [EnumMember]
        RoadJunction,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("CLSFAC")]
        [EnumMember]
        ClassificationFacility,
		
        /// <summary>
        /// A hole in the ground used by a soldier for protection.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("FOXHOL")]
        [EnumMember]
        Foxhole,
		
        /// <summary>
        /// A building or set of integrated buildings that use state-of-the-art-technology designed for a specific purpose such as manufacturing, research and development or other related activity.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("HGHTCH")]
        [EnumMember]
        HighTechnologyComplex,
		
        /// <summary>
        /// A facility, at the tactical level, used by intelligence personnel for intelligence operations.
        /// </summary>
        [DomValIx(1000305)]
        [StringValue("INTCTR")]
        [EnumMember]
        IntelligenceCentreTactical,
		
        /// <summary>
        /// A position from which military observations are made, or fire directed and adjusted, and which possesses appropriate communications.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("OBSTWR")]
        [EnumMember]
        ObservationTower,
		
        /// <summary>
        /// A coordinated series of obstacles designed or employed to detect, channel, direct, restrict, delay or stop the movement of personnel.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("PERSBR")]
        [EnumMember]
        PersonnelBarrier,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("IMPBED")]
        [EnumMember]
        ImprovedBedTypeUnknown,
		
        /// <summary>
        /// A facility at which civilian-military coordination operations are performed.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("CIMICC")]
        [EnumMember]
        CivilianMilitaryCoordinationCentre,
		
        /// <summary>
        /// A facility on the ground that has an electromagnetic link to an airborne early warning system.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("AEWGRD")]
        [EnumMember]
        AirborneEarlyWarningGroundFacility,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000311)]
        [StringValue("RDRHD")]
        [EnumMember]
        RadarHead,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("RDRPST")]
        [EnumMember]
        RadarPost,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("SNSRFP")]
        [EnumMember]
        SensorFusionPost,
		
        /// <summary>
        /// A facility that is used as a military base by the army.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("FACAR")]
        [EnumMember]
        MilitaryBaseFacilityArmy,
		
        /// <summary>
        /// A facility used for non-directional radio transmissions.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("OMNIST")]
        [EnumMember]
        OmnirangeStation,
		
        /// <summary>
        /// A facility used for aircraft production.
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("PRCXAC")]
        [EnumMember]
        ProductionComplexAircraft,
		
        /// <summary>
        /// A facility used for production of chemicals.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("PRCXCH")]
        [EnumMember]
        ProductionComplexChemical,
		
        /// <summary>
        /// A facility used for production of guided missiles.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("PRCXGM")]
        [EnumMember]
        ProductionComplexGuidedMissile,
		
        /// <summary>
        /// A facility used in short range navigation.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("SHORAN")]
        [EnumMember]
        ShoranStation,
		
        /// <summary>
        /// A temporary storage area, usually in the open, for ammunition.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("SUPDAM")]
        [EnumMember]
        SupplyDumpAmmunition,
		
        /// <summary>
        /// A facility used in a global tactical air navigation system.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("TACAN")]
        [EnumMember]
        TacanStation,
		
        /// <summary>
        /// A Naval facility that is used by and provides services for naval or other aviation units or organisations.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("NAVAST")]
        [EnumMember]
        NavalAirStation,
		
        /// <summary>
        /// A FACILITY-TYPE that is a class of an area prepared for the accommodation (including any buildings, installations, or equipment) of landing and take off of aircraft.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("AIRFLD")]
        [EnumMember]
        AirfieldType,
		
        /// <summary>
        /// A FACILITY-TYPE that is an area intended for parking, loading, unloading and/or servicing.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("APRON")]
        [EnumMember]
        Apron,
		
        /// <summary>
        /// A facility used for non-military motor vehicle production and assembly.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("PRCXMV")]
        [EnumMember]
        ProductionComplexGeneralMotorVehicle,
		
        /// <summary>
        /// A structure generally created for commemorative purposes.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("MONUM")]
        [EnumMember]
        Monument,
		
        /// <summary>
        /// A place for concealment and safekeeping.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("CACHE")]
        [EnumMember]
        Cache,
		
        /// <summary>
        /// A cluster of structures having a shared purpose, usually inside a fence or wall.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("COMPND")]
        [EnumMember]
        Compound,
		
        /// <summary>
        /// An area that is recognised (for example: designated as World Heritage Site) because of its cultural (for example: historical) importance.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("CULTRL")]
        [EnumMember]
        CulturalSite,
		
        /// <summary>
        /// An enclosed channel for carrying a watercourse (for example: a stream, a sewer, or a drain) under a route (for example: a road, a railway, or an embankment).
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("CULVRT")]
        [EnumMember]
        Culvert,
		
        /// <summary>
        /// A man-made raised long mound of earth or other material.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("EMBNKM")]
        [EnumMember]
        Embankment,
		
        /// <summary>
        /// A base used to support tactical operations without establishing full support facilities which may be used for an extended time period.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("FOB")]
        [EnumMember]
        ForwardOperatingBase,
		
        /// <summary>
        /// A building, either private or public, used for parking and/or storing vehicles.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("GARAGE")]
        [EnumMember]
        Garage,
		
        /// <summary>
        /// A site containing one or more historical structures or terrain.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("HISTST")]
        [EnumMember]
        HistoricSite,
		
        /// <summary>
        /// A facility where commercial activity is conducted and goods and services are bought and sold.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("MARKET")]
        [EnumMember]
        Market,
		
    }
}
