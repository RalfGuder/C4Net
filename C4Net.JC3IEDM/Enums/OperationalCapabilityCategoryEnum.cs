using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies a particular OPERATIONAL-CAPABILITY.
    /// </summary>
    [DomId(100004362)]
    [DataContract]
    public enum OperationalCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The capability to perform a mission involving total integration of helicopter assets in their ground or air roles.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARASLT")]
        [EnumMember]
        AirAssault,
		
        /// <summary>
        /// The capability to carry out operations, either by paradrop or air landing, following an air movement.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRBRN")]
        [EnumMember]
        Airborne,
		
        /// <summary>
        /// The capability to conduct an operation launched from the sea by military forces against a hostile or potentially hostile shore.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AMPH")]
        [EnumMember]
        Amphibious,
		
        /// <summary>
        /// The capability to perform a mission involving an arctic operation.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARC")]
        [EnumMember]
        Arctic,
		
        /// <summary>
        /// The capability to calculate the coordinates and the altitude of an object/point and from which the bearings/azimuths to a number of reference objects are also known.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARTYSV")]
        [EnumMember]
        ArtillerySurvey,
		
        /// <summary>
        /// The capability to perform an offensive mission.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ATTACK")]
        [EnumMember]
        Attack,
		
        /// <summary>
        /// The capability to exercise the authority, responsibilities and activities of military commanders in direction and co-ordination or military forces and the implementation of orders related to the execution of operations.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("C2")]
        [EnumMember]
        C2,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CTRINT")]
        [EnumMember]
        CentralIntelligence,
		
        /// <summary>
        /// The capability to conduct civilian law enforcement operations.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CIVLWE")]
        [EnumMember]
        CivilianLawEnforcement,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CMDOPS")]
        [EnumMember]
        CommandOperations,
		
        /// <summary>
        /// The capability to conduct activities that are concerned with identifying and counteracting the threat to security posed by hostile intelligence services or organisations, or by individuals engaged in espionage, sabotage, subversion or terrorism.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CNTRIN")]
        [EnumMember]
        CounterIntelligence,
		
        /// <summary>
        /// The capability to establish target distance electronically.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ELCRNG")]
        [EnumMember]
        ElectronicRanging,
		
        /// <summary>
        /// The capability for obtaining bearings of radio frequency emitters by using a directional antenna and a display unit on an intercept receiver or ancillary equipment.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("EWDF")]
        [EnumMember]
        ElectronicWarfareDirectionFinding,
		
        /// <summary>
        /// The capability to intercept intentional or unintentional radiated electromagnetic energy for the purpose of immediate threat recognition.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("EWINTC")]
        [EnumMember]
        ElectronicWarfareIntercept,
		
        /// <summary>
        /// The capability to deliver radiation, re-radiation or reflection of electromagnetic energy with the object of impairing the use of electronic devices, equipment or systems being used by an enemy.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("EWJAM")]
        [EnumMember]
        ElectronicWarfareJamming,
		
        /// <summary>
        /// The capability to perform engineer functions in direct support of combat operations.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("ENGCBT")]
        [EnumMember]
        EngineerCombat,
		
        /// <summary>
        /// The capability to build various facilities in direct support of military operations.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ENGCN")]
        [EnumMember]
        EngineerConstruction,
		
        /// <summary>
        /// The capability to build various facilities in direct support of naval operations.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("ENGCNN")]
        [EnumMember]
        EngineerConstructionNaval,
		
        /// <summary>
        /// The capability to provide financial advice and guidance, support for the procurement process, providing pay and disbursing support.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("FINANC")]
        [EnumMember]
        Finance,
		
        /// <summary>
        /// The capability to procure information by direct questioning of a person under the control of a questioner.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("INTERO")]
        [EnumMember]
        Interrogation,
		
        /// <summary>
        /// The capability to produce intelligence from elements of more than one Service.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("JNTINT")]
        [EnumMember]
        JointIntelligence,
		
        /// <summary>
        /// The capability to provide labour services.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("LABOUR")]
        [EnumMember]
        Labour,
		
        /// <summary>
        /// The capability to provide legal services.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("LEGAL")]
        [EnumMember]
        Legal,
		
        /// <summary>
        /// The capability to maintain electro-optical materiel in or to restore it to a specified condition.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("MNTELO")]
        [EnumMember]
        MaintenanceElectroOptical,
		
        /// <summary>
        /// The capability to maintain ordnance (ammunition) in or to restore it to a specified condition.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("MNTOD")]
        [EnumMember]
        MaintenanceOrdnance,
		
        /// <summary>
        /// The capability to maintain ordnance missile (materiel) in or to restore it to a specified condition.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("MNTODM")]
        [EnumMember]
        MaintenanceOrdnanceMissile,
		
        /// <summary>
        /// The capability to perform maritime/littoral operations.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("MARINE")]
        [EnumMember]
        Marine,
		
        /// <summary>
        /// The capability for timely and efficient movement of patients while providing en route medical care to and between medical treatment facilities.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("MEDEVC")]
        [EnumMember]
        MedicalEvacuation,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("MIAREX")]
        [EnumMember]
        MilitaryIntelligenceAerialExploitation,
		
        /// <summary>
        /// The capability to provide information required for the planning and conducting campaigns and major operations to accomplish strategic objectives within theatres or areas of operations.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("MIOPS")]
        [EnumMember]
        MilitaryIntelligenceOperation,
		
        /// <summary>
        /// The capability to use information required for the planning and conducting tactical operations.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("MITCEX")]
        [EnumMember]
        MilitaryIntelligenceTacticalExploitation,
		
        /// <summary>
        /// The capability to prevent or reduce damage or danger from mines.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("MCM")]
        [EnumMember]
        MineCountermeasure,
		
        /// <summary>
        /// The capability to provide morale, welfare and recreation services in support of military personnel.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("MWR")]
        [EnumMember]
        MoraleWelfareRecreation,
		
        /// <summary>
        /// The capability to provide care and disposition of deceased personnel.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("MRTGRR")]
        [EnumMember]
        MortuaryGravesRegistry,
		
        /// <summary>
        /// The capability to conduct military operations in mountainous areas.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("MOUNTN")]
        [EnumMember]
        Mountain,
		
        /// <summary>
        /// The capability to employ biological materiel to produce casualties in man or animals and damage to plants or materiel; or defence against such employment.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("BIOMAT")]
        [EnumMember]
        NbcBiological,
		
        /// <summary>
        /// The capability to employ chemical materiel to kill, injure, or incapacitate for a significant period of time, man or animals, and deny or hinder the use of areas, facilities or materiel; or defence against such employment.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("CHMMAT")]
        [EnumMember]
        NbcChemical,
		
        /// <summary>
        /// The capability to make any person, object, or area safe by absorbing, destroying, neutralizing, making harmless, or removing, chemical materiel.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("CHMDEC")]
        [EnumMember]
        NbcChemicalDecontamination,
		
        /// <summary>
        /// The capability to employ chemical materiel released as a cloud of smoke or defence against such employment.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("CHMSMK")]
        [EnumMember]
        NbcChemicalSmoke,
		
        /// <summary>
        /// The capability to make any person, object, or area safe by absorbing, destroying, neutralizing, making harmless, or removing, chemical or biological materiel, or by removing radioactive material clinging to or around it.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("CBRNDC")]
        [EnumMember]
        NbcDecontamination,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("NUCMAT")]
        [EnumMember]
        NbcNuclear,
		
        /// <summary>
        /// The capability to conduct multi-functional operations involving military forces and diplomatic and humanitarian agencies. The operations are designed to achieve humanitarian goals or a long term peace settlement.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("PSO")]
        [EnumMember]
        PeaceSupport,
		
        /// <summary>
        /// The capability to provide the support services needed by military and civilian personnel.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("PERSVC")]
        [EnumMember]
        PersonnelServices,
		
        /// <summary>
        /// The capability to provide those public information, command information, and community relations activities directed towards the general public.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("PUBAF")]
        [EnumMember]
        PublicAffairs,
		
        /// <summary>
        /// The capability to provide those public information, command information, and community relation activities over a broadcast medium, such as radio or TV, directed towards the general public.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("PUBAFB")]
        [EnumMember]
        PublicAffairsBroadcast,
		
        /// <summary>
        /// The capability to provide those public information, command information, and community relations activities directed towards the general public in a joint services environment.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("PUBAFJ")]
        [EnumMember]
        PublicAffairsJointInformation,
		
        /// <summary>
        /// The capability to provide rail services.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("RAILWY")]
        [EnumMember]
        Railway,
		
        /// <summary>
        /// The capability to obtain, by visual observation or other detection methods, information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographical, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnaissance,
		
        /// <summary>
        /// The capability to contact, protect and extract personnel, small groups or units, or materiel.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("RECVRY")]
        [EnumMember]
        Recovery,
		
        /// <summary>
        /// The capability to provide personnel to take the place of other personnel who depart a unit.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("REPLHO")]
        [EnumMember]
        ReplacementHolding,
		
        /// <summary>
        /// The capability to move out ahead of the main force in order to reconnoitre the position or movements of the enemy.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("SCOUT")]
        [EnumMember]
        Scout,
		
        /// <summary>
        /// The capability to use aircraft, surface craft, submarines, specialised rescue teams, and equipment to search for and rescue personnel in distress on land or sea.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("SAR")]
        [EnumMember]
        SearchAndRescue,
		
        /// <summary>
        /// The capability to provide tactical communications in the combat zone.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("SGFC")]
        [EnumMember]
        SignalForwardCommunications,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a communications node centre.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("SGNC")]
        [EnumMember]
        SignalNodeCentre,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a communications large extension node.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("SGNLE")]
        [EnumMember]
        SignalNodeLargeExtension,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a communications small extension node.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("SGNSE")]
        [EnumMember]
        SignalNodeSmallExtension,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a radio communications.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("SIGRAD")]
        [EnumMember]
        SignalRadio,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a communications radio relay.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("SGRDRL")]
        [EnumMember]
        SignalRadioRelay,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a tactical satellite terminal.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("SGRDTA")]
        [EnumMember]
        SignalRadioTacticalSatellite,
		
        /// <summary>
        /// The capability in signal services to manage, operate and control a radio teletype communications.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("SGRDTE")]
        [EnumMember]
        SignalRadioTeletype,
		
        /// <summary>
        /// The capability to provide personnel and equipment from other forces for the establishment of a special or supplementary communications system.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("SGSPT")]
        [EnumMember]
        SignalSupport,
		
        /// <summary>
        /// The capability to provide intelligence derived from communications, electronics, and instrumentation signals.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("SIGINT")]
        [EnumMember]
        SignalsIntelligenceSigint,
		
        /// <summary>
        /// The capability to provide combat/fresh rations, water and personal, health and welfare items.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("SPLC1")]
        [EnumMember]
        SupplyClassI,
		
        /// <summary>
        /// The capability to provide materiel.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("SPLC2")]
        [EnumMember]
        SupplyClassIi,
		
        /// <summary>
        /// The capability to provide aviation fuel and lubricants.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("SPLC3A")]
        [EnumMember]
        SupplyClassIiiAviation,
		
        /// <summary>
        /// The capability to provide fuel and lubricants.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("SPLC3")]
        [EnumMember]
        SupplyClassIii,
		
        /// <summary>
        /// The capability to provide ammunition, explosives and chemical agents.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("SPLC5")]
        [EnumMember]
        SupplyClassV,
		
        /// <summary>
        /// The capability to provide drinking water.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("SPLWAT")]
        [EnumMember]
        SupplyWater,
		
        /// <summary>
        /// The capability to provide laundry and/or bath services.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("SPLLDB")]
        [EnumMember]
        SupplyLaundryBath,
		
        /// <summary>
        /// The capability to perform systematic observation of aerospace, surface or subsurface areas, places, persons, or things by visual, aural, electronic, photographic, or other means.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("SRV")]
        [EnumMember]
        Surveillance,
		
        /// <summary>
        /// The capability to manage and operate a ground module for a surveillance system.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("SRVGM")]
        [EnumMember]
        SurveillanceGroundModule,
		
        /// <summary>
        /// The capability to perform, from long range, systematic observation of aerospace, surface or subsurface areas, places, persons, or things by visual, aural, electronic, photographic, or other means from a ground station.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("SRVLR")]
        [EnumMember]
        SurveillanceLongRange,
		
        /// <summary>
        /// The capability to perform systematic observation of meteorological conditions.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("SRVMET")]
        [EnumMember]
        SurveillanceMeteorological,
		
        /// <summary>
        /// The capability to manage, operate and maintain sensor surveillance assets.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("SRVSEN")]
        [EnumMember]
        SurveillanceSensor,
		
        /// <summary>
        /// The capability to manage, operate and maintain target acquisition assets.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("TGT")]
        [EnumMember]
        TargetAcquisition,
		
        /// <summary>
        /// The capability to manage, operate and maintain flash target acquisition assets.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("TGTAFL")]
        [EnumMember]
        TargetAcquisitionFlash,
		
        /// <summary>
        /// The capability to manage, operate and maintain radar target acquisition assets.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("TGTARD")]
        [EnumMember]
        TargetAcquisitionRadar,
		
        /// <summary>
        /// The capability to manage, operate and maintain sound target acquisition assets.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("TGTASD")]
        [EnumMember]
        TargetAcquisitionSound,
		
        /// <summary>
        /// The capability to provide targeting services.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("TGTNG")]
        [EnumMember]
        Targeting,
		
        /// <summary>
        /// The capability to manage, operate and maintain theatre missile defence assets.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("THTMSD")]
        [EnumMember]
        TheatreMissileDefence,
		
        /// <summary>
        /// The capability to provide transportation services at aerial ports where cargo or personnel arrive or depart.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("TRNAPD")]
        [EnumMember]
        TransportationApodApoe,
		
        /// <summary>
        /// The capability to provide equipment for transportation of missiles.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("TRNMSL")]
        [EnumMember]
        TransportationMissile,
		
        /// <summary>
        /// The capability to provide planning, routing, scheduling and control of personnel and freight movements over lines of communication.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("TRNMVC")]
        [EnumMember]
        TransportationMovementControl,
		
        /// <summary>
        /// The capability to provide transportation services at seaports where cargo or personnel arrive or depart.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("TRNSPD")]
        [EnumMember]
        TransportationSpodSpoe,
		
        /// <summary>
        /// The capability to provide utilities (water, gas, electric, et al).
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("UTILTY")]
        [EnumMember]
        Utility,
		
        /// <summary>
        /// The capability to provide clean potable drinking/bathing water.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("WATER")]
        [EnumMember]
        WaterPurification,
		
        /// <summary>
        /// The capability involving the use of electromagnetic energy to determine, exploit, reduce, or prevent hostile use of the electromagnetic spectrum and action to retain its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("EW")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// The capability to provide supply and repair services to keep a force in condition to carry out its mission.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("MAINT")]
        [EnumMember]
        Maintenance,
		
        /// <summary>
        /// The capability to provide construction materials.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("SPLC4")]
        [EnumMember]
        SupplyClassIv,
		
        /// <summary>
        /// Air operations conducted to destroy, neutralize, or delay the enemy's military potential before it can be brought to bear effectively against friendly forces at such distance from friendly forces that detailed integration of each air mission with the fire and movement of friendly forces is not required.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("AIRINT")]
        [EnumMember]
        AirInterdiction,
		
        /// <summary>
        /// The capability to perform an air action against hostile targets which are in close proximity to friendly forces and which require detailed integration of each air mission with the fire and movement of those forces.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("CAS")]
        [EnumMember]
        CloseAirSupport,
		
        /// <summary>
        /// The capability to use of air vehicles to obtain information concerning terrain, weather, and the disposition, composition, movement, installations, lines of communications, electronic and communication emissions of enemy forces. Also included are artillery and naval gunfire adjustment, and systematic and random observation of ground battle areas, targets, and/ or sectors of airspace.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("TAIRRE")]
        [EnumMember]
        TacticalAirReconnaissance,
		
        /// <summary>
        /// Operations conducted with the intention of denying the enemy the effective use of his submarines.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("ANTSUB")]
        [EnumMember]
        AntiSubmarineWarfare,
		
        /// <summary>
        /// The capability to perform air to ground operations.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("AIRGRD")]
        [EnumMember]
        AirToGround,
		
        /// <summary>
        /// The capability to refuel aircraft in flight, which extends presence, increases range, and serves as a force multiplier.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("ARLRFL")]
        [EnumMember]
        AerialRefuelling,
		
        /// <summary>
        /// The capability to employ radiological materiel to produce casualties in man or animals and damage to plants or materiel; or defence against such employment.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("RADMAT")]
        [EnumMember]
        NbcRadiological,
		
        /// <summary>
        /// The capability to nullify or reduce the effectiveness of hostile air action.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("AIRDEF")]
        [EnumMember]
        AirDefence,
		
        /// <summary>
        /// The capability to perform maritime/deep water operations.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("MARTME")]
        [EnumMember]
        Maritime,
		
        /// <summary>
        /// A capability that enables an equipment to be used to train personnel.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("TRAIN")]
        [EnumMember]
        Training,
		
    }
}
