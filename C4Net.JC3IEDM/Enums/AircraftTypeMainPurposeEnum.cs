using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the main purpose of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004368)]
    [DataContract]
    public enum AircraftTypeMainPurposeEnum
    {
		
        /// <summary>
        /// An aircraft that is the airborne element in which the unit or sub-unit commander is located or from which he operates.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACP")]
        [EnumMember]
        AirborneCommandPostC2,
		
        /// <summary>
        /// An aircraft equipped with search and height finding radars and communications equipment designed to provide air surveillance.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AEW")]
        [EnumMember]
        AirborneEarlyWarning,
		
        /// <summary>
        /// An aircraft equipped with search and height finding radars and communications equipment designed to provide air surveillance and to control airborne weapons systems.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AEWCON")]
        [EnumMember]
        AirborneEarlyWarningAndControl,
		
        /// <summary>
        /// An aircraft that employs a technique with radio relay for the purpose of increasing the range, flexibility or physical security of communication systems.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARELAY")]
        [EnumMember]
        AirborneRelay,
		
        /// <summary>
        /// An aircraft that protects and defends an area, and/or a strike attack, and/or an installation, and/or naval forces.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AIRDEF")]
        [EnumMember]
        AirDefense,
		
        /// <summary>
        /// An aircraft that is deemed to obtain a degree of dominance in the air battle of one force over another in order to permit the conduct of operations by the former and its related land, sea and air forces at a given time and place without prohibitive interference by the opposite force.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AIRSUP")]
        [EnumMember]
        AirSuperiority,
		
        /// <summary>
        /// An aircraft in which the objective is to enhance combat effectiveness by extending the range, payload or endurance of receiver aircraft.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("AAR")]
        [EnumMember]
        AirToAirRefuelling,
		
        /// <summary>
        /// An aircraft designed and primarily armed for use in the destruction of armoured targets.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ANTARM")]
        [EnumMember]
        AntiArmour,
		
        /// <summary>
        /// An aircraft employed in air operation conducted with the intention of denying the enemy the effective use of submarines.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ASUW")]
        [EnumMember]
        AntiSubmarineWarfare,
		
        /// <summary>
        /// An aircraft based on an aircraft carrier conducting operations with the intention of denying the enemy the effective use of submarines.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ASCB")]
        [EnumMember]
        AntiSubmarineWarfareCarrierBased,
		
        /// <summary>
        /// A maritime patrol aircraft conducting operations with the intention of denying the enemy the effective use of submarines.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ASMPA")]
        [EnumMember]
        AntiSubmarineWarfareMpa,
		
        /// <summary>
        /// A maritime patrol aircraft conducting operations with the intention of denying the enemy the effective use of surface forces.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ASW")]
        [EnumMember]
        AntiSurfaceMpa,
		
        /// <summary>
        /// An aircraft that enables a short, violent, but well ordered attack against a local objective such as a gun emplacement, a fort or a machine-gun nest.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("ARMAS")]
        [EnumMember]
        ArmedAssault,
		
        /// <summary>
        /// An aircraft specifically designed to employ various weapons to attack and destroy enemy targets.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ATTACK")]
        [EnumMember]
        Attack,
		
        /// <summary>
        /// An aircraft specifically designed to employ various weapons within a strike to attack and destroy enemy targets.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("ATKSTR")]
        [EnumMember]
        AttackStrike,
		
        /// <summary>
        /// An aircraft used for the transport of cargo.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("CARGO")]
        [EnumMember]
        CargoAirlift,
		
        /// <summary>
        /// An aircraft designed and equipped to allow a commander to exercise authority and direction over assigned and attached forces in the accomplishment of the mission.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("CMDCTL")]
        [EnumMember]
        CommandAndControl,
		
        /// <summary>
        /// An aircraft equipped with communication means such as data links or radio means for the purpose of consultation, command, control and intelligence.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("COM")]
        [EnumMember]
        CommunicationsC3I,
		
        /// <summary>
        /// An aircraft used for the launch of drones.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("DRONL")]
        [EnumMember]
        DroneLaunch,
		
        /// <summary>
        /// An aircraft that operates in a division of electronic warfare involving actions taken to prevent or reduce an enemy’s effective use of the electromagnetic spectrum through the use of electromagnetic energy. There are three subdivisions of electronic countermeasures: electronic jamming, electronic deception and electronic neutralization.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("ELCCNM")]
        [EnumMember]
        ElectronicCounterMeasures,
		
        /// <summary>
        /// An aircraft that operates in a division of electronic warfare involving actions taken to prevent or reduce an enemy’s effective use of the electromagnetic spectrum through the use of electromagnetic energy by electronic jamming.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("ECMJAM")]
        [EnumMember]
        ElectronicCounterMeasuresJammer,
		
        /// <summary>
        /// An aircraft designed for military action to exploit the electromagnetic spectrum encompassing: the search for, interception and identification of electromagnetic emissions, the employment of electromagnetic energy, including directed energy, to reduce or prevent hostile use of the electromagnetic spectrum, and actions to ensure its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("EW")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// An aircraft that combines the functions of a fighter and a bomber.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("FIGBOM")]
        [EnumMember]
        FighterBomber,
		
        /// <summary>
        /// An aircraft that combines the functions of a fighter and an interceptor.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("FIGINT")]
        [EnumMember]
        FighterInterceptor,
		
        /// <summary>
        /// An aircraft that performs ground attack.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("GDATK")]
        [EnumMember]
        GroundAttack,
		
        /// <summary>
        /// An aircraft that performs reconnaissance in order to gather information to prepare for ground attacks.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("GDATKR")]
        [EnumMember]
        GroundAttackReconnaissance,
		
        /// <summary>
        /// An aircraft designed and equipped with imaging sensors primarily for the purpose of gathering imagery for intelligence purposes.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("IMINGT")]
        [EnumMember]
        ImageryIntelligenceGathering,
		
        /// <summary>
        /// An aircraft that is devoted to liaise between different locations.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("LIAIS")]
        [EnumMember]
        LiaisonDuties,
		
        /// <summary>
        /// An aircraft that is equipped to perform the maintenance, overhaul or repair of other aircraft.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("MAINT")]
        [EnumMember]
        MaintenanceOverhaulRepair,
		
        /// <summary>
        /// An aircraft that flies over an area monitoring and where necessary destroying hostile aircraft as well as protecting friendly shipping in the vicinity of the objective area in amphibious operations.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("MPA")]
        [EnumMember]
        MaritimePatrol,
		
        /// <summary>
        /// The role of the aircraft is to obtain, by radar detection and other sensory means information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("MPAREC")]
        [EnumMember]
        MaritimeReconnaissance,
		
        /// <summary>
        /// An aircraft designed and equipped to perform medical evacuation and treatment.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("MEDEVC")]
        [EnumMember]
        MedicalEvacuation,
		
        /// <summary>
        /// An aircraft that gathers meteorological information such as humidity, pressure, and temperature characteristics of Earth’s atmosphere.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("METBAL")]
        [EnumMember]
        Meteorological,
		
        /// <summary>
        /// An aircraft designed and equipped to perform mine warfare functions including mine laying and mine countermeasures.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("MINWAR")]
        [EnumMember]
        MineWarfare,
		
        /// <summary>
        /// An aircraft designed and equipped to perform mine countermeasures.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("MINCM")]
        [EnumMember]
        MineCountermeasures,
		
        /// <summary>
        /// An aircraft that is capable of performing various missions.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("MULTIP")]
        [EnumMember]
        MultiPurpose,
		
        /// <summary>
        /// An aircraft equipped with multi sensors that detect, and may indicate, and/or record objects and activities by means of energy or particles emitted, reflected, or modified by objects.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("MULTIS")]
        [EnumMember]
        MultiSensor,
		
        /// <summary>
        /// An aircraft that is capable of performing maritime missions.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("NAV")]
        [EnumMember]
        Naval,
		
        /// <summary>
        /// An aircraft that is capable of performing naval attack.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("NAVATK")]
        [EnumMember]
        NavalAttack,
		
        /// <summary>
        /// An aircraft used for the transport of passengers.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("PSG")]
        [EnumMember]
        PassengerAirlift,
		
        /// <summary>
        /// An aircraft flying over an objective area, over the force projected, over the critical area of a combat zone, or over an air-defense area for the purpose of intercepting and destroying hostile aircraft before they reach their target.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("PATROL")]
        [EnumMember]
        Patrol,
		
        /// <summary>
        /// An aircraft that produces a photograph or photomosaic upon which the grid lines, marginal data, contours, place names, boundaries, and other data may be added.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("PHOTO")]
        [EnumMember]
        PhotoMapping,
		
        /// <summary>
        /// An aircraft that flies a specific route to calibrate radars and radios.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("RCALIB")]
        [EnumMember]
        RadioRadarCalibration,
		
        /// <summary>
        /// An aircraft intended to obtain, by visual observation or other detection methods, information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnaissance,
		
        /// <summary>
        /// An aircraft intended to obtain by detection means information about the ECM activities and resources of an enemy or potential enemy in a particular area.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("RECECM")]
        [EnumMember]
        ReconnaissanceEcm,
		
        /// <summary>
        /// An aircraft intended to obtain, by photographic means information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("RECPHO")]
        [EnumMember]
        ReconnaissancePhotographic,
		
        /// <summary>
        /// The role of the aircraft is to obtain, by radar detection methods information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("RECRAD")]
        [EnumMember]
        ReconnaissanceRadar,
		
        /// <summary>
        /// The role of the aircraft is to obtain, visual information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("RECVIS")]
        [EnumMember]
        ReconnaissanceVisual,
		
        /// <summary>
        /// An aircraft collecting intelligence without engaging enemy forces in order to participate in the close in security of a force.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("SCOUT")]
        [EnumMember]
        Scout,
		
        /// <summary>
        /// An aircraft designed and equipped to look for and bring back any lost, incapacitated or captured person or group of persons.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("SAR")]
        [EnumMember]
        SearchAndRescue,
		
        /// <summary>
        /// An aircraft designed and equipped to look for and bring back any lost, incapacitated or captured person or group of persons in a combat area.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("CSAR")]
        [EnumMember]
        SearchAndRescueCombat,
		
        /// <summary>
        /// An aircraft designed and equipped primarily for the purpose of intercepting and gathering electronic and communications transmissions for intelligence purposes.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("SINGA")]
        [EnumMember]
        SignalsIntelligenceGathering,
		
        /// <summary>
        /// An aircraft used for the transport of members of special operation forces.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("SOF")]
        [EnumMember]
        SpecialOperationsForces,
		
        /// <summary>
        /// An aircraft designed for a singular purpose.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("SPCPRP")]
        [EnumMember]
        SpecialPurpose,
		
        /// <summary>
        /// An aircraft under care and maintenance.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("STOR")]
        [EnumMember]
        Storage,
		
        /// <summary>
        /// An aircraft used for carrying fuel in bulk, esp. for the aerial refuelling of other aircraft.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("TANKER")]
        [EnumMember]
        Tanker,
		
        /// <summary>
        /// An aircraft capable of obtaining information about the activities and resources of a target.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("TGTREL")]
        [EnumMember]
        TargetRelayReconnaissance,
		
        /// <summary>
        /// An aircraft capable of towing a target.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("TOWTGT")]
        [EnumMember]
        TowTarget,
		
        /// <summary>
        /// Multi-purpose aircraft capable of carrying troops but may be used in a command and control, logistics, casualty evacuation or armed aircraft role.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("UTILTY")]
        [EnumMember]
        Utility,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
