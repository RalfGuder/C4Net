using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that qualifies the functional specialisation of a particular UNIT-TYPE.
    /// </summary>
    [DomId(100000332)]
    [DataContract]
    public enum UnitTypeArmSpecialisationEnum
    {
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to build various facilities in direct support of military operations.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ENCNST")]
        [EnumMember]
        EngineerConstruction,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide dental care.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DENTAL")]
        [EnumMember]
        Dental,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to use electromagnetic energy to determine, exploit, reduce, or prevent hostile use of the electromagnetic spectrum and to perform actions in order to retain its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("EW")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide financial services.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FINANC")]
        [EnumMember]
        Finance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide police services.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MILPOL")]
        [EnumMember]
        MilitaryPolice,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide services related to personnel administration.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("PERSVC")]
        [EnumMember]
        PersonnelServices,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide postal services.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("POSTAL")]
        [EnumMember]
        Postal,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide treatment dealing with the mental and emotional state of a person.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PSYCH")]
        [EnumMember]
        Psychological,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide religious services.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("RELCHP")]
        [EnumMember]
        ReligiousChaplain,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide security police services for air-related facilities or assets.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SECPOL")]
        [EnumMember]
        SecurityPoliceAir,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide shore patrol services.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SHRPAT")]
        [EnumMember]
        ShorePatrol,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide surgical services.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SURG")]
        [EnumMember]
        Surgical,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide medical or surgical treatment for animals.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("VET")]
        [EnumMember]
        Veterinary,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to patrol an area.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("SCOUT")]
        [EnumMember]
        Scout,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to produce maps and other topographical information.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("TOPO")]
        [EnumMember]
        TopographicalSurvey,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to take full advantage of any information that was obtained from aerial sources.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("AIREXP")]
        [EnumMember]
        AerialExploitation,
		
        /// <summary>
        /// An air-defence UNIT-TYPE whose primary function is to combat aircraft by the means of both guns and missiles.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ADCOMP")]
        [EnumMember]
        AirDefenceCompositeWeapons,
		
        /// <summary>
        /// An air-defence UNIT-TYPE whose primary function is to combat aircraft by the means of guns.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ADGUN")]
        [EnumMember]
        AirDefenceGun,
		
        /// <summary>
        /// An air-defence UNIT-TYPE whose primary function is to combat aircraft by the means of missiles.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("ADMSL")]
        [EnumMember]
        AirDefenceMissile,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to combat submarines by the means of air assets.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ANTSUB")]
        [EnumMember]
        AntisubmarineWarfareAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide transportation services at aerial ports where cargo or personnel arrive or depart.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("APOD")]
        [EnumMember]
        ApodApoe,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to recover armoured vehicles unable to move by their own means.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("ARMREC")]
        [EnumMember]
        ArmourRecovery,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to calculate the coordinates and altitude of object/point and from which the bearings/azimuths to a number of reference objects are also known.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("ARTSVY")]
        [EnumMember]
        ArtillerySurvey,
		
        /// <summary>
        /// An aviation UNIT-TYPE whose primary function is to perform an offensive mission.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("ATTACK")]
        [EnumMember]
        AttackAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain a state of law and order within air facilities or assets.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("AVASEC")]
        [EnumMember]
        AviationSecurityForces,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to employ biological agents to produce casualties in man or animals and damage to plants or materiel; or defend against such employment.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("BIOLOG")]
        [EnumMember]
        Biological,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain information about the presence, nature and concentration of biological agents in the environment.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("BIOREC")]
        [EnumMember]
        BiologicalReconnaissance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide patrol along the borders.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("BRDRPT")]
        [EnumMember]
        BorderPatrol,
		
        /// <summary>
        /// An engineer UNIT-TYPE whose primary function is to build bridges or to provide means to cross dry cuts or water courses.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("BRDGG")]
        [EnumMember]
        Bridging,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to serve as a command and control element.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("C2AVA")]
        [EnumMember]
        C2Aviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to fight in armoured vehicles.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("CAVLRY")]
        [EnumMember]
        Cavalry,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("CNTINT")]
        [EnumMember]
        CentralIntelligence,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to employ chemical agents to kill, injure, or incapacitate for a significant period of time, man or animals, and deny or hinder the use of areas, facilities or materiel; or defend against such employment.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("CHMCAL")]
        [EnumMember]
        Chemical,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain information about the presence, nature and concentration of chemical agents in the environment.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("CHMREC")]
        [EnumMember]
        ChemicalReconnaissance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to employ chemical agents released as a cloud of smoke or defend against such employment.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("CHMSMK")]
        [EnumMember]
        ChemicalSmoke,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to make any person, object, or area safe by absorbing, destroying, neutralizing, making harmless, or removing, chemical agents.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("CHMSMD")]
        [EnumMember]
        ChemicalSmokeDecontamination,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is either to facilitate the relationships between the forces engaged on a theatre of operations and the civilian authorities of the countries in the theatre, the international organisations and the local populations, or to coordinate the actions led for the benefit of the concerned countries in order to preserve or restore the functioning of the institutions and public services as well as that of those services essential for the life of the populations of that country.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("CIVAFR")]
        [EnumMember]
        CivilAffairs,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to conduct civilian law enforcement operations.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("CIVLWE")]
        [EnumMember]
        CivilianLawEnforcement,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to search for and rescue personnel in distress on land or sea in enemy-controlled territory.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("CSAR")]
        [EnumMember]
        CombatSearchAndRescueAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to conduct activities that are concerned with identifying and counteracting the threat to security posed by hostile intelligence services or organisations, or by individuals engaged in espionage, sabotage, subversion or terrorism.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("CNTRIN")]
        [EnumMember]
        CounterIntelligence,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to make any person, object, or area safe by absorbing, destroying, neutralizing, making harmless, or removing, chemical or biological agents, or by removing radioactive material clinging to or around it.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("DECONT")]
        [EnumMember]
        Decontamination,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain a state of law and order and whose primary mode of operation is on foot.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("DISSEC")]
        [EnumMember]
        DismountedSecurityForces,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain bearings of radio frequency emitters by using a directional antenna and a display unit on an intercept receiver or ancillary equipment.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("EWDF")]
        [EnumMember]
        ElectronicWarfareDirectionFinding,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to intercept intentional or unintentional radiated electromagnetic energy for the purpose of immediate threat recognition.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("EWINTC")]
        [EnumMember]
        ElectronicWarfareIntercept,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to deliver radiation, re-radiation or reflection of electromagnetic energy with the object of impairing the use of electronic devices, equipment or systems being used by an enemy.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("EWJAM")]
        [EnumMember]
        ElectronicWarfareJamming,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain, by visual observation or other detection methods, information required for site surveys prior to construction or demolition.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("ENGREC")]
        [EnumMember]
        EngineerReconnaissance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary functions includes construction or demolition of roads and railways in support of military operations.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("ENGRRW")]
        [EnumMember]
        EngineerRoadRailways,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to transfer materiel in or out of transportation means such as trains, ships or planes.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("HNDLDG")]
        [EnumMember]
        HandlingLoadingUnloading,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to procure information by direct questioning of a person under the control of a questioner.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("INTERO")]
        [EnumMember]
        Interrogation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to produce intelligence from elements of more than one Service.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("JNTINT")]
        [EnumMember]
        JointIntelligence,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide labour services.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("LABOUR")]
        [EnumMember]
        Labour,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide legal services.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("LEGAL")]
        [EnumMember]
        LegalServices,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain electronics and armament (materiel) in or to restore it to operational condition.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("MNTELC")]
        [EnumMember]
        MaintenanceElectronicsArmament,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain electro-optical materiel in or to restore it to operational condition.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("MNTELO")]
        [EnumMember]
        MaintenanceElectroOptical,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to accomplish supply and repair actions necessary to keep the heavy equipment of a force in condition to carry out its mission.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("MNTHVY")]
        [EnumMember]
        MaintenanceHeavy,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain ordnance missile (materiel) in or to restore it to operational condition.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("MNTMSL")]
        [EnumMember]
        MaintenanceMissile,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain ordnance (ammunition) in or to restore it to operational condition.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("MNTORD")]
        [EnumMember]
        MaintenanceOrdnance,
		
        /// <summary>
        /// An aviation UNIT-TYPE whose primary function is to move patients by air means in a timely and efficient manner while providing en route medical care to and between medical treatment facilities.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("MEDEVC")]
        [EnumMember]
        MedicalEvacuationAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to move patients between medical treatment facilities while providing en route medical care.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("MEDTRS")]
        [EnumMember]
        MedicalTransport,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to perform interventions or treatment under supervision of a physician.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("MEDTRT")]
        [EnumMember]
        MedicalTreatment,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to perform systematic observation of meteorological conditions and/or forecast future meteorological conditions.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("METEO")]
        [EnumMember]
        Meteorological,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to prevent or reduce damage or danger from mines by using airborne means.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("MCMAVA")]
        [EnumMember]
        MineCountermeasureAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide morale, welfare and recreation services in support of military personnel.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("MWR")]
        [EnumMember]
        MoraleWelfareRecreation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide care and disposition of deceased personnel.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("MRTGRR")]
        [EnumMember]
        MortuaryGravesRegistry,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide planning, routing, scheduling and control of personnel and freight movements over lines of communication.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("MVTCNT")]
        [EnumMember]
        MovementControl,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain information about the presence, nature and concentration of CBRN agents in the environment.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("CBRNRC")]
        [EnumMember]
        NbcReconnaissance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to defend or protect against radiological or nuclear materiel dangers.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("NUCRAD")]
        [EnumMember]
        Nuclear,
		
        /// <summary>
        /// A military intelligence UNIT-TYPE whose primary function is to provide information required for the planning and conducting campaigns and major operations to accomplish strategic objectives within theatres or areas of operations.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("MIOPS")]
        [EnumMember]
        MilitaryIntelligenceOperations,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to construct, maintain or operate pipelines.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("PIPELN")]
        [EnumMember]
        Pipeline,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide convey selected information and indicators to foreign audiences to influence their emotions, motives, objective reasoning, and ultimately the behaviour of foreign governments, organisations, groups, and individuals.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("PSYOP")]
        [EnumMember]
        PsychologicalOperations,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide public information, command information, and community relations activities directed towards the general public.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("PUBAF")]
        [EnumMember]
        PublicAffairs,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide public information, command information, and community relation activities over a broadcast medium, such as radio or TV, directed towards the general public.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("PUBAFB")]
        [EnumMember]
        PublicAffairsBroadcast,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide public information, command information, and community relations activities directed towards the general public in a joint services environment.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("PUBAFJ")]
        [EnumMember]
        PublicAffairsJointInformation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide lodging and rations for the troops.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("QM")]
        [EnumMember]
        Quartermaster,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain a state of law and order within railway facilities or assets.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("RAILSE")]
        [EnumMember]
        RailwaySecurityForces,
		
        /// <summary>
        /// A UNIT-TYPE of rapidly deployable airborne light infantry organized and trained to conduct highly complex joint direct action operations in coordination with or in support of other special operations units of all services.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("RANGER")]
        [EnumMember]
        Ranger,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to obtain, by airborne means and through visual observation or other detection methods, information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographical, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("RECAVA")]
        [EnumMember]
        ReconnaissanceAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to recover vehicles unable to move by their own means.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("RECOVR")]
        [EnumMember]
        Recovery,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to deliver fuel to other aircraft while in flight.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("REFAVA")]
        [EnumMember]
        RefuelAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide personnel to take the place of other personnel who depart a unit.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("REPLHO")]
        [EnumMember]
        ReplacementHolding,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to maintain a state of law and order and that operates on or along a river.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("RIVSEC")]
        [EnumMember]
        RiverineSecurityForces,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is Sea Air Land operations.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("SEAL")]
        [EnumMember]
        Seal,
		
        /// <summary>
        /// An aviation UNIT-TYPE whose primary function is to search for and rescue personnel in distress on land or sea.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("SARAVA")]
        [EnumMember]
        SearchAndRescueAviation,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("SGCMDO")]
        [EnumMember]
        SignalCommandOperations,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to establish target distance electronically.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("SGELCR")]
        [EnumMember]
        SignalElectronicRanging,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a communications node centre.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("SGNC")]
        [EnumMember]
        SignalNodeCentre,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a communications large extension node.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("SGNLE")]
        [EnumMember]
        SignalNodeLargeExtension,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a communications small extension node.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("SGNSE")]
        [EnumMember]
        SignalNodeSmallExtension,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide personnel and equipment from other forces for the establishment of a special or supplementary communications system.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("SGSPT")]
        [EnumMember]
        SignalSupport,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control radio communications.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("SGRAD")]
        [EnumMember]
        SignalRadio,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a communications radio relay.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("SGRDRL")]
        [EnumMember]
        SignalRadioRelay,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a tactical satellite terminal.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("SGTACS")]
        [EnumMember]
        SignalTacticalSatellite,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control a tactical telephone switch.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("SGTELS")]
        [EnumMember]
        SignalTelephoneSwitch,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage, operate and control radio-teletype communications.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("SGTELC")]
        [EnumMember]
        SignalTeletypeCentre,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide intelligence derived from communications, electronics, and instrumentation signals.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("SIGINT")]
        [EnumMember]
        SignalsIntelligence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("SPBOAT")]
        [EnumMember]
        SpecialBoat,
		
        /// <summary>
        /// A UNIT-TYPE, selected, trained and organised to special levels, whose primary function is to be employed in pursuit of strategic objectives.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("SPCFOR")]
        [EnumMember]
        SpecialForces,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to support special operations forces.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("SPOPSP")]
        [EnumMember]
        SpecialOperationsSupport,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("SPSSNR")]
        [EnumMember]
        SpecialSsnr,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide transportation services at sea ports where cargo or personnel arrive or depart.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("SPOD")]
        [EnumMember]
        SpodSpoe,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide combat/fresh rations, water and personal, health and welfare items.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("SPLC1")]
        [EnumMember]
        SupplyClassI,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide materiel.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("SPLC2")]
        [EnumMember]
        SupplyClassIi,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide fuel and lubricants.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("SPLC3")]
        [EnumMember]
        SupplyClassIii,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide aviation fuel and lubricants.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("SPLC3A")]
        [EnumMember]
        SupplyClassIiiAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide construction materials.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("SPLC4")]
        [EnumMember]
        SupplyClassIv,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide ammunition, explosives and chemical agents.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("SPLC5")]
        [EnumMember]
        SupplyClassV,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide drinking water.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("SPLWAT")]
        [EnumMember]
        SupplyWater,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide laundry and/or bath services.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("SPLLDB")]
        [EnumMember]
        SupplyLaundryBath,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to perform systematic observation of aerospace, surface or subsurface areas, places, persons, or things by visual, aural, electronic, photographic, or other means.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("SRV")]
        [EnumMember]
        Surveillance,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate a ground module for a surveillance system.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("SRVGSM")]
        [EnumMember]
        SurveillanceGroundStationModule,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate a ground radar for a surveillance system.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("SRVGSR")]
        [EnumMember]
        SurveillanceGroundSurveillanceRadar,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to perform, from long range, systematic observation of aerospace, surface or subsurface areas, places, persons, or things by visual, aural, electronic, photographic, or other means from a ground station.
        /// </summary>
        [DomValIx(1000127)]
        [StringValue("SRVLR")]
        [EnumMember]
        SurveillanceLongRange,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate sensor surveillance assets.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("SRVSEN")]
        [EnumMember]
        SurveillanceSensor,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("SRSNSC")]
        [EnumMember]
        SurveillanceSensorScm,
		
        /// <summary>
        /// A military intelligence UNIT-TYPE whose primary function is to use information required for the planning and conducting tactical operations.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("TACEXP")]
        [EnumMember]
        TacticalExploitation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate target acquisition assets.
        /// </summary>
        [DomValIx(1000131)]
        [StringValue("TGTACQ")]
        [EnumMember]
        TargetAcquisition,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate optical target acquisition assets.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("TGTAOP")]
        [EnumMember]
        TargetAcquisitionOptical,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate radar target acquisition assets.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("TGTARD")]
        [EnumMember]
        TargetAcquisitionRadar,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to manage and operate sound target acquisition assets.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("TGTASD")]
        [EnumMember]
        TargetAcquisitionSound,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide targeting services.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("TGTNG")]
        [EnumMember]
        Targeting,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide equipment for transportation of missiles.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("TRNMSL")]
        [EnumMember]
        TransportationMissile,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide transportation by means of railways.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("TRNRLY")]
        [EnumMember]
        TransportationRailways,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to damage or destroy equipment or facilities laying totally or partially in water and that moves under the water surface to achieve this.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("UDT")]
        [EnumMember]
        UnderwaterDemolition,
		
        /// <summary>
        /// An aviation UNIT-TYPE whose primary function is to transport equipment or personnel.
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("UTLAVA")]
        [EnumMember]
        UtilityAviation,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to provide clean potable drinking/bathing water.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("WATER")]
        [EnumMember]
        WaterPurification,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of howitzers or artillery guns in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("FAHOW")]
        [EnumMember]
        FieldArtilleryHowitzerGun,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of mortars in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("FAMORT")]
        [EnumMember]
        FieldArtilleryMortar,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of multi rocket launchers in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("FAMLRS")]
        [EnumMember]
        FieldArtilleryMultiRocketLauncher,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of rocket launchers in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("FARCKL")]
        [EnumMember]
        FieldArtilleryRocketLauncher,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of single rocket launchers in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("FASLRS")]
        [EnumMember]
        FieldArtillerySingleRocketLauncher,
		
        /// <summary>
        /// A UNIT-TYPE whose primary function is to utilise unmanned air assets.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("UAV")]
        [EnumMember]
        UnmannedAerialVehicle,
		
    }
}
